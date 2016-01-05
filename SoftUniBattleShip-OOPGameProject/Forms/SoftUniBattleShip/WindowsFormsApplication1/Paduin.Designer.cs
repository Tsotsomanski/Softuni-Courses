namespace WindowsFormsApplication1
{
    partial class Paduin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paduin));
            this.label1 = new System.Windows.Forms.Label();
            this.SevginButton = new System.Windows.Forms.RadioButton();
            this.YanchoButton = new System.Windows.Forms.RadioButton();
            this.SashoButton = new System.Windows.Forms.RadioButton();
            this.JanButton = new System.Windows.Forms.RadioButton();
            this.SaveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose your character";
            // 
            // SevginButton
            // 
            this.SevginButton.AutoSize = true;
            this.SevginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SevginButton.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevginButton.ForeColor = System.Drawing.Color.Black;
            this.SevginButton.Location = new System.Drawing.Point(750, 28);
            this.SevginButton.Name = "SevginButton";
            this.SevginButton.Size = new System.Drawing.Size(172, 27);
            this.SevginButton.TabIndex = 1;
            this.SevginButton.TabStop = true;
            this.SevginButton.Text = "Count Sevgin";
            this.SevginButton.UseVisualStyleBackColor = true;
            this.SevginButton.CheckedChanged += new System.EventHandler(this.SevginButton_CheckedChanged);
            // 
            // YanchoButton
            // 
            this.YanchoButton.AutoSize = true;
            this.YanchoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YanchoButton.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YanchoButton.ForeColor = System.Drawing.Color.Black;
            this.YanchoButton.Location = new System.Drawing.Point(489, 28);
            this.YanchoButton.Name = "YanchoButton";
            this.YanchoButton.Size = new System.Drawing.Size(238, 27);
            this.YanchoButton.TabIndex = 2;
            this.YanchoButton.TabStop = true;
            this.YanchoButton.Text = "Karnobatman Bane";
            this.YanchoButton.UseVisualStyleBackColor = true;
            this.YanchoButton.CheckedChanged += new System.EventHandler(this.YanchoButton_CheckedChanged);
            // 
            // SashoButton
            // 
            this.SashoButton.AutoSize = true;
            this.SashoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SashoButton.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SashoButton.ForeColor = System.Drawing.Color.Black;
            this.SashoButton.Location = new System.Drawing.Point(75, 28);
            this.SashoButton.Name = "SashoButton";
            this.SashoButton.Size = new System.Drawing.Size(150, 27);
            this.SashoButton.TabIndex = 3;
            this.SashoButton.TabStop = true;
            this.SashoButton.Text = "Sasho Fett";
            this.SashoButton.UseVisualStyleBackColor = true;
            this.SashoButton.CheckedChanged += new System.EventHandler(this.SashoButton_CheckedChanged);
            // 
            // JanButton
            // 
            this.JanButton.AutoSize = true;
            this.JanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JanButton.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JanButton.ForeColor = System.Drawing.Color.Black;
            this.JanButton.Location = new System.Drawing.Point(301, 28);
            this.JanButton.Name = "JanButton";
            this.JanButton.Size = new System.Drawing.Size(142, 27);
            this.JanButton.TabIndex = 4;
            this.JanButton.TabStop = true;
            this.JanButton.Text = "Wight Jan";
            this.JanButton.UseVisualStyleBackColor = true;
            this.JanButton.CheckedChanged += new System.EventHandler(this.JanButton_CheckedChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveButton.Location = new System.Drawing.Point(853, 9);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(92, 51);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.SevginButton);
            this.groupBox1.Controls.Add(this.YanchoButton);
            this.groupBox1.Controls.Add(this.SashoButton);
            this.groupBox1.Controls.Add(this.JanButton);
            this.groupBox1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(0, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 72);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paduins:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 411);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(270, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 403);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(481, 144);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(232, 403);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(715, 153);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(232, 394);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // Paduin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(957, 558);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SaveButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(613, 192);
            this.MaximizeBox = false;
            this.Name = "Paduin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Paduin";
            this.Load += new System.EventHandler(this.Paduin_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton SevginButton;
        private System.Windows.Forms.RadioButton YanchoButton;
        private System.Windows.Forms.RadioButton SashoButton;
        private System.Windows.Forms.RadioButton JanButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}