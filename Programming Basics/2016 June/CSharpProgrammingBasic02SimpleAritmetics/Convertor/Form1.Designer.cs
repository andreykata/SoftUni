namespace Convertor
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
            this.Convertor = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.InputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Convertor
            // 
            this.Convertor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Convertor.Location = new System.Drawing.Point(51, 63);
            this.Convertor.Name = "Convertor";
            this.Convertor.Size = new System.Drawing.Size(183, 64);
            this.Convertor.TabIndex = 0;
            this.Convertor.Text = "Conevrt";
            this.Convertor.UseVisualStyleBackColor = true;
            this.Convertor.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputBox
            // 
            this.InputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.InputBox.Location = new System.Drawing.Point(263, 63);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(120, 55);
            this.InputBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(417, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "BGN to EUR";
            // 
            // ResultBox
            // 
            this.ResultBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultBox.Location = new System.Drawing.Point(51, 153);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(430, 55);
            this.ResultBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 500);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.Convertor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InputBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Convertor;
        private System.Windows.Forms.NumericUpDown InputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ResultBox;
    }
}

