namespace Project3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.is_label = new System.Windows.Forms.Label();
            this.trit_label = new System.Windows.Forms.Label();
            this.abtTitle_label = new System.Windows.Forms.Label();
            this.tcAbout = new System.Windows.Forms.TabControl();
            this.tpDesc = new System.Windows.Forms.TabPage();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.tpQuote = new System.Windows.Forms.TabPage();
            this.rtbQuote = new System.Windows.Forms.RichTextBox();
            this.lblSocialTitle = new System.Windows.Forms.Label();
            this.rtbTweet = new System.Windows.Forms.RichTextBox();
            this.btnResearch = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnNews = new System.Windows.Forms.Button();
            this.btnMinors = new System.Windows.Forms.Button();
            this.btnEmployment = new System.Windows.Forms.Button();
            this.btnDegrees = new System.Windows.Forms.Button();
            this.btnPeople = new System.Windows.Forms.Button();
            this.btnResources = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tcAbout.SuspendLayout();
            this.tpDesc.SuspendLayout();
            this.tpQuote.SuspendLayout();
            this.SuspendLayout();
            // 
            // is_label
            // 
            this.is_label.AutoSize = true;
            this.is_label.BackColor = System.Drawing.Color.Transparent;
            this.is_label.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.is_label.ForeColor = System.Drawing.Color.Cyan;
            this.is_label.Location = new System.Drawing.Point(221, 107);
            this.is_label.Name = "is_label";
            this.is_label.Size = new System.Drawing.Size(375, 45);
            this.is_label.TabIndex = 1;
            this.is_label.Text = "Information Sciences &&";
            // 
            // trit_label
            // 
            this.trit_label.AutoSize = true;
            this.trit_label.BackColor = System.Drawing.Color.Transparent;
            this.trit_label.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trit_label.ForeColor = System.Drawing.Color.DarkOrange;
            this.trit_label.Location = new System.Drawing.Point(265, 152);
            this.trit_label.Name = "trit_label";
            this.trit_label.Size = new System.Drawing.Size(277, 42);
            this.trit_label.TabIndex = 2;
            this.trit_label.Text = "Technology @ RIT";
            // 
            // abtTitle_label
            // 
            this.abtTitle_label.AutoSize = true;
            this.abtTitle_label.BackColor = System.Drawing.Color.Transparent;
            this.abtTitle_label.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abtTitle_label.ForeColor = System.Drawing.Color.White;
            this.abtTitle_label.Location = new System.Drawing.Point(206, 218);
            this.abtTitle_label.Name = "abtTitle_label";
            this.abtTitle_label.Size = new System.Drawing.Size(184, 29);
            this.abtTitle_label.TabIndex = 4;
            this.abtTitle_label.Text = "{about title here}";
            // 
            // tcAbout
            // 
            this.tcAbout.Controls.Add(this.tpDesc);
            this.tcAbout.Controls.Add(this.tpQuote);
            this.tcAbout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcAbout.Location = new System.Drawing.Point(118, 250);
            this.tcAbout.Name = "tcAbout";
            this.tcAbout.SelectedIndex = 0;
            this.tcAbout.Size = new System.Drawing.Size(574, 174);
            this.tcAbout.TabIndex = 5;
            // 
            // tpDesc
            // 
            this.tpDesc.AccessibleDescription = "";
            this.tpDesc.Controls.Add(this.rtbDesc);
            this.tpDesc.Location = new System.Drawing.Point(4, 25);
            this.tpDesc.Name = "tpDesc";
            this.tpDesc.Padding = new System.Windows.Forms.Padding(3);
            this.tpDesc.Size = new System.Drawing.Size(566, 145);
            this.tpDesc.TabIndex = 0;
            this.tpDesc.Text = "Description";
            this.tpDesc.UseVisualStyleBackColor = true;
            // 
            // rtbDesc
            // 
            this.rtbDesc.AccessibleName = "rtbDesc";
            this.rtbDesc.BackColor = System.Drawing.Color.PapayaWhip;
            this.rtbDesc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDesc.Location = new System.Drawing.Point(0, 0);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.ReadOnly = true;
            this.rtbDesc.Size = new System.Drawing.Size(567, 148);
            this.rtbDesc.TabIndex = 6;
            this.rtbDesc.Text = "";
            // 
            // tpQuote
            // 
            this.tpQuote.Controls.Add(this.rtbQuote);
            this.tpQuote.Location = new System.Drawing.Point(4, 25);
            this.tpQuote.Name = "tpQuote";
            this.tpQuote.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuote.Size = new System.Drawing.Size(566, 145);
            this.tpQuote.TabIndex = 1;
            this.tpQuote.Text = "Quote";
            this.tpQuote.UseVisualStyleBackColor = true;
            // 
            // rtbQuote
            // 
            this.rtbQuote.AccessibleName = "rtbQuote";
            this.rtbQuote.BackColor = System.Drawing.Color.PapayaWhip;
            this.rtbQuote.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbQuote.Location = new System.Drawing.Point(0, 0);
            this.rtbQuote.Name = "rtbQuote";
            this.rtbQuote.ReadOnly = true;
            this.rtbQuote.Size = new System.Drawing.Size(566, 148);
            this.rtbQuote.TabIndex = 7;
            this.rtbQuote.Text = "";
            // 
            // lblSocialTitle
            // 
            this.lblSocialTitle.AutoSize = true;
            this.lblSocialTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSocialTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocialTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSocialTitle.Location = new System.Drawing.Point(310, 427);
            this.lblSocialTitle.Name = "lblSocialTitle";
            this.lblSocialTitle.Size = new System.Drawing.Size(197, 23);
            this.lblSocialTitle.TabIndex = 17;
            this.lblSocialTitle.Text = "{Social Title Goes Here}";
            // 
            // rtbTweet
            // 
            this.rtbTweet.AccessibleName = "rtbQuote";
            this.rtbTweet.BackColor = System.Drawing.Color.PapayaWhip;
            this.rtbTweet.Enabled = false;
            this.rtbTweet.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTweet.Location = new System.Drawing.Point(193, 453);
            this.rtbTweet.Name = "rtbTweet";
            this.rtbTweet.ReadOnly = true;
            this.rtbTweet.Size = new System.Drawing.Size(430, 69);
            this.rtbTweet.TabIndex = 8;
            this.rtbTweet.Text = "";
            // 
            // btnResearch
            // 
            this.btnResearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnResearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResearch.Location = new System.Drawing.Point(409, 12);
            this.btnResearch.Name = "btnResearch";
            this.btnResearch.Size = new System.Drawing.Size(95, 46);
            this.btnResearch.TabIndex = 38;
            this.btnResearch.Text = "Research";
            this.btnResearch.UseVisualStyleBackColor = false;
            this.btnResearch.Click += new System.EventHandler(this.btnResearch_Click);
            // 
            // btnMap
            // 
            this.btnMap.BackColor = System.Drawing.Color.Cyan;
            this.btnMap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.Location = new System.Drawing.Point(510, 60);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(95, 46);
            this.btnMap.TabIndex = 37;
            this.btnMap.Text = "IST Map";
            this.btnMap.UseVisualStyleBackColor = false;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnNews
            // 
            this.btnNews.BackColor = System.Drawing.Color.Crimson;
            this.btnNews.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNews.Location = new System.Drawing.Point(510, 12);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(95, 46);
            this.btnNews.TabIndex = 36;
            this.btnNews.Text = "News";
            this.btnNews.UseVisualStyleBackColor = false;
            this.btnNews.Click += new System.EventHandler(this.btnNews_Click);
            // 
            // btnMinors
            // 
            this.btnMinors.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMinors.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinors.Location = new System.Drawing.Point(207, 60);
            this.btnMinors.Name = "btnMinors";
            this.btnMinors.Size = new System.Drawing.Size(95, 46);
            this.btnMinors.TabIndex = 35;
            this.btnMinors.Text = "Minors";
            this.btnMinors.UseVisualStyleBackColor = false;
            this.btnMinors.Click += new System.EventHandler(this.btnMinors_Click);
            // 
            // btnEmployment
            // 
            this.btnEmployment.BackColor = System.Drawing.Color.Gold;
            this.btnEmployment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployment.Location = new System.Drawing.Point(308, 12);
            this.btnEmployment.Name = "btnEmployment";
            this.btnEmployment.Size = new System.Drawing.Size(95, 46);
            this.btnEmployment.TabIndex = 34;
            this.btnEmployment.Text = "Employment";
            this.btnEmployment.UseVisualStyleBackColor = false;
            this.btnEmployment.Click += new System.EventHandler(this.btnEmployment_Click);
            // 
            // btnDegrees
            // 
            this.btnDegrees.BackColor = System.Drawing.Color.Red;
            this.btnDegrees.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDegrees.Location = new System.Drawing.Point(207, 12);
            this.btnDegrees.Name = "btnDegrees";
            this.btnDegrees.Size = new System.Drawing.Size(95, 46);
            this.btnDegrees.TabIndex = 33;
            this.btnDegrees.Text = "Degrees";
            this.btnDegrees.UseVisualStyleBackColor = false;
            this.btnDegrees.Click += new System.EventHandler(this.btnDegrees_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.BackColor = System.Drawing.Color.Salmon;
            this.btnPeople.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeople.Location = new System.Drawing.Point(308, 60);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(95, 46);
            this.btnPeople.TabIndex = 32;
            this.btnPeople.Text = "People";
            this.btnPeople.UseVisualStyleBackColor = false;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnResources
            // 
            this.btnResources.BackColor = System.Drawing.Color.Orchid;
            this.btnResources.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResources.Location = new System.Drawing.Point(409, 60);
            this.btnResources.Name = "btnResources";
            this.btnResources.Size = new System.Drawing.Size(95, 46);
            this.btnResources.TabIndex = 31;
            this.btnResources.Text = "Resources";
            this.btnResources.UseVisualStyleBackColor = false;
            this.btnResources.Click += new System.EventHandler(this.btnResources_Click);
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.Chocolate;
            this.btnContact.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContact.Location = new System.Drawing.Point(342, 539);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(119, 46);
            this.btnContact.TabIndex = 39;
            this.btnContact.Text = "Contact Form";
            this.btnContact.UseVisualStyleBackColor = false;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(356, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Jason Kirshner";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(831, 597);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.btnResearch);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnNews);
            this.Controls.Add(this.btnMinors);
            this.Controls.Add(this.btnEmployment);
            this.Controls.Add(this.btnDegrees);
            this.Controls.Add(this.btnPeople);
            this.Controls.Add(this.btnResources);
            this.Controls.Add(this.rtbTweet);
            this.Controls.Add(this.lblSocialTitle);
            this.Controls.Add(this.tcAbout);
            this.Controls.Add(this.abtTitle_label);
            this.Controls.Add(this.trit_label);
            this.Controls.Add(this.is_label);
            this.Name = "Form1";
            this.Text = "About Home - Jason Kirshner";
            this.tcAbout.ResumeLayout(false);
            this.tpDesc.ResumeLayout(false);
            this.tpQuote.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label is_label;
        private System.Windows.Forms.Label trit_label;
        private System.Windows.Forms.Label abtTitle_label;
        private System.Windows.Forms.TabControl tcAbout;
        private System.Windows.Forms.TabPage tpDesc;
        private System.Windows.Forms.TabPage tpQuote;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.RichTextBox rtbQuote;
        private System.Windows.Forms.Label lblSocialTitle;
        private System.Windows.Forms.RichTextBox rtbTweet;
        private System.Windows.Forms.Button btnResearch;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnNews;
        private System.Windows.Forms.Button btnMinors;
        private System.Windows.Forms.Button btnEmployment;
        private System.Windows.Forms.Button btnDegrees;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Button btnResources;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Label label1;
    }
}

