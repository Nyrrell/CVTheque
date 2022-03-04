using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace CVTheque;

  public static class Helpers
  {
    public static string CalculateAge(DateTime birthDay)
    {
      var dateNow = DateTime.Today;
      var age = dateNow.Year - birthDay.Year;

      age -= Convert.ToInt32(dateNow.Date < birthDay.Date.AddYears(age));

      return age.ToString();
    }

    public static DateTime? GetDate(string d)
    {
      var date = d.Split('/');
      if (date.Length > 1)
      {
        return new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
      }
      return null;
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
}