namespace Courseproj
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.информацияОШифреToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зашифроватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расшифроватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxKeyword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonEncode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(259, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Шифр Виженера. Описание алгоритма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(260, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Шифрование методом Виженера производится \r\nпо формуле:\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(316, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 42);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(260, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 64);
            this.label3.TabIndex = 4;
            this.label3.Text = "где ci – символ закодированного сообщения, \r\npi – символ исходного сообщения, \r\nk" +
    "i – символ ключа, \r\nN – мощность алфавита (количество символов в алфавите).";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(581, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Далее";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(581, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(260, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(394, 80);
            this.label4.TabIndex = 7;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(264, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(406, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // информацияОШифреToolStripMenuItem
            // 
            this.информацияОШифреToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.информацияОШифреToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("информацияОШифреToolStripMenuItem.Image")));
            this.информацияОШифреToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.информацияОШифреToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.DimGray;
            this.информацияОШифреToolStripMenuItem.Name = "информацияОШифреToolStripMenuItem";
            this.информацияОШифреToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.информацияОШифреToolStripMenuItem.Text = "Информация о шифре";
            this.информацияОШифреToolStripMenuItem.Click += new System.EventHandler(this.информацияОШифреToolStripMenuItem_Click);
            // 
            // зашифроватьToolStripMenuItem
            // 
            this.зашифроватьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("зашифроватьToolStripMenuItem.Image")));
            this.зашифроватьToolStripMenuItem.Name = "зашифроватьToolStripMenuItem";
            this.зашифроватьToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.зашифроватьToolStripMenuItem.Text = "Зашифровать";
            this.зашифроватьToolStripMenuItem.Click += new System.EventHandler(this.зашифроватьToolStripMenuItem_Click);
            // 
            // расшифроватьToolStripMenuItem
            // 
            this.расшифроватьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("расшифроватьToolStripMenuItem.Image")));
            this.расшифроватьToolStripMenuItem.Name = "расшифроватьToolStripMenuItem";
            this.расшифроватьToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.расшифроватьToolStripMenuItem.Text = "Расшифровать";
            this.расшифроватьToolStripMenuItem.Click += new System.EventHandler(this.расшифроватьToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОШифреToolStripMenuItem,
            this.зашифроватьToolStripMenuItem,
            this.расшифроватьToolStripMenuItem,
            this.обАвтореToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(240, 326);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("обАвтореToolStripMenuItem.Image")));
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(0, 102);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(240, 224);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxPath
            // 
            this.textBoxPath.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPath.Location = new System.Drawing.Point(279, 79);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(382, 20);
            this.textBoxPath.TabIndex = 10;
            this.textBoxPath.Visible = false;
            this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(275, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Выберите файл для шифрования: ";
            this.label5.Visible = false;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(567, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 32);
            this.button3.TabIndex = 12;
            this.button3.Text = "Обзор..";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(275, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Укажите ключевое слово (ключ):";
            this.label6.Visible = false;
            // 
            // textBoxKeyword
            // 
            this.textBoxKeyword.Location = new System.Drawing.Point(279, 187);
            this.textBoxKeyword.MaxLength = 15;
            this.textBoxKeyword.Name = "textBoxKeyword";
            this.textBoxKeyword.Size = new System.Drawing.Size(382, 20);
            this.textBoxKeyword.TabIndex = 14;
            this.textBoxKeyword.Visible = false;
            this.textBoxKeyword.TextChanged += new System.EventHandler(this.textBoxKeyword_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(275, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Выберите файл для расшифровки:";
            this.label7.Visible = false;
            // 
            // buttonDecode
            // 
            this.buttonDecode.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecode.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDecode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDecode.Location = new System.Drawing.Point(405, 241);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(135, 33);
            this.buttonDecode.TabIndex = 17;
            this.buttonDecode.Text = "Расшифровать";
            this.buttonDecode.UseVisualStyleBackColor = false;
            this.buttonDecode.Visible = false;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(276, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "*Нужно выбрать файл.";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(276, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "*Нужно ввести ключевое слово.";
            this.label9.Visible = false;
            // 
            // buttonEncode
            // 
            this.buttonEncode.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEncode.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEncode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEncode.Location = new System.Drawing.Point(405, 241);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(135, 33);
            this.buttonEncode.TabIndex = 20;
            this.buttonEncode.Text = "Зашифровать";
            this.buttonEncode.UseVisualStyleBackColor = false;
            this.buttonEncode.Visible = false;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(699, 326);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxKeyword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "File encryption / decryption";
            this.TransparencyKey = System.Drawing.SystemColors.WindowFrame;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem информацияОШифреToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зашифроватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расшифроватьToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKeyword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonEncode;
    }
}

