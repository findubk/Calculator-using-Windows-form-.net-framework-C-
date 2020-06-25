using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frm_cal : Form
    {
        string operation;
        Double Value1;
        bool operationFlag = true;
        bool EvalutioFlag = true;
        public frm_cal()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, EventArgs e)
        {
            if (txtBx.Text == "0"||EvalutioFlag==false)
            {
                txtBx.Clear();
            }
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtBx.Text.Contains("."))
                {
                    txtBx.Text = txtBx.Text + button.Text;
                    operationFlag = true;
                }
            }else
            txtBx.Text = txtBx.Text + button.Text;
            operationFlag = true;
        }

        private void operator_click(object sender, EventArgs e)
        {
            if (operationFlag == true)
            {
                Button button = (Button)sender;
                operation = button.Text;
                Value1 = Double.Parse(txtBx.Text);
                lbl_history.Text = Value1 + operation;
                txtBx.Clear();
                operationFlag = false;
            }
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtBx.Text = "0";
            lbl_history.Text = "";
        }

        
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtBx.Text = "0";
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    lbl_history.Text= (Value1.ToString() + operation + txtBx.Text );
                    txtBx.Text = (Value1 + Double.Parse(txtBx.Text)).ToString();
                    EvalutioFlag = false;
                    break;
                case "-":
                    lbl_history.Text = (Value1.ToString() + operation + txtBx.Text);
                    txtBx.Text = (Value1 - Double.Parse(txtBx.Text)).ToString();
                    EvalutioFlag = false;
                    break;
                case "*":
                    lbl_history.Text = (Value1.ToString() + operation + txtBx.Text);
                    txtBx.Text = (Value1 * Double.Parse(txtBx.Text)).ToString();
                    EvalutioFlag = false;
                    break;
                case "/":
                    lbl_history.Text = (Value1.ToString() + operation + txtBx.Text);
                    txtBx.Text = (Value1 / Double.Parse(txtBx.Text)).ToString();
                    EvalutioFlag = false;
                    break;
            }
        }

      
    }
}
