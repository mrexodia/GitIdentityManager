namespace GitIdentityManager
{
    partial class GitIdentityManager
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
            this.listBoxIdentities = new System.Windows.Forms.ListBox();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxIdentities
            // 
            this.listBoxIdentities.FormattingEnabled = true;
            this.listBoxIdentities.Location = new System.Drawing.Point(12, 12);
            this.listBoxIdentities.Name = "listBoxIdentities";
            this.listBoxIdentities.Size = new System.Drawing.Size(373, 43);
            this.listBoxIdentities.TabIndex = 0;
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDetails.Location = new System.Drawing.Point(12, 61);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.ReadOnly = true;
            this.textBoxDetails.Size = new System.Drawing.Size(373, 66);
            this.textBoxDetails.TabIndex = 1;
            this.textBoxDetails.WordWrap = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(310, 133);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "&Save && Exit";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // GitIdentityManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 170);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxDetails);
            this.Controls.Add(this.listBoxIdentities);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GitIdentityManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitIdentityManager";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxIdentities;
        private System.Windows.Forms.TextBox textBoxDetails;
        private System.Windows.Forms.Button buttonSave;
    }
}

