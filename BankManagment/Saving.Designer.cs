namespace BankManagment
{
    partial class Saving
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saving));
            this.labelSavingAcc = new System.Windows.Forms.Label();
            this.labelNameInitials = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelNICNo = new System.Windows.Forms.Label();
            this.labelPurpose = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxInitials = new System.Windows.Forms.TextBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxNIC = new System.Windows.Forms.TextBox();
            this.buttonSavingOK = new System.Windows.Forms.Button();
            this.errorProviderIniName = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonback = new System.Windows.Forms.Button();
            this.errorProviderNIC = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxDepositAmount = new System.Windows.Forms.TextBox();
            this.labelDepositAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIniName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNIC)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSavingAcc
            // 
            this.labelSavingAcc.AutoSize = true;
            this.labelSavingAcc.BackColor = System.Drawing.Color.Transparent;
            this.labelSavingAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSavingAcc.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSavingAcc.ForeColor = System.Drawing.Color.Yellow;
            this.labelSavingAcc.Location = new System.Drawing.Point(319, 9);
            this.labelSavingAcc.Name = "labelSavingAcc";
            this.labelSavingAcc.Size = new System.Drawing.Size(292, 40);
            this.labelSavingAcc.TabIndex = 0;
            this.labelSavingAcc.Text = "SAVING ACCOUNT";
            this.labelSavingAcc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNameInitials
            // 
            this.labelNameInitials.AutoSize = true;
            this.labelNameInitials.BackColor = System.Drawing.Color.Transparent;
            this.labelNameInitials.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameInitials.ForeColor = System.Drawing.Color.White;
            this.labelNameInitials.Location = new System.Drawing.Point(13, 110);
            this.labelNameInitials.Name = "labelNameInitials";
            this.labelNameInitials.Size = new System.Drawing.Size(178, 26);
            this.labelNameInitials.TabIndex = 1;
            this.labelNameInitials.Text = "Name with initials";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.BackColor = System.Drawing.Color.Transparent;
            this.labelFullName.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.ForeColor = System.Drawing.Color.White;
            this.labelFullName.Location = new System.Drawing.Point(13, 152);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(106, 26);
            this.labelFullName.TabIndex = 2;
            this.labelFullName.Text = "Full Name";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.White;
            this.labelAddress.Location = new System.Drawing.Point(13, 202);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(85, 26);
            this.labelAddress.TabIndex = 3;
            this.labelAddress.Text = "Address";
            // 
            // labelNICNo
            // 
            this.labelNICNo.AutoSize = true;
            this.labelNICNo.BackColor = System.Drawing.Color.Transparent;
            this.labelNICNo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNICNo.ForeColor = System.Drawing.Color.White;
            this.labelNICNo.Location = new System.Drawing.Point(12, 244);
            this.labelNICNo.Name = "labelNICNo";
            this.labelNICNo.Size = new System.Drawing.Size(81, 26);
            this.labelNICNo.TabIndex = 4;
            this.labelNICNo.Text = "NIC No";
            // 
            // labelPurpose
            // 
            this.labelPurpose.AutoSize = true;
            this.labelPurpose.BackColor = System.Drawing.Color.Transparent;
            this.labelPurpose.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPurpose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelPurpose.Location = new System.Drawing.Point(13, 330);
            this.labelPurpose.Name = "labelPurpose";
            this.labelPurpose.Size = new System.Drawing.Size(176, 22);
            this.labelPurpose.TabIndex = 5;
            this.labelPurpose.Text = "Purpose of open account";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Navy;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SAVING",
            "GETTING LOAN",
            "EMARGANCY FUND"});
            this.comboBox1.Location = new System.Drawing.Point(196, 330);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // textBoxInitials
            // 
            this.textBoxInitials.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxInitials.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInitials.Location = new System.Drawing.Point(196, 107);
            this.textBoxInitials.Name = "textBoxInitials";
            this.textBoxInitials.Size = new System.Drawing.Size(667, 29);
            this.textBoxInitials.TabIndex = 7;
            this.textBoxInitials.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxInitials_Validating);
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullName.Location = new System.Drawing.Point(196, 150);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(667, 29);
            this.textBoxFullName.TabIndex = 8;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(196, 199);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(667, 29);
            this.textBoxAddress.TabIndex = 9;
            // 
            // textBoxNIC
            // 
            this.textBoxNIC.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNIC.Location = new System.Drawing.Point(196, 241);
            this.textBoxNIC.Name = "textBoxNIC";
            this.textBoxNIC.Size = new System.Drawing.Size(194, 29);
            this.textBoxNIC.TabIndex = 10;
            this.textBoxNIC.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxInitials_Validating);
            // 
            // buttonSavingOK
            // 
            this.buttonSavingOK.BackColor = System.Drawing.Color.Navy;
            this.buttonSavingOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSavingOK.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSavingOK.ForeColor = System.Drawing.Color.Yellow;
            this.buttonSavingOK.Location = new System.Drawing.Point(727, 493);
            this.buttonSavingOK.Name = "buttonSavingOK";
            this.buttonSavingOK.Size = new System.Drawing.Size(215, 56);
            this.buttonSavingOK.TabIndex = 11;
            this.buttonSavingOK.Text = "OK";
            this.buttonSavingOK.UseVisualStyleBackColor = false;
            this.buttonSavingOK.Click += new System.EventHandler(this.buttonSavingOK_Click);
            // 
            // errorProviderIniName
            // 
            this.errorProviderIniName.ContainerControl = this;
            // 
            // buttonback
            // 
            this.buttonback.BackColor = System.Drawing.Color.Blue;
            this.buttonback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonback.BackgroundImage")));
            this.buttonback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonback.ForeColor = System.Drawing.Color.Transparent;
            this.buttonback.Location = new System.Drawing.Point(17, 13);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(40, 40);
            this.buttonback.TabIndex = 12;
            this.buttonback.UseVisualStyleBackColor = false;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // errorProviderNIC
            // 
            this.errorProviderNIC.ContainerControl = this;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelUserName.ForeColor = System.Drawing.Color.Transparent;
            this.labelUserName.Location = new System.Drawing.Point(18, 446);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(112, 26);
            this.labelUserName.TabIndex = 13;
            this.labelUserName.Text = "User Name";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelPassword.ForeColor = System.Drawing.Color.Transparent;
            this.labelPassword.Location = new System.Drawing.Point(18, 486);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(96, 26);
            this.labelPassword.TabIndex = 14;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.Color.Azure;
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(196, 443);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(194, 29);
            this.textBoxUserName.TabIndex = 15;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.Azure;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(196, 483);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(194, 29);
            this.textBoxPassword.TabIndex = 16;
            // 
            // textBoxDepositAmount
            // 
            this.textBoxDepositAmount.BackColor = System.Drawing.Color.Azure;
            this.textBoxDepositAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDepositAmount.Location = new System.Drawing.Point(196, 526);
            this.textBoxDepositAmount.Name = "textBoxDepositAmount";
            this.textBoxDepositAmount.Size = new System.Drawing.Size(194, 29);
            this.textBoxDepositAmount.TabIndex = 18;
            // 
            // labelDepositAmount
            // 
            this.labelDepositAmount.AutoSize = true;
            this.labelDepositAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelDepositAmount.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelDepositAmount.ForeColor = System.Drawing.Color.Transparent;
            this.labelDepositAmount.Location = new System.Drawing.Point(18, 526);
            this.labelDepositAmount.Name = "labelDepositAmount";
            this.labelDepositAmount.Size = new System.Drawing.Size(161, 26);
            this.labelDepositAmount.TabIndex = 17;
            this.labelDepositAmount.Text = "Deposit Amount";
            // 
            // Saving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::BankManagment.Properties.Resources.BankLogin2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.textBoxDepositAmount);
            this.Controls.Add(this.labelDepositAmount);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.buttonSavingOK);
            this.Controls.Add(this.textBoxNIC);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.textBoxInitials);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelPurpose);
            this.Controls.Add(this.labelNICNo);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.labelNameInitials);
            this.Controls.Add(this.labelSavingAcc);
            this.Name = "Saving";
            this.Text = "Saving";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIniName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSavingAcc;
        private System.Windows.Forms.Label labelNameInitials;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelNICNo;
        private System.Windows.Forms.Label labelPurpose;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxInitials;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxNIC;
        private System.Windows.Forms.Button buttonSavingOK;
        private System.Windows.Forms.ErrorProvider errorProviderIniName;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.ErrorProvider errorProviderNIC;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxDepositAmount;
        private System.Windows.Forms.Label labelDepositAmount;
    }
}