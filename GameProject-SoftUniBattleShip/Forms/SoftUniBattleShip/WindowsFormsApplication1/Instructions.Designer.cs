namespace WindowsFormsApplication1
{
    partial class Instructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            this.Undestand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Undestand
            // 
            this.Undestand.BackColor = System.Drawing.Color.Black;
            this.Undestand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Undestand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Undestand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Undestand.Font = new System.Drawing.Font("Star Jedi Logo DoubleLine1", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Undestand.ForeColor = System.Drawing.Color.White;
            this.Undestand.Location = new System.Drawing.Point(718, 12);
            this.Undestand.Name = "Undestand";
            this.Undestand.Size = new System.Drawing.Size(154, 32);
            this.Undestand.TabIndex = 0;
            this.Undestand.Text = "understand";
            this.Undestand.UseVisualStyleBackColor = false;
            this.Undestand.Click += new System.EventHandler(this.button1_Click);
            // 
            // Instructions
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 601);
            this.Controls.Add(this.Undestand);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Instructions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Instructions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Undestand;
    }
}