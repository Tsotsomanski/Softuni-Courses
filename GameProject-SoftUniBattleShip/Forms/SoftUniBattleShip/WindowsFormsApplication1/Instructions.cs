using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            StartingScreen ss = new StartingScreen();
            ss.ShowDialog();
            Close();
        }

        private void Instructions_Load(object sender, EventArgs e)
        {

        }
    }
}
