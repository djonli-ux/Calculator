namespace calculator
{
    partial class Calculator
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
            btnSeven = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnMultiplication = new Button();
            btnSubtraction = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnAddition = new Button();
            btnThree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            btnResult = new Button();
            btnDot = new Button();
            btnZero = new Button();
            btnNegative = new Button();
            btnDivision = new Button();
            btnSqrt = new Button();
            btnExponentiation = new Button();
            btnDivRem = new Button();
            backSpace = new Button();
            btnClear = new Button();
            btnClear2 = new Button();
            btnClear3 = new Button();
            field = new RichTextBox();
            SuspendLayout();
            // 
            // btnSeven
            // 
            btnSeven.Location = new Point(1, 370);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(100, 56);
            btnSeven.TabIndex = 0;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += NumberButton_Click;
            // 
            // btnEight
            // 
            btnEight.Location = new Point(106, 370);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(100, 56);
            btnEight.TabIndex = 1;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += NumberButton_Click;
            // 
            // btnNine
            // 
            btnNine.Location = new Point(212, 370);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(100, 56);
            btnNine.TabIndex = 2;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += NumberButton_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.Location = new Point(318, 370);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(100, 56);
            btnMultiplication.TabIndex = 3;
            btnMultiplication.Text = "*";
            btnMultiplication.UseVisualStyleBackColor = true;
            btnMultiplication.Click += OperatorButton_Click;
            // 
            // btnSubtraction
            // 
            btnSubtraction.Location = new Point(318, 432);
            btnSubtraction.Name = "btnSubtraction";
            btnSubtraction.Size = new Size(100, 56);
            btnSubtraction.TabIndex = 7;
            btnSubtraction.Text = "-";
            btnSubtraction.UseVisualStyleBackColor = true;
            btnSubtraction.Click += OperatorButton_Click;
            // 
            // btnSix
            // 
            btnSix.Location = new Point(212, 432);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(100, 56);
            btnSix.TabIndex = 6;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += NumberButton_Click;
            // 
            // btnFive
            // 
            btnFive.Location = new Point(106, 432);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(100, 56);
            btnFive.TabIndex = 5;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += NumberButton_Click;
            // 
            // btnFour
            // 
            btnFour.Location = new Point(1, 432);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(100, 56);
            btnFour.TabIndex = 4;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += NumberButton_Click;
            // 
            // btnAddition
            // 
            btnAddition.Location = new Point(318, 494);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(100, 56);
            btnAddition.TabIndex = 11;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = true;
            btnAddition.Click += OperatorButton_Click;
            // 
            // btnThree
            // 
            btnThree.Location = new Point(212, 494);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(100, 56);
            btnThree.TabIndex = 10;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += NumberButton_Click;
            // 
            // btnTwo
            // 
            btnTwo.Location = new Point(106, 494);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(100, 56);
            btnTwo.TabIndex = 9;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += NumberButton_Click;
            // 
            // btnOne
            // 
            btnOne.Location = new Point(1, 494);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(100, 56);
            btnOne.TabIndex = 8;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += NumberButton_Click;
            // 
            // btnResult
            // 
            btnResult.Location = new Point(318, 556);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(100, 56);
            btnResult.TabIndex = 15;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(212, 556);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(100, 56);
            btnDot.TabIndex = 14;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(106, 556);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(100, 56);
            btnZero.TabIndex = 13;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += NumberButton_Click;
            // 
            // btnNegative
            // 
            btnNegative.Location = new Point(1, 556);
            btnNegative.Name = "btnNegative";
            btnNegative.Size = new Size(100, 56);
            btnNegative.TabIndex = 12;
            btnNegative.Text = "+/-";
            btnNegative.UseVisualStyleBackColor = true;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(318, 308);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(100, 56);
            btnDivision.TabIndex = 23;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += OperatorButton_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.Location = new Point(212, 308);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(100, 56);
            btnSqrt.TabIndex = 22;
            btnSqrt.Text = "√";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += OperatorButton_Click;
            // 
            // btnExponentiation
            // 
            btnExponentiation.Location = new Point(106, 308);
            btnExponentiation.Name = "btnExponentiation";
            btnExponentiation.Size = new Size(100, 56);
            btnExponentiation.TabIndex = 21;
            btnExponentiation.Text = "^";
            btnExponentiation.UseVisualStyleBackColor = true;
            btnExponentiation.Click += OperatorButton_Click;
            // 
            // btnDivRem
            // 
            btnDivRem.Location = new Point(1, 308);
            btnDivRem.Name = "btnDivRem";
            btnDivRem.Size = new Size(100, 56);
            btnDivRem.TabIndex = 20;
            btnDivRem.Text = "%";
            btnDivRem.UseVisualStyleBackColor = true;
            btnDivRem.Click += OperatorButton_Click;
            // 
            // backSpace
            // 
            backSpace.Location = new Point(318, 246);
            backSpace.Name = "backSpace";
            backSpace.Size = new Size(100, 56);
            backSpace.TabIndex = 19;
            backSpace.Text = "←";
            backSpace.UseVisualStyleBackColor = true;
            backSpace.Click += backSpace_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(212, 246);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 56);
            btnClear.TabIndex = 18;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClear2
            // 
            btnClear2.Location = new Point(106, 246);
            btnClear2.Name = "btnClear2";
            btnClear2.Size = new Size(100, 56);
            btnClear2.TabIndex = 17;
            btnClear2.Text = "CE";
            btnClear2.UseVisualStyleBackColor = true;
            btnClear2.Click += btnClear_Click;
            // 
            // btnClear3
            // 
            btnClear3.Location = new Point(1, 246);
            btnClear3.Name = "btnClear3";
            btnClear3.Size = new Size(100, 56);
            btnClear3.TabIndex = 16;
            btnClear3.Text = "CL";
            btnClear3.UseVisualStyleBackColor = true;
            btnClear3.Click += btnClear_Click;
            // 
            // field
            // 
            field.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            field.Location = new Point(12, 12);
            field.Name = "field";
            field.Size = new Size(397, 219);
            field.TabIndex = 24;
            field.Text = "";
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 622);
            Controls.Add(field);
            Controls.Add(btnDivision);
            Controls.Add(btnSqrt);
            Controls.Add(btnExponentiation);
            Controls.Add(btnDivRem);
            Controls.Add(backSpace);
            Controls.Add(btnClear);
            Controls.Add(btnClear2);
            Controls.Add(btnClear3);
            Controls.Add(btnResult);
            Controls.Add(btnDot);
            Controls.Add(btnZero);
            Controls.Add(btnNegative);
            Controls.Add(btnAddition);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(btnSubtraction);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnMultiplication);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Button btnMultiplication;
        private Button btnSubtraction;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnAddition;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private Button btnResult;
        private Button btnDot;
        private Button btnZero;
        private Button btnNegative;
        private Button btnDivision;
        private Button btnSqrt;
        private Button btnExponentiation;
        private Button btnDivRem;
        private Button backSpace;
        private Button btnClear;
        private Button btnClear2;
        private Button btnClear3;
        private RichTextBox field;
    }
}