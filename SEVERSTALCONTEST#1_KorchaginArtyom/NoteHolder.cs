using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SEVERSTALCONTEST_1_KorchaginArtyom
{
    public partial class NoteHolder : UserControl
    {
        internal string Title { get; set; }
        internal string Description { get; set; }
        internal string DateofCreation { get; set; }
        bool enabled = false;
        bool readyToSave = false;
        NoteObjCreator parentCreator;

        // Дефолтная заметка
        public NoteHolder(NoteObjCreator noteObjCreator)
        {
            Title = "Заголовок";
            Description = "Наполни меня своими мыслями!";
            DateofCreation = DateTime.Now.ToString("dd.MM.yyyy");
            InitializeComponent();
            this.Height = 40;
            DescriptionBox.ReadOnly = true;
            TitleBox.Enabled = false;
            HideEditButtons();
            parentCreator = noteObjCreator;
            dateLabel.Text = DateofCreation;
            SetTextToNote();
        }

        private void NoteHolder_Load(object sender, EventArgs e)
        {

        }
        // Заметка "приоткрывается" при попадании курсора в область заметки
        private void NoteHolder_MouseEnter(object sender, EventArgs e)
        {
            if (!enabled)
                this.Height = 250;
        }
        // заметка обратно уменшься при отсутствии курсора в области заметки
        private void NoteHolder_MouseLeave(object sender, EventArgs e)
        {
            if (!enabled)
                this.Height = 40;
        }
        // При первом клике заметка полностью открывается, позволяя использовать кнопки "редактировать" и "сохранить"
        // При втором клике заметка уходит в исходное состояние
        private void NoteHolder_MouseClick(object sender, MouseEventArgs e)
        {
            if (!enabled)
            {
                this.Height = 300;
                enabled = true;
            }
            else
            {
                if (!readyToSave) {
                    this.Height = 40;
                    enabled = false;
                }
            }

        }
        // Кнопка редактировать позволяет, как ни странно, редактировать заголовок и текст заметки.
        private void button_editText_Click(object sender, EventArgs e)
        {
            DescriptionBox.ReadOnly = false;
            TitleBox.Enabled = true;
            readyToSave = true;
            ShowEditButtons();
        }
        // Кнопка сохранить передает значения текстбоксов в свойства класса (для дальнейшего занесения в xml файл)
        private void button_saveNote_Click(object sender, EventArgs e)
        {
            DescriptionBox.ReadOnly = true;
            TitleBox.Enabled = false;
            HideEditButtons();
            if (readyToSave)
            {
                Title = TitleBox.Text;
                Description = DescriptionBox.Text;
                DateofCreation = dateLabel.Text;
                readyToSave = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // Прячет кнопки, "спрятанные" под кнопкой редактировать
        private void HideEditButtons()
        {
            button_boldFont.Visible = false;
            button_italicFont.Visible = false;
            button_deleteNote.Visible = false;
            button_saveNoteTo.Visible = false;
            button_editText.Visible = true;
        }
        // Показывает кнопки, "спрятанные" под кнопкой редактировать
        private void ShowEditButtons()
        {
            button_boldFont.Visible = true;
            button_italicFont.Visible = true;
            button_deleteNote.Visible = true;
            button_saveNoteTo.Visible = true;
            button_editText.Visible = false;
        }
        // Удаляет заметку "с глаз долой, из сердца вон"
        private void button_deleteNote_Click(object sender, EventArgs e)
        {
            parentCreator.RemoveNote(this);
            this.DestroyHandle();
        }
        // Делает текст жирным
        private void button_boldFont_Click(object sender, EventArgs e)
        {
            Font SelectedText_Font = DescriptionBox.SelectionFont;
            if (SelectedText_Font != null)
                DescriptionBox.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Bold);
        }
        // Делает текст курсивным
        private void button_italicFont_Click(object sender, EventArgs e)
        {
            Font SelectedText_Font = DescriptionBox.SelectionFont;
            if (SelectedText_Font != null)
                DescriptionBox.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Italic);
        }

        // Устанавливает значения заметки в textbox'ы noteHandler
        public void SetTextToNote()
        {
            TitleBox.Text = Title;
            DescriptionBox.Text = Description;
            dateLabel.Text = DateofCreation;
        }
        // Вызывает диалоговое окно для сохранения заметки в файл тхт
        private void button_saveNoteTo_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = TitleBox.Text;
            saveFileDialog1.Filter = "Текстовый документ|*.txt";
            saveFileDialog1.Title = "Сохранение заметки"; 

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, DescriptionBox.Text);
            }
        }
    }
}
