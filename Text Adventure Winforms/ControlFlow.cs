using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_Winforms
{
    public class ControlFlow
    {
        public void StartControlFlow ()
        {
            WindowManager.Get().AddText("\n");
            WindowManager.Get().StartTick();
        }
    }
}
