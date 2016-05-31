namespace WindowsFormsApplication1
{
    using System;
    using System.Windows.Forms;

    public partial class ChooseCategoryScreen : Form
    {
        private int category = 1;
        private static int finalCategory = 1;

        public ChooseCategoryScreen()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.category = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.category = 2;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Hide();
            StartingScreen ss = new StartingScreen();
            finalCategory = this.category;
            ss.ShowDialog();
            Close();
        }

        private void ChooseCategoryScreen_Load(object sender, EventArgs e)
        {

        }

        private void CPPButton_CheckedChanged(object sender, EventArgs e)
        {
            this.category = 3;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            this.category = 4;
        }
        
        /// <summary>
        /// This method gets the category depending on the player choice
        /// </summary>
        /// <returns>category as string</returns>
        public static string GetFinalCategory()
        {
            string category = null;

            switch (finalCategory)
            {
                case 1:
                    category = "Csharp";
                   break;
                case 2:
                    category = "Java";
                    break;
                case 3:
                    category = "Cpp";
                    break;
                case 4:
                    category = "OOP";
                    break;
            }
            return category;
        }
    }
}
