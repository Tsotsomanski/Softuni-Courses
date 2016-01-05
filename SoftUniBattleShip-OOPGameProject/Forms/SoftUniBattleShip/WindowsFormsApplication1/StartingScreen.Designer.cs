namespace WindowsFormsApplication1
{
    partial class StartingScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingScreen));
            this.button1 = new System.Windows.Forms.Button();
            this.InstructionsButton = new System.Windows.Forms.Button();
            this.CharacterTypeButton = new System.Windows.Forms.Button();
            this.ChooseCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Star Jedi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InstructionsButton
            // 
            this.InstructionsButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.InstructionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InstructionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InstructionsButton.Font = new System.Drawing.Font("Star Jedi", 14.25F);
            this.InstructionsButton.Location = new System.Drawing.Point(525, 136);
            this.InstructionsButton.Name = "InstructionsButton";
            this.InstructionsButton.Size = new System.Drawing.Size(171, 36);
            this.InstructionsButton.TabIndex = 1;
            this.InstructionsButton.Text = "instructions";
            this.InstructionsButton.UseVisualStyleBackColor = false;
            this.InstructionsButton.Click += new System.EventHandler(this.InstructionsButton_Click);
            // 
            // CharacterTypeButton
            // 
            this.CharacterTypeButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CharacterTypeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CharacterTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CharacterTypeButton.Font = new System.Drawing.Font("Star Jedi", 14.25F);
            this.CharacterTypeButton.Location = new System.Drawing.Point(525, 30);
            this.CharacterTypeButton.Name = "CharacterTypeButton";
            this.CharacterTypeButton.Size = new System.Drawing.Size(171, 36);
            this.CharacterTypeButton.TabIndex = 2;
            this.CharacterTypeButton.Text = "Character";
            this.CharacterTypeButton.UseVisualStyleBackColor = false;
            this.CharacterTypeButton.Click += new System.EventHandler(this.CharacterTypeButton_Click);
            // 
            // ChooseCategory
            // 
            this.ChooseCategory.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ChooseCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChooseCategory.Font = new System.Drawing.Font("Star Jedi", 14.25F);
            this.ChooseCategory.Location = new System.Drawing.Point(12, 136);
            this.ChooseCategory.Name = "ChooseCategory";
            this.ChooseCategory.Size = new System.Drawing.Size(134, 36);
            this.ChooseCategory.TabIndex = 3;
            this.ChooseCategory.Text = "Category";
            this.ChooseCategory.UseVisualStyleBackColor = false;
            this.ChooseCategory.Click += new System.EventHandler(this.ChooseCategory_Click);
            // 
            // StartingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(710, 206);
            this.Controls.Add(this.ChooseCategory);
            this.Controls.Add(this.CharacterTypeButton);
            this.Controls.Add(this.InstructionsButton);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "StartingScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftUniBattleShip";
            this.Load += new System.EventHandler(this.StartingScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button InstructionsButton;
        private System.Windows.Forms.Button CharacterTypeButton;
        private System.Windows.Forms.Button ChooseCategory;
    }
}

