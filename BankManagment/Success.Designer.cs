namespace BankManagment
{
    partial class Success
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
            this.labelSuccess = new System.Windows.Forms.Label();
            this.textBoxAccBalance = new System.Windows.Forms.TextBox();
            this.labelAccBalance = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelHello = new System.Windows.Forms.Label();
            this.labelThank = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = true;
            this.labelSuccess.BackColor = System.Drawing.Color.Transparent;
            this.labelSuccess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSuccess.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuccess.ForeColor = System.Drawing.Color.Yellow;
            this.labelSuccess.Location = new System.Drawing.Point(222, 22);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(469, 40);
            this.labelSuccess.TabIndex = 2;
            this.labelSuccess.Text = "TRANSACTION sUCCESSFULL";
            this.labelSuccess.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxAccBalance
            // 
            this.textBoxAccBalance.BackColor = System.Drawing.Color.Navy;
            this.textBoxAccBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAccBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxAccBalance.Location = new System.Drawing.Point(472, 142);
            this.textBoxAccBalance.Name = "textBoxAccBalance";
            this.textBoxAccBalance.Size = new System.Drawing.Size(184, 22);
            this.textBoxAccBalance.TabIndex = 11;
            // 
            // labelAccBalance
            // 
            this.labelAccBalance.AutoSize = true;
            this.labelAccBalance.BackColor = System.Drawing.Color.Transparent;
            this.labelAccBalance.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccBalance.ForeColor = System.Drawing.Color.White;
            this.labelAccBalance.Location = new System.Drawing.Point(249, 144);
            this.labelAccBalance.Name = "labelAccBalance";
            this.labelAccBalance.Size = new System.Drawing.Size(199, 20);
            this.labelAccBalance.TabIndex = 10;
            this.labelAccBalance.Text = "Your Account Balance";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.Color.Navy;
            this.textBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxUserName.Location = new System.Drawing.Point(472, 104);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(184, 22);
            this.textBoxUserName.TabIndex = 9;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.BackColor = System.Drawing.Color.Transparent;
            this.labelHello.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHello.ForeColor = System.Drawing.Color.LightYellow;
            this.labelHello.Location = new System.Drawing.Point(383, 99);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(65, 33);
            this.labelHello.TabIndex = 8;
            this.labelHello.Text = "Hello";
            // 
            // labelThank
            // 
            this.labelThank.AutoSize = true;
            this.labelThank.BackColor = System.Drawing.Color.Transparent;
            this.labelThank.Font = new System.Drawing.Font("Magneto", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThank.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labelThank.Location = new System.Drawing.Point(12, 520);
            this.labelThank.Name = "labelThank";
            this.labelThank.Size = new System.Drawing.Size(937, 32);
            this.labelThank.TabIndex = 12;
            this.labelThank.Text = "Thank you for banking with MONEYBANK... Have a Nice Day";
            // 
            // Success
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankManagment.Properties.Resources.BankLogin6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.labelThank);
            this.Controls.Add(this.textBoxAccBalance);
            this.Controls.Add(this.labelAccBalance);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.labelSuccess);
            this.Name = "Success";
            this.Text = "Success";
            this.Load += new System.EventHandler(this.Success_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSuccess;
        private System.Windows.Forms.TextBox textBoxAccBalance;
        private System.Windows.Forms.Label labelAccBalance;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Label labelThank;
    }
}