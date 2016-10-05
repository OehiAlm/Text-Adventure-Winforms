using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Adventure_Winforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            OutputStream.AppendText("\n");
        }

        // Now come various methods, that I didn't know where to put elsewhere :D

        private void PrintFireState ()
        {
            OutputStream.AppendText(Firestate.firestateText + "\n");
        }

        public static void DisableButtons (Button i) //have no access from outside of this class to this method... why? and how can i fix it?
        {
            i.Enabled = false;
        }

        private void KindleButton_Click(object sender, EventArgs e)
        {
            Firestate.KindleFire();
            PrintFireState();
        }

        private void ExtinguishButton_Click(object sender, EventArgs e)
        {
            Firestate.ExtinguishFire();
            PrintFireState();
        }
    }
}
