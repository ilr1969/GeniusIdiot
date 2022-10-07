
namespace WindowsFormsApp
{
    partial class ShowResults
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
            this.showResultsButton = new System.Windows.Forms.Button();
            this.showResultsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // showResultsButton
            // 
            this.showResultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showResultsButton.Location = new System.Drawing.Point(94, 253);
            this.showResultsButton.Name = "showResultsButton";
            this.showResultsButton.Size = new System.Drawing.Size(104, 49);
            this.showResultsButton.TabIndex = 0;
            this.showResultsButton.Text = "Закрыть";
            this.showResultsButton.UseVisualStyleBackColor = true;
            this.showResultsButton.Click += new System.EventHandler(this.showResultsButton_Click);
            // 
            // showResultsRichTextBox
            // 
            this.showResultsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showResultsRichTextBox.Location = new System.Drawing.Point(26, 13);
            this.showResultsRichTextBox.Name = "showResultsRichTextBox";
            this.showResultsRichTextBox.ReadOnly = true;
            this.showResultsRichTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.showResultsRichTextBox.Size = new System.Drawing.Size(240, 220);
            this.showResultsRichTextBox.TabIndex = 1;
            this.showResultsRichTextBox.Text = "";
            // 
            // ShowResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 314);
            this.Controls.Add(this.showResultsRichTextBox);
            this.Controls.Add(this.showResultsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ShowResults";
            this.Text = "ShowResults";
            this.Load += new System.EventHandler(this.ShowResults_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showResultsButton;
        private System.Windows.Forms.RichTextBox showResultsRichTextBox;
    }
}