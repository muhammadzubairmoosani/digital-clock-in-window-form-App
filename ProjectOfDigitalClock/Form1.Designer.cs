namespace ProjectOfDigitalClock
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
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblLatinWords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("Digital-7 Mono", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTime.Location = new System.Drawing.Point(183, 74);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(262, 98);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "22:22";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeconds.Font = new System.Drawing.Font("Digital-7 Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSeconds.Location = new System.Drawing.Point(442, 142);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(38, 30);
            this.lblSeconds.TabIndex = 2;
            this.lblSeconds.Text = "22";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Font = new System.Drawing.Font("Digital-7 Mono", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDate.Location = new System.Drawing.Point(61, 216);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(288, 51);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "JUNE 25 2019";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDay.Font = new System.Drawing.Font("Digital-7 Mono", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDay.Location = new System.Drawing.Point(405, 216);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(156, 51);
            this.lblDay.TabIndex = 4;
            this.lblDay.Text = "SUNDAY";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblLatinWords
            // 
            this.lblLatinWords.AutoSize = true;
            this.lblLatinWords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLatinWords.Font = new System.Drawing.Font("Digital-7 Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatinWords.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLatinWords.Location = new System.Drawing.Point(442, 74);
            this.lblLatinWords.Name = "lblLatinWords";
            this.lblLatinWords.Size = new System.Drawing.Size(38, 30);
            this.lblLatinWords.TabIndex = 5;
            this.lblLatinWords.Text = "PM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(623, 341);
            this.Controls.Add(this.lblLatinWords);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblLatinWords;
    }
}

