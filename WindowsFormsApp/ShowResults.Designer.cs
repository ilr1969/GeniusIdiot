
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
            this.showResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.showResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // showResultsButton
            // 
            this.showResultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showResultsButton.Location = new System.Drawing.Point(136, 289);
            this.showResultsButton.Name = "showResultsButton";
            this.showResultsButton.Size = new System.Drawing.Size(104, 49);
            this.showResultsButton.TabIndex = 0;
            this.showResultsButton.Text = "Закрыть";
            this.showResultsButton.UseVisualStyleBackColor = true;
            this.showResultsButton.Click += new System.EventHandler(this.showResultsButton_Click);
            // 
            // showResultsDataGridView
            // 
            this.showResultsDataGridView.AllowUserToOrderColumns = true;
            this.showResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO,
            this.Result,
            this.Diagnose});
            this.showResultsDataGridView.Location = new System.Drawing.Point(13, 13);
            this.showResultsDataGridView.Name = "showResultsDataGridView";
            this.showResultsDataGridView.Size = new System.Drawing.Size(361, 255);
            this.showResultsDataGridView.TabIndex = 2;
            // 
            // FIO
            // 
            this.FIO.HeaderText = "Имя";
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            // 
            // Result
            // 
            this.Result.HeaderText = "Результат";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            // 
            // Diagnose
            // 
            this.Diagnose.HeaderText = "Диагноз";
            this.Diagnose.Name = "Diagnose";
            this.Diagnose.ReadOnly = true;
            // 
            // ShowResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 350);
            this.Controls.Add(this.showResultsDataGridView);
            this.Controls.Add(this.showResultsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ShowResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowResults";
            this.Load += new System.EventHandler(this.ShowResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showResultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showResultsButton;
        private System.Windows.Forms.DataGridView showResultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnose;
    }
}