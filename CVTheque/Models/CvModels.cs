using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVTheque.Models
{
  public class CvModels
  {
    private string _age = "";
    private string _skills = "";

    public int? Id { get; set; }
    public string? LastName { get; set; }
    public string? FisrtName { get; set; }
    public string Birthdate { get; set; } = string.Empty;
    public string Adress { get; set; } = string.Empty;
    public string Adress1 { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string MobilePhone { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Profil { get; set; } = string.Empty;
    public string Skill1 { get; set; } = string.Empty;
    public string Skill2 { get; set; } = string.Empty;
    public string Skill3 { get; set; } = string.Empty;
    public string Skill4 { get; set; } = string.Empty;
    public string Skill5 { get; set; } = string.Empty;
    public string Skill6 { get; set; } = string.Empty;
    public string Skill7 { get; set; } = string.Empty;
    public string Skill8 { get; set; } = string.Empty;
    public string Skill9 { get; set; } = string.Empty;
    public string Skill10 { get; set; } = string.Empty;
    public string Website { get; set; } = string.Empty;
    public string Linkedin { get; set; } = string.Empty;
    public string Viadeo { get; set; } = string.Empty;
    public string Facebook { get; set; } = string.Empty;

    public string Age
    {
      get { return _age; }
      set
      {
        string[] date = Birthdate.Split('/');
        if (date.Length > 1)
        {
          DateTime bday = new DateTime(Int32.Parse(date[2]), Int32.Parse(date[1]), Int32.Parse(date[0]));
          DateTime now = DateTime.Today;
          int age = now.Year - bday.Year;
          _age = age.ToString();
        }
      }
    }

    public string Skills
    {
      get { return _skills; }
      set
      {
        if (Skill1 != String.Empty) _skills = Skill1;
        if (Skill2 != String.Empty) _skills += "\n" + Skill2;
        if (Skill3 != String.Empty) _skills += "\n" + Skill3;
        if (Skill4 != String.Empty) _skills += "\n" + Skill4;
        if (Skill5 != String.Empty) _skills += "\n" + Skill5;
        if (Skill6 != String.Empty) _skills += "\n" + Skill6;
        if (Skill7 != String.Empty) _skills += "\n" + Skill7;
        if (Skill8 != String.Empty) _skills += "\n" + Skill8;
        if (Skill9 != String.Empty) _skills += "\n" + Skill9;
        if (Skill10 != String.Empty) _skills += "\n" + Skill10;

      }
    }
  }
}