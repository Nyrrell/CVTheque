using static CVTheque.Helpers;

namespace CVTheque.Models
{
  public class CvModels
  {
    public int? Id { get; set; }
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public string Birthdate { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Address1 { get; set; } = string.Empty;
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
      get
      {
        var date = GetDate(Birthdate);
        if (date != null) return CalculateAge((DateTime) date);
        return null;
      }
    }

    internal string Skills
    {
      get
      {
        string[] skillsArray = {Skill1, Skill2, Skill3, Skill4, Skill5, Skill6, Skill7, Skill8, Skill9, Skill10};
        skillsArray = skillsArray.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
        Array.Sort(skillsArray, string.Compare);
        return string.Join("\n", skillsArray);
      }
    }
  }
}