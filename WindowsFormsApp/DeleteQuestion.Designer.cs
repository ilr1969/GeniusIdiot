
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
            this.delButton = new System.Windows.Forms.Button();
            this.questionsDataGridView = new System.Windows.Forms.DataGridView();
            this.question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // delButton
            // 
            this.delButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delButton.Location = new System.Drawing.Point(30, 389);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(735, 37);
            this.delButton.TabIndex = 3;
            this.delButton.Text = "Удалить выделенный вопрос";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton1_Click);
            // 
            // questionsDataGridView
            // 
            this.questionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.question});
            this.questionsDataGridView.Location = new System.Drawing.Point(30, 32);
            this.questionsDataGridView.Name = "questionsDataGridView";
            this.questionsDataGridView.Size = new System.Drawing.Size(735, 333);
            this.questionsDataGridView.TabIndex = 4;
            // 
            // question
            // 
            this.question.HeaderText = "Вопросы в тесте:";
            this.question.Name = "question";
            this.question.ReadOnly = true;
            this.question.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.question.Width = 650;
            // 
            // DeleteQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.questionsDataGridView);
            this.Controls.Add(this.delButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DeleteQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление вопроса";
            this.Load += new System.EventHandler(this.DeleteQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.DataGridView questionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn question;
    }
}