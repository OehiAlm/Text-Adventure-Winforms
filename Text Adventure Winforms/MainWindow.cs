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
        //
        //  Data
        //

        byte numberofTicks = 0;

        // Constructor, automatically called, when MainForm is being created

        public MainForm()
        {
            InitializeComponent();
            WindowManager.Get().RegisterWindow(this);
            ControlFlow Start = new ControlFlow();
            Start.StartControlFlow();
        }

        //Outside outside;
        Firestate firestate = new Firestate();      // Creating a local copy of Firestate to use all logic & data from this class

        //
        //  Button logic
        //

        void CheckButtonstate(Button button, Button counterpart)
        {
            if (firestate.intFirestate == ETextsLowerBound() || firestate.intFirestate == ETextsUpperBound())
                ToggleButtonStates(button, counterpart, true);   //Den counterpart muss ich durchreichen, damit der andere Button wieder enabled wird

            else
                ToggleButtonStates(button, counterpart, false);
        }

        void ToggleButtonStates(Button button, Button counterpart, bool enabled)
        {
            if (enabled)
                button.Enabled = false;
            else
                counterpart.Enabled = true;
        }

        //
        //  Helper functions
        //

        public void AddText (string a)
        {
            OutputStream.AppendText(a);
        }

        public void StartTick ()
        {
            AdventureTick.Start();
        }

        public void StopTick()
        {
            AdventureTick.Stop();
        }

        public void ToggleTick ()
        {
            if (AdventureTick.Enabled)
                AdventureTick.Stop();
            else
                AdventureTick.Start();
        }

        public int ETextsUpperBound()
        {
            return Enum.GetValues(typeof(EFireTexts)).Cast<int>().Max();
        }

        public int ETextsLowerBound()
        {
            return Enum.GetValues(typeof(EFireTexts)).Cast<int>().Min();
        }

        //
        //  Element Manipulation
        //

        public void ChangeWindowSize (int width, int height)
        {
            this.Size = new Size(width, height);
        }

        //
        //  Element Events
        //

        private void KindleButton_Click(object sender, EventArgs e)
        {
            firestate.KindleFire();
            OutputStream.AppendText(firestate.strFirestate + "\n");
            CheckButtonstate(KindleButton, ExtinguishButton);
            UpdateOutside(firestate);
        }

        private void ExtinguishButton_Click(object sender, EventArgs e)
        {
            firestate.ExtinguishFire();
            OutputStream.AppendText(firestate.strFirestate + "\n");
            CheckButtonstate(ExtinguishButton,KindleButton);
            UpdateOutside(firestate);
        }

        private void StandardTick_Tick(object sender, EventArgs e)
        {
            
            //numberofTicks++;
        }
    }
}
