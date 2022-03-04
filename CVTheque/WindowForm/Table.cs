using System.ComponentModel;
using CVTheque.Models;
using System.Diagnostics;
using CVTheque.services;

namespace CVTheque.WindowForm;

public partial class Table : Form
{
  private List<CvModels> _dataImport;
  private string? _id;

  public Table()
  {
    InitializeComponent();
    _dataImport = CsvParser.Import();
  }

  // CHARGEMENT DES DATAS DANS LE TABLEAU SI DISPONIBLE
  private void Table_Shown(object sender, EventArgs e)
  {
    if (_dataImport.Count == 0)
    {
      MessageBox.Show("Impossible d'ouvrir le fichier CSV !", "Erreur");
      return;
    }

    _dataImport.ForEach(c =>
    {
      dataGridView1.Rows.Add(
        c.Id,
        c.LastName,
        c.FirstName,
        c.Birthdate,
        c.Age,
        c.MobilePhone,
        c.Email,
        c.Profil,
        c.City.ToUpper(),
        c.Skills
      );
    });
    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
    dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
    dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[1];
    _id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
  }

  // EDITION D'UN CANDIDAT
  private void editBtn_Click_1(object sender, EventArgs e)
  {
    var customer = _dataImport.Find(models => models.Id == int.Parse(_id));
    var Form = new Formulaire(_id, customer);
    Form.ShowDialog();

    CvModels result = Form.Response;
    if (result == null) return;

    // MODIFICATIONS DU CANDIDAT DANS LE STATE LOCAL
    customer.FirstName = result.FirstName; 
    customer.LastName = result.LastName;
    customer.City = result.City;
    customer.Birthdate = result.Birthdate;
    customer.PostalCode = result.PostalCode;
    customer.Address = result.Address;
    customer.Address1 = result.Address1;
    customer.Website = result.Website;
    customer.Linkedin = result.Linkedin;
    customer.Viadeo = result.Viadeo;
    customer.Facebook = result.Facebook;
    customer.MobilePhone = result.MobilePhone;
    customer.Phone = result.Phone;
    customer.Email = result.Email;
    customer.Profil = result.Profil;
    customer.Skill1 = result.Skill1;
    customer.Skill2 = result.Skill2;
    customer.Skill3 = result.Skill3;
    customer.Skill4 = result.Skill4;
    customer.Skill5 = result.Skill5;
    customer.Skill6 = result.Skill6;
    customer.Skill7 = result.Skill7;
    customer.Skill8 = result.Skill8;
    customer.Skill9 = result.Skill9;
    customer.Skill10 = result.Skill10;

    CsvParser.Export(_dataImport, null); // ENREGISTREMENT DES MODIFICATIONS DANS LE FICHIER CSV
    dataGridView1.Rows.Clear();
    Table_Shown(sender, e);
  }

  // AJOUT D'UN NOUVEAU CANDIDAT 
  private void NewRow_Click(object sender, EventArgs e)
  {
    var newId = dataGridView1.RowCount + 1;
    var Form = new Formulaire(newId.ToString());
    Form.ShowDialog();

    CvModels result = Form.Response;
    if (result == null) return;

    _dataImport.Add(result); // AJOUT DE LA LIGNE DANS LE STATE LOCAL
    CsvParser.Append(result); // AJOUT DE LA LIGNE DANS LE FICHIER CSV
    dataGridView1.Rows.Clear();
    Table_Shown(sender, e);
  }

  // OUVERTURE DU CV SI DISPONIBLE AU DOUBLE CLIQUE SUR LA LIGNE
  private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    if (e.RowIndex == -1) return;

    var FileName = $@"..\..\..\data\cv\{_id}";
    var Ext = File.Exists(FileName + ".pdf") ? ".pdf" : ".docx";

    try
    {
      ProcessStartInfo process = new()
      {
        FileName = FileName + Ext,
        UseShellExecute = true
      };
      Process.Start(process);
    }
    catch (Exception exception)
    {
      Console.WriteLine(exception);
      MessageBox.Show("Impossible d'ouvrir le cv !", "Erreur");
    }
  }

  // FILTRAGE DES LIGNES AFFICHER DANS LE TABLEAU
  private void SearchBox_TextChanged(object sender, EventArgs e)
  {
    var txtsearch = (TextBox) sender;
    var filter = ((KeyValuePair<string, string>) filterParams.SelectedItem).Key;

    if (txtsearch.Text != string.Empty)
    {
      foreach (DataGridViewRow row in dataGridView1.Rows)
      {
        row.Visible = row.Cells[filter].Value.ToString().Trim().ToLower().Contains(txtsearch.Text.Trim().ToLower());
      }
    }
    else
    {
      foreach (DataGridViewRow row in dataGridView1.Rows)
      {
        row.Visible = true;
      }
    }
  }

  // LISTENER POUR DETERMINER L'ID DU CANDIDAT A MODIFIER
  private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
  {
    if (e.RowIndex == -1) return;

    var grid = (DataGridView) sender;
    _id = grid.Rows[e.RowIndex].Cells[0].Value.ToString();
  }

  // EXPORT DES LIGNES FILTRER DANS UN FICHIER CSV
  private void export_Click(object sender, EventArgs e)
  {
    var rows = dataGridView1.Rows;

    var dataToExport = new List<CvModels?>();

    foreach (DataGridViewRow row in rows)
    {
      if (!row.Visible) continue;
      var id = int.Parse(row.Cells[0].Value.ToString());
      dataToExport.Add(_dataImport.Find(r => r.Id == id));
    }

    if (dataToExport.Count < 1)
    {
      MessageBox.Show("Aucune donnée à exporter !", "Erreur");
      return;
    }

    var path = "";
    var saveAs = new SaveFileDialog
    {
      Filter = "csv files (*.csv)|*.csv",
    };

    if (saveAs.ShowDialog() == DialogResult.OK)
    {
      path = saveAs.FileName;
    }

    if (path == string.Empty) return;

    CsvParser.Export(dataToExport, path);
  }

  // INJECTION DE CLE/VALEUR DANS LA COMBO-BOX POUR LE SYSTEME DE FILTRAGE
  private void Table_Load(object sender, EventArgs e)
  {
    Dictionary<string, string> filterDictionary = new()
    {
      {"Age", "Age"},
      {"City", "Ville"},
      {"Skills", "Compétence"}
    };

    filterParams.DataSource = new BindingSource(filterDictionary, null);
    filterParams.DisplayMember = "Value";
    filterParams.ValueMember = "Key";
    filterParams.SelectedIndex = 0;
  }
}