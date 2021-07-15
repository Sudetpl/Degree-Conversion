using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double santigrad, fahrenayt;
            santigrad = Convert.ToDouble(textBox1.Text);
            fahrenayt = (santigrad * 9 / 5 + 32);//santigratı fahrenayta çevirdim
            textBox2.Text = fahrenayt +" "+"F".ToString();//fahrenayt olarak yazdırdım
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double santigrad, fahrenayt;
            fahrenayt = Convert.ToDouble(textBox1.Text);
            santigrad = ((fahrenayt-32)*5/9);//fahrenaytı santigrata çevirdim
            textBox2.Text = santigrad +" "+"C".ToString();//santigrad olarak yazdırdım
        }
    }
}
