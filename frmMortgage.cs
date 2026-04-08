using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 個人房貸試算器
{
    public partial class frmMortgage : Form
    {
        public frmMortgage()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try //以防格式不符 就跳到catch
            {

                double housePrice = double.Parse(txtTotalPrice.Text);
                double downPaymentRate = double.Parse(txtDownPayment.Text);
                double annualRate = double.Parse(txtRate.Text);
                int loanYears = int.Parse(txtLoanTerm.Text);
                int graceYears = int.Parse(txtGracePeriod.Text);

                // 檢查負數
                if (housePrice < 0 || downPaymentRate < 0 || annualRate < 0 || loanYears < 0 || graceYears < 0)
                {
                    MessageBox.Show("所有數值都不能是負數喔！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 檢查百分比
                if (downPaymentRate > 100 || annualRate > 100)
                {
                    MessageBox.Show("自備款比例與利率不能超過 100%！", "數值過大", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 檢查寬限期
                if (graceYears >= loanYears)
                {
                    MessageBox.Show("寬限期必須小於貸款年限！", "邏輯錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                housePrice *= 10000; // 萬轉為元
                downPaymentRate /=100;
                annualRate /= 100;           

                // 基礎計算
                double loanAmount = housePrice * (1 - downPaymentRate); // 貸款總額
                double monthlyRate = annualRate / 12; // 月利率
                int totalMonths = loanYears * 12;   // 貸款總月數
                int graceMonths = graceYears * 12;  // 寬限期月數

                // 計算每月應繳金額
                double monthlyPayment;
                if (monthlyRate == 0)
                {
                    monthlyPayment = loanAmount / (totalMonths - graceMonths);
                }
                else
                {
                    monthlyPayment = loanAmount * (Math.Pow(1 + monthlyRate, totalMonths - graceMonths) * monthlyRate)
                                    / (Math.Pow(1 + monthlyRate, totalMonths - graceMonths) - 1);
                }

                // 計算首期利息與本金
                double firstMonthInterest = loanAmount * monthlyRate;
                double firstMonthPrincipal = (graceMonths > 0) ? 0 : (monthlyPayment - firstMonthInterest);

                // 計算總支出
                double totalInterest = (firstMonthInterest * graceMonths) + (monthlyPayment * (totalMonths - graceMonths)) - loanAmount;
                double totalRepayment = loanAmount + totalInterest;

                // 輸出
                txtTotalLoan.Text = (loanAmount / 10000).ToString("N2"); // 轉回萬元
                txtMonthlyPayment.Text = (monthlyPayment / 10000).ToString("N2");
                txtFirst.Text = $"{(firstMonthInterest):N0} / {(firstMonthPrincipal):N0}";
                txtTotalInterest.Text = (totalInterest / 10000).ToString("N2");
                txtTotalRepayment.Text = (totalRepayment / 10000).ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("請輸入正確的數字格式！");
            }
        }
    }
}
