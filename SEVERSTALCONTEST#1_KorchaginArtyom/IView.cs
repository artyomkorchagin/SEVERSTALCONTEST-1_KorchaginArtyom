using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEVERSTALCONTEST_1_KorchaginArtyom
{

    // В следующих версиях тут должно быть больше методов
    public interface IView
    {


        void AddNoteToPanel(NoteHolder note);
    }
}
