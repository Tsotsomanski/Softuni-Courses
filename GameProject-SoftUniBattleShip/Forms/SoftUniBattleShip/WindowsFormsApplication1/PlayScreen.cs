using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    using Interface;
    using Interface.IJedi;
    using Interface.IJedi.IAssistants;
    using Interface.IPadaun.IPaduinStudents;
    using Jedis;
    using Paduins.Paduin;

    public partial class PlayScreen : Form
    {
        private Question q;
        private PlayScreen playScreen;
        private int x;
        private int y;

        private IJedi jedi;
        private IPaduin paduinCharacter;
        private IAssistants assistantsJedi;

        private int assistantDrunkScore;
        private int paduinDrunkScore;
        private int jediDrunkScore;
        private int paduinKnowledgeScore;

        private Timer timer = new Timer();
        private Direction directionCharacter;
        private Direction directionAssistant;
        private Direction directionPaduin;
        private Direction lastPaduinDirection;
        private Direction directionBeer;
        private Image image;

        private Direction directionCategory1 = Direction.None;
        private Direction directionCategory2 = Direction.None;
        private Direction directionCategory3 = Direction.None;
        private Direction directionCategory4 = Direction.None;
        private Direction directionCategory5 = Direction.None;
        private Direction directionCategory6 = Direction.None;
        private Direction directionCategory7 = Direction.None;
        private Direction directionCategory8 = Direction.None;
        private Direction directionCategory9 = Direction.None;
        private Direction directionCategory10 = Direction.None;
        private Direction directionCategory11 = Direction.None;


        public PlayScreen()
        {
            InitializeComponent();

            this.x = 1;
            this.y = 1;
            this.directionCharacter = Direction.Down;
            this.directionAssistant = Direction.Up;
            this.directionPaduin = Direction.None;
            this.directionBeer = Direction.None;

            this.directionCategory1 = Direction.None;
            this.directionCategory2 = Direction.None;
            this.directionCategory3 = Direction.None;
            this.directionCategory4 = Direction.None;
            this.directionCategory5 = Direction.None;
            this.directionCategory6 = Direction.None;
            this.directionCategory7 = Direction.None;
            this.directionCategory8 = Direction.None;
            this.directionCategory9 = Direction.None;
            this.directionCategory10 = Direction.None;
            this.directionCategory11 = Direction.None;

            this.lastPaduinDirection = Direction.Left;

            this.pictureBox3.Visible = false;
            this.pictureBox4.Visible = false;
            this.pictureBox5.Visible = false;
            this.pictureBox6.Visible = false;
            this.pictureBox7.Visible = false;
            this.pictureBox8.Visible = false;
            this.pictureBox9.Visible = false;
            this.pictureBox10.Visible = false;
            this.pictureBox11.Visible = false;
            this.pictureBox12.Visible = false;
            this.pictureBox13.Visible = false;
            this.beerBox.Visible = false;

            this.timer.Interval = 15;
            this.timer.Tick += timerCharacter_Tick;
            this.timer.Start();
        }
        
        //Walls
        private void WallsInitialization()
        {
            Image image = Image.FromFile(@"..\..\Resources\RedSwordOffRightUpOfficial.png");
            Image image2 = Image.FromFile(@"..\..\Resources\RedSwordOffRightUpOfficial.png");

            Image image5 = Image.FromFile(@"..\..\Resources\RedSwordOffRightDown.png");
            Image image4 = Image.FromFile(@"..\..\Resources\RedSwordOffRightUpOfficial.png");

            Image image3 = Image.FromFile(@"..\..\Resources\beer.png");
            beerBox.Image = image3;
            beerBox.Height = image3.Height;
            beerBox.Width = image3.Width;
        }
        
       
        private void JediInitialization()
        {
             //Jedi
            if (Jedi.FinalCharacter == 1)
            {
                this.jedi = JediFactory.CreatJedi(JediType.JoNakov);
                JediImageValidation(this.jedi, enemyBox);
            }
            else if (Jedi.FinalCharacter == 2)
            {
                this.jedi = JediFactory.CreatJedi(JediType.AchoUanKenobi);
                JediImageValidation(jedi, enemyBox);
            }
            else if (Jedi.FinalCharacter == 3)
            {
                this.jedi = JediFactory.CreatJedi(JediType.RoyalSkyWalker);
                JediImageValidation(jedi, enemyBox);
            }
            else if (Jedi.FinalCharacter == 4)
            {
                this.jedi = JediFactory.CreatJedi(JediType.NaskoSolo);
                JediImageValidation(jedi, enemyBox);
            }

            //AssistentJedi
            if (Jedi.FinalAssistantCharacter == 1)
            {
                this.assistantsJedi = AssistantJediFactory.CreateJediАsistant(AssistantJediType.ChubiEdo);
                AssistantImageValidation(this.assistantsJedi, pictureBox1);

            }
            else if (Jedi.FinalAssistantCharacter == 2)
            {
                this.assistantsJedi = AssistantJediFactory.CreateJediАsistant(AssistantJediType.R2Trifon2);
                AssistantImageValidation(this.assistantsJedi, pictureBox1);
            }
        }

        private void PictureQuestionInitialization()
        {
            if (ChooseCategoryScreen.GetFinalCategory() == "Csharp")
            {
                this.image = Image.FromFile(@"..\..\Resources\Csharp.png");
                CategoryValidation(this.image);
            }
            else if (ChooseCategoryScreen.GetFinalCategory() == "Java")
            {
                this.image = Image.FromFile(@"..\..\Resources\Java.png");
                CategoryValidation(this.image);
            }
            else if (ChooseCategoryScreen.GetFinalCategory() == "Cpp")
            {
                this.image = Image.FromFile(@"..\..\Resources\Cplusplus.png");
                CategoryValidation(this.image);
            }
            else if (ChooseCategoryScreen.GetFinalCategory() == "OOP")
            {
                this.image = Image.FromFile(@"..\..\Resources\Oop.png");
                CategoryValidation(this.image);
            }
        }

        private void PaduanInitialization()
        {
            if (Paduin.FinalPaduinCharacter == 1)
            {
                this.paduinCharacter = new CountSevgin();
                PaduinImageValidation(this.paduinCharacter, paduin);
            }
            else if (Paduin.FinalPaduinCharacter == 2)
            {
                this.paduinCharacter = new Karnobatman();
                PaduinImageValidation(this.paduinCharacter, paduin);
            }
            else if (Paduin.FinalPaduinCharacter == 3)
            {
                this.paduinCharacter = new SashoFett();
                PaduinImageValidation(this.paduinCharacter, paduin);
            }
            else if (Paduin.FinalPaduinCharacter == 4)
            {
                this.paduinCharacter = new WightJan();
                PaduinImageValidation(this.paduinCharacter, paduin);
            }
        }

        private void BeerInitialization()
        {
            try
            {
                Image image = Image.FromFile(@"..\..\Resources\Beer.png");
                pictureBox11.Image = image;
                pictureBox11.Width = image.Width;
                pictureBox11.Height = image.Height;
                pictureBox12.Image = image;
                pictureBox12.Width = image.Width;
                pictureBox12.Height = image.Height;
                pictureBox13.Image = image;
                pictureBox13.Width = image.Width;
                pictureBox13.Height = image.Height;
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("The beer path is not in the correct format");
            }
        }

        private void PlayScreen_Load(object sender, EventArgs e)
        {
            JediInitialization();

            PictureQuestionInitialization();

            PaduanInitialization();

            WallsInitialization();

            BeerInitialization();
        }

        private void timerCharacter_Tick(object sender, EventArgs e)
        {
            if (paduinKnowledgeScore >= 100)
            {
                paduinKnowledgeScore = 100;
            }
            if (paduinDrunkScore >= 100)
            {
                paduinDrunkScore = 100;
            }
            if (jediDrunkScore >= 100)
            {
                jediDrunkScore = 100;
            }
            if (assistantDrunkScore >= 100)
            {
                assistantDrunkScore = 100;
            }

            this.paduinKnowledge.Text = String.Format("Paduin Knowledge : {0} %", this.paduinKnowledgeScore);
            this.jediDrunk.Text = String.Format("Jedi Drunk : {0} %", this.jediDrunkScore);
            this.assistantDrunk.Text = String.Format("Assistant Drunk : {0} %", this.assistantDrunkScore);
            this.paduinDrunk.Text = String.Format("Paduin Drunk : {0} %", this.paduinDrunkScore);

            if (this.jediDrunkScore == 100 || this.paduinKnowledgeScore == 100)
            {
                JediIsDrunk();
            }
            if (this.assistantDrunkScore == 100 || this.paduinDrunkScore == 100)
            {
                AssistantIsDrunk();
            }

            //Games End 
            if (this.paduinKnowledgeScore == 100 && this.paduinDrunkScore == 100)
            {
                timer.Stop();
                Hide();
                EndScreen end = new EndScreen();
                end.LoserScreen();
                end.ShowDialog();
                Close();
            }
            else if (this.jediDrunkScore == 100 && this.assistantDrunkScore == 100)
            {
                timer.Stop();
                Hide();
                EndScreen end = new EndScreen();
                end.WinnerScreen();
                end.ShowDialog();
                Close();
            }


            AskQuestion();

            if (this.pictureBox4.Bounds.IntersectsWith(this.paduin.Bounds))
            {
                this.paduinKnowledgeScore = this.paduinKnowledgeScore + this.jedi.PointsDamage;
                this.directionCategory2 = Direction.None;
                this.pictureBox4.Hide();
                this.pictureBox4.Location = new Point(this.pictureBox4.Location.X - this.paduin.Location.X + 60, this.pictureBox4.Location.Y);
            }

            if (this.pictureBox5.Bounds.IntersectsWith(this.paduin.Bounds))
            {
                this.paduinKnowledgeScore = this.paduinKnowledgeScore + this.jedi.PointsDamage;
                this.directionCategory3 = Direction.None;
                this.pictureBox5.Hide();
                this.pictureBox5.Location = new Point(this.pictureBox5.Location.X - this.paduin.Location.X + 60, this.pictureBox5.Location.Y);
            }

            if (this.pictureBox7.Bounds.IntersectsWith(this.paduin.Bounds))
            {
                this.paduinKnowledgeScore = this.paduinKnowledgeScore + this.jedi.PointsDamage;
                this.directionCategory5 = Direction.None;
                this.pictureBox7.Hide();
                this.pictureBox7.Location = new Point(this.pictureBox7.Location.X - this.paduin.Location.X + 60, this.pictureBox7.Location.Y);
            }

            if (this.pictureBox8.Bounds.IntersectsWith(this.paduin.Bounds))
            {
                this.paduinKnowledgeScore = this.paduinKnowledgeScore + this.jedi.PointsDamage;
                this.directionCategory6 = Direction.None;
                this.pictureBox8.Hide();
                this.pictureBox8.Location = new Point(this.pictureBox8.Location.X - this.paduin.Location.X + 60, this.pictureBox8.Location.Y);
            }

            if (this.pictureBox9.Bounds.IntersectsWith(this.paduin.Bounds))
            {
                this.paduinKnowledgeScore = this.paduinKnowledgeScore + this.jedi.PointsDamage;
                this.directionCategory7 = Direction.None;
                this.pictureBox9.Hide();
                this.pictureBox9.Location = new Point(this.pictureBox9.Location.X - this.paduin.Location.X + 60, this.pictureBox9.Location.Y);
            }

            if (this.pictureBox11.Bounds.IntersectsWith(this.paduin.Bounds))
            {
                this.paduinDrunkScore = this.paduinDrunkScore + this.assistantsJedi.AssistantAttack;
                this.directionCategory9 = Direction.None;
                this.pictureBox11.Hide();
                this.pictureBox11.Location = new Point(822, 120);
            }

            if (this.pictureBox12.Bounds.IntersectsWith(this.paduin.Bounds))
            {
                this.paduinDrunkScore = this.paduinDrunkScore + this.assistantsJedi.AssistantAttack;
                this.directionCategory10 = Direction.None;
                this.pictureBox12.Hide();
                this.pictureBox12.Location = new Point(822, 240);
            }
            if (this.pictureBox13.Bounds.IntersectsWith(this.paduin.Bounds))
            {
                this.paduinDrunkScore = this.paduinDrunkScore + this.assistantsJedi.AssistantAttack;
                this.directionCategory11 = Direction.None;
                this.pictureBox13.Hide();
                this.pictureBox13.Location = new Point(822, 400);
            }

            //Paduin Beer hits enemy jedi
            if (this.beerBox.Bounds.IntersectsWith(this.enemyBox.Bounds) ||
                this.beerBox.Left >= 800 || this.beerBox.Left <= 10)
            {
                this.jediDrunkScore = this.jediDrunkScore + this.jedi.KnowledgeDamage;
                this.directionBeer = Direction.None;
                this.beerBox.Hide();
                this.beerBox.Location = new Point(412, 259);
            }

            //Paduin Beer hits enemy assistant
            if (this.beerBox.Bounds.IntersectsWith(this.pictureBox1.Bounds) ||
                this.beerBox.Left >= 800 || this.beerBox.Left <= 10)
            {
                this.assistantDrunkScore = this.assistantDrunkScore + this.assistantsJedi.AssistantAttack;
                this.directionBeer = Direction.None;
                this.beerBox.Hide();
                this.beerBox.Location = new Point(412, 259);
            }

            //First Category
            if (this.enemyBox.Location.Y == this.pictureBox3.Location.Y)
            {
                this.pictureBox3.Visible = true;
                this.pictureBox3.Location = new Point(this.pictureBox3.Location.X, this.pictureBox3.Location.Y);
                this.directionCategory1 = Direction.Right;
            }
            if (this.pictureBox3.Left >= 740)
            {
                this.directionCategory1 = Direction.None;
                this.pictureBox3.Hide();
                this.pictureBox3.Location = new Point(this.pictureBox3.Location.X - 720, this.pictureBox3.Location.Y);
            }

            //Second Category
            if (this.enemyBox.Location.Y == this.pictureBox4.Location.Y)
            {
                this.pictureBox4.Visible = true;
                this.pictureBox4.Location = new Point(this.pictureBox4.Location.X, this.pictureBox4.Location.Y);
                this.directionCategory2 = Direction.Right;
            }
            if (this.pictureBox4.Left >= 740)
            {
                this.directionCategory2 = Direction.None;
                this.pictureBox4.Hide();
                this.pictureBox4.Location = new Point(this.pictureBox4.Location.X - 720, this.pictureBox4.Location.Y);
            }

            //Third Category
            if (this.enemyBox.Location.Y == this.pictureBox5.Location.Y)
            {
                this.pictureBox5.Visible = true;
                this.pictureBox5.Location = new Point(this.pictureBox5.Location.X, this.pictureBox5.Location.Y);
                this.directionCategory3 = Direction.Right;
            }
            if (this.pictureBox5.Left >= 740)
            {
                this.directionCategory3 = Direction.None;
                this.pictureBox5.Hide();
                this.pictureBox5.Location = new Point(this.pictureBox5.Location.X - 720, this.pictureBox5.Location.Y);
            }


            //Forth Category 
            if (this.enemyBox.Location.Y == this.pictureBox6.Location.Y)
            {
                this.pictureBox6.Visible = true;
                this.pictureBox6.Location = new Point(this.pictureBox6.Location.X, this.pictureBox6.Location.Y);
                this.directionCategory4 = Direction.Right;
            }
            if (this.pictureBox6.Left >= 740)
            {
                this.directionCategory4 = Direction.None;
                this.pictureBox6.Hide();
                this.pictureBox6.Location = new Point(this.pictureBox6.Location.X - 720, this.pictureBox6.Location.Y);
            }

            //Fifth Category
            if (this.enemyBox.Location.Y == this.pictureBox7.Location.Y)
            {
                this.pictureBox7.Visible = true;
                this.pictureBox7.Location = new Point(this.pictureBox7.Location.X, this.pictureBox7.Location.Y);
                this.directionCategory5 = Direction.Right;
            }
            if (this.pictureBox7.Left >= 740)
            {
                this.directionCategory5 = Direction.None;
                this.pictureBox7.Hide();
                this.pictureBox7.Location = new Point(this.pictureBox7.Location.X - 720, this.pictureBox7.Location.Y);
            }

            //Sixth Category
            if (this.enemyBox.Location.Y == this.pictureBox8.Location.Y)
            {
                this.pictureBox8.Visible = true;
                this.pictureBox8.Location = new Point(this.pictureBox8.Location.X, this.pictureBox8.Location.Y);
                this.directionCategory6 = Direction.Right;
            }
            if (this.pictureBox8.Left >= 740)
            {
                this.directionCategory6 = Direction.None;
                this.pictureBox8.Hide();
                this.pictureBox8.Location = new Point(this.pictureBox8.Location.X - 720, this.pictureBox8.Location.Y);
            }

            //Seventh Category
            if (this.enemyBox.Location.Y == this.pictureBox9.Location.Y)
            {
                this.pictureBox9.Visible = true;
                this.pictureBox9.Location = new Point(this.pictureBox9.Location.X, this.pictureBox9.Location.Y);
                this.directionCategory7 = Direction.Right;
            }
            if (this.pictureBox9.Left >= 740)
            {
                this.directionCategory7 = Direction.None;
                this.pictureBox9.Hide();
                this.pictureBox9.Location = new Point(this.pictureBox9.Location.X - 720, this.pictureBox9.Location.Y);
            }

            //Eight Category
            if (this.enemyBox.Location.Y == this.pictureBox10.Location.Y)
            {
                this.pictureBox10.Visible = true;
                this.pictureBox10.Location = new Point(this.pictureBox10.Location.X, this.pictureBox10.Location.Y);
                this.directionCategory8 = Direction.Right;
            }
            if (this.pictureBox10.Left >= 740)
            {
                this.directionCategory8 = Direction.None;
                this.pictureBox10.Hide();
                this.pictureBox10.Location = new Point(this.pictureBox10.Location.X - 720, this.pictureBox10.Location.Y);
            }

            //BeerOne Category
            if (this.pictureBox1.Location.Y == this.pictureBox11.Location.Y)
            {
                this.pictureBox11.Visible = true;
                this.pictureBox11.Location = new Point(this.pictureBox11.Location.X, this.pictureBox11.Location.Y);
                this.directionCategory9 = Direction.Left;
            }
            if (this.pictureBox11.Left <= 100)
            {
                this.directionCategory9 = Direction.None;
                this.pictureBox11.Hide();
                this.pictureBox11.Location = new Point(822, 120);
            }

            //BeerTwo Category
            if (this.pictureBox1.Location.Y == this.pictureBox12.Location.Y)
            {
                this.pictureBox12.Visible = true;
                this.pictureBox12.Location = new Point(this.pictureBox12.Location.X, this.pictureBox12.Location.Y);
                this.directionCategory10 = Direction.Left;
            }
            if (this.pictureBox12.Left <= 100)
            {
                this.directionCategory10 = Direction.None;
                this.pictureBox12.Hide();
                this.pictureBox12.Location = new Point(822, 240);
            }
            //BeerThree Category
            if (this.pictureBox1.Location.Y == this.pictureBox13.Location.Y)
            {
                this.pictureBox13.Visible = true;
                this.pictureBox13.Location = new Point(this.pictureBox13.Location.X, this.pictureBox13.Location.Y);
                this.directionCategory11 = Direction.Left;
            }
            if (this.pictureBox13.Left <= 100)
            {
                this.directionCategory11 = Direction.None;
                this.pictureBox13.Hide();
                this.pictureBox13.Location = new Point(822, 400);
            }

            //Paduins Direction
            this.PaduinDirectionsMethod();

            //Category direction - only Right
            this.CategoriesDirectionMethod();

            //Jedi Character direction - only Up and Down
            this.JediDirectionsMethod();

            //Assistant direction - only Up and Down
            this.AssistantDirectionsMethod();

            //Beer direction
            if (this.directionBeer == Direction.Right)
            {
                beerBox.Left += 5;
            }
            else if (this.directionBeer == Direction.Left)
            {
                beerBox.Left -= 5;
            }

            Invalidate();
        }

        private void AssistantIsDrunk()
        {
            this.directionCategory9 = Direction.None;
            this.directionCategory10 = Direction.None;
            this.directionCategory11 = Direction.None;
            this.pictureBox13.Visible = false;
            this.pictureBox12.Visible = false;
            this.pictureBox11.Visible = false;
        }

        private void JediIsDrunk()
        {
            this.directionCategory1 = Direction.None;
            this.directionCategory2 = Direction.None;
            this.directionCategory3 = Direction.None;
            this.directionCategory4 = Direction.None;
            this.directionCategory5 = Direction.None;
            this.directionCategory6 = Direction.None;
            this.directionCategory7 = Direction.None;
            this.directionCategory8 = Direction.None;
            this.pictureBox3.Visible = false;
            this.pictureBox4.Visible = false;
            this.pictureBox5.Visible = false;
            this.pictureBox6.Visible = false;
            this.pictureBox7.Visible = false;
            this.pictureBox8.Visible = false;
            this.pictureBox9.Visible = false;
            this.pictureBox10.Visible = false;
        }

        private void AskQuestion()
        {
            if (this.pictureBox3.Bounds.IntersectsWith(this.paduin.Bounds))
            {
                this.timer.Stop();
                this.q = new Question();
                this.q.ShowDialog();

                if (Question.FinalAnswer == 1)
                {
                    this.directionCategory1 = Direction.None;
                    this.pictureBox3.Hide();
                    this.pictureBox3.Location = new Point(this.pictureBox3.Location.X - this.paduin.Location.X + 60,
                        this.pictureBox3.Location.Y);
                    this.timer.Start();
                }
                else if (Question.FinalAnswer == 2)
                {
                    this.directionCategory1 = Direction.None;
                    this.pictureBox3.Hide();
                    this.pictureBox3.Location = new Point(this.pictureBox3.Location.X - this.paduin.Location.X + 60,
                        this.pictureBox3.Location.Y);
                    this.paduinKnowledgeScore = this.paduinKnowledgeScore + 30;
                    this.timer.Start();
                }
            }
            if (this.pictureBox6.Bounds.IntersectsWith(this.paduin.Bounds))
            {
                this.timer.Stop();
                this.q = new Question();
                this.q.ShowDialog();

                if (Question.FinalAnswer == 1)
                {
                    this.directionCategory4 = Direction.None;
                    this.pictureBox6.Hide();
                    this.pictureBox6.Location = new Point(this.pictureBox6.Location.X - this.paduin.Location.X + 60,
                        this.pictureBox6.Location.Y);
                    this.timer.Start();
                }
                else if (Question.FinalAnswer == 2)
                {
                    this.directionCategory4 = Direction.None;
                    this.pictureBox6.Hide();
                    this.pictureBox6.Location = new Point(this.pictureBox6.Location.X - this.paduin.Location.X + 60,
                        this.pictureBox6.Location.Y);
                    this.paduinKnowledgeScore = this.paduinKnowledgeScore + 30;
                    this.timer.Start();
                }
            }
            if (this.pictureBox10.Bounds.IntersectsWith(this.paduin.Bounds))
            {
                this.timer.Stop();
                this.q = new Question();
                this.q.ShowDialog();

                if (Question.FinalAnswer == 1)
                {
                    this.directionCategory8 = Direction.None;
                    this.pictureBox10.Hide();
                    this.pictureBox10.Location = new Point(this.pictureBox10.Location.X - this.paduin.Location.X + 60,
                        this.pictureBox10.Location.Y);
                    this.timer.Start();
                }
                else if (Question.FinalAnswer == 2)
                {
                    this.directionCategory8 = Direction.None;
                    this.pictureBox10.Hide();
                    this.pictureBox10.Location = new Point(this.pictureBox10.Location.X - this.paduin.Location.X + 60,
                        this.pictureBox10.Location.Y);
                    this.paduinKnowledgeScore = this.paduinKnowledgeScore + 30;
                    this.timer.Start();
                }
            }
        }

        private void AssistantDirectionsMethod()
        {
            if (this.directionAssistant == Direction.Up)
            {
                this.pictureBox1.Top -= 2;
                if (this.pictureBox1.Top <= 30)
                {
                    this.directionAssistant = Direction.Down;
                }
            }

            if (this.directionAssistant == Direction.Down)
            {
                this.pictureBox1.Top += 2;
                if (this.pictureBox1.Top >= 460)
                {
                    this.directionAssistant = Direction.Up;
                }
            }
        }

        private void JediDirectionsMethod()
        {
            if (this.directionCharacter == Direction.Up)
            {
                this.enemyBox.Top -= 2;
                if (this.enemyBox.Top <= 30)
                {
                    this.directionCharacter = Direction.Down;
                }
            }
            if (this.directionCharacter == Direction.Down)
            {
                this.enemyBox.Top += 2;
                if (this.enemyBox.Top >= 460)
                {
                    this.directionCharacter = Direction.Up;
                }
            }
        }

        private void CategoriesDirectionMethod()
        {
            if (this.directionCategory1 == Direction.Right)
            {
                this.pictureBox3.Left += 4;
            }

            if (this.directionCategory2 == Direction.Right)
            {
                this.pictureBox4.Left += 4;
            }

            if (this.directionCategory3 == Direction.Right)
            {
                this.pictureBox5.Left += 4;
            }

            if (this.directionCategory4 == Direction.Right)
            {
                this.pictureBox6.Left += 4;
            }

            if (this.directionCategory5 == Direction.Right)
            {
                this.pictureBox7.Left += 4;
            }

            if (this.directionCategory6 == Direction.Right)
            {
                this.pictureBox8.Left += 4;
            }

            if (this.directionCategory7 == Direction.Right)
            {
                this.pictureBox9.Left += 4;
            }

            if (this.directionCategory8 == Direction.Right)
            {
                this.pictureBox10.Left += 4;
            }

            if (this.directionCategory9 == Direction.Left)
            {
                this.pictureBox11.Left -= 4;
            }

            if (this.directionCategory10 == Direction.Left)
            {
                this.pictureBox12.Left -= 4;
            }
            if (this.directionCategory11 == Direction.Left)
            {
                this.pictureBox13.Left -= 4;
            }
        }

        private void PaduinDirectionsMethod()
        {
            if (this.directionPaduin == Direction.Right)
            {
                this.paduin.Left += 4;
                if (this.paduin.Left >= 750)
                {
                    this.paduin.Left = 700;
                    this.directionPaduin = Direction.Left;
                }
            }
            if (this.directionPaduin == Direction.Left)
            {
                this.paduin.Left -= 4;
                if (this.paduin.Left <= 90)
                {
                    this.paduin.Left = 150;
                    this.directionPaduin = Direction.Right;
                }
            }
            if (this.directionPaduin == Direction.Up)
            {
                this.paduin.Top -= 4;
                if (this.paduin.Top <= 75)
                {
                    this.paduin.Top = 105;
                    this.directionPaduin = Direction.Down;
                }
            }
            if (this.directionPaduin == Direction.Down)
            {
                this.paduin.Top += 4;
                if (this.paduin.Top >= 450)
                {
                    this.paduin.Top = 400;
                    this.directionPaduin = Direction.Up;
                }
            }
        }

        private void PlayScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                this.directionPaduin = Direction.Down;
            }
            if (e.KeyCode == Keys.Up)
            {
                this.directionPaduin = Direction.Up;
            }
            if (e.KeyCode == Keys.Left)
            {
                this.lastPaduinDirection = Direction.Left;
                this.directionPaduin = Direction.Left;
            }
            if (e.KeyCode == Keys.Right)
            {
                this.lastPaduinDirection = Direction.Right;
                this.directionPaduin = Direction.Right;
            }
            if (e.KeyCode == Keys.Space)
            {
                this.beerBox.Visible = true;
                if (this.directionPaduin == Direction.Right || this.lastPaduinDirection == Direction.Right)
                {
                    this.beerBox.Location = new Point(this.paduin.Location.X + 30, this.paduin.Location.Y);
                    this.directionBeer = Direction.Right;
                }
                else if (this.directionPaduin == Direction.Left || this.lastPaduinDirection == Direction.Left)
                {
                    this.beerBox.Location = new Point(this.paduin.Location.X - 30, this.paduin.Location.Y);
                    this.directionBeer = Direction.Left;
                }
            }
        }

        private void Picture(Image image)
        {
            this.pictureBox3.Image = image;
            this.pictureBox3.Height = image.Height;
            this.pictureBox3.Width = image.Width;
            this.pictureBox4.Image = image;
            this.pictureBox4.Height = image.Height;
            this.pictureBox4.Width = image.Width;
            this.pictureBox5.Image = image;
            this.pictureBox5.Height = image.Height;
            this.pictureBox5.Width = image.Width;
            this.pictureBox6.Image = image;
            this.pictureBox6.Height = image.Height;
            this.pictureBox6.Width = image.Width;
            this.pictureBox7.Image = image;
            this.pictureBox7.Height = image.Height;
            this.pictureBox7.Width = image.Width;
            this.pictureBox8.Image = image;
            this.pictureBox8.Height = image.Height;
            this.pictureBox8.Width = image.Width;
            this.pictureBox9.Image = image;
            this.pictureBox9.Height = image.Height;
            this.pictureBox9.Width = image.Width;
            this.pictureBox10.Image = image;
            this.pictureBox10.Height = image.Height;
            this.pictureBox10.Width = image.Width;
            this.pictureBox11.Image = image;
            this.pictureBox11.Height = image.Height;
            this.pictureBox11.Width = image.Width;
            this.pictureBox12.Image = image;
            this.pictureBox12.Height = image.Height;
            this.pictureBox12.Width = image.Width;
        }
        
        private void PaduinImageValidation(IPaduin paduinCharacter, PictureBox paduin)
        {
            try
            {
                image = Image.FromFile(paduinCharacter.CharacterImage);

                paduin.Image = image;
                paduin.Height = image.Height;
                paduin.Width = image.Width;
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("The path of " + paduinCharacter.GetType().Name + " is not in the correct format !");
            }
        }
        private void JediImageValidation(IJedi jediCharacter, PictureBox paduin)
        {
            try
            {
                image = Image.FromFile(jediCharacter.CharacterImage);

                paduin.Image = image;
                paduin.Height = image.Height;
                paduin.Width = image.Width;
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("The path of " + jediCharacter.GetType().Name + " is not in the correct format !");
            }
        }
        private void AssistantImageValidation(IAssistants assistantCharacter, PictureBox paduin)
        {
            try
            {
                image = Image.FromFile(assistantCharacter.CharacterImage);

                paduin.Image = image;
                paduin.Height = image.Height;
                paduin.Width = image.Width;
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("The path of " + assistantCharacter.GetType().Name + " is not in the correct format !");
            }
        }

        private void CategoryValidation(Image image)
        {
            try
            {
                Picture(image);
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("The category path is not in the correct format !");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click_1(object sender, EventArgs e)
        {

        }
        
        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void paduin_Click(object sender, EventArgs e)
        {

        }

        private void paduinKnowledge_Click(object sender, EventArgs e)
        {

        }

        private void jediDrunk_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void beerBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void paduinDrunk_Click(object sender, EventArgs e)
        {

        }

        private void assistantDrunk_Click(object sender, EventArgs e)
        {

        }
    }
}