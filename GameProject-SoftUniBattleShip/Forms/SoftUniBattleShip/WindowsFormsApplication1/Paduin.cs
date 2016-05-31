using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Paduin : Form
    {
        private int paduinCharacter = 1;
        public static int FinalPaduinCharacter = 1;
        public static int FinalPaduin = 1;

        public Paduin()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Hide();
            StartingScreen ss = new StartingScreen();
            FinalPaduinCharacter = this.paduinCharacter;
            ss.ShowDialog();
            Close();
        }

        private void SevginButton_CheckedChanged(object sender, EventArgs e)
        {
            this.paduinCharacter = 1;
        }

        private void YanchoButton_CheckedChanged(object sender, EventArgs e)
        {
            this.paduinCharacter = 2;
        }

        private void SashoButton_CheckedChanged(object sender, EventArgs e)
        {
            this.paduinCharacter = 3;
        }

        private void JanButton_CheckedChanged(object sender, EventArgs e)
        {
            this.paduinCharacter = 4;
        }

        private void Paduin_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Paduin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
