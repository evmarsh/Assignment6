namespace Assignment6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblAccId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.dataGridViewAccounts = new System.Windows.Forms.DataGridView();
            this.txtAccountId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAcc = new System.Windows.Forms.TabPage();
            this.tabPageOpr = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageAcc.SuspendLayout();
            this.tabPageOpr.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(383, 17);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(135, 63);
            this.btnCreateAccount.TabIndex = 0;
            this.btnCreateAccount.Text = "Create account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(383, 103);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(135, 68);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load accounts";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(563, 62);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 66);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save accounts";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(472, 33);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(135, 63);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(472, 138);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(135, 59);
            this.btnWithdraw.TabIndex = 4;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            // 
            // lblAccId
            // 
            this.lblAccId.AutoSize = true;
            this.lblAccId.Location = new System.Drawing.Point(8, 41);
            this.lblAccId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccId.Name = "lblAccId";
            this.lblAccId.Size = new System.Drawing.Size(71, 16);
            this.lblAccId.TabIndex = 5;
            this.lblAccId.Text = "AccountID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 87);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Customer name:";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(47, 57);
            this.lblDeposit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(57, 16);
            this.lblDeposit.TabIndex = 7;
            this.lblDeposit.Text = "Deposit:";
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Location = new System.Drawing.Point(47, 100);
            this.lblWithdraw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(65, 16);
            this.lblWithdraw.TabIndex = 8;
            this.lblWithdraw.Text = "Withdraw:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(8, 129);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(60, 16);
            this.lblBalance.TabIndex = 9;
            this.lblBalance.Text = "Balance:";
            // 
            // dataGridViewAccounts
            // 
            this.dataGridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccounts.Location = new System.Drawing.Point(43, 311);
            this.dataGridViewAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewAccounts.Name = "dataGridViewAccounts";
            this.dataGridViewAccounts.Size = new System.Drawing.Size(552, 207);
            this.dataGridViewAccounts.TabIndex = 10;
            // 
            // txtAccountId
            // 
            this.txtAccountId.Location = new System.Drawing.Point(127, 32);
            this.txtAccountId.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccountId.Name = "txtAccountId";
            this.txtAccountId.Size = new System.Drawing.Size(204, 22);
            this.txtAccountId.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 79);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 22);
            this.txtName.TabIndex = 12;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(152, 53);
            this.txtDeposit.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(204, 22);
            this.txtDeposit.TabIndex = 13;
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(152, 96);
            this.txtWithdraw.Margin = new System.Windows.Forms.Padding(4);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(204, 22);
            this.txtWithdraw.TabIndex = 14;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(125, 121);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(4);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(204, 22);
            this.txtBalance.TabIndex = 15;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAcc);
            this.tabControl1.Controls.Add(this.tabPageOpr);
            this.tabControl1.Location = new System.Drawing.Point(37, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(747, 266);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPageAcc
            // 
            this.tabPageAcc.Controls.Add(this.lblAccId);
            this.tabPageAcc.Controls.Add(this.txtBalance);
            this.tabPageAcc.Controls.Add(this.btnCreateAccount);
            this.tabPageAcc.Controls.Add(this.btnLoad);
            this.tabPageAcc.Controls.Add(this.btnSave);
            this.tabPageAcc.Controls.Add(this.txtName);
            this.tabPageAcc.Controls.Add(this.txtAccountId);
            this.tabPageAcc.Controls.Add(this.lblName);
            this.tabPageAcc.Controls.Add(this.lblBalance);
            this.tabPageAcc.Location = new System.Drawing.Point(4, 25);
            this.tabPageAcc.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAcc.Name = "tabPageAcc";
            this.tabPageAcc.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageAcc.Size = new System.Drawing.Size(739, 237);
            this.tabPageAcc.TabIndex = 0;
            this.tabPageAcc.Text = "Account details";
            this.tabPageAcc.UseVisualStyleBackColor = true;
            // 
            // tabPageOpr
            // 
            this.tabPageOpr.Controls.Add(this.label2);
            this.tabPageOpr.Controls.Add(this.textBox2);
            this.tabPageOpr.Controls.Add(this.textBox1);
            this.tabPageOpr.Controls.Add(this.btnDeposit);
            this.tabPageOpr.Controls.Add(this.txtWithdraw);
            this.tabPageOpr.Controls.Add(this.label1);
            this.tabPageOpr.Controls.Add(this.lblWithdraw);
            this.tabPageOpr.Controls.Add(this.btnWithdraw);
            this.tabPageOpr.Controls.Add(this.lblDeposit);
            this.tabPageOpr.Controls.Add(this.txtDeposit);
            this.tabPageOpr.Location = new System.Drawing.Point(4, 25);
            this.tabPageOpr.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageOpr.Name = "tabPageOpr";
            this.tabPageOpr.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageOpr.Size = new System.Drawing.Size(739, 237);
            this.tabPageOpr.TabIndex = 1;
            this.tabPageOpr.Text = "Operations";
            this.tabPageOpr.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 138);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(204, 22);
            this.textBox1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "AccountID:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 20);
            this.textBox2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 614);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridViewAccounts);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "BANK ACCOUNTS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageAcc.ResumeLayout(false);
            this.tabPageAcc.PerformLayout();
            this.tabPageOpr.ResumeLayout(false);
            this.tabPageOpr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblAccId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.DataGridView dataGridViewAccounts;
        private System.Windows.Forms.TextBox txtAccountId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAcc;
        private System.Windows.Forms.TabPage tabPageOpr;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

