﻿namespace txtFiletoUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblYearofBirth = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblSpecificRoleSection = new System.Windows.Forms.Label();
            this.btnLoadUserInfo = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtYearofBirth = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtSpecificRoleSection = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(90, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(67, 104);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(74, 20);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname";
            // 
            // lblYearofBirth
            // 
            this.lblYearofBirth.AutoSize = true;
            this.lblYearofBirth.Location = new System.Drawing.Point(51, 146);
            this.lblYearofBirth.Name = "lblYearofBirth";
            this.lblYearofBirth.Size = new System.Drawing.Size(90, 20);
            this.lblYearofBirth.TabIndex = 2;
            this.lblYearofBirth.Text = "YearofBirth";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(106, 187);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 20);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(81, 233);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(60, 20);
            this.lblFaculty.TabIndex = 4;
            this.lblFaculty.Text = "Faculty";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(99, 278);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(42, 20);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Role";
            // 
            // btnLoadUserInfo
            // 
            this.btnLoadUserInfo.Location = new System.Drawing.Point(16, 12);
            this.btnLoadUserInfo.Name = "btnLoadUserInfo";
            this.btnLoadUserInfo.Size = new System.Drawing.Size(274, 39);
            this.btnLoadUserInfo.TabIndex = 6;
            this.btnLoadUserInfo.Text = "Load User Information";
            this.btnLoadUserInfo.UseVisualStyleBackColor = true;
            this.btnLoadUserInfo.Click += new System.EventHandler(this.btnLoadUserInfo_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(162, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 26);
            this.txtName.TabIndex = 7;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(162, 98);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(199, 26);
            this.txtSurname.TabIndex = 8;
            // 
            // txtYearofBirth
            // 
            this.txtYearofBirth.Location = new System.Drawing.Point(162, 140);
            this.txtYearofBirth.Name = "txtYearofBirth";
            this.txtYearofBirth.Size = new System.Drawing.Size(199, 26);
            this.txtYearofBirth.TabIndex = 9;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(162, 184);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(199, 26);
            this.txtCity.TabIndex = 10;
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point(162, 227);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(199, 26);
            this.txtFaculty.TabIndex = 11;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(162, 272);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(199, 26);
            this.txtRole.TabIndex = 12;
            // 
            // Specific Role Description
            // 
            this.lblSpecificRoleSection.AutoSize = true;
            this.lblSpecificRoleSection.Location = new System.Drawing.Point(15, 314);
            this.lblSpecificRoleSection.Name = "lblSpecificRoleSection";
            this.lblSpecificRoleSection.Size = new System.Drawing.Size(126, 20);
            this.lblSpecificRoleSection.TabIndex = 13;
            this.lblSpecificRoleSection.Text = "Specific Role Section";
            // 
            // txtSpecificRoleSection
            // 
            this.txtSpecificRoleSection.Location = new System.Drawing.Point(162, 314);
            this.txtSpecificRoleSection.Name = "txtSpecificRoleSection";
            this.txtSpecificRoleSection.Size = new System.Drawing.Size(199, 26);
            this.txtSpecificRoleSection.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSpecificRoleSection);
            this.Controls.Add(this.lblSpecificRoleSection);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtFaculty);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtYearofBirth);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnLoadUserInfo);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblYearofBirth);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "User Info Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblYearofBirth;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnLoadUserInfo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtYearofBirth;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label lblSpecificRoleSection;
        private System.Windows.Forms.TextBox txtSpecificRoleSection;
    }
}

