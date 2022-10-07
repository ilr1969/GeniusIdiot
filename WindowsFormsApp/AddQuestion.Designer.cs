
namespace WindowsFormsApp
{
    partial class addQuestion
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(13, 13);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(88, 13);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Введите вопрос";
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(13, 42);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(80, 13);
            this.answerLabel.TabIndex = 1;
            this.answerLabel.Text = "Введите ответ";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(122, 13);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(511, 20);
            this.questionTextBox.TabIndex = 2;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(122, 42);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(100, 20);
            this.answerTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(16, 71);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(138, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 106);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.questionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление вопроса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button addButton;
    }
}