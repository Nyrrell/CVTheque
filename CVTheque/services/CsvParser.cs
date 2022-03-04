using System.Diagnostics;
using System.Globalization;
using System.Text;
using CsvHelper;
using CVTheque.Models;

namespace CVTheque.services;

public class CsvParser
{
  private const string _filename = @"..\..\..\data\hrdata.csv";

  // IMPORTE LE FICHIER CSV
  public static List<CvModels> Import()
  {
    if (!File.Exists(_filename)) return new List<CvModels>();

    CsvReader? csv = null;
    try
    {
      var sr = new StreamReader(_filename, Encoding.GetEncoding("iso-8859-1"));
      csv = new CsvReader(sr, new CultureInfo("fr"));
      csv.Context.RegisterClassMap<CsvMap>();
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
    }

    var data = csv == null ? new List<CvModels>() : csv.GetRecords<CvModels>().ToList();
    csv.Dispose();
    return data;
  }

  // EXPORT LE FICHIER CSV OU MET A JOUR LE CONTENU DU CSV D'ORIGINE
  public static void Export(List<CvModels> data, string? path)
  {
    try
    {
      var export = path != null;
      path ??= _filename;

      using var sw = new StreamWriter(path, false, Encoding.GetEncoding("iso-8859-1"));
      using var csv = new CsvWriter(sw, new CultureInfo("fr"));
      csv.Context.RegisterClassMap<CsvMap>();
      csv.WriteHeader<CvModels>();
      csv.NextRecord();

      csv.WriteRecords(data);
      csv.Dispose();

      if (export)
      {
        MessageBox.Show("Exportation du fichier réussi.", "Succes");
        ProcessStartInfo process = new()
        {
          FileName = path,
          UseShellExecute = true
        };
        Process.Start(process);
      }
    }
    catch (Exception exception)
    {
      Console.WriteLine(exception);
      MessageBox.Show("Impossible d'exporter le fichier !", "Erreur");
    }
  }

  // AJOUTE UNE NOUVELLE LIGNE AU FICHIER CSV
  public static void Append(CvModels data)
  {
    try
    {
      using var stream = File.Open(_filename, FileMode.Append);
      using var sw = new StreamWriter(stream, Encoding.GetEncoding("iso-8859-1"));
      using var csv = new CsvWriter(sw, new CultureInfo("fr"));
      csv.Context.RegisterClassMap<CsvMap>();

      csv.WriteRecord(data);
      csv.NextRecord();
      csv.Dispose();
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
      MessageBox.Show("Impossible d'ajouter le candidat au fichier !", "Erreur");
    }
  }
}