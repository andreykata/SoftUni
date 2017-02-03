namespace Task09CurrencyConvertor
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
            this.inputBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.DecimalPlaces = 2;
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBox.Location = new System.Drawing.Point(41, 36);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(227, 45);
            this.inputBox.TabIndex = 0;
            this.inputBox.ValueChanged += new System.EventHandler(this.inputBox_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(302, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "BGN ->";
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP"});
            this.comboBoxCurrency.Location = new System.Drawing.Point(517, 37);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(190, 46);
            this.comboBoxCurrency.TabIndex = 2;
            this.comboBoxCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrency_SelectedIndexChanged);
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.Color.Lime;
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultBox.Location = new System.Drawing.Point(45, 131);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(696, 45);
            this.resultBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 224);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.comboBoxCurrency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inputBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown inputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.TextBox resultBox;
    }
}

