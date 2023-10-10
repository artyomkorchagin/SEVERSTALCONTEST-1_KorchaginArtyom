using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace SEVERSTALCONTEST_1_KorchaginArtyom
{
    public class Model
    {
        XmlDocument xNotes = new XmlDocument();
        public Model()
        {
            // xml файл, в котором хранится вся информация о заметках
            if (!File.Exists(@"notes.xml"))
            {
                XmlWriter writer = XmlWriter.Create(@"notes.xml");
                writer.WriteStartElement("exitinfo");
                writer.WriteEndElement();
                writer.Flush();
                writer.Close();
            }
            xNotes.Load(@"notes.xml");
        }

        // метод, возращающий все заметки из xml файла. Запускается при запуске приложения, для восстановления сеанса
        public List<NoteHolder> ReadToApp(NoteObjCreator noteCreator)
        {
            List<NoteHolder> extractedNote = new List<NoteHolder>();
            XmlElement xRoot = xNotes.DocumentElement;
            if (xRoot != null)
            {
                // обход всех узлов в корневом элементе
                foreach (XmlElement xnode in xRoot)
                {
                    NoteHolder note = new NoteHolder(noteCreator);
                    note.Title = xnode.FirstChild.InnerText;
                    // обходим все дочерние узлы элемента user
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        // если узел - description
                        if (childnode.Name == "description")
                        {
                            note.Description = childnode.InnerText;
                        }
                        // если узел - dateOfCreation
                        if (childnode.Name == "dateOfCreation")
                        {
                            note.DateofCreation = childnode.InnerText;
                        }
                    }
                    extractedNote.Add(note);
                }
            }
            return extractedNote;
        }

        // Сохранение информации о заметке
        public void AddNoteToXml(NoteHolder note)
        {
            XmlElement xRoot = xNotes.DocumentElement;

            // создаем элемент title
            XmlElement titleElem = xNotes.CreateElement("title");

            // создаем элемент description
            XmlElement descriptionElem = xNotes.CreateElement("description");

            // создаем элемент dateOfCreation
            XmlElement dateOfCreationElem = xNotes.CreateElement("dateOfCreation");

            // создаем текстовые значения для элементов
            XmlText titleText = xNotes.CreateTextNode(note.Title);
            XmlText descriptionText = xNotes.CreateTextNode(note.Description);
            XmlText dateOfCreationText = xNotes.CreateTextNode(note.DateofCreation);

            //добавляем узлы
            titleElem.AppendChild(titleText);
            descriptionElem.AppendChild(descriptionText);
            dateOfCreationElem.AppendChild(dateOfCreationText);
            titleElem.AppendChild(descriptionElem);
            titleElem.AppendChild(dateOfCreationElem);
           
            // добавляем в корневой элемент новый элемент title
            xRoot?.AppendChild(titleElem);
            // сохраняем изменения xml-документа в файл
            xNotes.Save("notes.xml");
        }

        // метод удаляет все данные внутри корня (то есть все заметки)
        // используется для предотвращения перезаписи данных в xml-документе
        public void DeleteNodesXml()
        {
            XmlElement root = xNotes.DocumentElement;
            root.RemoveAll();
            xNotes.Save("notes.xml");
        }
    }
}
