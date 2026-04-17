namespace RecursivePowerCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int RecursivePower(int x, int n)
        {
            if (n == 0) return 1;
            return x * RecursivePower(x, n - 1);
        }

        private void btnCalculatePower_Click(object sender, EventArgs e)
        {
            int baseValue = int.Parse(txtBaseInput.Text);
            int exponentValue = int.Parse(txtExponentInput.Text);
            int result = RecursivePower(baseValue, exponentValue);
            lblPowerResult.Text = $"Result: {result}";
        }
    }
}
