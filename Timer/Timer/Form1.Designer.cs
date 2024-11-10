namespace Timer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResetStopwatch = new System.Windows.Forms.Button();
            this.btnStopStopwatch = new System.Windows.Forms.Button();
            this.btnStartStopwatch = new System.Windows.Forms.Button();
            this.lblStopwatch = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStopTimer = new System.Windows.Forms.Button();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lblTimerDisplay = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpAlarmTime = new System.Windows.Forms.DateTimePicker();
            this.btnStopAlarm = new System.Windows.Forms.Button();
            this.btnSetAlarm = new System.Windows.Forms.Button();
            this.lblAlarmTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblClock);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Часы";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Часы";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClock.Location = new System.Drawing.Point(16, 148);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(212, 55);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "00:00:00";
            this.lblClock.Click += new System.EventHandler(this.lblClock_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnResetStopwatch);
            this.tabPage2.Controls.Add(this.btnStopStopwatch);
            this.tabPage2.Controls.Add(this.btnStartStopwatch);
            this.tabPage2.Controls.Add(this.lblStopwatch);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Секундомер";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 73);
            this.label2.TabIndex = 4;
            this.label2.Text = "Секундомер";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // btnResetStopwatch
            // 
            this.btnResetStopwatch.Location = new System.Drawing.Point(642, 386);
            this.btnResetStopwatch.Name = "btnResetStopwatch";
            this.btnResetStopwatch.Size = new System.Drawing.Size(143, 33);
            this.btnResetStopwatch.TabIndex = 3;
            this.btnResetStopwatch.Text = "Сброс";
            this.btnResetStopwatch.UseVisualStyleBackColor = true;
            this.btnResetStopwatch.Click += new System.EventHandler(this.btnResetStopwatch_Click);
            // 
            // btnStopStopwatch
            // 
            this.btnStopStopwatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStopStopwatch.Location = new System.Drawing.Point(624, 36);
            this.btnStopStopwatch.Name = "btnStopStopwatch";
            this.btnStopStopwatch.Size = new System.Drawing.Size(136, 37);
            this.btnStopStopwatch.TabIndex = 2;
            this.btnStopStopwatch.Text = "Стоп";
            this.btnStopStopwatch.UseVisualStyleBackColor = true;
            this.btnStopStopwatch.Click += new System.EventHandler(this.btnStopStopwatch_Click);
            // 
            // btnStartStopwatch
            // 
            this.btnStartStopwatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartStopwatch.Location = new System.Drawing.Point(427, 36);
            this.btnStartStopwatch.Name = "btnStartStopwatch";
            this.btnStartStopwatch.Size = new System.Drawing.Size(136, 37);
            this.btnStartStopwatch.TabIndex = 1;
            this.btnStartStopwatch.Text = "Запуск";
            this.btnStartStopwatch.UseVisualStyleBackColor = true;
            this.btnStartStopwatch.Click += new System.EventHandler(this.btnStartStopwatch_Click);
            // 
            // lblStopwatch
            // 
            this.lblStopwatch.AutoSize = true;
            this.lblStopwatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStopwatch.Location = new System.Drawing.Point(13, 147);
            this.lblStopwatch.Name = "lblStopwatch";
            this.lblStopwatch.Size = new System.Drawing.Size(212, 55);
            this.lblStopwatch.TabIndex = 0;
            this.lblStopwatch.Text = "00:00:00";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtSeconds);
            this.tabPage3.Controls.Add(this.txtMinutes);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btnStopTimer);
            this.tabPage3.Controls.Add(this.btnStartTimer);
            this.tabPage3.Controls.Add(this.txtHours);
            this.tabPage3.Controls.Add(this.lblTimerDisplay);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(794, 425);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Таймер";
            // 
            // txtSeconds
            // 
            this.txtSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSeconds.Location = new System.Drawing.Point(523, 276);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(114, 47);
            this.txtSeconds.TabIndex = 8;
            this.txtSeconds.TextChanged += new System.EventHandler(this.txtSeconds_TextChanged);
            // 
            // txtMinutes
            // 
            this.txtMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMinutes.Location = new System.Drawing.Point(341, 276);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(114, 47);
            this.txtMinutes.TabIndex = 7;
            this.txtMinutes.TextChanged += new System.EventHandler(this.txtMinutes_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(517, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Секунды";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 73);
            this.label3.TabIndex = 5;
            this.label3.Text = "Таймер";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnStopTimer
            // 
            this.btnStopTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStopTimer.Location = new System.Drawing.Point(420, 33);
            this.btnStopTimer.Name = "btnStopTimer";
            this.btnStopTimer.Size = new System.Drawing.Size(125, 43);
            this.btnStopTimer.TabIndex = 3;
            this.btnStopTimer.Text = "Стоп";
            this.btnStopTimer.UseVisualStyleBackColor = true;
            this.btnStopTimer.Click += new System.EventHandler(this.btnStopTimer_Click);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartTimer.Location = new System.Drawing.Point(289, 33);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(114, 43);
            this.btnStartTimer.TabIndex = 2;
            this.btnStartTimer.Text = "Запуск";
            this.btnStartTimer.UseVisualStyleBackColor = true;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHours.Location = new System.Drawing.Point(162, 276);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(114, 47);
            this.txtHours.TabIndex = 1;
            this.txtHours.TextChanged += new System.EventHandler(this.txtHours_TextChanged);
            // 
            // lblTimerDisplay
            // 
            this.lblTimerDisplay.AutoSize = true;
            this.lblTimerDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimerDisplay.Location = new System.Drawing.Point(292, 140);
            this.lblTimerDisplay.Name = "lblTimerDisplay";
            this.lblTimerDisplay.Size = new System.Drawing.Size(212, 55);
            this.lblTimerDisplay.TabIndex = 0;
            this.lblTimerDisplay.Text = "00:00:00";
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.dtpAlarmTime);
            this.tabPage4.Controls.Add(this.btnStopAlarm);
            this.tabPage4.Controls.Add(this.btnSetAlarm);
            this.tabPage4.Controls.Add(this.lblAlarmTime);
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(794, 425);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Будильник";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(362, 73);
            this.label4.TabIndex = 6;
            this.label4.Text = "Будильник";
            // 
            // dtpAlarmTime
            // 
            this.dtpAlarmTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpAlarmTime.Location = new System.Drawing.Point(22, 239);
            this.dtpAlarmTime.Name = "dtpAlarmTime";
            this.dtpAlarmTime.Size = new System.Drawing.Size(114, 20);
            this.dtpAlarmTime.TabIndex = 4;
            // 
            // btnStopAlarm
            // 
            this.btnStopAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStopAlarm.Location = new System.Drawing.Point(535, 34);
            this.btnStopAlarm.Name = "btnStopAlarm";
            this.btnStopAlarm.Size = new System.Drawing.Size(130, 41);
            this.btnStopAlarm.TabIndex = 3;
            this.btnStopAlarm.Text = "Стоп";
            this.btnStopAlarm.UseVisualStyleBackColor = true;
            this.btnStopAlarm.Click += new System.EventHandler(this.btnStopAlarm_Click);
            // 
            // btnSetAlarm
            // 
            this.btnSetAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetAlarm.Location = new System.Drawing.Point(377, 34);
            this.btnSetAlarm.Name = "btnSetAlarm";
            this.btnSetAlarm.Size = new System.Drawing.Size(130, 41);
            this.btnSetAlarm.TabIndex = 2;
            this.btnSetAlarm.Text = "Запуск";
            this.btnSetAlarm.UseVisualStyleBackColor = true;
            this.btnSetAlarm.Click += new System.EventHandler(this.btnSetAlarm_Click);
            // 
            // lblAlarmTime
            // 
            this.lblAlarmTime.AutoSize = true;
            this.lblAlarmTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAlarmTime.Location = new System.Drawing.Point(16, 149);
            this.lblAlarmTime.Name = "lblAlarmTime";
            this.lblAlarmTime.Size = new System.Drawing.Size(127, 33);
            this.lblAlarmTime.TabIndex = 0;
            this.lblAlarmTime.Text = "00:00:00";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(338, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Минуты";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(176, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 31);
            this.label7.TabIndex = 10;
            this.label7.Text = "Часы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Button btnStopStopwatch;
        private System.Windows.Forms.Button btnStartStopwatch;
        private System.Windows.Forms.Label lblStopwatch;
        private System.Windows.Forms.Button btnResetStopwatch;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label lblTimerDisplay;
        private System.Windows.Forms.Button btnStopTimer;
        private System.Windows.Forms.Label lblAlarmTime;
        private System.Windows.Forms.Button btnStopAlarm;
        private System.Windows.Forms.Button btnSetAlarm;
        private System.Windows.Forms.DateTimePicker dtpAlarmTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

