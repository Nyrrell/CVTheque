namespace CVTheque.WindowForm
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.SearchBox = new System.Windows.Forms.TextBox();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.MobilePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Profil = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Skills = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.editBtn = new System.Windows.Forms.Button();
      this.LabelSearch = new System.Windows.Forms.Label();
      this.NewRow = new System.Windows.Forms.Button();
      this.export = new System.Windows.Forms.Button();
      this.filterParams = new System.Windows.Forms.ComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // SearchBox
      // 
      this.SearchBox.Location = new System.Drawing.Point(184, 12);
      this.SearchBox.Name = "SearchBox";
      this.SearchBox.Size = new System.Drawing.Size(250, 23);
      this.SearchBox.TabIndex = 3;
      this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToOrderColumns = true;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.LastName,
            this.FirstName,
            this.BirthDate,
            this.Age,
            this.MobilePhone,
            this.Email,
            this.Profil,
            this.City,
            this.Skills});
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
      this.dataGridView1.Location = new System.Drawing.Point(12, 49);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.RowTemplate.Height = 25;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(1153, 500);
      this.dataGridView1.TabIndex = 4;
      this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
      this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
      // 
      // Id
      // 
      this.Id.DataPropertyName = "Id";
      this.Id.HeaderText = "Id";
      this.Id.Name = "Id";
      this.Id.ReadOnly = true;
      this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.Id.Visible = false;
      // 
      // LastName
      // 
      this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.LastName.DataPropertyName = "LastName";
      this.LastName.HeaderText = "Nom";
      this.LastName.Name = "LastName";
      this.LastName.ReadOnly = true;
      this.LastName.Width = 59;
      // 
      // FirstName
      // 
      this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.FirstName.DataPropertyName = "FirstName";
      this.FirstName.HeaderText = "Prénom";
      this.FirstName.Name = "FirstName";
      this.FirstName.ReadOnly = true;
      this.FirstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.FirstName.Width = 55;
      // 
      // BirthDate
      // 
      this.BirthDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.BirthDate.DataPropertyName = "Birthdate";
      this.BirthDate.HeaderText = "Né le";
      this.BirthDate.Name = "BirthDate";
      this.BirthDate.ReadOnly = true;
      this.BirthDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.BirthDate.Width = 40;
      // 
      // Age
      // 
      this.Age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
      this.Age.DataPropertyName = "Age";
      this.Age.HeaderText = "Age";
      this.Age.Name = "Age";
      this.Age.ReadOnly = true;
      this.Age.Width = 53;
      // 
      // MobilePhone
      // 
      this.MobilePhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.MobilePhone.DataPropertyName = "MobilePhone";
      this.MobilePhone.HeaderText = "Tél. portable";
      this.MobilePhone.Name = "MobilePhone";
      this.MobilePhone.ReadOnly = true;
      this.MobilePhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.MobilePhone.Width = 77;
      // 
      // Email
      // 
      this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Email.DataPropertyName = "Email";
      this.Email.HeaderText = "Email";
      this.Email.Name = "Email";
      this.Email.ReadOnly = true;
      this.Email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.Email.Width = 42;
      // 
      // Profil
      // 
      this.Profil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Profil.DataPropertyName = "Profil";
      this.Profil.HeaderText = "Profil";
      this.Profil.Name = "Profil";
      this.Profil.ReadOnly = true;
      this.Profil.Width = 60;
      // 
      // City
      // 
      this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.City.DataPropertyName = "City";
      dataGridViewCellStyle1.NullValue = "\"NULL\"";
      this.City.DefaultCellStyle = dataGridViewCellStyle1;
      this.City.HeaderText = "Ville";
      this.City.Name = "City";
      this.City.ReadOnly = true;
      this.City.Width = 54;
      // 
      // Skills
      // 
      this.Skills.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.Skills.DataPropertyName = "Skills";
      dataGridViewCellStyle2.NullValue = "NULL";
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.Skills.DefaultCellStyle = dataGridViewCellStyle2;
      this.Skills.HeaderText = "Compétences";
      this.Skills.Name = "Skills";
      this.Skills.ReadOnly = true;
      this.Skills.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // editBtn
      // 
      this.editBtn.Location = new System.Drawing.Point(524, 12);
      this.editBtn.Name = "editBtn";
      this.editBtn.Size = new System.Drawing.Size(78, 23);
      this.editBtn.TabIndex = 5;
      this.editBtn.Text = "Afficher";
      this.editBtn.UseVisualStyleBackColor = true;
      this.editBtn.Click += new System.EventHandler(this.editBtn_Click_1);
      // 
      // LabelSearch
      // 
      this.LabelSearch.AutoSize = true;
      this.LabelSearch.Location = new System.Drawing.Point(16, 15);
      this.LabelSearch.Name = "LabelSearch";
      this.LabelSearch.Size = new System.Drawing.Size(63, 15);
      this.LabelSearch.TabIndex = 6;
      this.LabelSearch.Text = "Filtrer par :";
      // 
      // NewRow
      // 
      this.NewRow.Location = new System.Drawing.Point(440, 12);
      this.NewRow.Name = "NewRow";
      this.NewRow.Size = new System.Drawing.Size(78, 23);
      this.NewRow.TabIndex = 7;
      this.NewRow.Text = "Nouveau";
      this.NewRow.UseVisualStyleBackColor = true;
      this.NewRow.Click += new System.EventHandler(this.NewRow_Click);
      // 
      // export
      // 
      this.export.Location = new System.Drawing.Point(1090, 12);
      this.export.Name = "export";
      this.export.Size = new System.Drawing.Size(75, 23);
      this.export.TabIndex = 8;
      this.export.Text = "Exporter";
      this.export.UseVisualStyleBackColor = true;
      this.export.Click += new System.EventHandler(this.export_Click);
      // 
      // filterParams
      // 
      this.filterParams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.filterParams.FormattingEnabled = true;
      this.filterParams.Location = new System.Drawing.Point(83, 12);
      this.filterParams.Name = "filterParams";
      this.filterParams.Size = new System.Drawing.Size(95, 23);
      this.filterParams.Sorted = true;
      this.filterParams.TabIndex = 9;
      // 
      // Table
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1177, 561);
      this.Controls.Add(this.filterParams);
      this.Controls.Add(this.export);
      this.Controls.Add(this.NewRow);
      this.Controls.Add(this.LabelSearch);
      this.Controls.Add(this.editBtn);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.SearchBox);
      this.MinimumSize = new System.Drawing.Size(1080, 600);
      this.Name = "Table";
      this.Text = "CVTheque";
      this.Load += new System.EventHandler(this.Table_Load);
      this.Shown += new System.EventHandler(this.Table_Shown);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private TextBox SearchBox;
    private DataGridView dataGridView1;
    private Button editBtn;
    private Label LabelSearch;
    private Button NewRow;
    private Button export;
    private DataGridViewTextBoxColumn Id;
    private DataGridViewTextBoxColumn LastName;
    private DataGridViewTextBoxColumn FirstName;
    private DataGridViewTextBoxColumn BirthDate;
    private DataGridViewTextBoxColumn Age;
    private DataGridViewTextBoxColumn MobilePhone;
    private DataGridViewTextBoxColumn Email;
    private DataGridViewTextBoxColumn Profil;
    private DataGridViewTextBoxColumn City;
    private DataGridViewTextBoxColumn Skills;
    private ComboBox filterParams;
  }
}