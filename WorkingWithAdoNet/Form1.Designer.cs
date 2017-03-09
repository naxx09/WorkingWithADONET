namespace WorkingWithAdoNet
{
    partial class AdoNetForm1
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
            this.lbCustomers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbCustomers
            // 
            this.lbCustomers.FormattingEnabled = true;
            this.lbCustomers.Location = new System.Drawing.Point(12, 12);
            this.lbCustomers.Name = "lbCustomers";
            this.lbCustomers.Size = new System.Drawing.Size(421, 173);
            this.lbCustomers.TabIndex = 0;
            // 
            // AdoNetForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 207);
            this.Controls.Add(this.lbCustomers);
            this.Name = "AdoNetForm1";
            this.Text = "Ado .Net Form 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbCustomers;
    }
}

