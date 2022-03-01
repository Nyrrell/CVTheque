using System.Data;
using System.Diagnostics;
using System.Globalization;
using CsvHelper;
using CVTheque.Models;
using CsvParser = CVTheque.services.CsvParser;

namespace CVTheque
{
  public partial class Table : Form
  {
    private List<CvModels> dataImport;

    public Table()
    {
      InitializeComponent();
      dataImport = CsvParser.Import();
      dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
      dataImport.ForEach(c =>
      {
        dataGridView1.Rows.Add(
          c.Id,
          c.LastName,
          c.FisrtName,
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

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      var grid = (DataGridView)sender;
      var id = grid.Rows[e.RowIndex].Cells[0].Value.ToString();
      Console.WriteLine(e.RowIndex);
      Console.WriteLine(id);
      var test = dataImport.Find(models => models.Id == Int32.Parse(id));
      Console.WriteLine(test.FisrtName);
      Console.WriteLine(test.LastName);

      var FileName = $@"..\..\..\data\cv\{id}";
      var Ext = File.Exists(FileName+".pdf") ? ".pdf" :".docx" ;

      ProcessStartInfo process = new();
      process.FileName = FileName+Ext;
      process.UseShellExecute = true;
      Process.Start(process);
    }
  }
}