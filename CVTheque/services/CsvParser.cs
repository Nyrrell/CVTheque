using System.Diagnostics;
using System.Globalization;
using System.Text;
using CsvHelper;
using CVTheque.Models;

namespace CVTheque.services;

public class CsvParser
{
  public static List<CvModels> Import()
  {
    var fileName = @"..\..\..\data\hrdata.csv";

    if (!File.Exists(fileName)) return new List<CvModels>();

    CsvReader? csv = null;
    try
    {
      var sr = new StreamReader(fileName, Encoding.GetEncoding("iso-8859-1"));
      csv = new CsvReader(sr, new CultureInfo("fr"));

      csv.Context.RegisterClassMap<CsvMap>();
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
    }
    return csv == null ? new List<CvModels>() : csv.GetRecords<CvModels>().ToList();
  }

  public static void Export(string path, List<CvModels> data)
  {
    try
    {
      using var sw = new StreamWriter(path, false, Encoding.GetEncoding("iso-8859-1"));
      using var csv = new CsvWriter(sw, new CultureInfo("fr"));
      csv.Context.RegisterClassMap<CsvMap>();
      csv.WriteHeader<CvModels>();
      csv.NextRecord();

      csv.WriteRecords(data);
      csv.Dispose();

      MessageBox.Show("Exportation du fichier réussi.", "Succes");
      ProcessStartInfo process = new()
      {
        FileName = path,
        UseShellExecute = true
      };
      Process.Start(process);
    }
    catch (Exception exception)
    {
      Console.WriteLine(exception);
      MessageBox.Show("Impossible d'exporter le fichier !", "Erreur");
    }

  }
}