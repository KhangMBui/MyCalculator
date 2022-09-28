using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void btnNum_click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || (isOperationPerformed))
                txtResult.Clear();
            Button button = (Button)sender;
            txtResult.Text += button.Text;
            isOperationPerformed = false;
        }
        private void btnOperator_click(object sender, EventArgs e)
        {
            if (txtResult.Text == "" && ((Button)sender).Text == "-")
                txtResult.Text = "-";
            else if (txtResult.Text == "" && ((Button)sender).Text != "-")
            {
                txtResult.Text = "";
            }
            else
            {
                Button button = (Button)sender;
                operationPerformed = button.Text;
                resultValue = Double.Parse(txtResult.Text);
                isOperationPerformed = true;
            }
        }

        private void btnResult_click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    txtResult.Text = (resultValue + Double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (resultValue - Double.Parse(txtResult.Text)).ToString();
                    break;
                case "X":
                    txtResult.Text = (resultValue * Double.Parse(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (resultValue / Double.Parse(txtResult.Text)).ToString();
                    break;
                case "%":
                    txtResult.Text = (resultValue % Double.Parse(txtResult.Text)).ToString();
                    break;

            }
            isOperationPerformed = true;
        }

        private void btnDau_click(object sender, EventArgs e)
        {
            string newSignStr = "";
            if (txtResult.Text[0] == '-')
            {
                for (int i = 1; i < txtResult.Text.Length; i++)
                    newSignStr += txtResult.Text[i];
            }
            else
            {
                newSignStr = "-";
                for (int i = 0; i < txtResult.Text.Length; i++)
                    newSignStr += txtResult.Text[i];
            }
            txtResult.Text = newSignStr;
        }

        private void btnAC_click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }



        private void btnDot_click(object sender, EventArgs e)
        {
            txtResult.Text += ".";
        }

   
    }
}
