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
      var customer = dataImport.Find(models => models.Id == Int32.Parse(_id));
      var Form = new Formulaire(customer);
      Form.ShowDialog();
      CvModels result = Form.Response;
      Form.Response = new CvModels();
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

    private void NewRow_Click(object sender, EventArgs e)
    {
      var Form = new Formulaire();
      Form.ShowDialog();
      CvModels result = Form.Response;
      Form.Response = new CvModels();
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      var grid = (DataGridView)sender;
      _id = grid.Rows[e.RowIndex].Cells[0].Value.ToString();
    }
  }
}