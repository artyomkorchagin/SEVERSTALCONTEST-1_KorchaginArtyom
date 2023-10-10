using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEVERSTALCONTEST_1_KorchaginArtyom
{
    // этот класс является Презентером шаблона MVP
    public class NoteObjCreator
    {


        // layout - самодельная сетка(grid), на которой будут размещены кнопки
        // Наверняка, можно сделать нормально через TableLayoutPanel, но я поздно понял это
        internal List<Point> layout = new List<Point>();


        internal List<NoteHolder> notes = new List<NoteHolder>();
        internal Model model;
        internal IView view;

        public NoteObjCreator(IView view)
        {
            this.view = view;
            model = new Model();
        }
        // создает заметку, помещает на следующее свободное место в панели
        public void CreateNote(NoteHolder note)
        {
            if (layout.Count != 0)
                layout.Add(new Point((layout.Count - 1) % 2 == 1 ? 10 : 220, (layout.Count - layout.Count % 2) * 30 + 10));
            else
                layout.Add(new Point(10, 10));
            notes.Add(note);
            note.Location = layout[layout.Count - 1];
            view.AddNoteToPanel(note);
        }
        // Удаляет заметку, сдвигая остальные заметки на 1 позицию влево
        public void RemoveNote(NoteHolder note)
        {
            int temp = notes.IndexOf(note);

            for (int i = temp; i < notes.Count-1; i++)
            {
                notes[i] = notes[i+1];
                notes[i].Location = layout[i];
            } 
            notes.RemoveAt(notes.Count-1);
            layout.RemoveAt(layout.Count-1);

        }

        // Восстанавливает сеанс, считывая информацию с xml=документа
        public void RestoreNotes()
        {
            List<NoteHolder> excractedNote = model.ReadToApp(this);

            foreach (NoteHolder note in excractedNote)
            {
                if (layout.Count != 0)
                    layout.Add(new Point((layout.Count - 1) % 2 == 1 ? 10 : 220, (layout.Count - layout.Count % 2) * 30 + 10));
                else
                    layout.Add(new Point(10, 10));

                notes.Add(note);
                note.SetTextToNote();
                note.Location = layout[layout.Count - 1];
                view.AddNoteToPanel(note);
            }
        }
        // метод очищает документ, потом вносит новые данные
        public void SaveAndExit()
        {
            model.DeleteNodesXml();

            foreach (NoteHolder note in notes) 
            {
                if (note.Title != "")
                    model.AddNoteToXml(note);
            }
        }


    }
}
