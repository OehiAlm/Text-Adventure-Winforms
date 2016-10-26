using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_Winforms
{
    public class WindowManager : Manager<WindowManager>
    {
        protected WindowManager() { }

        private MainForm m_MainWindow; 

        public void RegisterWindow(MainForm mainWindow)
        {
            this.m_MainWindow = mainWindow;
        }

        ////////////stuff starts here

        public void AddText (string a)
        {
            m_MainWindow.AddText(a);
        }

        public void StartTick()
        {
            m_MainWindow.StartTick();
        }

        public void StopTick()
        {
            m_MainWindow.StopTick();
        }

        public void ToggleTick()
        {
            m_MainWindow.ToggleTick();
        }
    }
}