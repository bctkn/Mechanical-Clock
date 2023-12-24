namespace ClockWinFormApp
{
    partial class Clock_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock_form));
            Clock_timer = new System.Windows.Forms.Timer(components);
            Clock_pictureBox = new PictureBox();
            menuStrip1 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)Clock_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // Clock_timer
            // 
            Clock_timer.Tick += Clock_timer_Tick;
            // 
            // Clock_pictureBox
            // 
            Clock_pictureBox.Image = (Image)resources.GetObject("Clock_pictureBox.Image");
            Clock_pictureBox.Location = new Point(-21, -13);
            Clock_pictureBox.Name = "Clock_pictureBox";
            Clock_pictureBox.Size = new Size(600, 608);
            Clock_pictureBox.TabIndex = 0;
            Clock_pictureBox.TabStop = false;
            Clock_pictureBox.Paint += Clock_pictureBox_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(579, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // Clock_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 586);
            Controls.Add(Clock_pictureBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Clock_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clock";
            ((System.ComponentModel.ISupportInitialize)Clock_pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer Clock_timer;
        private PictureBox Clock_pictureBox;
        private MenuStrip menuStrip1;
    }
}
