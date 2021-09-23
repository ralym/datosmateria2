using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String texto = ((Button)sender).Text;
            switch (texto){   
                case "+": 
                case "-": 
                case "*": 
                case "/": label2.Text = texto; break;
                case "=":
                    double a, b;
                    if (textBox3.TextLength > 0) a = Convert.ToDouble(textBox3.Text); else a = 0;
                    if (textBox1.TextLength > 0) b = Convert.ToDouble(textBox1.Text); else b = 0;
                    double res;
                    switch (label2.Text){
                        case "+": res = a + b; break;
                        case "-": res = a - b; break;
                        case "*": res = a * b; break;
                        case "/": res = a / b; break;
                        default: res = 0; break;}
                    textBox2.Text = res.ToString(); break;
                case "C":
                    label2.Text = "OPERACION"; textBox1.Text = textBox3.Text = textBox2.Text = ""; break;
                default:
                    if (label2.Text != "OPERACION") textBox1.Text += texto; else textBox3.Text += texto; break;
            }   
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
