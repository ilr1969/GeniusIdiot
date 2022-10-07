
namespace WindowsFormsApp
{
    partial class DeleteQuestion
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
            this.questionsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.numToDelTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionsRichTextBox
            // 
            this.questionsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionsRichTextBox.Location = new System.Drawing.Point(30, 26);
            this.questionsRichTextBox.Name = "questionsRichTextBox";
            this.questionsRichTextBox.Size = new System.Drawing.Size(735, 208);
            this.questionsRichTextBox.TabIndex = 0;
            this.questionsRichTextBox.Text = "";
            // 
            // numToDelTextBox
            // 
            this.numToDelTextBox.Location = new System.Drawing.Point(30, 309);
            this.numToDelTextBox.Name = "numToDelTextBox";
            this.numToDelTextBox.Size = new System.Drawing.Size(100, 20);
            this.numToDelTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите номер вопроса, который хотите удалить";
            // 
            // delButton
            // 
            this.delButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delButton.Location = new System.Drawing.Point(30, 357);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(100, 37);
            this.delButton.TabIndex = 3;
            this.delButton.Text = "Удалить";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // DeleteQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numToDelTextBox);
            this.Controls.Add(this.questionsRichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DeleteQuestion";
            this.Text = "Удаление вопроса";
            this.Load += new System.EventHandler(this.DeleteQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox questionsRichTextBox;
        private System.Windows.Forms.TextBox numToDelTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delButton;
    }
}