namespace SEVERSTALCONTEST_1_KorchaginArtyom
{
    partial class NoteHolder
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_editText = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.button_saveNote = new System.Windows.Forms.Button();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.button_boldFont = new System.Windows.Forms.Button();
            this.button_italicFont = new System.Windows.Forms.Button();
            this.button_deleteNote = new System.Windows.Forms.Button();
            this.button_saveNoteTo = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // button_editText
            // 
            this.button_editText.Location = new System.Drawing.Point(1, 254);
            this.button_editText.Name = "button_editText";
            this.button_editText.Size = new System.Drawing.Size(96, 44);
            this.button_editText.TabIndex = 3;
            this.button_editText.Text = "Редактировать";
            this.button_editText.UseVisualStyleBackColor = true;
            this.button_editText.Click += new System.EventHandler(this.button_editText_Click);
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.SystemColors.Info;
            this.DescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionBox.Location = new System.Drawing.Point(8, 44);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.ReadOnly = true;
            this.DescriptionBox.Size = new System.Drawing.Size(183, 203);
            this.DescriptionBox.TabIndex = 0;
            this.DescriptionBox.Text = "";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Enabled = false;
            this.dateLabel.Location = new System.Drawing.Point(136, 16);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 14);
            this.dateLabel.TabIndex = 4;
            // 
            // button_saveNote
            // 
            this.button_saveNote.Location = new System.Drawing.Point(101, 254);
            this.button_saveNote.Name = "button_saveNote";
            this.button_saveNote.Size = new System.Drawing.Size(90, 44);
            this.button_saveNote.TabIndex = 5;
            this.button_saveNote.Text = "Сохранить";
            this.button_saveNote.UseVisualStyleBackColor = true;
            this.button_saveNote.Click += new System.EventHandler(this.button_saveNote_Click);
            // 
            // TitleBox
            // 
            this.TitleBox.BackColor = System.Drawing.SystemColors.Info;
            this.TitleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleBox.Enabled = false;
            this.TitleBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleBox.Location = new System.Drawing.Point(8, 8);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(122, 22);
            this.TitleBox.TabIndex = 6;
            this.TitleBox.Text = "Title";
            this.TitleBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_boldFont
            // 
            this.button_boldFont.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_boldFont.Location = new System.Drawing.Point(27, 265);
            this.button_boldFont.Name = "button_boldFont";
            this.button_boldFont.Size = new System.Drawing.Size(23, 23);
            this.button_boldFont.TabIndex = 7;
            this.button_boldFont.Text = "B";
            this.button_boldFont.UseVisualStyleBackColor = true;
            this.button_boldFont.Click += new System.EventHandler(this.button_boldFont_Click);
            // 
            // button_italicFont
            // 
            this.button_italicFont.Font = new System.Drawing.Font("Arimo", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_italicFont.Location = new System.Drawing.Point(50, 265);
            this.button_italicFont.Name = "button_italicFont";
            this.button_italicFont.Size = new System.Drawing.Size(23, 23);
            this.button_italicFont.TabIndex = 8;
            this.button_italicFont.Text = "I";
            this.button_italicFont.UseVisualStyleBackColor = true;
            this.button_italicFont.Click += new System.EventHandler(this.button_italicFont_Click);
            // 
            // button_deleteNote
            // 
            this.button_deleteNote.Location = new System.Drawing.Point(72, 265);
            this.button_deleteNote.Name = "button_deleteNote";
            this.button_deleteNote.Size = new System.Drawing.Size(23, 23);
            this.button_deleteNote.TabIndex = 9;
            this.button_deleteNote.Text = "D";
            this.button_deleteNote.UseVisualStyleBackColor = true;
            this.button_deleteNote.Click += new System.EventHandler(this.button_deleteNote_Click);
            // 
            // button_saveNoteTo
            // 
            this.button_saveNoteTo.Location = new System.Drawing.Point(3, 265);
            this.button_saveNoteTo.Name = "button_saveNoteTo";
            this.button_saveNoteTo.Size = new System.Drawing.Size(23, 23);
            this.button_saveNoteTo.TabIndex = 10;
            this.button_saveNoteTo.Text = "S";
            this.button_saveNoteTo.UseVisualStyleBackColor = true;
            this.button_saveNoteTo.Click += new System.EventHandler(this.button_saveNoteTo_Click);
            // 
            // NoteHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button_saveNoteTo);
            this.Controls.Add(this.button_deleteNote);
            this.Controls.Add(this.button_italicFont);
            this.Controls.Add(this.button_boldFont);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.button_saveNote);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.button_editText);
            this.Name = "NoteHolder";
            this.Size = new System.Drawing.Size(200, 300);
            this.Load += new System.EventHandler(this.NoteHolder_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoteHolder_MouseClick);
            this.MouseEnter += new System.EventHandler(this.NoteHolder_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.NoteHolder_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_editText;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button button_saveNote;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Button button_boldFont;
        private System.Windows.Forms.Button button_italicFont;
        private System.Windows.Forms.Button button_deleteNote;
        private System.Windows.Forms.Button button_saveNoteTo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
