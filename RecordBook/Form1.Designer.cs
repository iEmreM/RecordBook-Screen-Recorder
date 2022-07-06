
namespace RecordBook
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
            this.kaydetButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.durdurButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.acButton = new System.Windows.Forms.Button();
            this.yolTextBox = new System.Windows.Forms.TextBox();
            this.genislikNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yukseklikNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kaliteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genislikNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yukseklikNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaliteNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // kaydetButton
            // 
            this.kaydetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kaydetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kaydetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydetButton.ForeColor = System.Drawing.Color.White;
            this.kaydetButton.Location = new System.Drawing.Point(743, 348);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(102, 69);
            this.kaydetButton.TabIndex = 0;
            this.kaydetButton.Text = "Kaydet";
            this.kaydetButton.UseVisualStyleBackColor = true;
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(144, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(720, 405);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // durdurButton
            // 
            this.durdurButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.durdurButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.durdurButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.durdurButton.ForeColor = System.Drawing.Color.White;
            this.durdurButton.Location = new System.Drawing.Point(851, 348);
            this.durdurButton.Name = "durdurButton";
            this.durdurButton.Size = new System.Drawing.Size(102, 69);
            this.durdurButton.TabIndex = 2;
            this.durdurButton.Text = "Durdur";
            this.durdurButton.UseVisualStyleBackColor = true;
            this.durdurButton.Click += new System.EventHandler(this.durdurButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(738, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.label1.Size = new System.Drawing.Size(208, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kaydedilecek Konum";
            // 
            // acButton
            // 
            this.acButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.acButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acButton.ForeColor = System.Drawing.Color.White;
            this.acButton.Location = new System.Drawing.Point(1196, 57);
            this.acButton.Name = "acButton";
            this.acButton.Size = new System.Drawing.Size(75, 27);
            this.acButton.TabIndex = 4;
            this.acButton.Text = "Aç";
            this.acButton.UseVisualStyleBackColor = true;
            this.acButton.Click += new System.EventHandler(this.acButton_Click);
            // 
            // yolTextBox
            // 
            this.yolTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yolTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.yolTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yolTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yolTextBox.ForeColor = System.Drawing.Color.White;
            this.yolTextBox.Location = new System.Drawing.Point(743, 57);
            this.yolTextBox.Name = "yolTextBox";
            this.yolTextBox.Size = new System.Drawing.Size(447, 27);
            this.yolTextBox.TabIndex = 5;
            // 
            // genislikNumericUpDown
            // 
            this.genislikNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.genislikNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.genislikNumericUpDown.ForeColor = System.Drawing.Color.White;
            this.genislikNumericUpDown.Location = new System.Drawing.Point(819, 162);
            this.genislikNumericUpDown.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.genislikNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.genislikNumericUpDown.Name = "genislikNumericUpDown";
            this.genislikNumericUpDown.Size = new System.Drawing.Size(189, 22);
            this.genislikNumericUpDown.TabIndex = 6;
            this.genislikNumericUpDown.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            // 
            // yukseklikNumericUpDown
            // 
            this.yukseklikNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yukseklikNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.yukseklikNumericUpDown.ForeColor = System.Drawing.Color.White;
            this.yukseklikNumericUpDown.Location = new System.Drawing.Point(819, 193);
            this.yukseklikNumericUpDown.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.yukseklikNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yukseklikNumericUpDown.Name = "yukseklikNumericUpDown";
            this.yukseklikNumericUpDown.Size = new System.Drawing.Size(189, 22);
            this.yukseklikNumericUpDown.TabIndex = 7;
            this.yukseklikNumericUpDown.Value = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(738, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Genişlik: ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(738, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yükseklik: ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(738, 218);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 40, 10, 10);
            this.label4.Size = new System.Drawing.Size(166, 75);
            this.label4.TabIndex = 10;
            this.label4.Text = "Görüntü Kalitesi:";
            // 
            // kaliteNumericUpDown
            // 
            this.kaliteNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kaliteNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.kaliteNumericUpDown.ForeColor = System.Drawing.Color.White;
            this.kaliteNumericUpDown.Location = new System.Drawing.Point(819, 288);
            this.kaliteNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kaliteNumericUpDown.Name = "kaliteNumericUpDown";
            this.kaliteNumericUpDown.Size = new System.Drawing.Size(189, 22);
            this.kaliteNumericUpDown.TabIndex = 11;
            this.kaliteNumericUpDown.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(738, 87);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 40, 10, 10);
            this.label5.Size = new System.Drawing.Size(139, 75);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ekran Boyutu";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(738, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kalite: %";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1283, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kaliteNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yukseklikNumericUpDown);
            this.Controls.Add(this.genislikNumericUpDown);
            this.Controls.Add(this.acButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yolTextBox);
            this.Controls.Add(this.durdurButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kaydetButton);
            this.MinimumSize = new System.Drawing.Size(1301, 497);
            this.Name = "Form1";
            this.Text = "RecordBook";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genislikNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yukseklikNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaliteNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kaydetButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button durdurButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button acButton;
        private System.Windows.Forms.TextBox yolTextBox;
        private System.Windows.Forms.NumericUpDown genislikNumericUpDown;
        private System.Windows.Forms.NumericUpDown yukseklikNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown kaliteNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

