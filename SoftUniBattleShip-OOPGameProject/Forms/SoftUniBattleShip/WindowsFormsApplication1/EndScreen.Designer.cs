namespace WindowsFormsApplication1
{
    partial class EndScreen
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
            this.EndScreenImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EndScreenImage)).BeginInit();
            this.SuspendLayout();
            // 
            // EndScreenImage
            // 
            this.EndScreenImage.Location = new System.Drawing.Point(0, 0);
            this.EndScreenImage.Name = "EndScreenImage";
            this.EndScreenImage.Size = new System.Drawing.Size(902, 598);
            this.EndScreenImage.TabIndex = 0;
            this.EndScreenImage.TabStop = false;
            this.EndScreenImage.Click += new System.EventHandler(this.EndScreenImage_Click);
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(903, 600);
            this.Controls.Add(this.EndScreenImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EndScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EndScreen";
            this.Load += new System.EventHandler(this.EndScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EndScreenImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox EndScreenImage;
    }
}