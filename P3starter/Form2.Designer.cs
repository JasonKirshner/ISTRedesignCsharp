namespace Project3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblPplTitle = new System.Windows.Forms.Label();
            this.lblPplSubTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpFaculty = new System.Windows.Forms.TabPage();
            this.llFacWeb = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFacEmail = new System.Windows.Forms.Label();
            this.lblFacPhone = new System.Windows.Forms.Label();
            this.lblFacOffice = new System.Windows.Forms.Label();
            this.lblFacIA = new System.Windows.Forms.Label();
            this.lblFacTitle = new System.Windows.Forms.Label();
            this.lblFacName = new System.Windows.Forms.Label();
            this.pbFacImg = new System.Windows.Forms.PictureBox();
            this.cbPeople = new System.Windows.Forms.ComboBox();
            this.tpStaff = new System.Windows.Forms.TabPage();
            this.llStaffWeb = new System.Windows.Forms.LinkLabel();
            this.lblStaffWeb = new System.Windows.Forms.Label();
            this.lblStaffEmail = new System.Windows.Forms.Label();
            this.lblStaffPhone = new System.Windows.Forms.Label();
            this.lblStaffOffice = new System.Windows.Forms.Label();
            this.lblStaffIA = new System.Windows.Forms.Label();
            this.lblStaffTitle = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.pbStaff = new System.Windows.Forms.PictureBox();
            this.cbStaff = new System.Windows.Forms.ComboBox();
            this.btnResearch = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnNews = new System.Windows.Forms.Button();
            this.btnMinors = new System.Windows.Forms.Button();
            this.btnEmployment = new System.Windows.Forms.Button();
            this.btnDegrees = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnResources = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpFaculty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFacImg)).BeginInit();
            this.tpStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPplTitle
            // 
            this.lblPplTitle.AutoSize = true;
            this.lblPplTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPplTitle.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPplTitle.ForeColor = System.Drawing.Color.White;
            this.lblPplTitle.Location = new System.Drawing.Point(356, 133);
            this.lblPplTitle.Name = "lblPplTitle";
            this.lblPplTitle.Size = new System.Drawing.Size(299, 36);
            this.lblPplTitle.TabIndex = 0;
            this.lblPplTitle.Text = "{People Title Goes Here}";
            // 
            // lblPplSubTitle
            // 
            this.lblPplSubTitle.AutoSize = true;
            this.lblPplSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPplSubTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPplSubTitle.ForeColor = System.Drawing.Color.White;
            this.lblPplSubTitle.Location = new System.Drawing.Point(226, 169);
            this.lblPplSubTitle.Name = "lblPplSubTitle";
            this.lblPplSubTitle.Size = new System.Drawing.Size(250, 26);
            this.lblPplSubTitle.TabIndex = 1;
            this.lblPplSubTitle.Text = "{People SubTitle Goes Here}";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpFaculty);
            this.tabControl1.Controls.Add(this.tpStaff);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(96, 227);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(702, 316);
            this.tabControl1.TabIndex = 2;
            // 
            // tpFaculty
            // 
            this.tpFaculty.BackColor = System.Drawing.Color.Pink;
            this.tpFaculty.Controls.Add(this.llFacWeb);
            this.tpFaculty.Controls.Add(this.label1);
            this.tpFaculty.Controls.Add(this.lblFacEmail);
            this.tpFaculty.Controls.Add(this.lblFacPhone);
            this.tpFaculty.Controls.Add(this.lblFacOffice);
            this.tpFaculty.Controls.Add(this.lblFacIA);
            this.tpFaculty.Controls.Add(this.lblFacTitle);
            this.tpFaculty.Controls.Add(this.lblFacName);
            this.tpFaculty.Controls.Add(this.pbFacImg);
            this.tpFaculty.Controls.Add(this.cbPeople);
            this.tpFaculty.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpFaculty.Location = new System.Drawing.Point(4, 25);
            this.tpFaculty.Name = "tpFaculty";
            this.tpFaculty.Padding = new System.Windows.Forms.Padding(3);
            this.tpFaculty.Size = new System.Drawing.Size(694, 287);
            this.tpFaculty.TabIndex = 0;
            this.tpFaculty.Text = "Faculty";
            // 
            // llFacWeb
            // 
            this.llFacWeb.AutoSize = true;
            this.llFacWeb.Location = new System.Drawing.Point(487, 200);
            this.llFacWeb.Name = "llFacWeb";
            this.llFacWeb.Size = new System.Drawing.Size(29, 15);
            this.llFacWeb.TabIndex = 19;
            this.llFacWeb.TabStop = true;
            this.llFacWeb.Text = "Link";
            this.llFacWeb.Click += new System.EventHandler(this.llFacWeb_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Website:";
            // 
            // lblFacEmail
            // 
            this.lblFacEmail.AutoSize = true;
            this.lblFacEmail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacEmail.Location = new System.Drawing.Point(400, 239);
            this.lblFacEmail.Name = "lblFacEmail";
            this.lblFacEmail.Size = new System.Drawing.Size(58, 23);
            this.lblFacEmail.TabIndex = 7;
            this.lblFacEmail.Text = "Email:";
            // 
            // lblFacPhone
            // 
            this.lblFacPhone.AutoSize = true;
            this.lblFacPhone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacPhone.Location = new System.Drawing.Point(400, 149);
            this.lblFacPhone.Name = "lblFacPhone";
            this.lblFacPhone.Size = new System.Drawing.Size(65, 23);
            this.lblFacPhone.TabIndex = 6;
            this.lblFacPhone.Text = "Phone:";
            // 
            // lblFacOffice
            // 
            this.lblFacOffice.AutoSize = true;
            this.lblFacOffice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacOffice.Location = new System.Drawing.Point(400, 104);
            this.lblFacOffice.Name = "lblFacOffice";
            this.lblFacOffice.Size = new System.Drawing.Size(66, 23);
            this.lblFacOffice.TabIndex = 5;
            this.lblFacOffice.Text = "Office: ";
            // 
            // lblFacIA
            // 
            this.lblFacIA.AutoSize = true;
            this.lblFacIA.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacIA.Location = new System.Drawing.Point(400, 60);
            this.lblFacIA.Name = "lblFacIA";
            this.lblFacIA.Size = new System.Drawing.Size(121, 23);
            this.lblFacIA.TabIndex = 4;
            this.lblFacIA.Text = "Interest Area:";
            // 
            // lblFacTitle
            // 
            this.lblFacTitle.AutoSize = true;
            this.lblFacTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacTitle.Location = new System.Drawing.Point(400, 16);
            this.lblFacTitle.Name = "lblFacTitle";
            this.lblFacTitle.Size = new System.Drawing.Size(51, 23);
            this.lblFacTitle.TabIndex = 3;
            this.lblFacTitle.Text = "Title:";
            // 
            // lblFacName
            // 
            this.lblFacName.AutoSize = true;
            this.lblFacName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacName.Location = new System.Drawing.Point(184, 202);
            this.lblFacName.Name = "lblFacName";
            this.lblFacName.Size = new System.Drawing.Size(57, 23);
            this.lblFacName.TabIndex = 2;
            this.lblFacName.Text = "Name";
            // 
            // pbFacImg
            // 
            this.pbFacImg.Location = new System.Drawing.Point(188, 16);
            this.pbFacImg.Name = "pbFacImg";
            this.pbFacImg.Size = new System.Drawing.Size(163, 183);
            this.pbFacImg.TabIndex = 1;
            this.pbFacImg.TabStop = false;
            // 
            // cbPeople
            // 
            this.cbPeople.BackColor = System.Drawing.Color.PowderBlue;
            this.cbPeople.FormattingEnabled = true;
            this.cbPeople.Location = new System.Drawing.Point(6, 16);
            this.cbPeople.Name = "cbPeople";
            this.cbPeople.Size = new System.Drawing.Size(167, 23);
            this.cbPeople.TabIndex = 0;
            this.cbPeople.SelectedIndexChanged += new System.EventHandler(this.cbPeople_SelectedIndexChanged);
            // 
            // tpStaff
            // 
            this.tpStaff.BackColor = System.Drawing.Color.Lavender;
            this.tpStaff.Controls.Add(this.llStaffWeb);
            this.tpStaff.Controls.Add(this.lblStaffWeb);
            this.tpStaff.Controls.Add(this.lblStaffEmail);
            this.tpStaff.Controls.Add(this.lblStaffPhone);
            this.tpStaff.Controls.Add(this.lblStaffOffice);
            this.tpStaff.Controls.Add(this.lblStaffIA);
            this.tpStaff.Controls.Add(this.lblStaffTitle);
            this.tpStaff.Controls.Add(this.lblStaffName);
            this.tpStaff.Controls.Add(this.pbStaff);
            this.tpStaff.Controls.Add(this.cbStaff);
            this.tpStaff.Location = new System.Drawing.Point(4, 25);
            this.tpStaff.Name = "tpStaff";
            this.tpStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tpStaff.Size = new System.Drawing.Size(694, 287);
            this.tpStaff.TabIndex = 1;
            this.tpStaff.Text = "Staff";
            // 
            // llStaffWeb
            // 
            this.llStaffWeb.AutoSize = true;
            this.llStaffWeb.Location = new System.Drawing.Point(482, 199);
            this.llStaffWeb.Name = "llStaffWeb";
            this.llStaffWeb.Size = new System.Drawing.Size(35, 16);
            this.llStaffWeb.TabIndex = 17;
            this.llStaffWeb.TabStop = true;
            this.llStaffWeb.Text = "Link";
            this.llStaffWeb.Click += new System.EventHandler(this.llStaffWeb_LinkClicked);
            // 
            // lblStaffWeb
            // 
            this.lblStaffWeb.AutoSize = true;
            this.lblStaffWeb.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffWeb.Location = new System.Drawing.Point(395, 192);
            this.lblStaffWeb.Name = "lblStaffWeb";
            this.lblStaffWeb.Size = new System.Drawing.Size(81, 23);
            this.lblStaffWeb.TabIndex = 16;
            this.lblStaffWeb.Text = "Website:";
            // 
            // lblStaffEmail
            // 
            this.lblStaffEmail.AutoSize = true;
            this.lblStaffEmail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffEmail.Location = new System.Drawing.Point(395, 236);
            this.lblStaffEmail.Name = "lblStaffEmail";
            this.lblStaffEmail.Size = new System.Drawing.Size(58, 23);
            this.lblStaffEmail.TabIndex = 15;
            this.lblStaffEmail.Text = "Email:";
            // 
            // lblStaffPhone
            // 
            this.lblStaffPhone.AutoSize = true;
            this.lblStaffPhone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffPhone.Location = new System.Drawing.Point(395, 148);
            this.lblStaffPhone.Name = "lblStaffPhone";
            this.lblStaffPhone.Size = new System.Drawing.Size(65, 23);
            this.lblStaffPhone.TabIndex = 14;
            this.lblStaffPhone.Text = "Phone:";
            // 
            // lblStaffOffice
            // 
            this.lblStaffOffice.AutoSize = true;
            this.lblStaffOffice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffOffice.Location = new System.Drawing.Point(395, 103);
            this.lblStaffOffice.Name = "lblStaffOffice";
            this.lblStaffOffice.Size = new System.Drawing.Size(66, 23);
            this.lblStaffOffice.TabIndex = 13;
            this.lblStaffOffice.Text = "Office: ";
            // 
            // lblStaffIA
            // 
            this.lblStaffIA.AutoSize = true;
            this.lblStaffIA.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffIA.Location = new System.Drawing.Point(395, 59);
            this.lblStaffIA.Name = "lblStaffIA";
            this.lblStaffIA.Size = new System.Drawing.Size(121, 23);
            this.lblStaffIA.TabIndex = 12;
            this.lblStaffIA.Text = "Interest Area:";
            // 
            // lblStaffTitle
            // 
            this.lblStaffTitle.AutoSize = true;
            this.lblStaffTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffTitle.Location = new System.Drawing.Point(395, 15);
            this.lblStaffTitle.Name = "lblStaffTitle";
            this.lblStaffTitle.Size = new System.Drawing.Size(51, 23);
            this.lblStaffTitle.TabIndex = 11;
            this.lblStaffTitle.Text = "Title:";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(184, 264);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(57, 23);
            this.lblStaffName.TabIndex = 10;
            this.lblStaffName.Text = "Name";
            // 
            // pbStaff
            // 
            this.pbStaff.Location = new System.Drawing.Point(188, 15);
            this.pbStaff.Name = "pbStaff";
            this.pbStaff.Size = new System.Drawing.Size(201, 246);
            this.pbStaff.TabIndex = 9;
            this.pbStaff.TabStop = false;
            // 
            // cbStaff
            // 
            this.cbStaff.BackColor = System.Drawing.Color.PowderBlue;
            this.cbStaff.FormattingEnabled = true;
            this.cbStaff.Location = new System.Drawing.Point(6, 15);
            this.cbStaff.Name = "cbStaff";
            this.cbStaff.Size = new System.Drawing.Size(167, 24);
            this.cbStaff.TabIndex = 8;
            this.cbStaff.SelectedIndexChanged += new System.EventHandler(this.cbStaff_SelectedIndexChanged);
            // 
            // btnResearch
            // 
            this.btnResearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnResearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResearch.Location = new System.Drawing.Point(442, 12);
            this.btnResearch.Name = "btnResearch";
            this.btnResearch.Size = new System.Drawing.Size(95, 46);
            this.btnResearch.TabIndex = 46;
            this.btnResearch.Text = "Research";
            this.btnResearch.UseVisualStyleBackColor = false;
            this.btnResearch.Click += new System.EventHandler(this.btnResearch_Click);
            // 
            // btnMap
            // 
            this.btnMap.BackColor = System.Drawing.Color.Cyan;
            this.btnMap.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.Location = new System.Drawing.Point(543, 60);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(95, 46);
            this.btnMap.TabIndex = 45;
            this.btnMap.Text = "IST Map";
            this.btnMap.UseVisualStyleBackColor = false;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnNews
            // 
            this.btnNews.BackColor = System.Drawing.Color.Crimson;
            this.btnNews.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNews.Location = new System.Drawing.Point(543, 12);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(95, 46);
            this.btnNews.TabIndex = 44;
            this.btnNews.Text = "News";
            this.btnNews.UseVisualStyleBackColor = false;
            this.btnNews.Click += new System.EventHandler(this.btnNews_Click);
            // 
            // btnMinors
            // 
            this.btnMinors.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMinors.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinors.Location = new System.Drawing.Point(240, 60);
            this.btnMinors.Name = "btnMinors";
            this.btnMinors.Size = new System.Drawing.Size(95, 46);
            this.btnMinors.TabIndex = 43;
            this.btnMinors.Text = "Minors";
            this.btnMinors.UseVisualStyleBackColor = false;
            this.btnMinors.Click += new System.EventHandler(this.btnMinors_Click);
            // 
            // btnEmployment
            // 
            this.btnEmployment.BackColor = System.Drawing.Color.Gold;
            this.btnEmployment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployment.Location = new System.Drawing.Point(341, 12);
            this.btnEmployment.Name = "btnEmployment";
            this.btnEmployment.Size = new System.Drawing.Size(95, 46);
            this.btnEmployment.TabIndex = 42;
            this.btnEmployment.Text = "Employment";
            this.btnEmployment.UseVisualStyleBackColor = false;
            this.btnEmployment.Click += new System.EventHandler(this.btnEmployment_Click);
            // 
            // btnDegrees
            // 
            this.btnDegrees.BackColor = System.Drawing.Color.Red;
            this.btnDegrees.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDegrees.Location = new System.Drawing.Point(240, 12);
            this.btnDegrees.Name = "btnDegrees";
            this.btnDegrees.Size = new System.Drawing.Size(95, 46);
            this.btnDegrees.TabIndex = 41;
            this.btnDegrees.Text = "Degrees";
            this.btnDegrees.UseVisualStyleBackColor = false;
            this.btnDegrees.Click += new System.EventHandler(this.btnDegrees_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Salmon;
            this.btnHome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(341, 60);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(95, 46);
            this.btnHome.TabIndex = 40;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnResources
            // 
            this.btnResources.BackColor = System.Drawing.Color.Orchid;
            this.btnResources.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResources.Location = new System.Drawing.Point(442, 60);
            this.btnResources.Name = "btnResources";
            this.btnResources.Size = new System.Drawing.Size(95, 46);
            this.btnResources.TabIndex = 39;
            this.btnResources.Text = "Resources";
            this.btnResources.UseVisualStyleBackColor = false;
            this.btnResources.Click += new System.EventHandler(this.btnResources_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(899, 598);
            this.Controls.Add(this.btnResearch);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnNews);
            this.Controls.Add(this.btnMinors);
            this.Controls.Add(this.btnEmployment);
            this.Controls.Add(this.btnDegrees);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnResources);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblPplSubTitle);
            this.Controls.Add(this.lblPplTitle);
            this.Name = "Form2";
            this.Text = "People";
            this.tabControl1.ResumeLayout(false);
            this.tpFaculty.ResumeLayout(false);
            this.tpFaculty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFacImg)).EndInit();
            this.tpStaff.ResumeLayout(false);
            this.tpStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPplTitle;
        private System.Windows.Forms.Label lblPplSubTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpFaculty;
        private System.Windows.Forms.TabPage tpStaff;
        private System.Windows.Forms.ComboBox cbPeople;
        private System.Windows.Forms.Label lblFacName;
        private System.Windows.Forms.PictureBox pbFacImg;
        private System.Windows.Forms.Label lblFacEmail;
        private System.Windows.Forms.Label lblFacPhone;
        private System.Windows.Forms.Label lblFacOffice;
        private System.Windows.Forms.Label lblFacIA;
        private System.Windows.Forms.Label lblFacTitle;
        private System.Windows.Forms.LinkLabel llFacWeb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llStaffWeb;
        private System.Windows.Forms.Label lblStaffWeb;
        private System.Windows.Forms.Label lblStaffEmail;
        private System.Windows.Forms.Label lblStaffPhone;
        private System.Windows.Forms.Label lblStaffOffice;
        private System.Windows.Forms.Label lblStaffIA;
        private System.Windows.Forms.Label lblStaffTitle;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.PictureBox pbStaff;
        private System.Windows.Forms.ComboBox cbStaff;
        private System.Windows.Forms.Button btnResearch;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnNews;
        private System.Windows.Forms.Button btnMinors;
        private System.Windows.Forms.Button btnEmployment;
        private System.Windows.Forms.Button btnDegrees;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnResources;
    }
}