
namespace WindowsFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NextButton = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.TextBox();
            this.QuestionNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.questionBox = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.показатьРезультатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.рыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пройтиТестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьРезультатыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьОтветыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.Location = new System.Drawing.Point(29, 213);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(158, 89);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Далее";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer.Location = new System.Drawing.Point(29, 167);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(103, 29);
            this.answer.TabIndex = 4;
            // 
            // QuestionNumber
            // 
            this.QuestionNumber.AutoSize = true;
            this.QuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionNumber.Location = new System.Drawing.Point(25, 56);
            this.QuestionNumber.Name = "QuestionNumber";
            this.QuestionNumber.Size = new System.Drawing.Size(0, 24);
            this.QuestionNumber.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ответ:";
            // 
            // questionBox
            // 
            this.questionBox.AutoSize = true;
            this.questionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionBox.Location = new System.Drawing.Point(25, 98);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(0, 24);
            this.questionBox.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // показатьРезультатыToolStripMenuItem
            // 
            this.показатьРезультатыToolStripMenuItem.Name = "показатьРезультатыToolStripMenuItem";
            this.показатьРезультатыToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // рыToolStripMenuItem
            // 
            this.рыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пройтиТестToolStripMenuItem,
            this.показатьРезультатыToolStripMenuItem1,
            this.добавитьВопросToolStripMenuItem,
            this.удалитьВопросToolStripMenuItem,
            this.показатьОтветыToolStripMenuItem,
            this.выходStripMenuItem1});
            this.рыToolStripMenuItem.Name = "рыToolStripMenuItem";
            this.рыToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.рыToolStripMenuItem.Text = "Меню";
            // 
            // пройтиТестToolStripMenuItem
            // 
            this.пройтиТестToolStripMenuItem.Name = "пройтиТестToolStripMenuItem";
            this.пройтиТестToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.пройтиТестToolStripMenuItem.Text = "Пройти тест";
            this.пройтиТестToolStripMenuItem.Click += new System.EventHandler(this.пройтиТестToolStripMenuItem_Click);
            // 
            // показатьРезультатыToolStripMenuItem1
            // 
            this.показатьРезультатыToolStripMenuItem1.Name = "показатьРезультатыToolStripMenuItem1";
            this.показатьРезультатыToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.показатьРезультатыToolStripMenuItem1.Text = "Показать результаты";
            this.показатьРезультатыToolStripMenuItem1.Click += new System.EventHandler(this.показатьРезультатыToolStripMenuItem1_Click);
            // 
            // добавитьВопросToolStripMenuItem
            // 
            this.добавитьВопросToolStripMenuItem.Name = "добавитьВопросToolStripMenuItem";
            this.добавитьВопросToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.добавитьВопросToolStripMenuItem.Text = "Добавить вопрос";
            this.добавитьВопросToolStripMenuItem.Click += new System.EventHandler(this.добавитьВопросToolStripMenuItem_Click);
            // 
            // удалитьВопросToolStripMenuItem
            // 
            this.удалитьВопросToolStripMenuItem.Name = "удалитьВопросToolStripMenuItem";
            this.удалитьВопросToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.удалитьВопросToolStripMenuItem.Text = "Удалить вопрос";
            this.удалитьВопросToolStripMenuItem.Click += new System.EventHandler(this.удалитьВопросToolStripMenuItem_Click);
            // 
            // выходStripMenuItem1
            // 
            this.выходStripMenuItem1.Name = "выходStripMenuItem1";
            this.выходStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.выходStripMenuItem1.Text = "Выход";
            this.выходStripMenuItem1.Click += new System.EventHandler(this.выходStripMenuItem1_Click);
            // 
            // показатьОтветыToolStripMenuItem
            // 
            this.показатьОтветыToolStripMenuItem.Name = "показатьОтветыToolStripMenuItem";
            this.показатьОтветыToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.показатьОтветыToolStripMenuItem.Text = "Показать ответы";
            this.показатьОтветыToolStripMenuItem.Click += new System.EventHandler(this.показатьОтветыToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 329);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuestionNumber);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.NextButton);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeniusIdiot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label QuestionNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label questionBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem показатьРезультатыToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem рыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пройтиТестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьРезультатыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьВопросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВопросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem показатьОтветыToolStripMenuItem;
    }
}

