using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCALC
{
    public partial class Form1 : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpFToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void standarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 254;
            txtDisplay.Width = 218;

        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 486;
            txtDisplay.Width = 445;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            lbl.Text = "";
            switch(operation)
            {
                case "+":
                    txtDisplay.Text = (results + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (results - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (results * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (results / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "Mod":
                    txtDisplay.Text = (results % Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(txtDisplay.Text);
                    double q;
                    q = (results);
                    txtDisplay.Text = Math.Exp(i * Math.Log(q * 1)).ToString();
                    break;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if ( num.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + num.Text;
            }
            else
                txtDisplay.Text = txtDisplay.Text + num.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lbl.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lbl.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length >0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            lbl.Text = System.Convert.ToString(results) + "" + operation ;

        }

        private void button40_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "3.14159265359";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            double iLog = Double.Parse(txtDisplay.Text);
            lbl.Text = System.Convert.ToString("Log" + "(" + (txtDisplay.Text) + ")");
            iLog = Math.Log10(iLog);
            txtDisplay.Text = System.Convert.ToString(iLog);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            double Sq = Double.Parse(txtDisplay.Text);
            lbl.Text = System.Convert.ToString("Log" + "(" + (txtDisplay.Text) + ")");
            Sq = Math.Sqrt(Sq);
            txtDisplay.Text = System.Convert.ToString(Sq);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            double qSinh = Double.Parse(txtDisplay.Text);
            lbl.Text = System.Convert.ToString("Sinh" + "(" + (txtDisplay.Text) + ")");
            qSinh = Math.Sinh(qSinh);
            txtDisplay.Text = System.Convert.ToString(qSinh);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            double qSin = Double.Parse(txtDisplay.Text);
            double qqSin = Math.PI * qSin / 180.0;
            lbl.Text = System.Convert.ToString("Sin" + "(" + (txtDisplay.Text) + ")");
            qqSin = Math.Sin(qqSin);
            txtDisplay.Text = System.Convert.ToString(qqSin);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            double qCosh = Double.Parse(txtDisplay.Text);
            lbl.Text = System.Convert.ToString("Cosh" + "(" + (txtDisplay.Text) + ")");
            qCosh = Math.Cosh(qCosh);
            txtDisplay.Text = System.Convert.ToString(qCosh);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            double qqCos = Double.Parse(txtDisplay.Text);
            double qCos = Math.PI * qqCos / 180.0;
            lbl.Text = System.Convert.ToString("Cos" + "(" + (txtDisplay.Text) + ")");
            qCos = Math.Cos(qCos);
            txtDisplay.Text = System.Convert.ToString(qCos);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double qTanh = Double.Parse(txtDisplay.Text);
            lbl.Text = System.Convert.ToString("Tanh" + "(" + (txtDisplay.Text) + ")");
            qTanh = Math.Tanh(qTanh);
            txtDisplay.Text = System.Convert.ToString(qTanh);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double qqTan = Double.Parse(txtDisplay.Text);
            double qTan = Math.PI * qqTan / 180.0;
            lbl.Text = System.Convert.ToString("Tan" + "(" + (txtDisplay.Text) + ")");
            qTan = Math.Tan(qTan);
            txtDisplay.Text = System.Convert.ToString(qTan);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 2);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a,16);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 8);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtDisplay.Text));
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double iLog = Double.Parse(txtDisplay.Text);
            lbl.Text = System.Convert.ToString("Log" + "(" + (txtDisplay.Text) + ")");
            iLog = Math.Log(iLog);
            txtDisplay.Text = System.Convert.ToString(iLog);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtDisplay.Text) / Convert.ToDouble(100);
            txtDisplay.Text = System.Convert.ToString(a);
        }
    }
}
