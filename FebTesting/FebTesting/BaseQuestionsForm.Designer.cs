namespace FebTesting
{
    partial class BaseQuestionsForm
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
            button5 = new Button();
            button4 = new Button();
            QuestionTxt = new TextBox();
            PagingTxt = new TextBox();
            button3 = new Button();
            PrvBtn = new Button();
            NextBtn = new Button();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.ImageAlign = ContentAlignment.BottomLeft;
            button5.Location = new Point(669, 470);
            button5.Name = "button5";
            button5.Size = new Size(101, 23);
            button5.TabIndex = 30;
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
            button4.TabIndex = 29;
            button4.Text = "OpenQuestions";
            button4.UseVisualStyleBackColor = true;
            // 
            // QuestionTxt
            // 
            QuestionTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            QuestionTxt.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            QuestionTxt.Location = new Point(13, 10);
            QuestionTxt.Multiline = true;
            QuestionTxt.Name = "QuestionTxt";
            QuestionTxt.ReadOnly = true;
            QuestionTxt.Size = new Size(864, 329);
            QuestionTxt.TabIndex = 28;
            // 
            // PagingTxt
            // 
            PagingTxt.Anchor = AnchorStyles.Bottom;
            PagingTxt.Location = new Point(415, 470);
            PagingTxt.Name = "PagingTxt";
            PagingTxt.ReadOnly = true;
            PagingTxt.Size = new Size(65, 23);
            PagingTxt.TabIndex = 27;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.ImageAlign = ContentAlignment.BottomLeft;
            button3.Location = new Point(12, 470);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 26;
            button3.Text = "Settings";
            button3.UseVisualStyleBackColor = true;
            // 
            // PrvBtn
            // 
            PrvBtn.Anchor = AnchorStyles.Bottom;
            PrvBtn.Location = new Point(334, 470);
            PrvBtn.Name = "PrvBtn";
            PrvBtn.Size = new Size(75, 23);
            PrvBtn.TabIndex = 25;
            PrvBtn.Text = "<<";
            PrvBtn.TextAlign = ContentAlignment.BottomCenter;
            PrvBtn.UseVisualStyleBackColor = true;
            // 
            // NextBtn
            // 
            NextBtn.Anchor = AnchorStyles.Bottom;
            NextBtn.Location = new Point(486, 470);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(75, 23);
            NextBtn.TabIndex = 24;
            NextBtn.Text = ">>";
            NextBtn.TextAlign = ContentAlignment.BottomCenter;
            NextBtn.UseVisualStyleBackColor = true;
            // 
            // BaseQuestionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 503);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(QuestionTxt);
            Controls.Add(PagingTxt);
            Controls.Add(button3);
            Controls.Add(PrvBtn);
            Controls.Add(NextBtn);
            Name = "BaseQuestionsForm";
            Text = "BaseQuestionsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Button button4;
        private TextBox QuestionTxt;
        private TextBox PagingTxt;
        private Button button3;
        private Button PrvBtn;
        private Button NextBtn;
    }
}