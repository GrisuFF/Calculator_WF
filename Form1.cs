using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WF
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPreformed = "";
        bool isOperationPreformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDigits_click(object sender, EventArgs e)
        {
            if ((TbDisplay.Text == "0") || (isOperationPreformed))
                TbDisplay.Clear();
            Button b = sender as Button;
            TbDisplay.Text += b.Text;
            isOperationPreformed = false;
        }

        private void btnOperators_click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            resultValue = Double.Parse(TbDisplay.Text);
            operationPreformed = b.Text;
            lblCurrentOperation.Text = resultValue + " " + operationPreformed;
            isOperationPreformed = true;
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            TbDisplay.Text = "0";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TbDisplay.Text = "0";
            resultValue = 0;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            switch (operationPreformed)
            {
                case "+":
                    TbDisplay.Text = (resultValue + Double.Parse(TbDisplay.Text)).ToString();
                    break;

                case "-":
                    TbDisplay.Text = (resultValue - Double.Parse(TbDisplay.Text)).ToString();
                    break;

                case "*":
                    TbDisplay.Text = (resultValue * Double.Parse(TbDisplay.Text)).ToString();
                    break;

                case "/":
                    TbDisplay.Text = (resultValue / Double.Parse(TbDisplay.Text)).ToString();
                    break;
            }
        }
    }
}
