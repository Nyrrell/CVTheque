using System.Data;
using System.Diagnostics;
using CVTheque.Models;
using CVTheque.services;

namespace CVTheque
{
  public partial class Table : Form
  {
    public Table()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      CsvParser.Parse();

    }

  }
}