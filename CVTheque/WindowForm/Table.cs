using System.ComponentModel;
using System.Data;
using CVTheque.Models;
using System.Diagnostics;
using System.Globalization;
using CsvHelper;
using CsvParser = CVTheque.services.CsvParser;

namespace CVTheque.WindowForm
{
  public partial class Table : Form
  {
    private List<CvModels> dataImport;
    private string? _id;

    public Table()
    {
      InitializeComponent();
      dataImport = CsvParser.Import();
    }

    private void Table_Shown(object sender, EventArgs e)
    {
      if (dataImport.Count == 0)
      {
        MessageBox.Show("Impossible d'ouvrir le fichier CSV !", "Erreur");
        return;
      }

      dataImport.ForEach(c =>
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
      dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[1];
      _id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
    }

    private void editBtn_Click_1(object sender, EventArgs e)
    {
      var customer = dataImport.Find(models => models.Id == int.Parse(_id));
      var Form = new Formulaire(_id, customer);
      Form.ShowDialog();

      if (Form.Response != null)
      {
        CvModels result = Form.Response;
        Form.Response = new CvModels();
        customer.FirstName = result.FirstName;
        customer.LastName = result.LastName;
        customer.City = result.City;
        customer.Birthdate = result.Birthdate;
        customer.Age = result.Age;
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
        customer.Skills = result.Skills;

        dataGridView1.Rows.Clear();
        Table_Shown(sender, e);
      }
    }

    private void NewRow_Click(object sender, EventArgs e)
    {
      var newId = dataGridView1.RowCount + 1;
      var Form = new Formulaire(newId.ToString());
      Form.ShowDialog();

      if (Form.Response != null)
      {
        CvModels result = Form.Response;
        Form.Response = new CvModels();
        dataImport.Add(result);
        dataGridView1.Rows.Clear();
        Table_Shown(sender, e);
      }
    }

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

    private void SearchBox_TextChanged(object sender, EventArgs e)
    {
      var txtsearch = (TextBox) sender;
      var filter = ((KeyValuePair<string, string>) filterParams.SelectedItem).Key;

      if (txtsearch.Text != string.Empty)
      {
        foreach (DataGridViewRow row in dataGridView1.Rows)
        {
          if (row.Cells[filter].Value.ToString().Trim().ToLower().Contains(txtsearch.Text.Trim().ToLower()))
          {
            row.Visible = true;
          }
          else
            row.Visible = false;
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

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == -1) return;

      var grid = (DataGridView) sender;
      _id = grid.Rows[e.RowIndex].Cells[0].Value.ToString();
    }

    private void export_Click(object sender, EventArgs e)
    {
      using (var textWriter = File.CreateText(@"C:\Users\User-14\Desktop\NewCsv.csv"))
      using (var csv = new CsvWriter(textWriter, new CultureInfo("fr")))
      {
        // Write columns
        foreach (DataGridViewTextBoxColumn column in dataGridView1.Columns)
        {
          csv.WriteField(column.Name);
        }

        csv.NextRecord();

        // Write row values
        foreach (DataGridViewRow row in dataGridView1.Rows)
        {
          for (var i = 0; i < dataGridView1.Columns.Count; i++)
          {
            csv.WriteField(row.Cells[i].Value.ToString());
          }

          csv.NextRecord();
        }
      }
    }

    private void Table_Load(object sender, EventArgs e)
    {
      dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
      dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);

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
}