using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVTheque.services
{
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
  }
}