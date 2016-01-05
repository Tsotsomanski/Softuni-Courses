namespace WindowsFormsApplication1
{
    using System;
    using System.Windows.Forms;

    using Quests;

    public partial class Question : Form
    {
        public static int FinalAnswer; //used smwhere else and cannot be converted to string for checking answer
                                       //makes it too complicated... introducing answerAsString for the check

        private string answer;
        private Quest quest;
        private string answerAsString; //used to check playerAnswer - questionAnswer

        public Question()
        {
            InitializeComponent();
        }

        private void Question_Load(object sender, EventArgs e)
        {
            quest = QuestFactory.GenerateQuestOnCategory();
            this.questionLabel.Text = quest.ToString();
        }

        private void TrueButton_CheckedChanged(object sender, EventArgs e)
        {
            this.answerAsString = "true";
        }

        private void FalseButton_CheckedChanged(object sender, EventArgs e)
        {
            this.answerAsString = "false";
        }
        

        private void Save_Click(object sender, EventArgs e)
        {
            //checks the anwer of the question
            if (QuestFactory.CheckAnswer(answerAsString, quest.Answer))
            {
                FinalAnswer = 1;
                MessageBox.Show("CORRECT!"); //logic if correct
            }
            else
            {
                FinalAnswer = 2;
                MessageBox.Show("NOT CORRECT"); //logic if not correct
            }

            Close();
        }

        private void questionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
