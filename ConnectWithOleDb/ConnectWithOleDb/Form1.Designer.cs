namespace ConnectWithOleDb
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
            this.lbCustomers = new System.Windows.Forms.ListBox();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCustomers
            // 
            this.lbCustomers.FormattingEnabled = true;
            this.lbCustomers.Location = new System.Drawing.Point(12, 13);
            this.lbCustomers.Name = "lbCustomers";
            this.lbCustomers.Size = new System.Drawing.Size(260, 56);
            this.lbCustomers.TabIndex = 0;
            // 
            // dgvStaff
            // 
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(12, 99);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.Size = new System.Drawing.Size(260, 150);
            this.dgvStaff.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.lbCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbCustomers;
        private System.Windows.Forms.DataGridView dgvStaff;
    }
}

