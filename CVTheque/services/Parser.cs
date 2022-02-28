using System;
using System.Linq;
using System.Globalization;
using System.IO;
using System.Data;
using System.Diagnostics;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using CVTheque.Models;

namespace CVTheque.services;

public class CsvParser
{
  public static void Parse()
  {
    using var streamReader = new StreamReader(@"..\..\..\data\hrdata.csv", Encoding.GetEncoding("iso-8859-1"));
    using var csv = new CsvReader(streamReader, new CultureInfo("fr"));

    csv.Context.RegisterClassMap<csvMap>();
    var records = csv.GetRecords<CvModels>().ToList();
  }
  
}

internal class csvMap : ClassMap<CvModels>
{
  public csvMap()
  {
    Map(m => m.Id).Name("Id");
    Map(m => m.FisrtName).Name("Prénom");
    Map(m => m.LastName).Name("LastName");
    Map(m => m.Age).Name("Âge");
    Map(m => m.Birthdate).Name("Date de naissance");
    Map(m => m.Adress1).Name("Adresse");
    Map(m => m.Adress2).Name("Adresse1");
    Map(m => m.PostalCode).Name("Code postal");
    Map(m => m.City).Name("ville");
    Map(m => m.MobilePhone).Name("Numéro de téléphone portable");
    Map(m => m.Phone).Name("Numéro de téléphone fixe");
    Map(m => m.Email).Name("Email");
    Map(m => m.Profil).Name("Profil");
    Map(m => m.Skill1).Name("Compétence 1");
    Map(m => m.Skill2).Name("Compétence 2");
    Map(m => m.Skill3).Name("Compétence 3");
    Map(m => m.Skill4).Name("Compétence 4");
    Map(m => m.Skill5).Name("Compétence 5");
    Map(m => m.Skill6).Name("Compétence 6");
    Map(m => m.Skill7).Name("Compétence 7");
    Map(m => m.Skill8).Name("Compétence 8");
    Map(m => m.Skill9).Name("Compétence 9");
    Map(m => m.Skill10).Name("Compétence 10");
    Map(m => m.Website).Name("Site Web");
    Map(m => m.Linkedin).Name("Profil Linkedin");
    Map(m => m.Viadeo).Name("Profil Viadeo");
    Map(m => m.Facebook).Name("Profil Facebook");
  }
}