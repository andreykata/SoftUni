using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task09CurrencyConvertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxCurrency.SelectedIndex = 1;
        }

        private void inputBox_ValueChanged(object sender, EventArgs e)
        {
            Convert();
        }

        private void comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            Convert();
        }

        private void Convert()
        {
            var number = inputBox.Value;
            var outputCurrency = comboBoxCurrency.Text;
            var result = 0.0M;

            if (outputCurrency == "USD")
            {
                result = number / 1.80810M;
            }
            else if (outputCurrency == "EUR")
            {
                result = number / 1.95583M;
            }
            else if (outputCurrency == "GBP")
            {
                result = number / 2.54490M;
            }

            this.resultBox.Text = string.Format("{0} лв. = {1:F2} {2}", number, result, outputCurrency);
        }
    }
}
