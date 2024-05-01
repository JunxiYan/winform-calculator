
namespace winformCalculator.GUI
{
    partial class Form
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonMultipy = new Button();
            buttonMinus = new Button();
            buttonPlus = new Button();
            buttonPoint = new Button();
            buttonSolution = new Button();
            textBox = new TextBox();
            buttonDelete = new Button();
            buttonDivide = new Button();
            buttonLeftparen = new Button();
            buttonRightparen = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(28, 214);
            button1.Name = "button1";
            button1.Size = new Size(100, 100);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(134, 214);
            button2.Name = "button2";
            button2.Size = new Size(100, 100);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(240, 214);
            button3.Name = "button3";
            button3.Size = new Size(100, 100);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(28, 320);
            button4.Name = "button4";
            button4.Size = new Size(100, 100);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(132, 320);
            button5.Name = "button5";
            button5.Size = new Size(100, 100);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(240, 320);
            button6.Name = "button6";
            button6.Size = new Size(100, 100);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(28, 426);
            button7.Name = "button7";
            button7.Size = new Size(100, 100);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(132, 426);
            button8.Name = "button8";
            button8.Size = new Size(100, 100);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(238, 426);
            button9.Name = "button9";
            button9.Size = new Size(100, 100);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Location = new Point(132, 532);
            button0.Name = "button0";
            button0.Size = new Size(100, 100);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonMultipy
            // 
            buttonMultipy.Location = new Point(344, 214);
            buttonMultipy.Name = "buttonMultipy";
            buttonMultipy.Size = new Size(100, 100);
            buttonMultipy.TabIndex = 10;
            buttonMultipy.Text = "x";
            buttonMultipy.UseVisualStyleBackColor = true;
            buttonMultipy.Click += buttonMultipy_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(344, 320);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(100, 100);
            buttonMinus.TabIndex = 11;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(344, 426);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(100, 100);
            buttonPlus.TabIndex = 12;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonPoint
            // 
            buttonPoint.Location = new Point(238, 532);
            buttonPoint.Name = "buttonPoint";
            buttonPoint.Size = new Size(100, 100);
            buttonPoint.TabIndex = 13;
            buttonPoint.Text = ".";
            buttonPoint.UseVisualStyleBackColor = true;
            buttonPoint.Click += buttonPoint_Click;
            // 
            // buttonSolution
            // 
            buttonSolution.Location = new Point(344, 532);
            buttonSolution.Name = "buttonSolution";
            buttonSolution.Size = new Size(100, 100);
            buttonSolution.TabIndex = 14;
            buttonSolution.Text = "=";
            buttonSolution.UseVisualStyleBackColor = true;
            buttonSolution.Click += buttonSolution_Click;
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox.Location = new Point(28, 12);
            textBox.Name = "textBox";
            textBox.RightToLeft = RightToLeft.No;
            textBox.Size = new Size(416, 30);
            textBox.TabIndex = 15;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(28, 108);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(100, 100);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Del";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(344, 108);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(100, 100);
            buttonDivide.TabIndex = 17;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // buttonLeftparen
            // 
            buttonLeftparen.Location = new Point(134, 108);
            buttonLeftparen.Name = "buttonLeftparen";
            buttonLeftparen.Size = new Size(98, 100);
            buttonLeftparen.TabIndex = 18;
            buttonLeftparen.Text = "(";
            buttonLeftparen.UseVisualStyleBackColor = true;
            buttonLeftparen.Click += buttonLeftparen_Click;
            // 
            // buttonRightparen
            // 
            buttonRightparen.Location = new Point(238, 108);
            buttonRightparen.Name = "buttonRightparen";
            buttonRightparen.Size = new Size(98, 100);
            buttonRightparen.TabIndex = 19;
            buttonRightparen.Text = ")";
            buttonRightparen.UseVisualStyleBackColor = true;
            buttonRightparen.Click += buttonRightparen_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(478, 644);
            Controls.Add(buttonRightparen);
            Controls.Add(buttonLeftparen);
            Controls.Add(buttonDivide);
            Controls.Add(buttonDelete);
            Controls.Add(textBox);
            Controls.Add(buttonSolution);
            Controls.Add(buttonPoint);
            Controls.Add(buttonPlus);
            Controls.Add(buttonMinus);
            Controls.Add(buttonMultipy);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            MinimumSize = new Size(500, 700);
            Name = "Form";
            Text = "Calcualtor";
            Load += Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonMultipy;
        private Button buttonMinus;
        private Button buttonPlus;
        private Button buttonPoint;
        private Button buttonSolution;
        private TextBox textBox;
        private Button buttonDelete;
        private Button buttonDivide;
        private Button buttonLeftparen;
        private Button buttonRightparen;
    }
}
