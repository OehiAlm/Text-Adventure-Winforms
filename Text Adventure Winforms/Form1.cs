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
            this.Text = "Nice, I changed the Text from the default Form1. Name is still Form1, though";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
