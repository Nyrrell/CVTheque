using CVTheque.Models;
using static CVTheque.Helpers;

namespace CVTheque.WindowForm;

public partial class Formulaire : Form
{
  private string _id;
  private CvModels? _model;
  public CvModels? Response { get; set; }

  public Formulaire(string id, CvModels? data = null)
  {
    InitializeComponent();
    _id = id;
    _model = data;
  }

  private void Formulaire_Load(object sender, EventArgs e)
  {
    if (_model != null) PopulateField();
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
    LastName.Text = _model.LastName;
    FirstName.Text = _model.FirstName;
    Age.Text = _model.Age;
    Birthdate.Value = (DateTime) GetDate(_model.Birthdate);
    City.Text = _model.City;
    PostalCode.Text = _model.PostalCode;
    Adress.Text = _model.Address;
    Adress1.Text = _model.Address1;
    Website.Text = _model.Website;
    Linkedin.Text = _model.Linkedin;
    Viadeo.Text = _model.Viadeo;
    Facebook.Text = _model.Facebook;
    MobilePhone.Text = _model.MobilePhone;
    Phone.Text = _model.Phone;
    Email.Text = _model.Email;
    Profil.Text = _model.Profil;
    Skill1.Text = _model.Skill1;
    Skill2.Text = _model.Skill2;
    Skill3.Text = _model.Skill3;
    Skill4.Text = _model.Skill4;
    Skill5.Text = _model.Skill5;
    Skill6.Text = _model.Skill6;
    Skill7.Text = _model.Skill7;
    Skill8.Text = _model.Skill8;
    Skill9.Text = _model.Skill9;
    Skill10.Text = _model.Skill10;
  }
}