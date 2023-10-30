namespace FebTesting
{
    partial class ClosedQuestionsForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            AnsA_btn = new Button();
            AnsB_btn = new Button();
            AnsC_btn = new Button();
            AnsD_btn = new Button();
            AnsE_btn = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Location = new Point(485, 472);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = ">>";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.Location = new Point(333, 472);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "<<";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.ImageAlign = ContentAlignment.BottomLeft;
            button3.Location = new Point(11, 472);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Settings";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom;
            textBox1.Location = new Point(414, 472);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(65, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(12, 12);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(864, 329);
            textBox2.TabIndex = 4;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.ImageAlign = ContentAlignment.BottomLeft;
            button4.Location = new Point(775, 472);
            button4.Name = "button4";
            button4.Size = new Size(101, 23);
            button4.TabIndex = 5;
            button4.Text = "OpenQuestions";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.ImageAlign = ContentAlignment.BottomLeft;
            button5.Location = new Point(668, 472);
            button5.Name = "button5";
            button5.Size = new Size(101, 23);
            button5.TabIndex = 6;
            button5.Text = "True False";
            button5.UseVisualStyleBackColor = true;
            // 
            // AnsA_btn
            // 
            AnsA_btn.Anchor = AnchorStyles.Bottom;
            AnsA_btn.Location = new Point(12, 347);
            AnsA_btn.Name = "AnsA_btn";
            AnsA_btn.Size = new Size(121, 119);
            AnsA_btn.TabIndex = 7;
            AnsA_btn.Text = "A";
            AnsA_btn.UseVisualStyleBackColor = true;
            // 
            // AnsB_btn
            // 
            AnsB_btn.Anchor = AnchorStyles.Bottom;
            AnsB_btn.Location = new Point(199, 347);
            AnsB_btn.Name = "AnsB_btn";
            AnsB_btn.Size = new Size(121, 119);
            AnsB_btn.TabIndex = 8;
            AnsB_btn.Text = "B";
            AnsB_btn.UseVisualStyleBackColor = true;
            // 
            // AnsC_btn
            // 
            AnsC_btn.Anchor = AnchorStyles.Bottom;
            AnsC_btn.Location = new Point(386, 347);
            AnsC_btn.Name = "AnsC_btn";
            AnsC_btn.Size = new Size(121, 119);
            AnsC_btn.TabIndex = 9;
            AnsC_btn.Text = "C";
            AnsC_btn.UseVisualStyleBackColor = true;
            // 
            // AnsD_btn
            // 
            AnsD_btn.Anchor = AnchorStyles.Bottom;
            AnsD_btn.Location = new Point(570, 347);
            AnsD_btn.Name = "AnsD_btn";
            AnsD_btn.Size = new Size(121, 119);
            AnsD_btn.TabIndex = 10;
            AnsD_btn.Text = "D";
            AnsD_btn.UseVisualStyleBackColor = true;
            // 
            // AnsE_btn
            // 
            AnsE_btn.Anchor = AnchorStyles.Bottom;
            AnsE_btn.Location = new Point(755, 347);
            AnsE_btn.Name = "AnsE_btn";
            AnsE_btn.Size = new Size(121, 119);
            AnsE_btn.TabIndex = 11;
            AnsE_btn.Text = "E";
            AnsE_btn.UseVisualStyleBackColor = true;
            // 
            // ClosedQuestionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 503);
            Controls.Add(AnsE_btn);
            Controls.Add(AnsD_btn);
            Controls.Add(AnsC_btn);
            Controls.Add(AnsB_btn);
            Controls.Add(AnsA_btn);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ClosedQuestionsForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button4;
        private Button button5;
        private Button AnsA_btn;
        private Button AnsB_btn;
        private Button AnsC_btn;
        private Button AnsD_btn;
        private Button AnsE_btn;
    }
}