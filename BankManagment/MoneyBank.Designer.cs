namespace BankManagment
{
    partial class MoneyBank
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
            this.labelMoneyBank = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonSavingAcc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMoneyBank
            // 
            this.labelMoneyBank.AutoSize = true;
            this.labelMoneyBank.BackColor = System.Drawing.Color.Transparent;
            this.labelMoneyBank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMoneyBank.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoneyBank.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelMoneyBank.Location = new System.Drawing.Point(274, 9);
            this.labelMoneyBank.Name = "labelMoneyBank";
            this.labelMoneyBank.Size = new System.Drawing.Size(372, 90);
            this.labelMoneyBank.TabIndex = 0;
            this.labelMoneyBank.Text = "Money Bank";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.Yellow;
            this.labelWelcome.Location = new System.Drawing.Point(329, 113);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(242, 55);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Welcome";
            // 
            // buttonSavingAcc
            // 
            this.buttonSavingAcc.BackColor = System.Drawing.Color.Navy;
            this.buttonSavingAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSavingAcc.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSavingAcc.ForeColor = System.Drawing.Color.White;
            this.buttonSavingAcc.Location = new System.Drawing.Point(12, 235);
            this.buttonSavingAcc.Name = "buttonSavingAcc";
            this.buttonSavingAcc.Size = new System.Drawing.Size(929, 57);
            this.buttonSavingAcc.TabIndex = 2;
            this.buttonSavingAcc.Text = "SAVING ACCOUNT";
            this.buttonSavingAcc.UseVisualStyleBackColor = false;
            this.buttonSavingAcc.Click += new System.EventHandler(this.buttonSavingAcc_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(14, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(927, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "CURRENT ACCOUNT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MoneyBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::BankManagment.Properties.Resources.BankLogin1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSavingAcc);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelMoneyBank);
            this.Name = "MoneyBank";
            this.Text = "Money Bank";
            this.Load += new System.EventHandler(this.FormMoneyBank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMoneyBank;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonSavingAcc;
        private System.Windows.Forms.Button button1;
    }
}

