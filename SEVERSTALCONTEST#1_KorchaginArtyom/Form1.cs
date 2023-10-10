using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace SEVERSTALCONTEST_1_KorchaginArtyom
{
    public partial class MainForm : Form, IView
    {
        NoteObjCreator noteCreator;
        NoteHolder placeholdernote;
        public MainForm()
        {
            InitializeComponent();
            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
            noteCreator = new NoteObjCreator(this);
            noteCreator.RestoreNotes();

            // Проверка на первый запуск, если файла не существует, значит это первый запуск.
            if(!File.Exists(@"firstlaunch.dat"))
            {
                File.Create(@"firstlaunch.dat");
                placeholdernote = new NoteHolder(noteCreator);
                placeholdernote.Title = "Привет!";
                placeholdernote.Description = "Спасибо за установку данного приложения!" +
                    "\nПри щелчке по этой заметке, станет доступна кнопка \"Редактировать\", при её нажатии станут доступны следующие кнопки:" +
                    "\nS - сохранить заметку на компьютер" +
                    "\nB - применить жирный шрифт" +
                    "\nI - применить курсив" +
                    "\nD - удалить заметку";

                placeholdernote.SetTextToNote();
                noteCreator.CreateNote(placeholdernote);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        // создание новой заметки
        private void button1_Click(object sender, EventArgs e)
        {
            placeholdernote = new NoteHolder(noteCreator);
            panel1.VerticalScroll.Value = 0;
            noteCreator.CreateNote(placeholdernote);
            ScrollToBottom(panel1);
        }


        // добавляет заметку на панель на mainForm
        public void AddNoteToPanel(NoteHolder note)
        {
            panel1.Controls.Add(note);
        }


        // Опускается в конец панели, нужно для того, чтобы позиция сетки не сбивалась
        public void ScrollToBottom(Panel p)
        {
            using (Control c = new Control() { Parent = p, Dock = DockStyle.Bottom })
            {
                p.ScrollControlIntoView(c);
                c.Parent = null;
            }
        }

        // Сохраняет все заметки при закрытии приложения
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            noteCreator.SaveAndExit();
        }
    }
}
