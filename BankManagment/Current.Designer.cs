namespace BankManagment
{
    partial class Current
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
            this.labelCurrentAcc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNICNo = new System.Windows.Forms.Label();
            this.comboBoxPurpose = new System.Windows.Forms.ComboBox();
            this.labelPurpose = new System.Windows.Forms.Label();
            this.radioButton01 = new System.Windows.Forms.RadioButton();
            this.labelNumberOfOwners = new System.Windows.Forms.Label();
            this.radioButton0205 = new System.Windows.Forms.RadioButton();
            this.radioButton0510 = new System.Windows.Forms.RadioButton();
            this.radioButton10up = new System.Windows.Forms.RadioButton();
            this.textBoxInitialsName = new System.Windows.Forms.TextBox();
            this.textBoaxFullName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxNicBussNo = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.errorProviderIniName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNic = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxDepositAmount = new System.Windows.Forms.TextBox();
            this.labelDepositAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIniName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNic)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCurrentAcc
            // 
            this.labelCurrentAcc.AutoSize = true;
            this.labelCurrentAcc.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCurrentAcc.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentAcc.ForeColor = System.Drawing.Color.Yellow;
            this.labelCurrentAcc.Location = new System.Drawing.Point(291, 9);
            this.labelCurrentAcc.Name = "labelCurrentAcc";
            this.labelCurrentAcc.Size = new System.Drawing.Size(326, 40);
            this.labelCurrentAcc.TabIndex = 0;
            this.labelCurrentAcc.Text = "CURRENT ACCOUNT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name with initials";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.BackColor = System.Drawing.Color.Transparent;
            this.labelFullName.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.ForeColor = System.Drawing.Color.White;
            this.labelFullName.Location = new System.Drawing.Point(36, 159);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(106, 26);
            this.labelFullName.TabIndex = 2;
            this.labelFullName.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            // 
            // labelNICNo
            // 
            this.labelNICNo.AutoSize = true;
            this.labelNICNo.BackColor = System.Drawing.Color.Transparent;
            this.labelNICNo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNICNo.ForeColor = System.Drawing.Color.Transparent;
            this.labelNICNo.Location = new System.Drawing.Point(36, 265);
            this.labelNICNo.Name = "labelNICNo";
            this.labelNICNo.Size = new System.Drawing.Size(161, 52);
            this.labelNICNo.TabIndex = 4;
            this.labelNICNo.Text = "NIC No\r\nBusiness Reg No";
            // 
            // comboBoxPurpose
            // 
            this.comboBoxPurpose.BackColor = System.Drawing.Color.Navy;
            this.comboBoxPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxPurpose.ForeColor = System.Drawing.Color.White;
            this.comboBoxPurpose.FormattingEnabled = true;
            this.comboBoxPurpose.Items.AddRange(new object[] {
            "For Business",
            "For Company"});
            this.comboBoxPurpose.Location = new System.Drawing.Point(366, 345);
            this.comboBoxPurpose.Name = "comboBoxPurpose";
            this.comboBoxPurpose.Size = new System.Drawing.Size(225, 28);
            this.comboBoxPurpose.TabIndex = 5;
            // 
            // labelPurpose
            // 
            this.labelPurpose.AutoSize = true;
            this.labelPurpose.BackColor = System.Drawing.Color.Transparent;
            this.labelPurpose.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPurpose.ForeColor = System.Drawing.Color.White;
            this.labelPurpose.Location = new System.Drawing.Point(36, 340);
            this.labelPurpose.Name = "labelPurpose";
            this.labelPurpose.Size = new System.Drawing.Size(311, 26);
            this.labelPurpose.TabIndex = 6;
            this.labelPurpose.Text = "Purpose of open Current Account";
            // 
            // radioButton01
            // 
            this.radioButton01.AutoSize = true;
            this.radioButton01.BackColor = System.Drawing.Color.Transparent;
            this.radioButton01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton01.ForeColor = System.Drawing.Color.White;
            this.radioButton01.Location = new System.Drawing.Point(243, 415);
            this.radioButton01.Name = "radioButton01";
            this.radioButton01.Size = new System.Drawing.Size(41, 20);
            this.radioButton01.TabIndex = 7;
            this.radioButton01.TabStop = true;
            this.radioButton01.Text = "01";
            this.radioButton01.UseVisualStyleBackColor = false;
            // 
            // labelNumberOfOwners
            // 
            this.labelNumberOfOwners.AutoSize = true;
            this.labelNumberOfOwners.BackColor = System.Drawing.Color.Transparent;
            this.labelNumberOfOwners.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfOwners.ForeColor = System.Drawing.Color.White;
            this.labelNumberOfOwners.Location = new System.Drawing.Point(36, 409);
            this.labelNumberOfOwners.Name = "labelNumberOfOwners";
            this.labelNumberOfOwners.Size = new System.Drawing.Size(191, 26);
            this.labelNumberOfOwners.TabIndex = 8;
            this.labelNumberOfOwners.Text = "Number Of Owners";
            // 
            // radioButton0205
            // 
            this.radioButton0205.AutoSize = true;
            this.radioButton0205.BackColor = System.Drawing.Color.Transparent;
            this.radioButton0205.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton0205.ForeColor = System.Drawing.Color.White;
            this.radioButton0205.Location = new System.Drawing.Point(291, 415);
            this.radioButton0205.Name = "radioButton0205";
            this.radioButton0205.Size = new System.Drawing.Size(62, 20);
            this.radioButton0205.TabIndex = 9;
            this.radioButton0205.TabStop = true;
            this.radioButton0205.Text = "02-05";
            this.radioButton0205.UseVisualStyleBackColor = false;
            // 
            // radioButton0510
            // 
            this.radioButton0510.AutoSize = true;
            this.radioButton0510.BackColor = System.Drawing.Color.Transparent;
            this.radioButton0510.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton0510.ForeColor = System.Drawing.Color.White;
            this.radioButton0510.Location = new System.Drawing.Point(359, 415);
            this.radioButton0510.Name = "radioButton0510";
            this.radioButton0510.Size = new System.Drawing.Size(62, 20);
            this.radioButton0510.TabIndex = 10;
            this.radioButton0510.TabStop = true;
            this.radioButton0510.Text = "05-10";
            this.radioButton0510.UseVisualStyleBackColor = false;
            // 
            // radioButton10up
            // 
            this.radioButton10up.AutoSize = true;
            this.radioButton10up.BackColor = System.Drawing.Color.Transparent;
            this.radioButton10up.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton10up.ForeColor = System.Drawing.Color.White;
            this.radioButton10up.Location = new System.Drawing.Point(427, 415);
            this.radioButton10up.Name = "radioButton10up";
            this.radioButton10up.Size = new System.Drawing.Size(49, 20);
            this.radioButton10up.TabIndex = 11;
            this.radioButton10up.TabStop = true;
            this.radioButton10up.Text = "10+";
            this.radioButton10up.UseVisualStyleBackColor = false;
            // 
            // textBoxInitialsName
            // 
            this.textBoxInitialsName.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxInitialsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxInitialsName.Location = new System.Drawing.Point(243, 109);
            this.textBoxInitialsName.Name = "textBoxInitialsName";
            this.textBoxInitialsName.Size = new System.Drawing.Size(667, 29);
            this.textBoxInitialsName.TabIndex = 12;
            this.textBoxInitialsName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxInitialsName_Validating);
            // 
            // textBoaxFullName
            // 
            this.textBoaxFullName.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoaxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoaxFullName.Location = new System.Drawing.Point(243, 157);
            this.textBoaxFullName.Name = "textBoaxFullName";
            this.textBoaxFullName.Size = new System.Drawing.Size(667, 29);
            this.textBoaxFullName.TabIndex = 13;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxAddress.Location = new System.Drawing.Point(243, 204);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(667, 29);
            this.textBoxAddress.TabIndex = 14;
            // 
            // textBoxNicBussNo
            // 
            this.textBoxNicBussNo.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxNicBussNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxNicBussNo.Location = new System.Drawing.Point(243, 275);
            this.textBoxNicBussNo.Name = "textBoxNicBussNo";
            this.textBoxNicBussNo.Size = new System.Drawing.Size(243, 29);
            this.textBoxNicBussNo.TabIndex = 15;
            this.textBoxNicBussNo.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNicBussNo_Validating);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Navy;
            this.buttonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOK.Font = new System.Drawing.Font("Britannic Bold", 21.75F);
            this.buttonOK.ForeColor = System.Drawing.Color.Yellow;
            this.buttonOK.Location = new System.Drawing.Point(706, 493);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(215, 56);
            this.buttonOK.TabIndex = 16;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonback
            // 
            this.buttonback.BackColor = System.Drawing.Color.Blue;
            this.buttonback.BackgroundImage = global::BankManagment.Properties.Resources.back;
            this.buttonback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonback.Location = new System.Drawing.Point(41, 13);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(40, 40);
            this.buttonback.TabIndex = 17;
            this.buttonback.UseVisualStyleBackColor = false;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // errorProviderIniName
            // 
            this.errorProviderIniName.ContainerControl = this;
            // 
            // errorProviderNic
            // 
            this.errorProviderNic.ContainerControl = this;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.Azure;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(207, 489);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(194, 29);
            this.textBoxPassword.TabIndex = 21;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.Color.Azure;
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(207, 454);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(194, 29);
            this.textBoxUserName.TabIndex = 20;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelPassword.ForeColor = System.Drawing.Color.Transparent;
            this.labelPassword.Location = new System.Drawing.Point(36, 496);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(96, 26);
            this.labelPassword.TabIndex = 19;
            this.labelPassword.Text = "Password";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelUserName.ForeColor = System.Drawing.Color.Transparent;
            this.labelUserName.Location = new System.Drawing.Point(36, 457);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(112, 26);
            this.labelUserName.TabIndex = 18;
            this.labelUserName.Text = "User Name";
            // 
            // textBoxDepositAmount
            // 
            this.textBoxDepositAmount.BackColor = System.Drawing.Color.Azure;
            this.textBoxDepositAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDepositAmount.Location = new System.Drawing.Point(207, 528);
            this.textBoxDepositAmount.Name = "textBoxDepositAmount";
            this.textBoxDepositAmount.Size = new System.Drawing.Size(194, 29);
            this.textBoxDepositAmount.TabIndex = 23;
            // 
            // labelDepositAmount
            // 
            this.labelDepositAmount.AutoSize = true;
            this.labelDepositAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelDepositAmount.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelDepositAmount.ForeColor = System.Drawing.Color.Transparent;
            this.labelDepositAmount.Location = new System.Drawing.Point(36, 528);
            this.labelDepositAmount.Name = "labelDepositAmount";
            this.labelDepositAmount.Size = new System.Drawing.Size(161, 26);
            this.labelDepositAmount.TabIndex = 22;
            this.labelDepositAmount.Text = "Deposit Amount";
            // 
            // Current
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankManagment.Properties.Resources.BankLogin3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.textBoxDepositAmount);
            this.Controls.Add(this.labelDepositAmount);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxNicBussNo);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoaxFullName);
            this.Controls.Add(this.textBoxInitialsName);
            this.Controls.Add(this.radioButton10up);
            this.Controls.Add(this.radioButton0510);
            this.Controls.Add(this.radioButton0205);
            this.Controls.Add(this.labelNumberOfOwners);
            this.Controls.Add(this.radioButton01);
            this.Controls.Add(this.labelPurpose);
            this.Controls.Add(this.comboBoxPurpose);
            this.Controls.Add(this.labelNICNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCurrentAcc);
            this.Name = "Current";
            this.Text = "Current";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIniName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNICNo;
        private System.Windows.Forms.ComboBox comboBoxPurpose;
        private System.Windows.Forms.Label labelPurpose;
        private System.Windows.Forms.RadioButton radioButton01;
        private System.Windows.Forms.Label labelNumberOfOwners;
        private System.Windows.Forms.RadioButton radioButton0205;
        private System.Windows.Forms.RadioButton radioButton0510;
        private System.Windows.Forms.RadioButton radioButton10up;
        private System.Windows.Forms.TextBox textBoxInitialsName;
        private System.Windows.Forms.TextBox textBoaxFullName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxNicBussNo;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.ErrorProvider errorProviderIniName;
        private System.Windows.Forms.ErrorProvider errorProviderNic;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxDepositAmount;
        private System.Windows.Forms.Label labelDepositAmount;
    }
}