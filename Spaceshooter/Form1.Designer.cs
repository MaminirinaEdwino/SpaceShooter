namespace Spaceshooter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Movebytimer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.leftmovetimer = new System.Windows.Forms.Timer(this.components);
            this.rightmovetimer = new System.Windows.Forms.Timer(this.components);
            this.upmovetimer = new System.Windows.Forms.Timer(this.components);
            this.downmovetimer = new System.Windows.Forms.Timer(this.components);
            this.movemunitiontimer = new System.Windows.Forms.Timer(this.components);
            this.moveenemiestimer = new System.Windows.Forms.Timer(this.components);
            this.enemiesmunitiontimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_replay = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.levellabel = new System.Windows.Forms.Label();
            this.scorelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // Movebytimer
            // 
            this.Movebytimer.Enabled = true;
            this.Movebytimer.Interval = 10;
            this.Movebytimer.Tick += new System.EventHandler(this.movebytimer_tick);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(271, 399);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // leftmovetimer
            // 
            this.leftmovetimer.Interval = 5;
            this.leftmovetimer.Tick += new System.EventHandler(this.leftmovetimer_Tick);
            // 
            // rightmovetimer
            // 
            this.rightmovetimer.Interval = 5;
            this.rightmovetimer.Tick += new System.EventHandler(this.rightmovetimer_Tick);
            // 
            // upmovetimer
            // 
            this.upmovetimer.Interval = 5;
            this.upmovetimer.Tick += new System.EventHandler(this.upmovetimer_Tick);
            // 
            // downmovetimer
            // 
            this.downmovetimer.Interval = 5;
            this.downmovetimer.Tick += new System.EventHandler(this.downmovetimer_Tick);
            // 
            // movemunitiontimer
            // 
            this.movemunitiontimer.Enabled = true;
            this.movemunitiontimer.Interval = 20;
            this.movemunitiontimer.Tick += new System.EventHandler(this.movemunitiontimer_Tick);
            // 
            // moveenemiestimer
            // 
            this.moveenemiestimer.Enabled = true;
            this.moveenemiestimer.Tick += new System.EventHandler(this.moveenemiestimer_Tick);
            // 
            // enemiesmunitiontimer
            // 
            this.enemiesmunitiontimer.Enabled = true;
            this.enemiesmunitiontimer.Interval = 20;
            this.enemiesmunitiontimer.Tick += new System.EventHandler(this.enemiesmunitiontimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(175, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // btn_replay
            // 
            this.btn_replay.BackColor = System.Drawing.Color.Lime;
            this.btn_replay.FlatAppearance.BorderSize = 0;
            this.btn_replay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_replay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_replay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_replay.Location = new System.Drawing.Point(229, 203);
            this.btn_replay.Name = "btn_replay";
            this.btn_replay.Size = new System.Drawing.Size(128, 36);
            this.btn_replay.TabIndex = 2;
            this.btn_replay.Text = "REPLAY";
            this.btn_replay.UseVisualStyleBackColor = false;
            this.btn_replay.Visible = false;
            this.btn_replay.Click += new System.EventHandler(this.btn_replay_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(229, 273);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(128, 32);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Visible = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // levellabel
            // 
            this.levellabel.AutoSize = true;
            this.levellabel.BackColor = System.Drawing.Color.Transparent;
            this.levellabel.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levellabel.ForeColor = System.Drawing.Color.Snow;
            this.levellabel.Location = new System.Drawing.Point(22, 25);
            this.levellabel.Name = "levellabel";
            this.levellabel.Size = new System.Drawing.Size(116, 19);
            this.levellabel.TabIndex = 3;
            this.levellabel.Text = "LEVEL :  1";
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.BackColor = System.Drawing.Color.Transparent;
            this.scorelabel.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelabel.ForeColor = System.Drawing.Color.Snow;
            this.scorelabel.Location = new System.Drawing.Point(418, 25);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(120, 19);
            this.scorelabel.TabIndex = 4;
            this.scorelabel.Text = "Score :  0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.levellabel);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_replay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.Text = "Space Shooter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Movebytimer;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer leftmovetimer;
        private System.Windows.Forms.Timer rightmovetimer;
        private System.Windows.Forms.Timer upmovetimer;
        private System.Windows.Forms.Timer downmovetimer;
        private System.Windows.Forms.Timer movemunitiontimer;
        private System.Windows.Forms.Timer moveenemiestimer;
        private System.Windows.Forms.Timer enemiesmunitiontimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_replay;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label levellabel;
        private System.Windows.Forms.Label scorelabel;
    }
}

