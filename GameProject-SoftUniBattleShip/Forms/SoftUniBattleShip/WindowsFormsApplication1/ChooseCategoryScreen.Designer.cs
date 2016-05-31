namespace WindowsFormsApplication1
{
    partial class ChooseCategoryScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseCategoryScreen));
            this.SaveButton = new System.Windows.Forms.Button();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CSharpButton = new System.Windows.Forms.RadioButton();
            this.CPPButton = new System.Windows.Forms.RadioButton();
            this.JavaButton = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveButton.Location = new System.Drawing.Point(526, 130);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(92, 51);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.CategoryLabel.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CategoryLabel.Location = new System.Drawing.Point(66, 21);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(635, 43);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Choose category of the Battle:";
            // 
            // CSharpButton
            // 
            this.CSharpButton.BackColor = System.Drawing.Color.Transparent;
            this.CSharpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CSharpButton.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSharpButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CSharpButton.Location = new System.Drawing.Point(73, 79);
            this.CSharpButton.Name = "CSharpButton";
            this.CSharpButton.Size = new System.Drawing.Size(104, 42);
            this.CSharpButton.TabIndex = 2;
            this.CSharpButton.TabStop = true;
            this.CSharpButton.Text = "C#";
            this.CSharpButton.UseVisualStyleBackColor = false;
            this.CSharpButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // CPPButton
            // 
            this.CPPButton.BackColor = System.Drawing.Color.Transparent;
            this.CPPButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CPPButton.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPPButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CPPButton.Location = new System.Drawing.Point(282, 144);
            this.CPPButton.Name = "CPPButton";
            this.CPPButton.Size = new System.Drawing.Size(104, 48);
            this.CPPButton.TabIndex = 3;
            this.CPPButton.TabStop = true;
            this.CPPButton.Text = "C++";
            this.CPPButton.UseVisualStyleBackColor = false;
            this.CPPButton.CheckedChanged += new System.EventHandler(this.CPPButton_CheckedChanged);
            // 
            // JavaButton
            // 
            this.JavaButton.BackColor = System.Drawing.Color.Transparent;
            this.JavaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JavaButton.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JavaButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.JavaButton.Location = new System.Drawing.Point(72, 144);
            this.JavaButton.Name = "JavaButton";
            this.JavaButton.Size = new System.Drawing.Size(104, 48);
            this.JavaButton.TabIndex = 4;
            this.JavaButton.TabStop = true;
            this.JavaButton.Text = "Java";
            this.JavaButton.UseVisualStyleBackColor = false;
            this.JavaButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton1.Location = new System.Drawing.Point(282, 79);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 42);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "OOP";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // ChooseCategoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(654, 204);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.JavaButton);
            this.Controls.Add(this.CPPButton);
            this.Controls.Add(this.CSharpButton);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ChooseCategoryScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.ChooseCategoryScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.RadioButton CSharpButton;
        private System.Windows.Forms.RadioButton CPPButton;
        private System.Windows.Forms.RadioButton JavaButton;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}