namespace Movie_Store
{
    public partial class Form1 : Form
    {
        private decimal subtotal;
        private decimal total;
        private decimal movies;
        const decimal SalexTaxPct = 0.09m;
        decimal salesTax;
        private decimal price = 5.0m;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Checks how many boxes are clicked and calculates subtotal, sales tax, and total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>Exits the program.</returns>
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            foreach (var item in checkedListBox1.CheckedItems)
            {
                movies += 1;
            }

            subtotal = movies * price;
            salesTax = subtotal * SalexTaxPct;
            total = subtotal + salesTax;

            txtSubtotal.Text = subtotal.ToString("c");
            txtSalesTax.Text = salesTax.ToString("c");
            txtOrderTotal.Text = total.ToString("c");
        }

        /// <summary>
        /// Closes the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Clears all the values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>Empty text boxes.</returns>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSubtotal.Text = "";
            txtSalesTax.Text = "";
            txtOrderTotal.Text = "";
        }
    }
}
