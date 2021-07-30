
namespace JobsReport
{
    partial class FrmReport
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btZatwierdz = new System.Windows.Forms.Button();
            this.lDataDo = new System.Windows.Forms.Label();
            this.dtDataDo = new System.Windows.Forms.DateTimePicker();
            this.lDataOd = new System.Windows.Forms.Label();
            this.dtDataOd = new System.Windows.Forms.DateTimePicker();
            this.lLokal = new System.Windows.Forms.Label();
            this.cbLokal = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvJobReports = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btZatwierdz);
            this.panel1.Controls.Add(this.lDataDo);
            this.panel1.Controls.Add(this.dtDataDo);
            this.panel1.Controls.Add(this.lDataOd);
            this.panel1.Controls.Add(this.dtDataOd);
            this.panel1.Controls.Add(this.lLokal);
            this.panel1.Controls.Add(this.cbLokal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 576);
            this.panel1.TabIndex = 0;
            // 
            // btZatwierdz
            // 
            this.btZatwierdz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btZatwierdz.Location = new System.Drawing.Point(21, 523);
            this.btZatwierdz.Name = "btZatwierdz";
            this.btZatwierdz.Size = new System.Drawing.Size(124, 41);
            this.btZatwierdz.TabIndex = 6;
            this.btZatwierdz.Text = "Zatwierdź";
            this.btZatwierdz.UseVisualStyleBackColor = true;
            this.btZatwierdz.Click += new System.EventHandler(this.btZatwierdz_Click);
            // 
            // lDataDo
            // 
            this.lDataDo.AutoSize = true;
            this.lDataDo.Location = new System.Drawing.Point(21, 111);
            this.lDataDo.Name = "lDataDo";
            this.lDataDo.Size = new System.Drawing.Size(25, 15);
            this.lDataDo.TabIndex = 5;
            this.lDataDo.Text = "Do:";
            // 
            // dtDataDo
            // 
            this.dtDataDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataDo.Location = new System.Drawing.Point(65, 105);
            this.dtDataDo.Name = "dtDataDo";
            this.dtDataDo.Size = new System.Drawing.Size(209, 23);
            this.dtDataDo.TabIndex = 4;
            // 
            // lDataOd
            // 
            this.lDataOd.AutoSize = true;
            this.lDataOd.Location = new System.Drawing.Point(21, 70);
            this.lDataOd.Name = "lDataOd";
            this.lDataOd.Size = new System.Drawing.Size(26, 15);
            this.lDataOd.TabIndex = 3;
            this.lDataOd.Text = "Od:";
            // 
            // dtDataOd
            // 
            this.dtDataOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataOd.Location = new System.Drawing.Point(65, 64);
            this.dtDataOd.Name = "dtDataOd";
            this.dtDataOd.Size = new System.Drawing.Size(209, 23);
            this.dtDataOd.TabIndex = 2;
            // 
            // lLokal
            // 
            this.lLokal.AutoSize = true;
            this.lLokal.Location = new System.Drawing.Point(21, 26);
            this.lLokal.Name = "lLokal";
            this.lLokal.Size = new System.Drawing.Size(38, 15);
            this.lLokal.TabIndex = 1;
            this.lLokal.Text = "Lokal:";
            // 
            // cbLokal
            // 
            this.cbLokal.FormattingEnabled = true;
            this.cbLokal.Location = new System.Drawing.Point(65, 23);
            this.cbLokal.Name = "cbLokal";
            this.cbLokal.Size = new System.Drawing.Size(209, 23);
            this.cbLokal.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvJobReports);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(295, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 576);
            this.panel2.TabIndex = 1;
            // 
            // dgvJobReports
            // 
            this.dgvJobReports.AllowUserToAddRows = false;
            this.dgvJobReports.AllowUserToDeleteRows = false;
            this.dgvJobReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJobReports.Location = new System.Drawing.Point(0, 0);
            this.dgvJobReports.Name = "dgvJobReports";
            this.dgvJobReports.ReadOnly = true;
            this.dgvJobReports.Size = new System.Drawing.Size(774, 576);
            this.dgvJobReports.TabIndex = 0;
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmReport";
            this.Text = "Raport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lDataDo;
        private System.Windows.Forms.DateTimePicker dtDataDo;
        private System.Windows.Forms.Label lDataOd;
        private System.Windows.Forms.DateTimePicker dtDataOd;
        private System.Windows.Forms.Label lLokal;
        private System.Windows.Forms.ComboBox cbLokal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvJobReports;
        private System.Windows.Forms.Button btZatwierdz;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

