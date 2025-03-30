namespace Pembuatan_Menu_Strip_dan_MDI_Form.GUI
{
    partial class Tiimer
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
            this.TimerReset = new System.Windows.Forms.Button();
            this.TimerStop = new System.Windows.Forms.Button();
            this.TimerStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TimerDetik = new System.Windows.Forms.Label();
            this.TimerMenit = new System.Windows.Forms.Label();
            this.TimerJam = new System.Windows.Forms.Label();
            this.TambahJam = new System.Windows.Forms.Button();
            this.KurangJam = new System.Windows.Forms.Button();
            this.KurangMenit = new System.Windows.Forms.Button();
            this.TambahMenit = new System.Windows.Forms.Button();
            this.KurangDetik = new System.Windows.Forms.Button();
            this.TambahDetik = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimerReset
            // 
            this.TimerReset.Font = new System.Drawing.Font("Sitka Text", 20F);
            this.TimerReset.Location = new System.Drawing.Point(514, 301);
            this.TimerReset.Name = "TimerReset";
            this.TimerReset.Size = new System.Drawing.Size(136, 57);
            this.TimerReset.TabIndex = 15;
            this.TimerReset.Text = "Reset";
            this.TimerReset.UseVisualStyleBackColor = true;
            this.TimerReset.Click += new System.EventHandler(this.TimerReset_Click);
            // 
            // TimerStop
            // 
            this.TimerStop.Font = new System.Drawing.Font("Sitka Text", 20F);
            this.TimerStop.Location = new System.Drawing.Point(333, 301);
            this.TimerStop.Name = "TimerStop";
            this.TimerStop.Size = new System.Drawing.Size(136, 57);
            this.TimerStop.TabIndex = 14;
            this.TimerStop.Text = "Stop";
            this.TimerStop.UseVisualStyleBackColor = true;
            this.TimerStop.Click += new System.EventHandler(this.TimerStop_Click);
            // 
            // TimerStart
            // 
            this.TimerStart.Font = new System.Drawing.Font("Sitka Text", 20F);
            this.TimerStart.Location = new System.Drawing.Point(150, 301);
            this.TimerStart.Name = "TimerStart";
            this.TimerStart.Size = new System.Drawing.Size(136, 57);
            this.TimerStart.TabIndex = 13;
            this.TimerStart.Text = "Start";
            this.TimerStart.UseVisualStyleBackColor = true;
            this.TimerStart.Click += new System.EventHandler(this.TimerStart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(452, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 137);
            this.label5.TabIndex = 12;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 137);
            this.label4.TabIndex = 11;
            this.label4.Text = ":";
            // 
            // TimerDetik
            // 
            this.TimerDetik.AutoSize = true;
            this.TimerDetik.Font = new System.Drawing.Font("Baskerville Old Face", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerDetik.Location = new System.Drawing.Point(514, 114);
            this.TimerDetik.Name = "TimerDetik";
            this.TimerDetik.Size = new System.Drawing.Size(176, 137);
            this.TimerDetik.TabIndex = 10;
            this.TimerDetik.Text = "00";
            // 
            // TimerMenit
            // 
            this.TimerMenit.AutoSize = true;
            this.TimerMenit.Font = new System.Drawing.Font("Baskerville Old Face", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerMenit.Location = new System.Drawing.Point(310, 114);
            this.TimerMenit.Name = "TimerMenit";
            this.TimerMenit.Size = new System.Drawing.Size(176, 137);
            this.TimerMenit.TabIndex = 9;
            this.TimerMenit.Text = "00";
            // 
            // TimerJam
            // 
            this.TimerJam.AutoSize = true;
            this.TimerJam.Font = new System.Drawing.Font("Baskerville Old Face", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerJam.Location = new System.Drawing.Point(110, 114);
            this.TimerJam.Name = "TimerJam";
            this.TimerJam.Size = new System.Drawing.Size(176, 137);
            this.TimerJam.TabIndex = 8;
            this.TimerJam.Text = "00";
            this.TimerJam.Click += new System.EventHandler(this.TimerJam_Click);
            // 
            // TambahJam
            // 
            this.TambahJam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TambahJam.Location = new System.Drawing.Point(133, 230);
            this.TambahJam.Name = "TambahJam";
            this.TambahJam.Size = new System.Drawing.Size(36, 35);
            this.TambahJam.TabIndex = 16;
            this.TambahJam.Text = "+";
            this.TambahJam.UseVisualStyleBackColor = true;
            this.TambahJam.Click += new System.EventHandler(this.TambahJam_Click);
            // 
            // KurangJam
            // 
            this.KurangJam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KurangJam.Location = new System.Drawing.Point(218, 230);
            this.KurangJam.Name = "KurangJam";
            this.KurangJam.Size = new System.Drawing.Size(36, 35);
            this.KurangJam.TabIndex = 17;
            this.KurangJam.Text = "-";
            this.KurangJam.UseVisualStyleBackColor = true;
            this.KurangJam.Click += new System.EventHandler(this.KurangJam_Click);
            // 
            // KurangMenit
            // 
            this.KurangMenit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KurangMenit.Location = new System.Drawing.Point(418, 230);
            this.KurangMenit.Name = "KurangMenit";
            this.KurangMenit.Size = new System.Drawing.Size(36, 35);
            this.KurangMenit.TabIndex = 19;
            this.KurangMenit.Text = "-";
            this.KurangMenit.UseVisualStyleBackColor = true;
            this.KurangMenit.Click += new System.EventHandler(this.KurangMenit_Click);
            // 
            // TambahMenit
            // 
            this.TambahMenit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TambahMenit.Location = new System.Drawing.Point(333, 230);
            this.TambahMenit.Name = "TambahMenit";
            this.TambahMenit.Size = new System.Drawing.Size(36, 35);
            this.TambahMenit.TabIndex = 18;
            this.TambahMenit.Text = "+";
            this.TambahMenit.UseVisualStyleBackColor = true;
            this.TambahMenit.Click += new System.EventHandler(this.button2_Click);
            // 
            // KurangDetik
            // 
            this.KurangDetik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KurangDetik.Location = new System.Drawing.Point(622, 233);
            this.KurangDetik.Name = "KurangDetik";
            this.KurangDetik.Size = new System.Drawing.Size(36, 35);
            this.KurangDetik.TabIndex = 21;
            this.KurangDetik.Text = "-";
            this.KurangDetik.UseVisualStyleBackColor = true;
            this.KurangDetik.Click += new System.EventHandler(this.KurangDetik_Click);
            // 
            // TambahDetik
            // 
            this.TambahDetik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TambahDetik.Location = new System.Drawing.Point(537, 233);
            this.TambahDetik.Name = "TambahDetik";
            this.TambahDetik.Size = new System.Drawing.Size(36, 35);
            this.TambahDetik.TabIndex = 20;
            this.TambahDetik.Text = "+";
            this.TambahDetik.UseVisualStyleBackColor = true;
            this.TambahDetik.Click += new System.EventHandler(this.TambahDetik_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Tiimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KurangDetik);
            this.Controls.Add(this.TambahDetik);
            this.Controls.Add(this.KurangMenit);
            this.Controls.Add(this.TambahMenit);
            this.Controls.Add(this.KurangJam);
            this.Controls.Add(this.TambahJam);
            this.Controls.Add(this.TimerReset);
            this.Controls.Add(this.TimerStop);
            this.Controls.Add(this.TimerStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TimerDetik);
            this.Controls.Add(this.TimerMenit);
            this.Controls.Add(this.TimerJam);
            this.Name = "Tiimer";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Timer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button TimerReset;
        public System.Windows.Forms.Button TimerStop;
        public System.Windows.Forms.Button TimerStart;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label TimerDetik;
        public System.Windows.Forms.Label TimerMenit;
        public System.Windows.Forms.Label TimerJam;
        protected System.Windows.Forms.Button TambahJam;
        public System.Windows.Forms.Button KurangJam;
        public System.Windows.Forms.Button KurangMenit;
        public System.Windows.Forms.Button KurangDetik;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Button TambahMenit;
        public System.Windows.Forms.Button TambahDetik;
    }
}