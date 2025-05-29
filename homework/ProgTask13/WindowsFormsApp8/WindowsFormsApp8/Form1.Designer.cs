namespace WindowsFormsApp8
{
    partial class Form1
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
            this.playgroundPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.greenballtimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // playgroundPanel
            // 
            this.playgroundPanel.Location = new System.Drawing.Point(20, 18);
            this.playgroundPanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.playgroundPanel.Name = "playgroundPanel";
            this.playgroundPanel.Size = new System.Drawing.Size(1293, 655);
            this.playgroundPanel.TabIndex = 0;
            this.playgroundPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PlayGroundPaint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // greenballtimer
            // 
            this.greenballtimer.Tick += new System.EventHandler(this.greenballtimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.playgroundPanel);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playgroundPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer greenballtimer;
    }
}

