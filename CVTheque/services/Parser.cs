using System;
using System.Linq;
using System.Globalization;
using System.IO;
using System.Data;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using CVTheque.Models;

namespace CVTheque.services;

public class CsvParser
{
  public static List<CvModels> Import()
  {
    var fileName = @"..\..\..\data\hrdata.csv";

    if (!File.Exists(fileName)) return new List<CvModels>();

    CsvReader csv = null;
    StreamReader sr;
    try
    {
      sr = new StreamReader(fileName, Encoding.GetEncoding("iso-8859-1"));
      csv = new CsvReader(sr, new CultureInfo("fr"));

      csv.Context.RegisterClassMap<CsvMap>();
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
    }
    return csv == null ? new List<CvModels>() : csv.GetRecords<CvModels>().ToList();
  }
}

internal class CsvMap : ClassMap<CvModels>
{
  public CsvMap()
  {
    Map(m => m.Id).Name("Id");
    Map(m => m.FirstName).Name("Prénom").TypeConverter<NulString>();
    Map(m => m.LastName).Name("Nom").TypeConverter<NulString>();
    Map(m => m.Birthdate).Name("Date de naissance").TypeConverter<NulString>();
    Map(m => m.Age).Name("Âge").TypeConverter<NulString>();
    Map(m => m.Address).Name("Adresse").TypeConverter<NulString>();
    Map(m => m.Address1).Name("Adresse 1").TypeConverter<NulString>();
    Map(m => m.PostalCode).Name("Code postal").TypeConverter<NulString>();
    Map(m => m.City).Name("ville").TypeConverter<NulString>();
    Map(m => m.MobilePhone).Name("Numéro de téléphone portable").TypeConverter<NulString>();
    Map(m => m.Phone).Name("Numéro de téléphone fixe").TypeConverter<NulString>();
    Map(m => m.Email).Name("Email").TypeConverter<NulString>();
    Map(m => m.Profil).Name("Profil").TypeConverter<NulString>();
    Map(m => m.Skill1).Name("Compétence 1").TypeConverter<NulString>();
    Map(m => m.Skill2).Name("Compétence 2").TypeConverter<NulString>();
    Map(m => m.Skill3).Name("Compétence 3").TypeConverter<NulString>();
    Map(m => m.Skill4).Name("Compétence 4").TypeConverter<NulString>();
    Map(m => m.Skill5).Name("Compétence 5").TypeConverter<NulString>();
    Map(m => m.Skill6).Name("Compétence 6").TypeConverter<NulString>();
    Map(m => m.Skill7).Name("Compétence 7").TypeConverter<NulString>();
    Map(m => m.Skill8).Name("Compétence 8").TypeConverter<NulString>();
    Map(m => m.Skill9).Name("Compétence 9").TypeConverter<NulString>();
    Map(m => m.Skill10).Name("Compétence 10").TypeConverter<NulString>();
    Map(m => m.Skills).Constant(string.Empty);
    Map(m => m.Website).Name("Site Web").TypeConverter<NulString>();
    Map(m => m.Linkedin).Name("Profil Linkedin").TypeConverter<NulString>();
    Map(m => m.Viadeo).Name("Profil Viadeo").TypeConverter<NulString>();
    Map(m => m.Facebook).Name("Profil facebook").TypeConverter<NulString>();
  }
}

public class NulString : StringConverter
{
  public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
  {
    if (text == "NULL")
    {
      text = string.Empty;
    }

    return base.ConvertFromString(text, row, memberMapData);
  }
}