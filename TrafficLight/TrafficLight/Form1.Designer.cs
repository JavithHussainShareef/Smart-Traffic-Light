namespace TrafficLight
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picNOrange = new System.Windows.Forms.PictureBox();
            this.picNGreen = new System.Windows.Forms.PictureBox();
            this.picNRed = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.picERed = new System.Windows.Forms.PictureBox();
            this.picEOrange = new System.Windows.Forms.PictureBox();
            this.picEGreen = new System.Windows.Forms.PictureBox();
            this.picSRed = new System.Windows.Forms.PictureBox();
            this.picWRed = new System.Windows.Forms.PictureBox();
            this.picWOrange = new System.Windows.Forms.PictureBox();
            this.picSOrange = new System.Windows.Forms.PictureBox();
            this.picSGreen = new System.Windows.Forms.PictureBox();
            this.picWGreen = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblStatusN = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblW = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lblStatusE = new System.Windows.Forms.Label();
            this.lblStatusS = new System.Windows.Forms.Label();
            this.lblStatusW = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picERed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picNOrange);
            this.panel1.Location = new System.Drawing.Point(320, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 179);
            this.panel1.TabIndex = 0;
            // 
            // picNOrange
            // 
            this.picNOrange.Image = global::TrafficLight.Properties.Resources.Orange;
            this.picNOrange.Location = new System.Drawing.Point(0, 64);
            this.picNOrange.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.picNOrange.Name = "picNOrange";
            this.picNOrange.Size = new System.Drawing.Size(60, 55);
            this.picNOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNOrange.TabIndex = 2;
            this.picNOrange.TabStop = false;
            this.picNOrange.UseWaitCursor = true;
            // 
            // picNGreen
            // 
            this.picNGreen.Image = global::TrafficLight.Properties.Resources.Green;
            this.picNGreen.Location = new System.Drawing.Point(322, 137);
            this.picNGreen.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.picNGreen.Name = "picNGreen";
            this.picNGreen.Size = new System.Drawing.Size(60, 55);
            this.picNGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNGreen.TabIndex = 3;
            this.picNGreen.TabStop = false;
            this.picNGreen.UseWaitCursor = true;
            // 
            // picNRed
            // 
            this.picNRed.Image = global::TrafficLight.Properties.Resources.REDSmall;
            this.picNRed.Location = new System.Drawing.Point(322, 15);
            this.picNRed.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.picNRed.Name = "picNRed";
            this.picNRed.Size = new System.Drawing.Size(60, 55);
            this.picNRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNRed.TabIndex = 1;
            this.picNRed.TabStop = false;
            this.picNRed.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "North";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(27, 15);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // picERed
            // 
            this.picERed.Image = global::TrafficLight.Properties.Resources.REDSmall;
            this.picERed.Location = new System.Drawing.Point(541, 101);
            this.picERed.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.picERed.Name = "picERed";
            this.picERed.Size = new System.Drawing.Size(60, 55);
            this.picERed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picERed.TabIndex = 3;
            this.picERed.TabStop = false;
            this.picERed.UseWaitCursor = true;
            // 
            // picEOrange
            // 
            this.picEOrange.Image = global::TrafficLight.Properties.Resources.Orange;
            this.picEOrange.Location = new System.Drawing.Point(541, 162);
            this.picEOrange.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.picEOrange.Name = "picEOrange";
            this.picEOrange.Size = new System.Drawing.Size(60, 55);
            this.picEOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picEOrange.TabIndex = 4;
            this.picEOrange.TabStop = false;
            this.picEOrange.UseWaitCursor = true;
            // 
            // picEGreen
            // 
            this.picEGreen.Image = global::TrafficLight.Properties.Resources.Green;
            this.picEGreen.Location = new System.Drawing.Point(541, 232);
            this.picEGreen.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.picEGreen.Name = "picEGreen";
            this.picEGreen.Size = new System.Drawing.Size(60, 55);
            this.picEGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picEGreen.TabIndex = 5;
            this.picEGreen.TabStop = false;
            this.picEGreen.UseWaitCursor = true;
            // 
            // picSRed
            // 
            this.picSRed.Image = global::TrafficLight.Properties.Resources.REDSmall;
            this.picSRed.Location = new System.Drawing.Point(322, 269);
            this.picSRed.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.picSRed.Name = "picSRed";
            this.picSRed.Size = new System.Drawing.Size(60, 55);
            this.picSRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSRed.TabIndex = 6;
            this.picSRed.TabStop = false;
            this.picSRed.UseWaitCursor = true;
            // 
            // picWRed
            // 
            this.picWRed.Image = global::TrafficLight.Properties.Resources.REDSmall;
            this.picWRed.Location = new System.Drawing.Point(147, 101);
            this.picWRed.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.picWRed.Name = "picWRed";
            this.picWRed.Size = new System.Drawing.Size(60, 55);
            this.picWRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWRed.TabIndex = 7;
            this.picWRed.TabStop = false;
            this.picWRed.UseWaitCursor = true;
            // 
            // picWOrange
            // 
            this.picWOrange.Image = global::TrafficLight.Properties.Resources.Orange;
            this.picWOrange.Location = new System.Drawing.Point(147, 162);
            this.picWOrange.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.picWOrange.Name = "picWOrange";
            this.picWOrange.Size = new System.Drawing.Size(60, 55);
            this.picWOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWOrange.TabIndex = 8;
            this.picWOrange.TabStop = false;
            this.picWOrange.UseWaitCursor = true;
            // 
            // picSOrange
            // 
            this.picSOrange.Image = global::TrafficLight.Properties.Resources.Orange;
            this.picSOrange.Location = new System.Drawing.Point(322, 330);
            this.picSOrange.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.picSOrange.Name = "picSOrange";
            this.picSOrange.Size = new System.Drawing.Size(60, 55);
            this.picSOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSOrange.TabIndex = 9;
            this.picSOrange.TabStop = false;
            this.picSOrange.UseWaitCursor = true;
            // 
            // picSGreen
            // 
            this.picSGreen.Image = global::TrafficLight.Properties.Resources.Green;
            this.picSGreen.Location = new System.Drawing.Point(322, 391);
            this.picSGreen.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.picSGreen.Name = "picSGreen";
            this.picSGreen.Size = new System.Drawing.Size(60, 55);
            this.picSGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSGreen.TabIndex = 10;
            this.picSGreen.TabStop = false;
            this.picSGreen.UseWaitCursor = true;
            // 
            // picWGreen
            // 
            this.picWGreen.Image = global::TrafficLight.Properties.Resources.Green;
            this.picWGreen.Location = new System.Drawing.Point(147, 223);
            this.picWGreen.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.picWGreen.Name = "picWGreen";
            this.picWGreen.Size = new System.Drawing.Size(60, 55);
            this.picWGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWGreen.TabIndex = 11;
            this.picWGreen.TabStop = false;
            this.picWGreen.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "South";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "West";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(663, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "East";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(433, 20);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(13, 13);
            this.lblN.TabIndex = 16;
            this.lblN.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer_Ticks);
            // 
            // lblStatusN
            // 
            this.lblStatusN.AutoSize = true;
            this.lblStatusN.Location = new System.Drawing.Point(422, 46);
            this.lblStatusN.Name = "lblStatusN";
            this.lblStatusN.Size = new System.Drawing.Size(63, 13);
            this.lblStatusN.TabIndex = 17;
            this.lblStatusN.Text = "NorthStatus";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Location = new System.Drawing.Point(56, 118);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(13, 13);
            this.lblW.TabIndex = 19;
            this.lblW.Text = "0";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(663, 118);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(13, 13);
            this.lblE.TabIndex = 20;
            this.lblE.Text = "0";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(433, 311);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(13, 13);
            this.lblS.TabIndex = 21;
            this.lblS.Text = "0";
            // 
            // lblStatusE
            // 
            this.lblStatusE.AutoSize = true;
            this.lblStatusE.Location = new System.Drawing.Point(666, 149);
            this.lblStatusE.Name = "lblStatusE";
            this.lblStatusE.Size = new System.Drawing.Size(58, 13);
            this.lblStatusE.TabIndex = 22;
            this.lblStatusE.Text = "EastStatus";
            // 
            // lblStatusS
            // 
            this.lblStatusS.AutoSize = true;
            this.lblStatusS.Location = new System.Drawing.Point(420, 344);
            this.lblStatusS.Name = "lblStatusS";
            this.lblStatusS.Size = new System.Drawing.Size(65, 13);
            this.lblStatusS.TabIndex = 23;
            this.lblStatusS.Text = "SouthStatus";
            // 
            // lblStatusW
            // 
            this.lblStatusW.AutoSize = true;
            this.lblStatusW.Location = new System.Drawing.Point(53, 149);
            this.lblStatusW.Name = "lblStatusW";
            this.lblStatusW.Size = new System.Drawing.Size(62, 13);
            this.lblStatusW.TabIndex = 24;
            this.lblStatusW.Text = "WestStatus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatusW);
            this.Controls.Add(this.lblStatusS);
            this.Controls.Add(this.lblStatusE);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblStatusN);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picWGreen);
            this.Controls.Add(this.picSGreen);
            this.Controls.Add(this.picSOrange);
            this.Controls.Add(this.picWOrange);
            this.Controls.Add(this.picWRed);
            this.Controls.Add(this.picSRed);
            this.Controls.Add(this.picEGreen);
            this.Controls.Add(this.picNGreen);
            this.Controls.Add(this.picEOrange);
            this.Controls.Add(this.picERed);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picNRed);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picERed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picNRed;
        private System.Windows.Forms.PictureBox picNOrange;
        private System.Windows.Forms.PictureBox picNGreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.PictureBox picERed;
        private System.Windows.Forms.PictureBox picEOrange;
        private System.Windows.Forms.PictureBox picEGreen;
        private System.Windows.Forms.PictureBox picSRed;
        private System.Windows.Forms.PictureBox picWRed;
        private System.Windows.Forms.PictureBox picWOrange;
        private System.Windows.Forms.PictureBox picSOrange;
        private System.Windows.Forms.PictureBox picSGreen;
        private System.Windows.Forms.PictureBox picWGreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblStatusN;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblStatusE;
        private System.Windows.Forms.Label lblStatusS;
        private System.Windows.Forms.Label lblStatusW;
    }
}

