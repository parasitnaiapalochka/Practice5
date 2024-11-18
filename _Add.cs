using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyForm
{
    public partial class _Add : Form
    {

        public _Add()
        {
            InitializeComponent();
        }
        private bool isnumber(string string1)
        {
            for (int i = 0; i < string1.Length; i++)
            {
                if (string1[i] <= '0' || string1[i] >= '9')
                {
                    return false;
                }
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
                if (textBox1.Text == "1")
                {
                if (textBox2.Text == "" || !isnumber(textBox3.Text) || textBox3.Text == "" || (textBox6.Text == ""))
                {
                    if (textBox2.Text == "")
                    {
                        textBox2.Text = "Введите значение";
                    }
                    if (!isnumber(textBox3.Text) || textBox3.Text == "")
                    {
                        textBox3.Text = "Введите число";
                    }
                    if (textBox6.Text == "")
                    {
                        textBox6.Text = "Введите значение";
                    }
                }
                else
                {
                    _NetworkEquip a1 = new _NetworkEquip(textBox2.Text, Convert.ToInt32(textBox3.Text),textBox6.Text);
                    Data.form3.Add_Net(a1);
                    this.Close();
                }
                }
                else if (textBox1.Text == "2" || textBox1.Text == "3")
                {
                if (textBox2.Text == "" || !isnumber(textBox3.Text) || textBox3.Text == "" || !isnumber(textBox4.Text) || textBox4.Text == "" || textBox5.Text == "")
                {
                    if (textBox2.Text == "")
                    {
                        textBox2.Text = "Введите значение";
                    }
                    if (textBox6.Text == "")
                    {
                        textBox6.Text = "Введите значение";
                    }
                    if (!isnumber(textBox3.Text) || textBox3.Text == "")
                    {
                        textBox3.Text = "Введите число";
                    }
                    if (!isnumber(textBox4.Text) || textBox4.Text == "")
                    {
                        textBox4.Text = "Введите число";
                    }
                    if (textBox5.Text == "")
                    {
                        textBox5.Text = "Введите значение";
                    }
                }
                else
                {
                    if (textBox1.Text == "2")
                    {
                        _Wifi_Router a1 = new _Wifi_Router(textBox2.Text, Convert.ToInt32(textBox3.Text), textBox6.Text,Convert.ToInt32(textBox4.Text), textBox5.Text);
                        Data.form3.Add_Wifi(a1);
                        this.Close();
                    }
                    else
                    {
                        _Switcher a1 = new _Switcher(textBox2.Text, Convert.ToInt32(textBox3.Text), textBox6.Text, Convert.ToInt32(textBox4.Text), textBox5.Text);
                        Data.form3.Add_Switch(a1);
                        this.Close();
                    }
                }
                }
                
            }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                groupBox1.Visible = true;
                textBox1.Visible = false;
                label1.Visible = false;
            }
            else if (textBox1.Text == "2")
            {
                label4.Text = "Введите функцию VPN";
                label3.Text = "Введите скорость передачи(МБит/С)\n до 200000 МБит/С";
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                textBox1.Visible = false;
                label1.Visible = false;
            }
            else if (textBox1.Text == "3")
            {
                label4.Text = "Введите размещение";
                label3.Text = "Введите количество портов(от 0 до 9)";
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                textBox1.Visible = false;
                label1.Visible = false;
            }
            else
            {
                textBox1.Text = "Введите 1,2 или 3";
            }
            
        }
    }
}
