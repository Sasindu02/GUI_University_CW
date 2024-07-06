namespace BankManagment
{
    partial class Customer
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
            this.labelCustomerProfile = new System.Windows.Forms.Label();
            this.labelHello = new System.Windows.Forms.Label();
            this.labelAccBalance = new System.Windows.Forms.Label();
            this.labelTransferAmount = new System.Windows.Forms.Label();
            this.labelDepositAmount = new System.Windows.Forms.Label();
            this.textBoxAccBalance = new System.Windows.Forms.TextBox();
            this.textBoxDepositAmount = new System.Windows.Forms.TextBox();
            this.textBoxTransferAmount = new System.Windows.Forms.TextBox();
            this.labelDeposit = new System.Windows.Forms.Label();
            this.labelTransfer = new System.Windows.Forms.Label();
            this.labelProceed = new System.Windows.Forms.Label();
            this.buttongo = new System.Windows.Forms.Button();
            this.labelTransferAcc = new System.Windows.Forms.Label();
            this.textBoxTransferAccNo = new System.Windows.Forms.TextBox();
            this.textBoxHello = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCustomerProfile
            // 
            this.labelCustomerProfile.AutoSize = true;
            this.labelCustomerProfile.BackColor = System.Drawing.Color.Transparent;
            this.labelCustomerProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCustomerProfile.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerProfile.ForeColor = System.Drawing.Color.Yellow;
            this.labelCustomerProfile.Location = new System.Drawing.Point(304, 9);
            this.labelCustomerProfile.Name = "labelCustomerProfile";
            this.labelCustomerProfile.Size = new System.Drawing.Size(336, 40);
            this.labelCustomerProfile.TabIndex = 1;
            this.labelCustomerProfile.Text = "CUSTOMER PROFILE";
            this.labelCustomerProfile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.BackColor = System.Drawing.Color.Transparent;
            this.labelHello.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHello.ForeColor = System.Drawing.Color.LightYellow;
            this.labelHello.Location = new System.Drawing.Point(343, 87);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(65, 33);
            this.labelHello.TabIndex = 2;
            this.labelHello.Text = "Hello";
            // 
            // labelAccBalance
            // 
            this.labelAccBalance.AutoSize = true;
            this.labelAccBalance.BackColor = System.Drawing.Color.Transparent;
            this.labelAccBalance.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccBalance.ForeColor = System.Drawing.Color.White;
            this.labelAccBalance.Location = new System.Drawing.Point(209, 132);
            this.labelAccBalance.Name = "labelAccBalance";
            this.labelAccBalance.Size = new System.Drawing.Size(199, 20);
            this.labelAccBalance.TabIndex = 4;
            this.labelAccBalance.Text = "Your Account Balance";
            // 
            // labelTransferAmount
            // 
            this.labelTransferAmount.AutoSize = true;
            this.labelTransferAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelTransferAmount.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransferAmount.ForeColor = System.Drawing.Color.White;
            this.labelTransferAmount.Location = new System.Drawing.Point(640, 318);
            this.labelTransferAmount.Name = "labelTransferAmount";
            this.labelTransferAmount.Size = new System.Drawing.Size(184, 23);
            this.labelTransferAmount.TabIndex = 5;
            this.labelTransferAmount.Text = "Transfer Amount";
            // 
            // labelDepositAmount
            // 
            this.labelDepositAmount.AutoSize = true;
            this.labelDepositAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelDepositAmount.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepositAmount.ForeColor = System.Drawing.Color.White;
            this.labelDepositAmount.Location = new System.Drawing.Point(65, 318);
            this.labelDepositAmount.Name = "labelDepositAmount";
            this.labelDepositAmount.Size = new System.Drawing.Size(176, 23);
            this.labelDepositAmount.TabIndex = 6;
            this.labelDepositAmount.Text = "Deposit Amount";
            // 
            // textBoxAccBalance
            // 
            this.textBoxAccBalance.BackColor = System.Drawing.Color.Navy;
            this.textBoxAccBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAccBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxAccBalance.Location = new System.Drawing.Point(432, 130);
            this.textBoxAccBalance.Name = "textBoxAccBalance";
            this.textBoxAccBalance.Size = new System.Drawing.Size(184, 22);
            this.textBoxAccBalance.TabIndex = 7;
            // 
            // textBoxDepositAmount
            // 
            this.textBoxDepositAmount.BackColor = System.Drawing.Color.Navy;
            this.textBoxDepositAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDepositAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxDepositAmount.Location = new System.Drawing.Point(58, 354);
            this.textBoxDepositAmount.Name = "textBoxDepositAmount";
            this.textBoxDepositAmount.Size = new System.Drawing.Size(193, 22);
            this.textBoxDepositAmount.TabIndex = 8;
            this.textBoxDepositAmount.TextChanged += new System.EventHandler(this.textBoxDepositAmount_TextChanged);
            // 
            // textBoxTransferAmount
            // 
            this.textBoxTransferAmount.BackColor = System.Drawing.Color.Navy;
            this.textBoxTransferAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTransferAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxTransferAmount.Location = new System.Drawing.Point(640, 354);
            this.textBoxTransferAmount.Name = "textBoxTransferAmount";
            this.textBoxTransferAmount.Size = new System.Drawing.Size(184, 22);
            this.textBoxTransferAmount.TabIndex = 9;
            // 
            // labelDeposit
            // 
            this.labelDeposit.AutoSize = true;
            this.labelDeposit.BackColor = System.Drawing.Color.Transparent;
            this.labelDeposit.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeposit.ForeColor = System.Drawing.Color.Yellow;
            this.labelDeposit.Location = new System.Drawing.Point(112, 262);
            this.labelDeposit.Name = "labelDeposit";
            this.labelDeposit.Size = new System.Drawing.Size(84, 33);
            this.labelDeposit.TabIndex = 10;
            this.labelDeposit.Text = "Deposit";
            // 
            // labelTransfer
            // 
            this.labelTransfer.AutoSize = true;
            this.labelTransfer.BackColor = System.Drawing.Color.Transparent;
            this.labelTransfer.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransfer.ForeColor = System.Drawing.Color.Yellow;
            this.labelTransfer.Location = new System.Drawing.Point(684, 262);
            this.labelTransfer.Name = "labelTransfer";
            this.labelTransfer.Size = new System.Drawing.Size(93, 33);
            this.labelTransfer.TabIndex = 11;
            this.labelTransfer.Text = "Transfer";
            // 
            // labelProceed
            // 
            this.labelProceed.AutoSize = true;
            this.labelProceed.BackColor = System.Drawing.Color.Transparent;
            this.labelProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProceed.Location = new System.Drawing.Point(518, 513);
            this.labelProceed.Name = "labelProceed";
            this.labelProceed.Size = new System.Drawing.Size(287, 25);
            this.labelProceed.TabIndex = 12;
            this.labelProceed.Text = "Proceed Your Transection";
            // 
            // buttongo
            // 
            this.buttongo.BackColor = System.Drawing.Color.Navy;
            this.buttongo.BackgroundImage = global::BankManagment.Properties.Resources.tick2;
            this.buttongo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttongo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttongo.ForeColor = System.Drawing.Color.Transparent;
            this.buttongo.Location = new System.Drawing.Point(811, 510);
            this.buttongo.Name = "buttongo";
            this.buttongo.Size = new System.Drawing.Size(44, 36);
            this.buttongo.TabIndex = 13;
            this.buttongo.Text = "\r\n";
            this.buttongo.UseVisualStyleBackColor = false;
            this.buttongo.Click += new System.EventHandler(this.buttongo_Click);
            // 
            // labelTransferAcc
            // 
            this.labelTransferAcc.AutoSize = true;
            this.labelTransferAcc.BackColor = System.Drawing.Color.Transparent;
            this.labelTransferAcc.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelTransferAcc.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransferAcc.ForeColor = System.Drawing.Color.White;
            this.labelTransferAcc.Location = new System.Drawing.Point(614, 402);
            this.labelTransferAcc.Name = "labelTransferAcc";
            this.labelTransferAcc.Size = new System.Drawing.Size(228, 23);
            this.labelTransferAcc.TabIndex = 14;
            this.labelTransferAcc.Text = "Transfer Acc Number";
            // 
            // textBoxTransferAccNo
            // 
            this.textBoxTransferAccNo.BackColor = System.Drawing.Color.Navy;
            this.textBoxTransferAccNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTransferAccNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxTransferAccNo.Location = new System.Drawing.Point(640, 441);
            this.textBoxTransferAccNo.Name = "textBoxTransferAccNo";
            this.textBoxTransferAccNo.Size = new System.Drawing.Size(184, 22);
            this.textBoxTransferAccNo.TabIndex = 15;
            // 
            // textBoxHello
            // 
            this.textBoxHello.BackColor = System.Drawing.Color.Navy;
            this.textBoxHello.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxHello.Location = new System.Drawing.Point(432, 87);
            this.textBoxHello.Name = "textBoxHello";
            this.textBoxHello.Size = new System.Drawing.Size(184, 22);
            this.textBoxHello.TabIndex = 16;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankManagment.Properties.Resources.BankLogin5;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.textBoxHello);
            this.Controls.Add(this.textBoxTransferAccNo);
            this.Controls.Add(this.labelTransferAcc);
            this.Controls.Add(this.buttongo);
            this.Controls.Add(this.labelProceed);
            this.Controls.Add(this.labelTransfer);
            this.Controls.Add(this.labelDeposit);
            this.Controls.Add(this.textBoxTransferAmount);
            this.Controls.Add(this.textBoxDepositAmount);
            this.Controls.Add(this.textBoxAccBalance);
            this.Controls.Add(this.labelDepositAmount);
            this.Controls.Add(this.labelTransferAmount);
            this.Controls.Add(this.labelAccBalance);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.labelCustomerProfile);
            this.Name = "Customer";
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomerProfile;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Label labelAccBalance;
        private System.Windows.Forms.Label labelTransferAmount;
        private System.Windows.Forms.Label labelDepositAmount;
        private System.Windows.Forms.TextBox textBoxAccBalance;
        private System.Windows.Forms.TextBox textBoxDepositAmount;
        private System.Windows.Forms.TextBox textBoxTransferAmount;
        private System.Windows.Forms.Label labelDeposit;
        private System.Windows.Forms.Label labelTransfer;
        private System.Windows.Forms.Label labelProceed;
        private System.Windows.Forms.Button buttongo;
        private System.Windows.Forms.Label labelTransferAcc;
        private System.Windows.Forms.TextBox textBoxTransferAccNo;
        private System.Windows.Forms.TextBox textBoxHello;
    }
}