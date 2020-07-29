namespace PlantVsZombie.forms
{
    partial class GardenForm
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
            this.components = new System.ComponentModel.Container();
            this.zombiesAnimateTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // zombiesAnimateTimer
            // 
            this.zombiesAnimateTimer.Enabled = true;
            this.zombiesAnimateTimer.Tick += new System.EventHandler(this.zombiesAnimateTimer_Tick);
            // 
            // GardenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 742);
            this.DoubleBuffered = true;
            this.Name = "GardenForm";
            this.Text = "GardenForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GardenForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer zombiesAnimateTimer;
    }
}