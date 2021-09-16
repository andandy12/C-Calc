
namespace WinFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.Display = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.ButtonDot = new System.Windows.Forms.Button();
            this.ButtonEquals = new System.Windows.Forms.Button();
            this.ButtonInvertSign = new System.Windows.Forms.Button();
            this.ButtonClearAll = new System.Windows.Forms.Button();
            this.ButtonClearOne = new System.Windows.Forms.Button();
            this.ButtonSubtraction = new System.Windows.Forms.Button();
            this.ButtonAddition = new System.Windows.Forms.Button();
            this.ButtonDivison = new System.Windows.Forms.Button();
            this.ButtonMultiplication = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LeftParenthesesButton = new System.Windows.Forms.Button();
            this.RightParenthesesButton = new System.Windows.Forms.Button();
            this.HelloWorldLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(10, 12);
            this.Display.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(312, 23);
            this.Display.TabIndex = 1;
            this.Display.TextChanged += new System.EventHandler(this.Display_textChanged);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(10, 222);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(74, 54);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(91, 222);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(74, 54);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(172, 222);
            this.Button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(74, 54);
            this.Button3.TabIndex = 4;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(10, 162);
            this.Button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(74, 54);
            this.Button4.TabIndex = 5;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(91, 162);
            this.Button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(74, 54);
            this.Button5.TabIndex = 6;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(172, 162);
            this.Button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(74, 54);
            this.Button6.TabIndex = 7;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(10, 102);
            this.Button7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(74, 54);
            this.Button7.TabIndex = 8;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(91, 102);
            this.Button8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(74, 54);
            this.Button8.TabIndex = 9;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(172, 102);
            this.Button9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(74, 54);
            this.Button9.TabIndex = 10;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // Button0
            // 
            this.Button0.Location = new System.Drawing.Point(91, 282);
            this.Button0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(74, 54);
            this.Button0.TabIndex = 11;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // ButtonDot
            // 
            this.ButtonDot.Location = new System.Drawing.Point(172, 282);
            this.ButtonDot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonDot.Name = "ButtonDot";
            this.ButtonDot.Size = new System.Drawing.Size(74, 54);
            this.ButtonDot.TabIndex = 20;
            this.ButtonDot.Text = ".";
            this.ButtonDot.UseVisualStyleBackColor = true;
            this.ButtonDot.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // ButtonEquals
            // 
            this.ButtonEquals.Location = new System.Drawing.Point(254, 282);
            this.ButtonEquals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonEquals.Name = "ButtonEquals";
            this.ButtonEquals.Size = new System.Drawing.Size(74, 54);
            this.ButtonEquals.TabIndex = 16;
            this.ButtonEquals.Text = "=";
            this.ButtonEquals.UseVisualStyleBackColor = true;
            this.ButtonEquals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // ButtonInvertSign
            // 
            this.ButtonInvertSign.Location = new System.Drawing.Point(10, 282);
            this.ButtonInvertSign.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonInvertSign.Name = "ButtonInvertSign";
            this.ButtonInvertSign.Size = new System.Drawing.Size(74, 54);
            this.ButtonInvertSign.TabIndex = 17;
            this.ButtonInvertSign.Text = "Invert";
            this.ToolTip.SetToolTip(this.ButtonInvertSign, "This looks odd but behaves weirdly");
            this.ButtonInvertSign.UseVisualStyleBackColor = true;
            this.ButtonInvertSign.Click += new System.EventHandler(this.InvertSign_Click);
            // 
            // ButtonClearAll
            // 
            this.ButtonClearAll.Location = new System.Drawing.Point(10, 42);
            this.ButtonClearAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonClearAll.Name = "ButtonClearAll";
            this.ButtonClearAll.Size = new System.Drawing.Size(74, 54);
            this.ButtonClearAll.TabIndex = 19;
            this.ButtonClearAll.Text = "Clear";
            this.ButtonClearAll.UseVisualStyleBackColor = true;
            this.ButtonClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // ButtonClearOne
            // 
            this.ButtonClearOne.Location = new System.Drawing.Point(91, 42);
            this.ButtonClearOne.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonClearOne.Name = "ButtonClearOne";
            this.ButtonClearOne.Size = new System.Drawing.Size(74, 54);
            this.ButtonClearOne.TabIndex = 18;
            this.ButtonClearOne.Text = "Back";
            this.ButtonClearOne.UseVisualStyleBackColor = true;
            this.ButtonClearOne.Click += new System.EventHandler(this.ClearOne_Click);
            // 
            // ButtonSubtraction
            // 
            this.ButtonSubtraction.Location = new System.Drawing.Point(254, 162);
            this.ButtonSubtraction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonSubtraction.Name = "ButtonSubtraction";
            this.ButtonSubtraction.Size = new System.Drawing.Size(74, 54);
            this.ButtonSubtraction.TabIndex = 12;
            this.ButtonSubtraction.Text = " - ";
            this.ButtonSubtraction.UseVisualStyleBackColor = true;
            this.ButtonSubtraction.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // ButtonAddition
            // 
            this.ButtonAddition.Location = new System.Drawing.Point(254, 222);
            this.ButtonAddition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonAddition.Name = "ButtonAddition";
            this.ButtonAddition.Size = new System.Drawing.Size(74, 54);
            this.ButtonAddition.TabIndex = 13;
            this.ButtonAddition.Text = " + ";
            this.ButtonAddition.UseVisualStyleBackColor = true;
            this.ButtonAddition.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // ButtonDivison
            // 
            this.ButtonDivison.Location = new System.Drawing.Point(254, 42);
            this.ButtonDivison.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonDivison.Name = "ButtonDivison";
            this.ButtonDivison.Size = new System.Drawing.Size(74, 54);
            this.ButtonDivison.TabIndex = 14;
            this.ButtonDivison.Text = " / ";
            this.ButtonDivison.UseVisualStyleBackColor = true;
            this.ButtonDivison.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // ButtonMultiplication
            // 
            this.ButtonMultiplication.Location = new System.Drawing.Point(254, 102);
            this.ButtonMultiplication.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonMultiplication.Name = "ButtonMultiplication";
            this.ButtonMultiplication.Size = new System.Drawing.Size(74, 54);
            this.ButtonMultiplication.TabIndex = 15;
            this.ButtonMultiplication.Text = " * ";
            this.ButtonMultiplication.UseVisualStyleBackColor = true;
            this.ButtonMultiplication.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // LeftParenthesesButton
            // 
            this.LeftParenthesesButton.Location = new System.Drawing.Point(172, 42);
            this.LeftParenthesesButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LeftParenthesesButton.Name = "LeftParenthesesButton";
            this.LeftParenthesesButton.Size = new System.Drawing.Size(35, 54);
            this.LeftParenthesesButton.TabIndex = 21;
            this.LeftParenthesesButton.Text = " ( ";
            this.LeftParenthesesButton.UseVisualStyleBackColor = true;
            this.LeftParenthesesButton.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // RightParenthesesButton
            // 
            this.RightParenthesesButton.Location = new System.Drawing.Point(211, 42);
            this.RightParenthesesButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RightParenthesesButton.Name = "RightParenthesesButton";
            this.RightParenthesesButton.Size = new System.Drawing.Size(35, 54);
            this.RightParenthesesButton.TabIndex = 22;
            this.RightParenthesesButton.Text = " ) ";
            this.RightParenthesesButton.UseVisualStyleBackColor = true;
            this.RightParenthesesButton.Click += new System.EventHandler(this.MainButtons_Click);
            // 
            // HelloWorldLabel
            // 
            this.HelloWorldLabel.AutoSize = true;
            this.HelloWorldLabel.Location = new System.Drawing.Point(12, 339);
            this.HelloWorldLabel.Name = "HelloWorldLabel";
            this.HelloWorldLabel.Size = new System.Drawing.Size(188, 15);
            this.HelloWorldLabel.TabIndex = 23;
            this.HelloWorldLabel.Text = "This was just a Hello World project";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 356);
            this.Controls.Add(this.HelloWorldLabel);
            this.Controls.Add(this.RightParenthesesButton);
            this.Controls.Add(this.LeftParenthesesButton);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button0);
            this.Controls.Add(this.ButtonDot);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.ButtonEquals);
            this.Controls.Add(this.ButtonInvertSign);
            this.Controls.Add(this.ButtonClearAll);
            this.Controls.Add(this.ButtonClearOne);
            this.Controls.Add(this.ButtonSubtraction);
            this.Controls.Add(this.ButtonAddition);
            this.Controls.Add(this.ButtonMultiplication);
            this.Controls.Add(this.ButtonDivison);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.Text = "Calculator";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button ButtonSubtraction;
        private System.Windows.Forms.Button ButtonAddition;
        private System.Windows.Forms.Button ButtonMultiplication;
        private System.Windows.Forms.Button ButtonDivison;
        private System.Windows.Forms.Button ButtonEquals;
        private System.Windows.Forms.Button ButtonInvertSign;
        private System.Windows.Forms.Button ButtonClearAll;
        private System.Windows.Forms.Button ButtonClearOne;
        private System.Windows.Forms.Button ButtonDot;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Button LeftParenthesesButton;
        private System.Windows.Forms.Button RightParenthesesButton;
        private System.Windows.Forms.Label HelloWorldLabel;
    }
}

