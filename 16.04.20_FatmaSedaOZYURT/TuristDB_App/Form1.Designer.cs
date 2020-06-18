namespace TuristDB_App
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblSoru1 = new System.Windows.Forms.LinkLabel();
            this.lblSoru2 = new System.Windows.Forms.LinkLabel();
            this.llSoru9 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(800, 154);
            this.dgvData.TabIndex = 0;
            // 
            // lblSoru1
            // 
            this.lblSoru1.AutoSize = true;
            this.lblSoru1.Location = new System.Drawing.Point(12, 173);
            this.lblSoru1.Name = "lblSoru1";
            this.lblSoru1.Size = new System.Drawing.Size(181, 13);
            this.lblSoru1.TabIndex = 1;
            this.lblSoru1.TabStop = true;
            this.lblSoru1.Text = "1)\tEn çok gezilen yer/yerler neresidir?";
            this.lblSoru1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSoru1_LinkClicked);
            // 
            // lblSoru2
            // 
            this.lblSoru2.AutoSize = true;
            this.lblSoru2.Location = new System.Drawing.Point(12, 196);
            this.lblSoru2.Name = "lblSoru2";
            this.lblSoru2.Size = new System.Drawing.Size(318, 13);
            this.lblSoru2.TabIndex = 2;
            this.lblSoru2.TabStop = true;
            this.lblSoru2.Text = "2)\tAğustos ayında en çok çalışan rehber/rehberler kimdir/kimlerdir?";
            this.lblSoru2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSoru2_LinkClicked);
            // 
            // llSoru9
            // 
            this.llSoru9.AutoSize = true;
            this.llSoru9.Location = new System.Drawing.Point(12, 225);
            this.llSoru9.Name = "llSoru9";
            this.llSoru9.Size = new System.Drawing.Size(248, 13);
            this.llSoru9.TabIndex = 3;
            this.llSoru9.TabStop = true;
            this.llSoru9.Text = "9)\tLinda Callahan’ın rehberlik ettiği turistler kimlerdir?";
            this.llSoru9.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSoru9_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llSoru9);
            this.Controls.Add(this.lblSoru2);
            this.Controls.Add(this.lblSoru1);
            this.Controls.Add(this.dgvData);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.LinkLabel lblSoru1;
        private System.Windows.Forms.LinkLabel lblSoru2;
        private System.Windows.Forms.LinkLabel llSoru9;
    }
}

