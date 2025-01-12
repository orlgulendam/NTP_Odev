namespace araba
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainpanel1 = new System.Windows.Forms.Panel();
            this.lane2 = new System.Windows.Forms.PictureBox();
            this.lane1 = new System.Windows.Forms.PictureBox();
            this.araba_1 = new System.Windows.Forms.PictureBox();
            this.araba = new System.Windows.Forms.Timer(this.components);
            this.araba2 = new System.Windows.Forms.Timer(this.components);
            this.mainpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lane2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba_1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainpanel1
            // 
            this.mainpanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mainpanel1.Controls.Add(this.lane2);
            this.mainpanel1.Controls.Add(this.lane1);
            this.mainpanel1.Controls.Add(this.araba_1);
            this.mainpanel1.Location = new System.Drawing.Point(0, 0);
            this.mainpanel1.Name = "mainpanel1";
            this.mainpanel1.Size = new System.Drawing.Size(301, 479);
            this.mainpanel1.TabIndex = 0;
            // 
            // lane2
            // 
            this.lane2.Image = global::araba.Properties.Resources.b;
            this.lane2.Location = new System.Drawing.Point(270, -30000);
            this.lane2.Name = "lane2";
            this.lane2.Size = new System.Drawing.Size(30, 30500);
            this.lane2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lane2.TabIndex = 3;
            this.lane2.TabStop = false;
            // 
            // lane1
            // 
            this.lane1.Image = global::araba.Properties.Resources.b;
            this.lane1.Location = new System.Drawing.Point(0, -30000);
            this.lane1.Name = "lane1";
            this.lane1.Size = new System.Drawing.Size(30, 30500);
            this.lane1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lane1.TabIndex = 2;
            this.lane1.TabStop = false;
            // 
            // araba_1
            // 
            this.araba_1.Image = global::araba.Properties.Resources.araba;
            this.araba_1.Location = new System.Drawing.Point(124, 388);
            this.araba_1.Name = "araba_1";
            this.araba_1.Size = new System.Drawing.Size(52, 60);
            this.araba_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araba_1.TabIndex = 1;
            this.araba_1.TabStop = false;
            // 
            // araba
            // 
            this.araba.Enabled = true;
            this.araba.Interval = 500;
            this.araba.Tick += new System.EventHandler(this.araba_Tick);
            // 
            // araba2
            // 
            this.araba2.Enabled = true;
            this.araba2.Tick += new System.EventHandler(this.araba2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 472);
            this.Controls.Add(this.mainpanel1);
            this.Name = "Form1";
            this.Text = "Araba";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.mainpanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lane2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainpanel1;
        private System.Windows.Forms.PictureBox araba_1;
        private System.Windows.Forms.PictureBox lane1;
        private System.Windows.Forms.PictureBox lane2;
        private System.Windows.Forms.Timer araba;
        private System.Windows.Forms.Timer araba2;
    }
}

