namespace Calculator
{
    public partial class FrmCalculator : Form
    {
        double result_Value = 0;
        string operationPerformed = "";
        bool isOperattionPerformed = false;
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void Numbers_click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0" || (isOperattionPerformed))
            {
                txtScreen.Clear();
            }

            isOperattionPerformed = false;

            Button btn = (Button)sender;

            if (btn.Text == ".")
            {
                if (!txtScreen.Text.Contains("."))
                {
                    txtScreen.Text += btn.Text;
                }
            }
            else
            {
                txtScreen.Text += btn.Text;
            }
        }

        private void Op_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operationPerformed = btn.Text;
            result_Value = double.Parse(txtScreen.Text);
            lblCurrntOp.Text = result_Value + " " + operationPerformed;
            isOperattionPerformed = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "0";
            result_Value = 0;
            lblCurrntOp.Text = "";
        }

        private void btnClearOP_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (operationPerformed == "+")
            {
                txtScreen.Text = (result_Value + double.Parse(txtScreen.Text)).ToString();
            }
            else if (operationPerformed == "-")
            {
                txtScreen.Text = (result_Value - double.Parse(txtScreen.Text)).ToString();
            }
            else if (operationPerformed == "x")
            {
                txtScreen.Text = (result_Value * double.Parse(txtScreen.Text)).ToString();
            }
            else
            {
                txtScreen.Text = (result_Value / double.Parse(txtScreen.Text)).ToString();
            }
        }

        private void btnDell_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text.Length > 0)
            {
                txtScreen.Text = txtScreen.Text.Remove(txtScreen.Text.Length - 1, 1);
                
            }

            if (txtScreen.Text == "")
            {
                txtScreen.Text = "0";
            }
        }
    }
}