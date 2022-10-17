
namespace WindowsFormsApp
{
    partial class ShowAnswers
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
            this.showAnswersDataGridView = new System.Windows.Forms.DataGridView();
            this.Вопрос = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ответ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.showAnswersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // showAnswersDataGridView
            // 
            this.showAnswersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.showAnswersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showAnswersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Вопрос,
            this.Ответ});
            this.showAnswersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.showAnswersDataGridView.Name = "showAnswersDataGridView";
            this.showAnswersDataGridView.Size = new System.Drawing.Size(619, 335);
            this.showAnswersDataGridView.TabIndex = 0;
            // 
            // Вопрос
            // 
            this.Вопрос.HeaderText = "Question";
            this.Вопрос.Name = "Вопрос";
            this.Вопрос.ReadOnly = true;
            this.Вопрос.Width = 72;
            // 
            // Ответ
            // 
            this.Ответ.HeaderText = "Answer";
            this.Ответ.Name = "Ответ";
            this.Ответ.ReadOnly = true;
            this.Ответ.Width = 65;
            // 
            // ShowAnswers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 359);
            this.Controls.Add(this.showAnswersDataGridView);
            this.Name = "ShowAnswers";
            this.Text = "ShowAnswers";
            this.Load += new System.EventHandler(this.ShowAnswers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showAnswersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView showAnswersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Вопрос;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ответ;
    }
}