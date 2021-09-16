using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void MainButtons_Click(object sender, EventArgs e)
        {
            Display.Text += (sender as Button).Text;
        }

        private static Double Eval(String expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expression, String.Empty));
        }

        private void InvertSign_Click(object sender, EventArgs e)
        {
            String[] temp = Display.Text.Split(" "); Double temp2 = 0;
            try
            {
                temp2 = -Double.Parse(temp[temp.Length - 1]);
                //Display.Text = Display.Text.Substring(0, Display.Text.Length - (temp2.ToString().Length)) + temp2.ToString();/// + temp2.ToString();
                Display.Text += " + " + temp2.ToString() + " + " + temp2.ToString();// value is correct but looks weird // we cant just do temp * 2 as if you invert multiple times it fucks up
            }
            catch
            {
                Display.Text += "-";
                // we know that the last index is not a section of numbers
            }
        }
        private void ClearAll_Click(object sender, EventArgs e) {
            Display.Text = "";
        }
        private void ClearOne_Click(object sender, EventArgs e) {
            Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            try
            {
                Display.Text = Eval(Display.Text).ToString();
            }
            catch
            {
                Display.Text = "An Error Has Occured";
            }
        }

        private void Display_textChanged(object sender, EventArgs e)
        {
        }
    }
}
