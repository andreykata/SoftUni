using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bgn = this.InputBox.Value;
            var eur = bgn * 1.95583M;
            var str = $"{bgn:0.00} BGN = {eur:0.00} EUR";
            this.ResultBox.Text = str;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
