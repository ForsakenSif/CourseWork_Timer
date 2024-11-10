using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Timer
{
    public partial class Form1 : Form
    {
        // Объявление таймера
        private System.Windows.Forms.Timer clockTimer = new System.Windows.Forms.Timer();

        // Переменные для секундомера
        private System.Windows.Forms.Timer stopwatchTimer = new System.Windows.Forms.Timer();
        private TimeSpan stopwatchTime = TimeSpan.Zero;
        private bool isStopwatchRunning = false;

        // Таймер для обратного отсчета
        private System.Windows.Forms.Timer countdownTimer = new System.Windows.Forms.Timer();
        private TimeSpan timerTime = TimeSpan.Zero;

        // Переменные для будильника
        private System.Windows.Forms.Timer alarmTimer = new System.Windows.Forms.Timer();
        private DateTime alarmTime;
        private bool isAlarmSet = false;



        public Form1()
        {
            InitializeComponent();

            // Настройка таймера
            clockTimer.Interval = 1000; // 1000 миллисекунд = 1 секунда
            clockTimer.Tick += ClockTimer_Tick;
            clockTimer.Start(); // Запуск таймера

            // Настройка таймера для секундомера
            stopwatchTimer.Interval = 1000; // 1000 миллисекунд = 1 секунда
            stopwatchTimer.Tick += StopwatchTimer_Tick;

            // Настройка таймера для обратного отсчета
            countdownTimer.Interval = 1000; // 1000 миллисекунд = 1 секунда
            countdownTimer.Tick += CountdownTimer_Tick;

            // Настройка таймера для проверки будильника
            alarmTimer.Interval = 1000; // Проверка каждую секунду
            alarmTimer.Tick += AlarmTimer_Tick; // Привязка обработчика для проверки времени
            alarmTimer.Start(); // Запуск таймера
            Console.WriteLine("Таймер для будильника запущен!"); // Выводим в консоль для отладки


        }

        // Обработчик события Tick, который вызывается каждую секунду
        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss"); // Отображение времени в формате ЧЧ:ММ:СС
        }


        // Обработчик для кнопки "Start"
        private void btnStartStopwatch_Click(object sender, EventArgs e)
        {
            if (!isStopwatchRunning)
            {
                stopwatchTimer.Start();
                isStopwatchRunning = true;
            }
        }

        // Обработчик для кнопки "Stop"
        private void btnStopStopwatch_Click(object sender, EventArgs e)
        {
            stopwatchTimer.Stop();
            isStopwatchRunning = false;
        }

        // Обработчик для кнопки "Reset"
        private void btnResetStopwatch_Click(object sender, EventArgs e)
        {
            stopwatchTimer.Stop();
            stopwatchTime = TimeSpan.Zero;
            lblStopwatch.Text = "00:00:00"; // Сбрасываем отображение на ноль
            isStopwatchRunning = false;
        }

        // Обработчик события Tick для секундомера
        private void StopwatchTimer_Tick(object sender, EventArgs e)
        {
            stopwatchTime = stopwatchTime.Add(TimeSpan.FromSeconds(1));
            lblStopwatch.Text = stopwatchTime.ToString(@"hh\:mm\:ss"); // Обновляем время на экране
        }


        // Таймер
        // Обработчик для кнопки "Start"
        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            // Получение введенных значений часов, минут и секунд
            int hours = int.TryParse(txtHours.Text, out hours) ? hours : 0;
            int minutes = int.TryParse(txtMinutes.Text, out minutes) ? minutes : 0;
            int seconds = int.TryParse(txtSeconds.Text, out seconds) ? seconds : 0;

            // Проверка на положительные значения
            if (hours >= 0 && minutes >= 0 && seconds >= 0)
            {
                // Создаем TimeSpan из введенных данных
                timerTime = new TimeSpan(hours, minutes, seconds);

                // Отображаем начальное время
                lblTimerDisplay.Text = timerTime.ToString(@"hh\:mm\:ss");

                // Запускаем таймер
                countdownTimer.Start();
            }
            else
            {
                MessageBox.Show("Введите корректные значения для времени.");
            }
        }

        // Обработчик для кнопки "Stop"
        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            countdownTimer.Stop();
        }

        // Обработчик для кнопки "Reset"
        private void btnResetTimer_Click(object sender, EventArgs e)
        {
            countdownTimer.Stop();
            timerTime = TimeSpan.Zero;
            lblTimerDisplay.Text = "00:00:00"; // Сбрасываем отображение на ноль
        }

        // Обработчик события Tick для таймера
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (timerTime.TotalSeconds > 0)
            {
                // Отнимаем 1 секунду от оставшегося времени
                timerTime = timerTime.Subtract(TimeSpan.FromSeconds(1));
                lblTimerDisplay.Text = timerTime.ToString(@"hh\:mm\:ss"); // Обновляем отображение на экране
            }
            else
            {
                countdownTimer.Stop(); // Останавливаем таймер
                MessageBox.Show("Время вышло!"); // Показать сообщение о завершении
            }
        }
    



    //Будильник


    // Обработчик события Tick для проверки срабатывания будильника
    private void AlarmTimer_Tick(object sender, EventArgs e)
        {
            // Выводим текущее время для отладки
            Console.WriteLine($"Текущее время: {DateTime.Now.ToString("HH:mm:ss")}, Время будильника: {alarmTime.ToString("HH:mm:ss")}");

            if (isAlarmSet && DateTime.Now >= alarmTime.AddSeconds(-5)) // Добавляем небольшую погрешность (5 секунд)
            {
                isAlarmSet = false; // Отключаем будильник после срабатывания
                MessageBox.Show("Будильник сработал!"); // Показываем сообщение
            }
        }

        // Обработчик для кнопки "Set Alarm" для установки будильника
        private void btnSetAlarm_Click(object sender, EventArgs e)
        {
            alarmTime = dtpAlarmTime.Value; // Получаем время из DateTimePicker
            isAlarmSet = true;
            lblAlarmTime.Text = $"Будильник установлен на: {alarmTime:HH:mm:ss}"; // Отображаем время установки будильника
            Console.WriteLine($"Будильник установлен на: {alarmTime.ToString("HH:mm:ss")}"); // Выводим в консоль для отладки
        }

        // Обработчик для кнопки "Stop Alarm" для остановки будильника
        private void btnStopAlarm_Click(object sender, EventArgs e)
        {
            isAlarmSet = false;
            lblAlarmTime.Text = "Будильник отключен";
            Console.WriteLine("Будильник отключен"); // Выводим в консоль для отладки
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void lblClock_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMinutes_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeconds_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
