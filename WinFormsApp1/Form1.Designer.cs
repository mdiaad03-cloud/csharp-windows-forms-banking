namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            bankAccountGrid = new DataGridView();
            DepositBtn = new Button();
            WithdrawBtn = new Button();
            CreateAccountBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bankAccountGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(41, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 67);
            label1.TabIndex = 0;
            label1.Text = "owner :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F);
            label2.Location = new Point(41, 374);
            label2.Name = "label2";
            label2.Size = new Size(231, 67);
            label2.TabIndex = 1;
            label2.Text = "Amount :";
            label2.Click += label2_Click;
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(223, 44);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(192, 27);
            OwnerTxt.TabIndex = 2;
            OwnerTxt.TextChanged += textBox1_TextChanged;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(267, 410);
            AmountNum.Maximum = new decimal(new int[] { 80000, 0, 0, 0 });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(148, 27);
            AmountNum.TabIndex = 3;
            // 
            // bankAccountGrid
            // 
            bankAccountGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bankAccountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bankAccountGrid.Location = new Point(421, 32);
            bankAccountGrid.Name = "bankAccountGrid";
            bankAccountGrid.RowHeadersWidth = 51;
            bankAccountGrid.Size = new Size(448, 303);
            bankAccountGrid.TabIndex = 4;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(456, 374);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(186, 43);
            DepositBtn.TabIndex = 5;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(666, 374);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(189, 43);
            WithdrawBtn.TabIndex = 6;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(223, 79);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(192, 40);
            CreateAccountBtn.TabIndex = 7;
            CreateAccountBtn.Text = "Create Account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 450);
            Controls.Add(CreateAccountBtn);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(bankAccountGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)bankAccountGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView bankAccountGrid;
        private Button DepositBtn;
        private Button WithdrawBtn;
        private Button CreateAccountBtn;
    }
}
