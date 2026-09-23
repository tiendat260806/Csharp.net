using System;
using System.Windows.Forms;
using System.Drawing;

namespace FromCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox txtDisplay;
        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMul;
        private Button btnDiv;
        private Button btnEquals;
        private Button btnClear;

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
            components = new System.ComponentModel.Container();

            // Display
            this.txtDisplay = new TextBox();
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.TextAlign = HorizontalAlignment.Right;
            this.txtDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtDisplay.Location = new Point(12, 12);
            this.txtDisplay.Size = new Size(260, 40);

            // Number buttons 0-9
            this.btn0 = new Button();
            this.btn0.Name = "btn0";
            this.btn0.Text = "0";
            this.btn0.Size = new Size(60, 40);
            this.btn0.Location = new Point(12, 220);
            this.btn0.Click += NumberButton_Click;

            this.btn1 = new Button(); this.btn1.Name = "btn1"; this.btn1.Text = "1"; this.btn1.Size = new Size(60,40); this.btn1.Location = new Point(12,170); this.btn1.Click += NumberButton_Click;
            this.btn2 = new Button(); this.btn2.Name = "btn2"; this.btn2.Text = "2"; this.btn2.Size = new Size(60,40); this.btn2.Location = new Point(82,170); this.btn2.Click += NumberButton_Click;
            this.btn3 = new Button(); this.btn3.Name = "btn3"; this.btn3.Text = "3"; this.btn3.Size = new Size(60,40); this.btn3.Location = new Point(152,170); this.btn3.Click += NumberButton_Click;

            this.btn4 = new Button(); this.btn4.Name = "btn4"; this.btn4.Text = "4"; this.btn4.Size = new Size(60,40); this.btn4.Location = new Point(12,120); this.btn4.Click += NumberButton_Click;
            this.btn5 = new Button(); this.btn5.Name = "btn5"; this.btn5.Text = "5"; this.btn5.Size = new Size(60,40); this.btn5.Location = new Point(82,120); this.btn5.Click += NumberButton_Click;
            this.btn6 = new Button(); this.btn6.Name = "btn6"; this.btn6.Text = "6"; this.btn6.Size = new Size(60,40); this.btn6.Location = new Point(152,120); this.btn6.Click += NumberButton_Click;

            this.btn7 = new Button(); this.btn7.Name = "btn7"; this.btn7.Text = "7"; this.btn7.Size = new Size(60,40); this.btn7.Location = new Point(12,70); this.btn7.Click += NumberButton_Click;
            this.btn8 = new Button(); this.btn8.Name = "btn8"; this.btn8.Text = "8"; this.btn8.Size = new Size(60,40); this.btn8.Location = new Point(82,70); this.btn8.Click += NumberButton_Click;
            this.btn9 = new Button(); this.btn9.Name = "btn9"; this.btn9.Text = "9"; this.btn9.Size = new Size(60,40); this.btn9.Location = new Point(152,70); this.btn9.Click += NumberButton_Click;

            // Operator buttons
            this.btnPlus = new Button(); this.btnPlus.Name = "btnPlus"; this.btnPlus.Text = "+"; this.btnPlus.Size = new Size(60,40); this.btnPlus.Location = new Point(222,70); this.btnPlus.Click += OperatorButton_Click;
            this.btnMinus = new Button(); this.btnMinus.Name = "btnMinus"; this.btnMinus.Text = "-"; this.btnMinus.Size = new Size(60,40); this.btnMinus.Location = new Point(222,120); this.btnMinus.Click += OperatorButton_Click;
            this.btnMul = new Button(); this.btnMul.Name = "btnMul"; this.btnMul.Text = "*"; this.btnMul.Size = new Size(60,40); this.btnMul.Location = new Point(222,170); this.btnMul.Click += OperatorButton_Click;
            this.btnDiv = new Button(); this.btnDiv.Name = "btnDiv"; this.btnDiv.Text = "/"; this.btnDiv.Size = new Size(60,40); this.btnDiv.Location = new Point(222,220); this.btnDiv.Click += OperatorButton_Click;

            this.btnEquals = new Button(); this.btnEquals.Name = "btnEquals"; this.btnEquals.Text = "="; this.btnEquals.Size = new Size(60,40); this.btnEquals.Location = new Point(152,220); this.btnEquals.Click += EqualsButton_Click;
            this.btnClear = new Button(); this.btnClear.Name = "btnClear"; this.btnClear.Text = "C"; this.btnClear.Size = new Size(60,40); this.btnClear.Location = new Point(82,220); this.btnClear.Click += ClearButton_Click;

            // Form
            this.ClientSize = new Size(300, 280);
            this.Text = "Calculator";

            // Add controls
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnClear);

        }

        #endregion
    }
}
