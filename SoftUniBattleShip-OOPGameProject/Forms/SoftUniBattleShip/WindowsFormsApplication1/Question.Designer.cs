namespace WindowsFormsApplication1
{
    partial class Question
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question));
            this.questionLabel = new System.Windows.Forms.Label();
            this.TrueButton = new System.Windows.Forms.RadioButton();
            this.FalseButton = new System.Windows.Forms.RadioButton();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.Transparent;
            this.questionLabel.Location = new System.Drawing.Point(12, 9);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(569, 118);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Question";
            this.questionLabel.Click += new System.EventHandler(this.questionLabel_Click);
            // 
            // TrueButton
            // 
            this.TrueButton.BackColor = System.Drawing.Color.SpringGreen;
            this.TrueButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.TrueButton.Font = new System.Drawing.Font("Kristen ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrueButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TrueButton.Location = new System.Drawing.Point(12, 149);
            this.TrueButton.Name = "TrueButton";
            this.TrueButton.Size = new System.Drawing.Size(108, 24);
            this.TrueButton.TabIndex = 3;
            this.TrueButton.TabStop = true;
            this.TrueButton.Text = "True";
            this.TrueButton.UseVisualStyleBackColor = false;
            this.TrueButton.CheckedChanged += new System.EventHandler(this.TrueButton_CheckedChanged);
            // 
            // FalseButton
            // 
            this.FalseButton.BackColor = System.Drawing.Color.SpringGreen;
            this.FalseButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FalseButton.Font = new System.Drawing.Font("Kristen ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FalseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FalseButton.Location = new System.Drawing.Point(242, 149);
            this.FalseButton.Name = "FalseButton";
            this.FalseButton.Size = new System.Drawing.Size(106, 24);
            this.FalseButton.TabIndex = 4;
            this.FalseButton.TabStop = true;
            this.FalseButton.Text = "False";
            this.FalseButton.UseVisualStyleBackColor = false;
            this.FalseButton.CheckedChanged += new System.EventHandler(this.FalseButton_CheckedChanged);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.SpringGreen;
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Italic);
            this.Save.Location = new System.Drawing.Point(464, 130);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(117, 58);
            this.Save.TabIndex = 7;
            this.Save.Text = "Give answer";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(593, 200);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.FalseButton);
            this.Controls.Add(this.TrueButton);
            this.Controls.Add(this.questionLabel);
            this.DoubleBuffered = true;
            this.Name = "Question";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question";
            this.Load += new System.EventHandler(this.Question_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.RadioButton TrueButton;
        private System.Windows.Forms.RadioButton FalseButton;
        private System.Windows.Forms.Button Save;
    }
}