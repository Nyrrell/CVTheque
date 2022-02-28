namespace CVTheque
{
  partial class Table
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.SearchBox = new System.Windows.Forms.TextBox();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.MobilePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Profil = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Skills = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // SearchBox
      // 
      this.SearchBox.Location = new System.Drawing.Point(12, 12);
      this.SearchBox.Name = "SearchBox";
      this.SearchBox.Size = new System.Drawing.Size(148, 23);
      this.SearchBox.TabIndex = 3;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToOrderColumns = true;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.BirthDate,
            this.Age,
            this.MobilePhone,
            this.Email,
            this.Profil,
            this.City,
            this.Skills});
      this.dataGridView1.Location = new System.Drawing.Point(12, 41);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowTemplate.Height = 25;
      this.dataGridView1.Size = new System.Drawing.Size(1040, 508);
      this.dataGridView1.TabIndex = 4;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // LastName
      // 
      this.LastName.HeaderText = "Nom";
      this.LastName.Name = "LastName";
      this.LastName.ReadOnly = true;
      // 
      // FirstName
      // 
      this.FirstName.HeaderText = "Prénom";
      this.FirstName.Name = "FirstName";
      this.FirstName.ReadOnly = true;
      // 
      // BirthDate
      // 
      this.BirthDate.HeaderText = "Né le";
      this.BirthDate.Name = "BirthDate";
      this.BirthDate.ReadOnly = true;
      // 
      // Age
      // 
      this.Age.HeaderText = "Age";
      this.Age.Name = "Age";
      this.Age.ReadOnly = true;
      // 
      // MobilePhone
      // 
      this.MobilePhone.HeaderText = "Tél. portable";
      this.MobilePhone.Name = "MobilePhone";
      this.MobilePhone.ReadOnly = true;
      // 
      // Email
      // 
      this.Email.HeaderText = "Email";
      this.Email.Name = "Email";
      this.Email.ReadOnly = true;
      // 
      // Profil
      // 
      this.Profil.HeaderText = "Profil";
      this.Profil.Name = "Profil";
      this.Profil.ReadOnly = true;
      // 
      // City
      // 
      this.City.HeaderText = "Ville";
      this.City.Name = "City";
      this.City.ReadOnly = true;
      // 
      // Skills
      // 
      this.Skills.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.Skills.HeaderText = "Compétences";
      this.Skills.Name = "Skills";
      this.Skills.ReadOnly = true;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(977, 11);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 5;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // Table
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1064, 561);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.SearchBox);
      this.MinimumSize = new System.Drawing.Size(1080, 600);
      this.Name = "Table";
      this.Text = "CVTheque";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private TextBox SearchBox;
    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn LastName;
    private DataGridViewTextBoxColumn FirstName;
    private DataGridViewTextBoxColumn BirthDate;
    private DataGridViewTextBoxColumn Age;
    private DataGridViewTextBoxColumn MobilePhone;
    private DataGridViewTextBoxColumn Email;
    private DataGridViewTextBoxColumn Profil;
    private DataGridViewTextBoxColumn City;
    private DataGridViewTextBoxColumn Skills;
    private Button button1;
  }
}