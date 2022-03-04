using CsvHelper.Configuration;

namespace CVTheque.Models;

internal class CsvMap : ClassMap<CvModels>
{
    public CsvMap()
    {
        Map(m => m.Id).Name("Id");
        Map(m => m.FirstName).Name("Prénom").TypeConverter<Helpers.NulString>();
        Map(m => m.LastName).Name("Nom").TypeConverter<Helpers.NulString>();
        Map(m => m.Birthdate).Name("Date de naissance").TypeConverter<Helpers.NulString>();
        Map(m => m.Age).Name("Âge").TypeConverter<Helpers.NulString>();
        Map(m => m.Address).Name("Adresse").TypeConverter<Helpers.NulString>();
        Map(m => m.Address1).Name("Adresse 1").TypeConverter<Helpers.NulString>();
        Map(m => m.PostalCode).Name("Code postal").TypeConverter<Helpers.NulString>();
        Map(m => m.City).Name("ville").TypeConverter<Helpers.NulString>();
        Map(m => m.MobilePhone).Name("Numéro de téléphone portable").TypeConverter<Helpers.NulString>();
        Map(m => m.Phone).Name("Numéro de téléphone fixe").TypeConverter<Helpers.NulString>();
        Map(m => m.Email).Name("Email").TypeConverter<Helpers.NulString>();
        Map(m => m.Profil).Name("Profil").TypeConverter<Helpers.NulString>();
        Map(m => m.Skill1).Name("Compétence 1").TypeConverter<Helpers.NulString>();
        Map(m => m.Skill2).Name("Compétence 2").TypeConverter<Helpers.NulString>();
        Map(m => m.Skill3).Name("Compétence 3").TypeConverter<Helpers.NulString>();
        Map(m => m.Skill4).Name("Compétence 4").TypeConverter<Helpers.NulString>();
        Map(m => m.Skill5).Name("Compétence 5").TypeConverter<Helpers.NulString>();
        Map(m => m.Skill6).Name("Compétence 6").TypeConverter<Helpers.NulString>();
        Map(m => m.Skill7).Name("Compétence 7").TypeConverter<Helpers.NulString>();
        Map(m => m.Skill8).Name("Compétence 8").TypeConverter<Helpers.NulString>();
        Map(m => m.Skill9).Name("Compétence 9").TypeConverter<Helpers.NulString>();
        Map(m => m.Skill10).Name("Compétence 10").TypeConverter<Helpers.NulString>();
        Map(m => m.Website).Name("Site Web").TypeConverter<Helpers.NulString>();
        Map(m => m.Linkedin).Name("Profil Linkedin").TypeConverter<Helpers.NulString>();
        Map(m => m.Viadeo).Name("Profil Viadeo").TypeConverter<Helpers.NulString>();
        Map(m => m.Facebook).Name("Profil facebook").TypeConverter<Helpers.NulString>();
    }
}