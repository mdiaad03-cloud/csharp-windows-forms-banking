namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();
        BankRepository repo = new BankRepository();
        public Form1()
        {
            InitializeComponent();






        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            
            if (bankAccountGrid.SelectedRows.Count == 1 )
            {
                BankAccount BankBalance = bankAccountGrid.SelectedRows[0].DataBoundItem as BankAccount;
                 
                    string mes= BankBalance.Withdraw(AmountNum.Value);
                    MessageBox.Show(mes);
                    RefreshGrid();
                

            }
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OwnerTxt.Text))
            {
                return;

            }
            BankAccount bankAccount = new BankAccount(OwnerTxt.Text);
            repo.Add(bankAccount);
            RefreshGrid();



        }
        private void RefreshGrid()
        {
            bankAccountGrid.DataSource = null;
            bankAccountGrid.DataSource = BankAccounts;
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if(bankAccountGrid.SelectedRows.Count==1)
            {
                BankAccount selectBankAccount= bankAccountGrid.SelectedRows[0].DataBoundItem as BankAccount;
               string meg= selectBankAccount.Deposit(AmountNum.Value);
                RefreshGrid();
                MessageBox.Show(meg);
                AmountNum .Value= 0;
            }
            
        }
    }
}
