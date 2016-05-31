namespace WindowsFormsApplication1
{
    partial class ChooseCharacterScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseCharacterScreen));
            this.JediButton = new System.Windows.Forms.Button();
            this.PaduinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JediButton
            // 
            this.JediButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.JediButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JediButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JediButton.Font = new System.Drawing.Font("Star Jedi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JediButton.Location = new System.Drawing.Point(507, 94);
            this.JediButton.Name = "JediButton";
            this.JediButton.Size = new System.Drawing.Size(122, 45);
            this.JediButton.TabIndex = 0;
            this.JediButton.Text = "Jedi";
            this.JediButton.UseVisualStyleBackColor = false;
            this.JediButton.Click += new System.EventHandler(this.JediButton_Click);
            // 
            // PaduinButton
            // 
            this.PaduinButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PaduinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaduinButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PaduinButton.Font = new System.Drawing.Font("Star Jedi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaduinButton.Location = new System.Drawing.Point(12, 94);
            this.PaduinButton.Name = "PaduinButton";
            this.PaduinButton.Size = new System.Drawing.Size(123, 45);
            this.PaduinButton.TabIndex = 1;
            this.PaduinButton.Text = "Paduin";
            this.PaduinButton.UseVisualStyleBackColor = false;
            this.PaduinButton.Click += new System.EventHandler(this.PaduinButton_Click);
            // 
            // ChooseCharacterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(654, 204);
            this.Controls.Add(this.PaduinButton);
            this.Controls.Add(this.JediButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ChooseCharacterScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Character";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button JediButton;
        private System.Windows.Forms.Button PaduinButton;
    }
}