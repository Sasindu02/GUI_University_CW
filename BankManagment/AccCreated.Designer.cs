namespace BankManagment
{
    partial class AccCreated
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
            this.labelAccountCreated = new System.Windows.Forms.Label();
            this.dataGridViewEnterData = new System.Windows.Forms.DataGridView();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelLogout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnterData)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAccountCreated
            // 
            this.labelAccountCreated.AutoSize = true;
            this.labelAccountCreated.BackColor = System.Drawing.Color.Transparent;
            this.labelAccountCreated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAccountCreated.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold);
            this.labelAccountCreated.ForeColor = System.Drawing.Color.Yellow;
            this.labelAccountCreated.Location = new System.Drawing.Point(284, 9);
            this.labelAccountCreated.Name = "labelAccountCreated";
            this.labelAccountCreated.Size = new System.Drawing.Size(321, 40);
            this.labelAccountCreated.TabIndex = 0;
            this.labelAccountCreated.Text = "Account Created";
            // 
            // dataGridViewEnterData
            // 
            this.dataGridViewEnterData.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewEnterData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnterData.Location = new System.Drawing.Point(13, 114);
            this.dataGridViewEnterData.Name = "dataGridViewEnterData";
            this.dataGridViewEnterData.Size = new System.Drawing.Size(929, 293);
            this.dataGridViewEnterData.TabIndex = 1;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogout.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Aqua;
            this.buttonLogout.Location = new System.Drawing.Point(633, 511);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(144, 38);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Click here";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelLogout
            // 
            this.labelLogout.AutoSize = true;
            this.labelLogout.BackColor = System.Drawing.Color.Transparent;
            this.labelLogout.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLogout.Location = new System.Drawing.Point(774, 518);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(115, 24);
            this.labelLogout.TabIndex = 3;
            this.labelLogout.Text = "for logout";
            // 
            // AccCreated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankManagment.Properties.Resources.BankLogin4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.labelLogout);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.dataGridViewEnterData);
            this.Controls.Add(this.labelAccountCreated);
            this.Name = "AccCreated";
            this.Text = "AccCreated";
            this.Load += new System.EventHandler(this.AccCreated_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnterData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAccountCreated;
        private System.Windows.Forms.DataGridView dataGridViewEnterData;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelLogout;
    }
}