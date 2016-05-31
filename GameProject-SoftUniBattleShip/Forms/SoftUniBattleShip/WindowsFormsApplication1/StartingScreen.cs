using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class StartingScreen : Form
    {
        private System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public StartingScreen()
        {
            player.SoundLocation = @"..\..\Resources\StarWars.wav";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Play();
            Hide();
            PlayScreen ps = new PlayScreen();
            ps.ShowDialog();
            Close();
        }

        private void StartingScreen_Load(object sender, EventArgs e)
        {

        }

        private void CharacterTypeButton_Click(object sender, EventArgs e)
        {
            Hide();
            ChooseCharacterScreen ccs = new ChooseCharacterScreen();
            ccs.ShowDialog();
            Close();
        }

        private void InstructionsButton_Click(object sender, EventArgs e)
        {
            Hide();
            Instructions instructions = new Instructions();
            instructions.ShowDialog();
            Close();
        }

        private void ChooseCategory_Click(object sender, EventArgs e)
        {
            Hide();
            ChooseCategoryScreen ccs = new ChooseCategoryScreen();
            ccs.ShowDialog();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
