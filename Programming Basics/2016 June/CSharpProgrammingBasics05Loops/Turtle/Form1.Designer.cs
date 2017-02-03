namespace Turtle
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
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonHideTurtle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDraw.Location = new System.Drawing.Point(23, 26);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(151, 86);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.Location = new System.Drawing.Point(28, 139);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(145, 82);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonHideTurtle
            // 
            this.buttonHideTurtle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHideTurtle.Location = new System.Drawing.Point(34, 249);
            this.buttonHideTurtle.Name = "buttonHideTurtle";
            this.buttonHideTurtle.Size = new System.Drawing.Size(139, 87);
            this.buttonHideTurtle.TabIndex = 2;
            this.buttonHideTurtle.Text = "Hide Turtle";
            this.buttonHideTurtle.UseVisualStyleBackColor = true;
            this.buttonHideTurtle.Click += new System.EventHandler(this.buttonHideTurtle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 568);
            this.Controls.Add(this.buttonHideTurtle);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonHideTurtle;
    }
}

