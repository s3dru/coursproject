using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courseproj
{
    public partial class Form1 : Form
    {
        public string isDone;
        public Form1()
        {
            InitializeComponent();
            N = characters.Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            pictureBox1.Visible = false;
            button2.Visible = true;
            label4.Visible = true;
            pictureBox2.Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            pictureBox1.Visible = true;
            button2.Visible = false;
            label4.Visible = false;
            pictureBox2.Visible = false;
        }

        private void информацияОШифреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            pictureBox1.Visible = true;
            button2.Visible = false;
            label4.Visible = false;
            pictureBox2.Visible = false;
            label5.Visible = false;
            textBoxPath.Visible = false;
            button3.Visible = false;
            label6.Visible = false;
            textBoxKeyword.Visible = false;
            buttonEncode.Visible = false;
            label7.Visible = false;
            buttonDecode.Visible = false;
        }

        private void зашифроватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            pictureBox1.Visible = false;
            button2.Visible = false;
            label4.Visible = false;
            pictureBox2.Visible = false;
            label5.Visible = true;
            textBoxPath.Visible = true;
            button3.Visible = true;
            label6.Visible = true;
            textBoxKeyword.Visible = true;
            buttonEncode.Visible = true;
            label7.Visible = false;
            buttonDecode.Visible = false;
            textBoxPath.Text = "";
            textBoxKeyword.Text = "";
        }

        public void расшифроватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            pictureBox1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
            label4.Visible = false;
            pictureBox2.Visible = false;
            label5.Visible = false;
            buttonEncode.Visible = false;
            label7.Visible = true;
            buttonDecode.Visible = true;
            textBoxPath.Visible = true;
            label6.Visible = true;
            textBoxKeyword.Visible = true;
            path = textBoxPath.Text;
            textBoxPath.Text = "";
            textBoxKeyword.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Текстовые файлы|*.txt";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = opf.FileName;
            }
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данный курсовой проект разработан студенткой 4-го курса \nгруппы ПО-411 Сотниковой Е.Д.");
        }

        private bool validate(string path, string keyword)
        {
            if (path.Length > 0)
            {
                if (keyword.Trim().Length > 0)
                    return true;
                else
                    label9.Visible = true;
            }
            else label8.Visible = true;

            return false;
        }

        private bool checkDriveFormat()
        {
            DriveInfo[] driver = DriveInfo.GetDrives();
            string p = Assembly.GetExecutingAssembly().Location;

            foreach (DriveInfo d in driver)
            {
                if (!(d.DriveFormat == "NTFS"))
                {
                    if (p.Substring(0, 3) == d.ToString())
                    {
                        MessageBox.Show("Поддерживается только файловая система NTFS!", "Ошибка", 0, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return true;
        }

        public static string path;
        //зашифровать
        private void buttonEncode_Click(object sender, EventArgs e)
        {       
            if (!(checkDriveFormat()))
                return;

            if (validate(textBoxPath.Text, textBoxKeyword.Text))
            {
                path = textBoxPath.Text;

                StreamReader sr = new StreamReader(path, Encoding.GetEncoding(1251));

                if (!(sr.ReadToEnd().Trim().Length > 0))
                {
                    FileInfo file = new FileInfo(path);
                    MessageBox.Show("Файл " + file.Name + " пуст!", "Ошибка", 0, MessageBoxIcon.Error);
                    return;
                }

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Текстовые файлы|*.txt";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    string pathToSave = save.FileName;
                    StreamWriter sw = new StreamWriter(pathToSave);

                    sr.BaseStream.Position = 0;

                    string s;
                    while (!sr.EndOfStream)
                    {
                        s = sr.ReadLine();
                        sw.WriteLine(Encode(s, textBoxKeyword.Text), Encoding.UTF8);
                    }
                    
                    MessageBox.Show("Процесс зашифровки завершен.");

                    sr.Close();
                    sw.Close();
                }
            }
        }

        //расшифровать
        private void buttonDecode_Click(object sender, EventArgs e)
        {
            if (!(checkDriveFormat()))
                return;

            path = textBoxPath.Text;
            if (validate(textBoxPath.Text, textBoxKeyword.Text)) {              

                StreamReader sr = new StreamReader(path, Encoding.UTF8);

                if (!(sr.ReadToEnd().Trim().Length > 0))
                {
                    FileInfo file = new FileInfo(path);
                    MessageBox.Show("Файл " + file.Name + " пуст!", "Ошибка", 0, MessageBoxIcon.Error);
                    return;
                }

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Текстовые файлы|*.txt";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    string pathToSave = save.FileName;
                    if (path == pathToSave)
                    {
                        MessageBox.Show("Необходимо выбрать новый файл!", "Ошибка", 0, MessageBoxIcon.Error);
                        return;
                    }
                        StreamWriter sw = new StreamWriter(pathToSave);

                    sr.BaseStream.Position = 0;

                    string s;
                    while (!sr.EndOfStream)
                    {
                        s = sr.ReadLine();
                        sw.WriteLine(Decode(s, textBoxKeyword.Text), Encoding.UTF8);
                    }

                    sr.Close();
                    sw.Close();

                    MessageBox.Show("Процесс расшифровки завершен.");
                }
            }
        }

        static char[] characters = new char[] { 'А', 'а', 'Б', 'б', 'В', 'в', 'Г', 'г', 'Д', 'д', 'Е', 'е',
                                                'Ё', 'ё', 'Ж', 'ж', 'З', 'з', 'И', 'и', 'Й', 'й', 'К', 'к',
                                                'Л', 'л', 'М', 'м', 'Н', 'н', 'О', 'о', 'П', 'п', 'Р', 'р',
                                                'С', 'с', 'Т', 'т', 'У', 'у', 'Ф', 'ф', 'Х', 'х', 'Ц', 'ц',
                                                'Ч', 'ч', 'Ш', 'ш', 'Щ', 'щ', 'ъ', 'ы', 'ь', 'Э', 'э', 'Ю', 'ю',
                                                'Я','я', ' ', ',', '.', '-', '!', '?', '1', '2', '3', '4', '5',
                                                '6', '7', '8', '9', '0', ':', 'A' , 'a', 'B', 'b', 'C', 'c',
                                                'D', 'd', 'E', 'e', 'F', 'f', 'G', 'g', 'H', 'h', 'I', 'i',
                                                'J', 'j', 'K', 'k', 'L', 'l', 'M', 'm', 'N', 'n', 'O', 'o',
                                                'P', 'p', 'Q', 'q', 'R', 'r', 'S', 's', 'T', 't', 'U', 'u',
                                                'V', 'v', 'W', 'w', 'X', 'x', 'Y', 'y', 'Z', 'z'};

        private int N;

        //зашифровать
        private string Encode(string input, string keyword)
        {
            input = input.Trim();
            keyword = keyword.Trim();

            string result = "";

            int keyword_index = 0;

            foreach (char symbol in input)
            {
                int c = (Array.IndexOf(characters, symbol) + Array.IndexOf(characters, keyword[keyword_index])) % N;

                result += characters[c];

                keyword_index++;

                if (keyword_index == keyword.Length)
                    keyword_index = 0;
            }

            return result;
        }

        //расшифровать
        private string Decode(string input, string keyword)
        {

            string result = "";

            int keyword_index = 0;

            foreach (char symbol in input)
            {
                int c = (Array.IndexOf(characters, symbol) + N - Array.IndexOf(characters, keyword[keyword_index])) % N;

                result += characters[c];

                keyword_index++;

                if (keyword_index == keyword.Length)
                    keyword_index = 0;
            }

            return result;
        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {
            label8.Visible = false;
        }

        private void textBoxKeyword_TextChanged(object sender, EventArgs e)
        {
            label9.Visible = false;
        }
    }
}
