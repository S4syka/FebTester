﻿namespace FebTesting
{
    partial class TrueFalseForm
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
            AnsE_btn = new Button();
            AnsTrue_btn = new Button();
            button5 = new Button();
            button4 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // AnsE_btn
            // 
            AnsE_btn.Anchor = AnchorStyles.Bottom;
            AnsE_btn.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            AnsE_btn.Location = new Point(486, 345);
            AnsE_btn.Name = "AnsE_btn";
            AnsE_btn.Size = new Size(391, 119);
            AnsE_btn.TabIndex = 23;
            AnsE_btn.Text = "False";
            AnsE_btn.UseVisualStyleBackColor = true;
            // 
            // AnsTrue_btn
            // 
            AnsTrue_btn.Anchor = AnchorStyles.Bottom;
            AnsTrue_btn.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            AnsTrue_btn.Location = new Point(13, 345);
            AnsTrue_btn.Name = "AnsTrue_btn";
            AnsTrue_btn.Size = new Size(396, 119);
            AnsTrue_btn.TabIndex = 22;
            AnsTrue_btn.Text = "True";
            AnsTrue_btn.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.ImageAlign = ContentAlignment.BottomLeft;
            button5.Location = new Point(669, 470);
            button5.Name = "button5";
            button5.Size = new Size(101, 23);
            button5.TabIndex = 18;
            button5.Text = "Closed Questions";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.ImageAlign = ContentAlignment.BottomLeft;
            button4.Location = new Point(776, 470);
            button4.Name = "button4";
            button4.Size = new Size(101, 23);
            button4.TabIndex = 17;
            button4.Text = "OpenQuestions";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(13, 10);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(864, 329);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom;
            textBox1.Location = new Point(415, 470);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(65, 23);
            textBox1.TabIndex = 15;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.ImageAlign = ContentAlignment.BottomLeft;
            button3.Location = new Point(12, 470);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 14;
            button3.Text = "Settings";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.Location = new Point(334, 470);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "<<";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Location = new Point(486, 470);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = ">>";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // TrueFalseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 503);
            Controls.Add(AnsE_btn);
            Controls.Add(AnsTrue_btn);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "TrueFalseForm";
            Text = "True False Questions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AnsE_btn;
        private Button AnsTrue_btn;
        private Button button5;
        private Button button4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}