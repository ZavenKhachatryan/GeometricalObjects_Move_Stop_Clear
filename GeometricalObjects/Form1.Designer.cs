namespace GeometricalObjects
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
            this.controlPanel = new System.Windows.Forms.GroupBox();
            this.clear = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.movie = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.triangle = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.clear);
            this.controlPanel.Controls.Add(this.pause);
            this.controlPanel.Controls.Add(this.movie);
            this.controlPanel.Controls.Add(this.circle);
            this.controlPanel.Controls.Add(this.triangle);
            this.controlPanel.Controls.Add(this.rectangle);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlPanel.Location = new System.Drawing.Point(940, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(200, 660);
            this.controlPanel.TabIndex = 1;
            this.controlPanel.TabStop = false;
            this.controlPanel.Text = "Control Panel";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(6, 606);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(188, 32);
            this.clear.TabIndex = 5;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(6, 494);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(188, 32);
            this.pause.TabIndex = 4;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // movie
            // 
            this.movie.Location = new System.Drawing.Point(6, 381);
            this.movie.Name = "movie";
            this.movie.Size = new System.Drawing.Size(188, 32);
            this.movie.TabIndex = 3;
            this.movie.Text = "Movie";
            this.movie.UseVisualStyleBackColor = true;
            this.movie.Click += new System.EventHandler(this.AsyncMovie_Click);
            // 
            // circle
            // 
            this.circle.Location = new System.Drawing.Point(6, 265);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(188, 32);
            this.circle.TabIndex = 2;
            this.circle.Text = "Circle";
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // triangle
            // 
            this.triangle.Location = new System.Drawing.Point(6, 160);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(188, 32);
            this.triangle.TabIndex = 1;
            this.triangle.Text = "Triangle";
            this.triangle.UseVisualStyleBackColor = true;
            this.triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // rectangle
            // 
            this.rectangle.Location = new System.Drawing.Point(6, 40);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(188, 32);
            this.rectangle.TabIndex = 0;
            this.rectangle.Text = "Rectangle";
            this.rectangle.UseVisualStyleBackColor = true;
            this.rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(940, 660);
            this.panel.TabIndex = 3;
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 660);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.controlPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox controlPanel;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button movie;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button triangle;
        private System.Windows.Forms.Button rectangle;
        public System.Windows.Forms.Panel panel;
    }
}

