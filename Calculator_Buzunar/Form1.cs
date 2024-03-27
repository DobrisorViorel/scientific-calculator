using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Buzunar
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

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 323;
            txtDisplay.Width = 277;
        }

        private void stiintificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 559;
            txtDisplay.Width = 516;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = "0";
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + num.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + num.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void Arit_Op(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    txtDisplay.Text = (results + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (results - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "x":
                    txtDisplay.Text = (results * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (results / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "%":
                    txtDisplay.Text = (results % Double.Parse(txtDisplay.Text)).ToString();
                    break;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "3,1415926535";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            double log = Double.Parse(txtDisplay.Text);
            log = Math.Log10(log);
            txtDisplay.Text = System.Convert.ToString(log);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(txtDisplay.Text);
            sq = Math.Sqrt(sq);
            txtDisplay.Text = System.Convert.ToString(sq);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            int nr = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(nr, 2);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int nr = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(nr, 16);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double sn = Double.Parse(txtDisplay.Text);
            sn = Math.Sin(sn);
            txtDisplay.Text = System.Convert.ToString(sn);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double log = Double.Parse(txtDisplay.Text);
            log = Math.Log(log);
            txtDisplay.Text = System.Convert.ToString(log);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Double nr = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(1/nr);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            int f = 1;
            int nr = int.Parse(txtDisplay.Text);
            for (int i = 1; i <= nr; i++)
                f = f * i;
            txtDisplay.Text = System.Convert.ToString(f);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text)   ;
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            int nr = int.Parse(txtDisplay.Text);
            int rez = 1;
            for (int i = 1; i <= nr; i++)
                rez = rez * 10;
            txtDisplay.Text = System.Convert.ToString(rez);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double cs = Double.Parse(txtDisplay.Text);
            cs = Math.Cos(cs);
            txtDisplay.Text = System.Convert.ToString(cs);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double tg = Double.Parse(txtDisplay.Text);
            tg = Math.Tan(tg);
            txtDisplay.Text = System.Convert.ToString(tg);
        }
    }
}
