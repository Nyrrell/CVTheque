﻿using System.ComponentModel;
using CVTheque.Models;
using static CVTheque.services.Helpers;

namespace CVTheque.WindowForm;

public partial class Formulaire : Form
{
  private string _id;
  private CvModels? model;
  public CvModels Response { get; set; }

  public Formulaire(string id, CvModels? data = null)
  {
    InitializeComponent();
    _id = id;
    model = data;
  }

  private void Formulaire_Load(object sender, EventArgs e)
  {
    if (model != null) PopulateField();
  }

  private void Birthdate_ValueChanged(object sender, EventArgs e)
  {
    var dateTime = (DateTimePicker) sender;
    Age.Text = CalculateAge(dateTime.Value.Date);
  }

  private void valid_Click(object sender, EventArgs e)
  {
    if (FirstName.Text == "" || LastName.Text == "" || MobilePhone.Text == "" || Email.Text == "" ||
        Profil.Text == "" || Skill1.Text == "" || Skill2.Text == "" || Skill3.Text == "" || Skill4.Text == "" ||
        Skill5.Text == "")
    {
      MessageBox.Show("Merci de remplir les champs requis !", "Erreur");
      return;
    }

    Response = new CvModels
    {
      Id = int.Parse(_id),
      FirstName = FirstName.Text,
      LastName = LastName.Text,
      City = City.Text,
      Birthdate = Birthdate.Value.ToShortDateString(),
      Age = Age.Text,
      PostalCode = PostalCode.Text,
      Address = Adress.Text,
      Address1 = Adress1.Text,
      Website = Website.Text,
      Linkedin = Linkedin.Text,
      Viadeo = Viadeo.Text,
      Facebook = Facebook.Text,
      MobilePhone = MobilePhone.Text,
      Phone = Phone.Text,
      Email = Email.Text,
      Profil = Profil.Text,
      Skill1 = Skill1.Text,
      Skill2 = Skill2.Text,
      Skill3 = Skill3.Text,
      Skill4 = Skill4.Text,
      Skill5 = Skill5.Text,
      Skill6 = Skill6.Text,
      Skill7 = Skill7.Text,
      Skill8 = Skill8.Text,
      Skill9 = Skill9.Text,
      Skill10 = Skill10.Text,
    };
    Dispose();
  }

  private void PopulateField()
  {
    LastName.Text = model.LastName;
    FirstName.Text = model.FirstName;
    Age.Text = model.Age;
    Birthdate.Value = (DateTime) GetDate(model.Birthdate);
    City.Text = model.City;
    PostalCode.Text = model.PostalCode;
    Adress.Text = model.Address;
    Adress1.Text = model.Address1;
    Website.Text = model.Website;
    Linkedin.Text = model.Linkedin;
    Viadeo.Text = model.Viadeo;
    Facebook.Text = model.Facebook;
    MobilePhone.Text = model.MobilePhone;
    Phone.Text = model.Phone;
    Email.Text = model.Email;
    Profil.Text = model.Profil;
    Skill1.Text = model.Skill1;
    Skill2.Text = model.Skill2;
    Skill3.Text = model.Skill3;
    Skill4.Text = model.Skill4;
    Skill5.Text = model.Skill5;
    Skill6.Text = model.Skill6;
    Skill7.Text = model.Skill7;
    Skill8.Text = model.Skill8;
    Skill9.Text = model.Skill9;
    Skill10.Text = model.Skill10;
  }
}