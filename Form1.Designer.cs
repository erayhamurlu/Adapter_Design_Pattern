namespace Adapter01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DbHataUret = new System.Windows.Forms.Button();
            this.ServiceHataUret = new System.Windows.Forms.Button();
            this.FaxHataUret = new System.Windows.Forms.Button();
            this.HataListele = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Temizle = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DbHataUret
            // 
            this.DbHataUret.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DbHataUret.Location = new System.Drawing.Point(38, 305);
            this.DbHataUret.Name = "DbHataUret";
            this.DbHataUret.Size = new System.Drawing.Size(92, 55);
            this.DbHataUret.TabIndex = 0;
            this.DbHataUret.Text = "DB Hata Uret";
            this.DbHataUret.UseVisualStyleBackColor = true;
            this.DbHataUret.Click += new System.EventHandler(this.DbHataUret_Click);
            // 
            // ServiceHataUret
            // 
            this.ServiceHataUret.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceHataUret.Location = new System.Drawing.Point(136, 305);
            this.ServiceHataUret.Name = "ServiceHataUret";
            this.ServiceHataUret.Size = new System.Drawing.Size(115, 55);
            this.ServiceHataUret.TabIndex = 1;
            this.ServiceHataUret.Text = "Service Hata Uret";
            this.ServiceHataUret.UseVisualStyleBackColor = true;
            this.ServiceHataUret.Click += new System.EventHandler(this.ServiceHataUret_Click);
            // 
            // FaxHataUret
            // 
            this.FaxHataUret.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FaxHataUret.Location = new System.Drawing.Point(257, 305);
            this.FaxHataUret.Name = "FaxHataUret";
            this.FaxHataUret.Size = new System.Drawing.Size(106, 55);
            this.FaxHataUret.TabIndex = 2;
            this.FaxHataUret.Text = "Fax Hata Uret";
            this.FaxHataUret.UseVisualStyleBackColor = true;
            this.FaxHataUret.Click += new System.EventHandler(this.FaxHataUret_Click);
            // 
            // HataListele
            // 
            this.HataListele.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HataListele.Location = new System.Drawing.Point(502, 305);
            this.HataListele.Name = "HataListele";
            this.HataListele.Size = new System.Drawing.Size(124, 55);
            this.HataListele.TabIndex = 3;
            this.HataListele.Text = "Hata Listele";
            this.HataListele.UseVisualStyleBackColor = true;
            this.HataListele.Click += new System.EventHandler(this.HataListele_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(38, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(588, 264);
            this.listBox1.TabIndex = 4;
            // 
            // Temizle
            // 
            this.Temizle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temizle.Location = new System.Drawing.Point(502, 379);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(124, 55);
            this.Temizle.TabIndex = 5;
            this.Temizle.Text = "Temizle";
            this.Temizle.UseVisualStyleBackColor = true;
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.Location = new System.Drawing.Point(632, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(32, 33);
            this.Exit.TabIndex = 6;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 446);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Temizle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.HataListele);
            this.Controls.Add(this.FaxHataUret);
            this.Controls.Add(this.ServiceHataUret);
            this.Controls.Add(this.DbHataUret);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DbHataUret;
        private System.Windows.Forms.Button ServiceHataUret;
        private System.Windows.Forms.Button FaxHataUret;
        private System.Windows.Forms.Button HataListele;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Temizle;
        private System.Windows.Forms.Button Exit;
    }
}

