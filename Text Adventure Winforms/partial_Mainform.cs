using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

enum EFirstTimeWorldEvents : byte
{
    ROOM_PARTIALLY_LIT,
    ROOM_COMPLETELY_LIT,
    DOOR_OPENS,
}

namespace Text_Adventure_Winforms
{
    public partial class MainForm
    {
        public struct Outside
        {
            Color backgroundcolor;
            Object[] objects;
        }

        void UpdateOutside(Firestate firestate)
        {
            int totalNumberOfStates = Enum.GetNames(typeof(EFireTexts)).Length;
            float quota = byte.MaxValue / totalNumberOfStates;
            worldWindow.BackColor = Color.FromArgb ((int)(firestate.intFirestate * quota),
                                                    (int)(firestate.intFirestate * quota),
                                                    (int)(firestate.intFirestate * quota));
        }
    }
}
