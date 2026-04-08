namespace 個人房貸試算器
{
    partial class frmMortgage
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtLoanTerm = new System.Windows.Forms.TextBox();
            this.txtGracePeriod = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblGracePeriod = new System.Windows.Forms.Label();
            this.lblLoanTerm = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblDownPayment = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.txtTotalRepayment = new System.Windows.Forms.TextBox();
            this.lblTotalRepayment = new System.Windows.Forms.Label();
            this.txtTotalInterest = new System.Windows.Forms.TextBox();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.lblFirst = new System.Windows.Forms.Label();
            this.txtMonthlyPayment = new System.Windows.Forms.TextBox();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.txtTotalLoan = new System.Windows.Forms.TextBox();
            this.lblTotalLoan = new System.Windows.Forms.Label();
            this.lblNTdollar1 = new System.Windows.Forms.Label();
            this.lblPercent1 = new System.Windows.Forms.Label();
            this.lblYear1 = new System.Windows.Forms.Label();
            this.lblYear2 = new System.Windows.Forms.Label();
            this.lblPercent2 = new System.Windows.Forms.Label();
            this.lblNTdollar2 = new System.Windows.Forms.Label();
            this.lblNTdollar3 = new System.Windows.Forms.Label();
            this.lblNTdollar4 = new System.Windows.Forms.Label();
            this.lblNTdollar5 = new System.Windows.Forms.Label();
            this.lblNTdollar6 = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.BackColor = System.Drawing.Color.AntiqueWhite;
            this.grpInput.Controls.Add(this.lblPercent2);
            this.grpInput.Controls.Add(this.lblYear2);
            this.grpInput.Controls.Add(this.lblYear1);
            this.grpInput.Controls.Add(this.lblPercent1);
            this.grpInput.Controls.Add(this.lblNTdollar1);
            this.grpInput.Controls.Add(this.btnCalculate);
            this.grpInput.Controls.Add(this.txtRate);
            this.grpInput.Controls.Add(this.txtLoanTerm);
            this.grpInput.Controls.Add(this.txtGracePeriod);
            this.grpInput.Controls.Add(this.txtDownPayment);
            this.grpInput.Controls.Add(this.txtTotalPrice);
            this.grpInput.Controls.Add(this.lblGracePeriod);
            this.grpInput.Controls.Add(this.lblLoanTerm);
            this.grpInput.Controls.Add(this.lblRate);
            this.grpInput.Controls.Add(this.lblDownPayment);
            this.grpInput.Controls.Add(this.lblTotalPrice);
            this.grpInput.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpInput.Location = new System.Drawing.Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(511, 441);
            this.grpInput.TabIndex = 3;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "輸入";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(368, 259);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(87, 83);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "計算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(32, 196);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(210, 34);
            this.txtRate.TabIndex = 2;
            // 
            // txtLoanTerm
            // 
            this.txtLoanTerm.Location = new System.Drawing.Point(32, 268);
            this.txtLoanTerm.Name = "txtLoanTerm";
            this.txtLoanTerm.Size = new System.Drawing.Size(210, 34);
            this.txtLoanTerm.TabIndex = 3;
            // 
            // txtGracePeriod
            // 
            this.txtGracePeriod.Location = new System.Drawing.Point(32, 345);
            this.txtGracePeriod.Name = "txtGracePeriod";
            this.txtGracePeriod.Size = new System.Drawing.Size(210, 34);
            this.txtGracePeriod.TabIndex = 4;
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(32, 134);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(210, 34);
            this.txtDownPayment.TabIndex = 1;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(32, 65);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(210, 34);
            this.txtTotalPrice.TabIndex = 0;
            // 
            // lblGracePeriod
            // 
            this.lblGracePeriod.AutoSize = true;
            this.lblGracePeriod.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGracePeriod.Location = new System.Drawing.Point(28, 320);
            this.lblGracePeriod.Name = "lblGracePeriod";
            this.lblGracePeriod.Size = new System.Drawing.Size(61, 22);
            this.lblGracePeriod.TabIndex = 4;
            this.lblGracePeriod.Text = "寬限期";
            // 
            // lblLoanTerm
            // 
            this.lblLoanTerm.AutoSize = true;
            this.lblLoanTerm.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLoanTerm.Location = new System.Drawing.Point(28, 243);
            this.lblLoanTerm.Name = "lblLoanTerm";
            this.lblLoanTerm.Size = new System.Drawing.Size(78, 22);
            this.lblLoanTerm.TabIndex = 3;
            this.lblLoanTerm.Text = "貸款年限";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRate.Location = new System.Drawing.Point(28, 171);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(78, 22);
            this.lblRate.TabIndex = 2;
            this.lblRate.Text = "貸款利率";
            // 
            // lblDownPayment
            // 
            this.lblDownPayment.AutoSize = true;
            this.lblDownPayment.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDownPayment.Location = new System.Drawing.Point(28, 102);
            this.lblDownPayment.Name = "lblDownPayment";
            this.lblDownPayment.Size = new System.Drawing.Size(95, 22);
            this.lblDownPayment.TabIndex = 1;
            this.lblDownPayment.Text = "自備款比例";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalPrice.Location = new System.Drawing.Point(28, 41);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(78, 22);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "房屋總價";
            // 
            // grpOutput
            // 
            this.grpOutput.BackColor = System.Drawing.Color.AntiqueWhite;
            this.grpOutput.Controls.Add(this.lblNTdollar6);
            this.grpOutput.Controls.Add(this.lblNTdollar5);
            this.grpOutput.Controls.Add(this.lblNTdollar4);
            this.grpOutput.Controls.Add(this.lblNTdollar3);
            this.grpOutput.Controls.Add(this.lblNTdollar2);
            this.grpOutput.Controls.Add(this.txtTotalRepayment);
            this.grpOutput.Controls.Add(this.lblTotalRepayment);
            this.grpOutput.Controls.Add(this.txtTotalInterest);
            this.grpOutput.Controls.Add(this.lblTotalInterest);
            this.grpOutput.Controls.Add(this.txtFirst);
            this.grpOutput.Controls.Add(this.lblFirst);
            this.grpOutput.Controls.Add(this.txtMonthlyPayment);
            this.grpOutput.Controls.Add(this.lblMonthlyPayment);
            this.grpOutput.Controls.Add(this.txtTotalLoan);
            this.grpOutput.Controls.Add(this.lblTotalLoan);
            this.grpOutput.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpOutput.Location = new System.Drawing.Point(575, 12);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(363, 441);
            this.grpOutput.TabIndex = 4;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "結果";
            // 
            // txtTotalRepayment
            // 
            this.txtTotalRepayment.Location = new System.Drawing.Point(26, 370);
            this.txtTotalRepayment.Name = "txtTotalRepayment";
            this.txtTotalRepayment.ReadOnly = true;
            this.txtTotalRepayment.Size = new System.Drawing.Size(234, 34);
            this.txtTotalRepayment.TabIndex = 10;
            // 
            // lblTotalRepayment
            // 
            this.lblTotalRepayment.AutoSize = true;
            this.lblTotalRepayment.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalRepayment.Location = new System.Drawing.Point(17, 345);
            this.lblTotalRepayment.Name = "lblTotalRepayment";
            this.lblTotalRepayment.Size = new System.Drawing.Size(95, 22);
            this.lblTotalRepayment.TabIndex = 14;
            this.lblTotalRepayment.Text = "總還款金額";
            // 
            // txtTotalInterest
            // 
            this.txtTotalInterest.Location = new System.Drawing.Point(26, 305);
            this.txtTotalInterest.Name = "txtTotalInterest";
            this.txtTotalInterest.ReadOnly = true;
            this.txtTotalInterest.Size = new System.Drawing.Size(234, 34);
            this.txtTotalInterest.TabIndex = 9;
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalInterest.Location = new System.Drawing.Point(17, 274);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(95, 22);
            this.lblTotalInterest.TabIndex = 12;
            this.lblTotalInterest.Text = "總利息支出";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(26, 227);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.ReadOnly = true;
            this.txtFirst.Size = new System.Drawing.Size(234, 34);
            this.txtFirst.TabIndex = 8;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFirst.Location = new System.Drawing.Point(17, 196);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(153, 22);
            this.lblFirst.TabIndex = 10;
            this.lblFirst.Text = "首期利息/首期本金";
            // 
            // txtMonthlyPayment
            // 
            this.txtMonthlyPayment.Location = new System.Drawing.Point(26, 148);
            this.txtMonthlyPayment.Name = "txtMonthlyPayment";
            this.txtMonthlyPayment.ReadOnly = true;
            this.txtMonthlyPayment.Size = new System.Drawing.Size(234, 34);
            this.txtMonthlyPayment.TabIndex = 7;
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMonthlyPayment.Location = new System.Drawing.Point(17, 117);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(203, 22);
            this.lblMonthlyPayment.TabIndex = 8;
            this.lblMonthlyPayment.Text = "每月應繳金額(本金+利息)";
            // 
            // txtTotalLoan
            // 
            this.txtTotalLoan.Location = new System.Drawing.Point(26, 70);
            this.txtTotalLoan.Name = "txtTotalLoan";
            this.txtTotalLoan.ReadOnly = true;
            this.txtTotalLoan.Size = new System.Drawing.Size(234, 34);
            this.txtTotalLoan.TabIndex = 6;
            // 
            // lblTotalLoan
            // 
            this.lblTotalLoan.AutoSize = true;
            this.lblTotalLoan.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalLoan.Location = new System.Drawing.Point(17, 39);
            this.lblTotalLoan.Name = "lblTotalLoan";
            this.lblTotalLoan.Size = new System.Drawing.Size(95, 22);
            this.lblTotalLoan.TabIndex = 0;
            this.lblTotalLoan.Text = "貸款總金額";
            // 
            // lblNTdollar1
            // 
            this.lblNTdollar1.AutoSize = true;
            this.lblNTdollar1.Location = new System.Drawing.Point(248, 69);
            this.lblNTdollar1.Name = "lblNTdollar1";
            this.lblNTdollar1.Size = new System.Drawing.Size(52, 25);
            this.lblNTdollar1.TabIndex = 11;
            this.lblNTdollar1.Text = "萬元";
            // 
            // lblPercent1
            // 
            this.lblPercent1.AutoSize = true;
            this.lblPercent1.Location = new System.Drawing.Point(248, 143);
            this.lblPercent1.Name = "lblPercent1";
            this.lblPercent1.Size = new System.Drawing.Size(30, 25);
            this.lblPercent1.TabIndex = 12;
            this.lblPercent1.Text = "%";
            // 
            // lblYear1
            // 
            this.lblYear1.AutoSize = true;
            this.lblYear1.Location = new System.Drawing.Point(248, 271);
            this.lblYear1.Name = "lblYear1";
            this.lblYear1.Size = new System.Drawing.Size(32, 25);
            this.lblYear1.TabIndex = 14;
            this.lblYear1.Text = "年";
            // 
            // lblYear2
            // 
            this.lblYear2.AutoSize = true;
            this.lblYear2.Location = new System.Drawing.Point(248, 354);
            this.lblYear2.Name = "lblYear2";
            this.lblYear2.Size = new System.Drawing.Size(32, 25);
            this.lblYear2.TabIndex = 15;
            this.lblYear2.Text = "年";
            // 
            // lblPercent2
            // 
            this.lblPercent2.AutoSize = true;
            this.lblPercent2.Location = new System.Drawing.Point(248, 205);
            this.lblPercent2.Name = "lblPercent2";
            this.lblPercent2.Size = new System.Drawing.Size(30, 25);
            this.lblPercent2.TabIndex = 16;
            this.lblPercent2.Text = "%";
            // 
            // lblNTdollar2
            // 
            this.lblNTdollar2.AutoSize = true;
            this.lblNTdollar2.Location = new System.Drawing.Point(265, 74);
            this.lblNTdollar2.Name = "lblNTdollar2";
            this.lblNTdollar2.Size = new System.Drawing.Size(52, 25);
            this.lblNTdollar2.TabIndex = 21;
            this.lblNTdollar2.Text = "萬元";
            // 
            // lblNTdollar3
            // 
            this.lblNTdollar3.AutoSize = true;
            this.lblNTdollar3.Location = new System.Drawing.Point(265, 151);
            this.lblNTdollar3.Name = "lblNTdollar3";
            this.lblNTdollar3.Size = new System.Drawing.Size(52, 25);
            this.lblNTdollar3.TabIndex = 22;
            this.lblNTdollar3.Text = "萬元";
            // 
            // lblNTdollar4
            // 
            this.lblNTdollar4.AutoSize = true;
            this.lblNTdollar4.Location = new System.Drawing.Point(266, 236);
            this.lblNTdollar4.Name = "lblNTdollar4";
            this.lblNTdollar4.Size = new System.Drawing.Size(52, 25);
            this.lblNTdollar4.TabIndex = 23;
            this.lblNTdollar4.Text = "萬元";
            // 
            // lblNTdollar5
            // 
            this.lblNTdollar5.AutoSize = true;
            this.lblNTdollar5.Location = new System.Drawing.Point(266, 308);
            this.lblNTdollar5.Name = "lblNTdollar5";
            this.lblNTdollar5.Size = new System.Drawing.Size(52, 25);
            this.lblNTdollar5.TabIndex = 24;
            this.lblNTdollar5.Text = "萬元";
            // 
            // lblNTdollar6
            // 
            this.lblNTdollar6.AutoSize = true;
            this.lblNTdollar6.Location = new System.Drawing.Point(265, 379);
            this.lblNTdollar6.Name = "lblNTdollar6";
            this.lblNTdollar6.Size = new System.Drawing.Size(52, 25);
            this.lblNTdollar6.TabIndex = 23;
            this.lblNTdollar6.Text = "萬元";
            // 
            // frmMortgage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(975, 528);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Name = "frmMortgage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "個人房貸試算器";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtLoanTerm;
        private System.Windows.Forms.TextBox txtGracePeriod;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblGracePeriod;
        private System.Windows.Forms.Label lblLoanTerm;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblDownPayment;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.TextBox txtTotalRepayment;
        private System.Windows.Forms.Label lblTotalRepayment;
        private System.Windows.Forms.TextBox txtTotalInterest;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.TextBox txtMonthlyPayment;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.TextBox txtTotalLoan;
        private System.Windows.Forms.Label lblTotalLoan;
        private System.Windows.Forms.Label lblPercent2;
        private System.Windows.Forms.Label lblYear2;
        private System.Windows.Forms.Label lblYear1;
        private System.Windows.Forms.Label lblPercent1;
        private System.Windows.Forms.Label lblNTdollar1;
        private System.Windows.Forms.Label lblNTdollar2;
        private System.Windows.Forms.Label lblNTdollar3;
        private System.Windows.Forms.Label lblNTdollar6;
        private System.Windows.Forms.Label lblNTdollar5;
        private System.Windows.Forms.Label lblNTdollar4;
    }
}

