using System.Diagnostics;
using CVTheque.Models;
using CsvParser = CVTheque.services.CsvParser;

namespace CVTheque.WindowForm
{
  public partial class Table : Form
  {
    private List<CvModels> dataImport;
    private string _id = "1";

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

      dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
    }

    private void editBtn_Click_1(object sender, EventArgs e)
    {
      var customer = dataImport.Find(models => models.Id == int.Parse(_id));
      var Form = new Formulaire(_id, customer);
      Form.ShowDialog();

      if (Form.DialogResult == DialogResult.OK)
      {
        CvModels result = Form.Response;
        Form.Response = new CvModels();
        dataImport[int.Parse(_id)].FirstName = result.FirstName;
        dataImport[int.Parse(_id)].LastName = result.LastName;
        dataImport[int.Parse(_id)].City = result.City;
        dataImport[int.Parse(_id)].Birthdate = result.Birthdate;
        dataImport[int.Parse(_id)].Age = result.Age;
        dataImport[int.Parse(_id)].PostalCode = result.PostalCode;
        dataImport[int.Parse(_id)].Address = result.Address;
        dataImport[int.Parse(_id)].Address1 = result.Address1;
        dataImport[int.Parse(_id)].Website = result.Website;
        dataImport[int.Parse(_id)].Linkedin = result.Linkedin;
        dataImport[int.Parse(_id)].Viadeo = result.Viadeo;
        dataImport[int.Parse(_id)].Facebook = result.Facebook;
        dataImport[int.Parse(_id)].MobilePhone = result.MobilePhone;
        dataImport[int.Parse(_id)].Phone = result.Phone;
        dataImport[int.Parse(_id)].Email = result.Email;
        dataImport[int.Parse(_id)].Profil = result.Profil;
        dataImport[int.Parse(_id)].Skill1 = result.Skill1;
        dataImport[int.Parse(_id)].Skill2 = result.Skill2;
        dataImport[int.Parse(_id)].Skill3 = result.Skill3;
        dataImport[int.Parse(_id)].Skill4 = result.Skill4;
        dataImport[int.Parse(_id)].Skill5 = result.Skill5;
        dataImport[int.Parse(_id)].Skill6 = result.Skill6;
        dataImport[int.Parse(_id)].Skill7 = result.Skill7;
        dataImport[int.Parse(_id)].Skill8 = result.Skill8;
        dataImport[int.Parse(_id)].Skill9 = result.Skill9;
        dataImport[int.Parse(_id)].Skill10 = result.Skill10;
        dataImport[int.Parse(_id)].Skills = customer.Skills;

        Table_Shown(sender, e);
      }
    }

    private void NewRow_Click(object sender, EventArgs e)
    {
      var newId = dataGridView1.RowCount + 1;
      var Form = new Formulaire(newId.ToString());
      Form.ShowDialog();

      if (Form.DialogResult == DialogResult.OK)
      {
        CvModels result = Form.Response;
        Form.Response = new CvModels();
        dataImport.Add(result);
        Table_Shown(sender, e);
      }
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
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
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      var grid = (DataGridView) sender;
      _id = grid.Rows[e.RowIndex].Cells[0].Value.ToString();
    }
  }
}