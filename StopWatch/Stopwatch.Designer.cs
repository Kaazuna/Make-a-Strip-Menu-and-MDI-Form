namespace Pembuatan_Menu_Strip_dan_MDI_Form
{
    partial class Stopwatch
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
            this.LabelJam = new System.Windows.Forms.Label();
            this.LabelMenit = new System.Windows.Forms.Label();
            this.LabelDetik = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LabelJam
            // 
            this.LabelJam.AutoSize = true;
            this.LabelJam.Font = new System.Drawing.Font("Baskerville Old Face", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelJam.Location = new System.Drawing.Point(105, 98);
            this.LabelJam.Name = "LabelJam";
            this.LabelJam.Size = new System.Drawing.Size(176, 137);
            this.LabelJam.TabIndex = 0;
            this.LabelJam.Text = "00";
            this.LabelJam.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelMenit
            // 
            this.LabelMenit.AutoSize = true;
            this.LabelMenit.Font = new System.Drawing.Font("Baskerville Old Face", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMenit.Location = new System.Drawing.Point(305, 98);
            this.LabelMenit.Name = "LabelMenit";
            this.LabelMenit.Size = new System.Drawing.Size(176, 137);
            this.LabelMenit.TabIndex = 1;
            this.LabelMenit.Text = "00";
            // 
            // LabelDetik
            // 
            this.LabelDetik.AutoSize = true;
            this.LabelDetik.Font = new System.Drawing.Font("Baskerville Old Face", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDetik.Location = new System.Drawing.Point(509, 98);
            this.LabelDetik.Name = "LabelDetik";
            this.LabelDetik.Size = new System.Drawing.Size(176, 137);
            this.LabelDetik.TabIndex = 2;
            this.LabelDetik.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 137);
            this.label4.TabIndex = 3;
            this.label4.Text = ":";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(447, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 137);
            this.label5.TabIndex = 4;
            this.label5.Text = ":";
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Sitka Text", 20F);
            this.Start.Location = new System.Drawing.Point(145, 285);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(136, 57);
            this.Start.TabIndex = 5;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Font = new System.Drawing.Font("Sitka Text", 20F);
            this.Stop.Location = new System.Drawing.Point(328, 285);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(136, 57);
            this.Stop.TabIndex = 6;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Sitka Text", 20F);
            this.Reset.Location = new System.Drawing.Point(509, 285);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(136, 57);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Stopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelDetik);
            this.Controls.Add(this.LabelMenit);
            this.Controls.Add(this.LabelJam);
            this.Name = "Stopwatch";
            this.Text = "Stopwatch";
            this.Load += new System.EventHandler(this.Stopwatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LabelJam;
        public System.Windows.Forms.Label LabelMenit;
        public System.Windows.Forms.Label LabelDetik;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button Start;
        public System.Windows.Forms.Button Stop;
        public System.Windows.Forms.Button Reset;
        public System.Windows.Forms.Timer timer1;
    }
}

