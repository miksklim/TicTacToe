namespace ApplicationTicTacToe
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
            this.playerlabel = new System.Windows.Forms.Label();
            this.cpulabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.TimerCPU = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // playerlabel
            // 
            this.playerlabel.AutoSize = true;
            this.playerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerlabel.Location = new System.Drawing.Point(12, 20);
            this.playerlabel.Name = "playerlabel";
            this.playerlabel.Size = new System.Drawing.Size(135, 25);
            this.playerlabel.TabIndex = 0;
            this.playerlabel.Text = "Player Wins:";
            // 
            // cpulabel
            // 
            this.cpulabel.AutoSize = true;
            this.cpulabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpulabel.Location = new System.Drawing.Point(405, 20);
            this.cpulabel.Name = "cpulabel";
            this.cpulabel.Size = new System.Drawing.Size(119, 25);
            this.cpulabel.TabIndex = 1;
            this.cpulabel.Text = "CPU Wins:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(108, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 90);
            this.button1.TabIndex = 2;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PlayerChooseOption);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(206, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 90);
            this.button2.TabIndex = 3;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PlayerChooseOption);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(304, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 90);
            this.button3.TabIndex = 4;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.PlayerChooseOption);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(304, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 90);
            this.button4.TabIndex = 7;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.PlayerChooseOption);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(206, 192);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 90);
            this.button5.TabIndex = 6;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.PlayerChooseOption);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(108, 192);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 90);
            this.button6.TabIndex = 5;
            this.button6.Text = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.PlayerChooseOption);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(304, 288);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 90);
            this.button7.TabIndex = 10;
            this.button7.Text = "?";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.PlayerChooseOption);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(206, 288);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 90);
            this.button8.TabIndex = 9;
            this.button8.Text = "?";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.PlayerChooseOption);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(108, 288);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(92, 90);
            this.button9.TabIndex = 8;
            this.button9.Text = "?";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.PlayerChooseOption);
            // 
            // TimerCPU
            // 
            this.TimerCPU.Interval = 1000;
            this.TimerCPU.Tick += new System.EventHandler(this.CPUChooseOption);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cpulabel);
            this.Controls.Add(this.playerlabel);
            this.Name = "Form1";
            this.Text = "TicTacToe Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerlabel;
        private System.Windows.Forms.Label cpulabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Timer TimerCPU;
    }
}

