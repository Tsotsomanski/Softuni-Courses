using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ChooseCharacterScreen : Form
    {
        public ChooseCharacterScreen()
        {
            InitializeComponent();
        }

        private void JediButton_Click(object sender, EventArgs e)
        {
            Hide();
            Jedi jedi = new Jedi();
            jedi.ShowDialog();
            Close();
        }

        private void PaduinButton_Click(object sender, EventArgs e)
        {
            Hide();
            Paduin paduin = new Paduin();
            paduin.ShowDialog();
            Close();
        }
    }
}
