using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using WindowsFormsApplication1.Jedis.Masters;

namespace WindowsFormsApplication1
{
    public partial class Jedi : Form
    {
        public Jedi()
        {
            InitializeComponent();
        }

        private int Character = 1;
        private int AssistantCharacter = 1;
        public static int FinalCharacter = 1;
        public static int FinalAssistantCharacter = 1;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            this.Character = 1;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Hide();
            FinalCharacter = this.Character;
            FinalAssistantCharacter = this.AssistantCharacter;
            ChooseCharacterScreen ss = new ChooseCharacterScreen();
            ss.ShowDialog();
            Close();
        }

        private void Jedi_Load(object sender, EventArgs e)
        {
            
        }

        private void BackButton(object sender, EventArgs e)
        {
            Hide();
            FinalCharacter = this.Character;
            FinalAssistantCharacter = this.AssistantCharacter;
            ChooseCharacterScreen ccs = new ChooseCharacterScreen();
            ccs.ShowDialog();
            Close();
        }



        public static implicit operator Jedi(JoNakov v)
        {
            throw new NotImplementedException();
        }

        private void NakovJediPic_Click(object sender, EventArgs e)
        {

        }

        private void NakovJediPic_MouseHover(object sender, EventArgs e)
        {
            NakovJediPic.Cursor = Cursors.Hand;
        }
        private void NakovLabel_TextChanged(object sender, EventArgs e)
        {
        }
        private void NakovLabel_MouseHover(object sender, EventArgs e)
        {
            NakovLabel.Cursor = Cursors.UpArrow;
        }
        private void NakovJediPic_MouseDown(object sender, MouseEventArgs e)
        {
            this.Character = 1;
            NakovJediPic.Hide();
        }




        private void AngelJediPic_Click(object sender, EventArgs e)
        {
            
        }
        private void AngelSecond_Click(object sender, EventArgs e)
        {   
        }
        private void AngelLabel_TextChanged(object sender, EventArgs e)
        {
        }
        private void AngelJediPic_MouseHover(object sender, EventArgs e)
        {
            AngelJediPic.Cursor = Cursors.Hand;
        }
        private void AngelLabel_MouseHover(object sender, EventArgs e)
        {
            AngelLabel.Cursor = Cursors.UpArrow;
        }
        private void AngelJediPic_MouseDown(object sender, MouseEventArgs e)
        {
            this.Character = 2;
            AngelJediPic.Hide();
        }




        private void RoyalJediPic_Click_1(object sender, EventArgs e)
        {
            
        }
        private void RoyalSecond_Click(object sender, EventArgs e)
        {
        }
        private void RoyalLabel_TextChanged(object sender, EventArgs e)
        {
        }
        private void RoyalLabel_MouseHover(object sender, EventArgs e)
        {
            textBox5.Cursor = Cursors.UpArrow;
        }
        private void RoyalJediPic_MouseHover_1(object sender, EventArgs e)
        {
            RoyalJediPic.Cursor = Cursors.Hand;
        }
        private void RoyalJediPic_MouseDown(object sender, MouseEventArgs e)
        {
            this.Character = 3;
            RoyalJediPic.Hide();
        }




        private void NaskoJediPic_Click(object sender, EventArgs e)
        {
            
        }
        private void NaskoSecond_Click(object sender, EventArgs e)
        {
        }
        private void NaskoLabel_TextChanged(object sender, EventArgs e)
        {
        }
        private void NaskoLabel_MouseHover(object sender, EventArgs e)
        {
            NaskoLabel.Cursor = Cursors.UpArrow;
        }
        private void NaskoJediPic_MouseHover(object sender, EventArgs e)
        {
            NaskoJediPic.Cursor = Cursors.Hand;
        }
        private void NaskoJediPic_MouseDown(object sender, MouseEventArgs e)
        {
            this.Character = 4;
            NaskoJediPic.Hide();
        }




        private void TrifonJediPic_Click(object sender, EventArgs e)
        {

        }
        private void TrifonSecond_Click(object sender, EventArgs e)
        {
        }
        private void TrifonLabel_TextChanged(object sender, EventArgs e)
        {
        }
        private void TrifonLabel_MouseHover(object sender, EventArgs e)
        {
            TrifonLabel.Cursor = Cursors.UpArrow;
        }
        private void TrifonJediPic_MouseHover(object sender, EventArgs e)
        {
            TrifonJediPic.Cursor = Cursors.Hand;
        }
        private void TrifonJediPic_MouseDown(object sender, MouseEventArgs e)
        {
            this.AssistantCharacter = 2;
            TrifonJediPic.Hide();
        }



        private void EdoSecond_Click(object sender, EventArgs e)
        {
        }
        private void EdoJediPic_MouseHover(object sender, EventArgs e)
        {
            EdoJediPic.Cursor = Cursors.Hand;
        }
        private void EdoLabel_TextChanged(object sender, EventArgs e)
        {
        }
        private void EdoLabel_MouseHover(object sender, EventArgs e)
        {
            EdoLabel.Cursor = Cursors.UpArrow;
        }
        private void EdoJediPic_MouseDown(object sender, MouseEventArgs e)
        {
            this.AssistantCharacter = 1;
            EdoJediPic.Hide();
        }
    }
}
