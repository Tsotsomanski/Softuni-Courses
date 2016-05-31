using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class EndScreen : Form
    {
        private Image image;
        public EndScreen()
        {
            InitializeComponent();

        }

        public void LoserScreen()
        {
            EndScreenImageInit();
        }

        public void WinnerScreen()
        {
            EndScreenForWinner();
        }

        private void EndScreenForWinner()
        {
            if (Paduin.FinalPaduinCharacter == 1)
            {
                image = Image.FromFile(@"..\..\Resources\PaduinsWin\SevginWin.jpg");
                EndScreenImage.Image = image;
                EndScreenImage.Height = image.Height;
                EndScreenImage.Width = image.Width;
            }
            else if (Paduin.FinalPaduinCharacter == 2)
            {
                image = Image.FromFile(@"..\..\Resources\PaduinsWin\QanchoWin.jpg");
                EndScreenImage.Image = image;
                EndScreenImage.Height = image.Height;
                EndScreenImage.Width = image.Width;
            }
            else if (Paduin.FinalPaduinCharacter == 3)
            {
                image = Image.FromFile(@"..\..\Resources\PaduinsWin\SashoWin.jpg");
                EndScreenImage.Image = image;
                EndScreenImage.Height = image.Height;
                EndScreenImage.Width = image.Width;
            }
            else if (Paduin.FinalPaduinCharacter == 4)
            {
                image = Image.FromFile(@"..\..\Resources\PaduinsWin\JanWIn.jpg");
                EndScreenImage.Image = image;
                EndScreenImage.Height = image.Height;
                EndScreenImage.Width = image.Width;
            }
        }
        private void EndScreenImageInit()
        {
            if (Jedi.FinalCharacter == 1 && Jedi.FinalAssistantCharacter == 1)
            {
                image = Image.FromFile(@"..\..\Resources\JedisWin\Nakov,Edo.jpg");
                EndScreenImage.Image = image;
                EndScreenImage.Height = image.Height;
                EndScreenImage.Width = image.Width;
            }
            else if (Jedi.FinalCharacter == 2 && Jedi.FinalAssistantCharacter == 1)
            {
                image = Image.FromFile(@"..\..\Resources\JedisWin\Acho,Edo.jpg");
                EndScreenImage.Image = image;
                EndScreenImage.Height = image.Height;
                EndScreenImage.Width = image.Width;
            }
            else if (Jedi.FinalCharacter == 3 && Jedi.FinalAssistantCharacter == 1)
            {
                image = Image.FromFile(@"..\..\Resources\JedisWin\Royal,Edo.jpg");
                EndScreenImage.Image = image;
                EndScreenImage.Height = image.Height;
                EndScreenImage.Width = image.Width;
            }
            else if (Jedi.FinalCharacter == 4 && Jedi.FinalAssistantCharacter == 1)
            {
                image = Image.FromFile(@"..\..\Resources\JedisWin\Nasko,Edo.jpg");
                EndScreenImage.Image = image;
                EndScreenImage.Height = image.Height;
                EndScreenImage.Width = image.Width;
            }
            else if (Jedi.FinalCharacter == 1 && Jedi.FinalAssistantCharacter == 2)
            {
                image = Image.FromFile(@"..\..\Resources\JedisWin\Nakov,Trifon.jpg");
                EndScreenImage.Image = image;
                EndScreenImage.Height = image.Height;
                EndScreenImage.Width = image.Width;
            }
            else if (Jedi.FinalCharacter == 2 && Jedi.FinalAssistantCharacter == 2)
            {
                image = Image.FromFile(@"..\..\Resources\JedisWin\Acho,Trifon.jpg");
                EndScreenImage.Image = image;
                EndScreenImage.Height = image.Height;
                EndScreenImage.Width = image.Width;
            }
            else if (Jedi.FinalCharacter == 3 && Jedi.FinalAssistantCharacter == 2)
            {
                image = Image.FromFile(@"..\..\Resources\JedisWin\Royal,Trifon.jpg");
                EndScreenImage.Image = image;
                EndScreenImage.Height = image.Height;
                EndScreenImage.Width = image.Width;
            }
            else if (Jedi.FinalCharacter == 4 && Jedi.FinalAssistantCharacter == 2)
            {
                image = Image.FromFile(@"..\..\Resources\JedisWin\Nasko,Trifon.jpg");
                EndScreenImage.Image = image;
                EndScreenImage.Height = image.Height;
                EndScreenImage.Width = image.Width;
            }
        }

        private void EndScreen_Load(object sender, EventArgs e)
        {

        }

        private void EndScreenImage_Click(object sender, EventArgs e)
        {

        }
    }
}
