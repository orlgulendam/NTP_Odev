namespace UÇAN_KUŞ
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
            this.yer = new System.Windows.Forms.PictureBox();
            this.sutun2 = new System.Windows.Forms.PictureBox();
            this.sutun1 = new System.Windows.Forms.PictureBox();
            this.kus = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_kontrol = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.yer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sutun2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sutun1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kus)).BeginInit();
            this.SuspendLayout();
            // 
            // yer
            // 
            this.yer.Image = global::UÇAN_KUŞ.Properties.Resources.kindpng_1153893;
            this.yer.Location = new System.Drawing.Point(0, 528);
            this.yer.Name = "yer";
            this.yer.Size = new System.Drawing.Size(806, 103);
            this.yer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yer.TabIndex = 3;
            this.yer.TabStop = false;
            // 
            // sutun2
            // 
            this.sutun2.Image = global::UÇAN_KUŞ.Properties.Resources.pipeBottom;
            this.sutun2.Location = new System.Drawing.Point(510, 380);
            this.sutun2.Name = "sutun2";
            this.sutun2.Size = new System.Drawing.Size(100, 201);
            this.sutun2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sutun2.TabIndex = 2;
            this.sutun2.TabStop = false;
            // 
            // sutun1
            // 
            this.sutun1.Image = global::UÇAN_KUŞ.Properties.Resources.pipeTop;
            this.sutun1.Location = new System.Drawing.Point(585, -41);
            this.sutun1.Name = "sutun1";
            this.sutun1.Size = new System.Drawing.Size(100, 182);
            this.sutun1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sutun1.TabIndex = 1;
            this.sutun1.TabStop = false;
            // 
            // kus
            // 
            this.kus.Image = global::UÇAN_KUŞ.Properties.Resources.flappyBird;
            this.kus.Location = new System.Drawing.Point(89, 197);
            this.kus.Name = "kus";
            this.kus.Size = new System.Drawing.Size(100, 65);
            this.kus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kus.TabIndex = 0;
            this.kus.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "SCORE:0";
            // 
            // timer_kontrol
            // 
            this.timer_kontrol.Enabled = true;
            this.timer_kontrol.Interval = 20;
            this.timer_kontrol.Tick += new System.EventHandler(this.timer_kontrol_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(726, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yer);
            this.Controls.Add(this.sutun2);
            this.Controls.Add(this.sutun1);
            this.Controls.Add(this.kus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_keydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_keyup);
            ((System.ComponentModel.ISupportInitialize)(this.yer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sutun2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sutun1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox kus;
        private System.Windows.Forms.PictureBox sutun1;
        private System.Windows.Forms.PictureBox sutun2;
        private System.Windows.Forms.PictureBox yer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_kontrol;
    }
}

