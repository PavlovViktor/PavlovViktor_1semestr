using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pz_23
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { 
            radioButton2.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Equals("")) || (textBox2.Text.Equals("")) || (textBox3.Text.Equals("")) || (textBox4.Text.Equals("")) || (textBox5.Text.Equals("")) || (textBox6.Text.Equals("")) || (comboBox1.Text.Equals("")) || (numericUpDown1.Text.Equals("")) || (numericUpDown1.Text.Equals("0")))
            {
                label8.Visible = true;
            }
            else
            {
                MessageBox.Show(
                "Данные сохранены!",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);


                string writePath = @"..\..\obj\Debug\Страхователи.txt";

                    using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                    {
                    sw.WriteLine($"Страхователь\nФамилия: {textBox1.Text}\nИмя: {textBox2.Text}\nДата рождения: {dateTimePicker1.Text}");
                    if (radioButton1.Checked)
                    {
                        sw.WriteLine("Пол: мужской");
                    }
                    else
                    {
                        sw.WriteLine("Пол: женский");
                    }
                    sw.WriteLine($"Адрес\nГород: {textBox3.Text}\nУлица: {textBox4.Text}\nДом: {textBox5.Text}\nКвартира: {textBox6.Text}\nСтрахование\nВид страхования: {comboBox1.Text}\nСрок страхования: {numericUpDown1.Text}");
                    sw.Close();
                    }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
