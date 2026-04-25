using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyPomodorro
{
    public partial class MainForm : Form
    {
        private enum PomodoroPhase
        {
            Work,
            ShortBreak,
            LongBreak
        }


        private Timer mainTimer;
        private int remainingSeconds;
        private bool isRunning = false;
        private int currentCycle = 1;
        private PomodoroPhase currentPhase = PomodoroPhase.Work;


        public MainForm()
        {
            InitializeComponent();
            InitializeTimer();
            ResetToInitialState();

            lblTimer.ForeColor = Color.DarkGreen;
            lblPhase.ForeColor = Color.DarkGreen;
            tlStpMnItmTimer.ForeColor = Color.DarkGreen;
        }


        private void InitializeTimer()
        {
            mainTimer = new Timer();
            mainTimer.Interval = 1000;
            mainTimer.Tick += MainTimer_Tick;
        }

        private void ResetToInitialState()
        {
            mainTimer.Stop();
            isRunning = false;
            currentCycle = 1;
            currentPhase = PomodoroPhase.Work;
            remainingSeconds = (int)nmrUpDnCycleLength.Value * 60;

            UpdateDisplay();

            lblTimer.ForeColor = SystemColors.ControlText;
            lblPhase.ForeColor = SystemColors.ControlText;

            btnStart.Text = "Старт";
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }
        private void UpdateDisplay()
        {
            lblTimer.Text = FormatTime(remainingSeconds);
            tlStpMnItmTimer.Text = lblTimer.Text;
            tlStpMnItmTimer.ForeColor = lblTimer.ForeColor;

            lblCycle.Text = $"{currentCycle} / {nmrUpDnCycles.Value}";

            string phaseText = "";

            switch (currentPhase)
            {
                case PomodoroPhase.Work:
                    phaseText = "Работа";
                    break;

                case PomodoroPhase.ShortBreak:
                    phaseText = "Короткий перерыв";
                    break;

                case PomodoroPhase.LongBreak:
                    phaseText = "Длинный перерыв";
                    break;

                default:
                    phaseText = "";
                    break;
            }


            lblPhase.Text = phaseText;
            if (currentPhase == PomodoroPhase.Work)
            {
                lblTimer.ForeColor = Color.DarkGreen;
                lblPhase.ForeColor = Color.DarkGreen;
            }
            else if (currentPhase == PomodoroPhase.ShortBreak)
            {
                lblTimer.ForeColor = Color.DarkOrange;
                lblPhase.ForeColor = Color.DarkOrange;
            }
            else if (currentPhase == PomodoroPhase.LongBreak)
            {
                lblTimer.ForeColor = Color.DarkRed;
                lblPhase.ForeColor = Color.DarkRed;
            }
            else
            {
                lblTimer.ForeColor = SystemColors.ControlText;
                lblPhase.ForeColor = SystemColors.ControlText;
            }

            string nextText = currentPhase == PomodoroPhase.Work ? (currentCycle % nmrUpDnCycles.Value == 0 ? nmrUpDnLongBreak.Value : nmrUpDnShortBreak.Value).ToString() : nmrUpDnCycleLength.Value.ToString();

            lblNextBreak.Text = nextText;
        }
        private string FormatTime(int totalSeconds)
        {
            int min = totalSeconds / 60;
            int sec = totalSeconds % 60;
            return $"{min:D2}:{sec:D2}";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                mainTimer.Stop();
                isRunning = false;
                btnStart.Text = "▶️";
            }
            else
            {
                if (remainingSeconds == 0)
                {
                    remainingSeconds = (int)nmrUpDnCycleLength.Value * 60;
                    currentPhase = PomodoroPhase.Work;
                    currentCycle = 1;
                }

                mainTimer.Start();
                isRunning = true;
                btnStart.Text = "⏸️";
                
                nmrUpDnCycleLength.Enabled = false;
                nmrUpDnShortBreak.Enabled = false;
                nmrUpDnLongBreak.Enabled = false;
                nmrUpDnCycles.Enabled = false;
            }

            btnStop.Enabled = isRunning;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            mainTimer.Stop();
            isRunning = false;
            btnStart.Text = "Старт";
            btnStop.Enabled = false;

            ResetToInitialState();

            nmrUpDnCycleLength.Enabled = true;
            nmrUpDnShortBreak.Enabled = true;
            nmrUpDnLongBreak.Enabled = true;
            nmrUpDnCycles.Enabled = true;
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            if (remainingSeconds > 0)
            {
                remainingSeconds--;
                UpdateDisplay();
            }
            else
            {
                mainTimer.Stop();
                isRunning = false;
                ShowNotification($"{currentPhase} завершён!");
                GoToNextPhase();
            }
        }

        private void GoToNextPhase()
        {
            if (currentPhase == PomodoroPhase.Work)
            {
                if (currentCycle % (int)nmrUpDnCycles.Value == 0)
                {
                    currentPhase = PomodoroPhase.LongBreak;
                    remainingSeconds = (int)nmrUpDnLongBreak.Value * 60;
                }
                else
                {
                    currentPhase = PomodoroPhase.ShortBreak;
                    remainingSeconds = (int)nmrUpDnShortBreak.Value * 60;
                }
            }
            else
            {
                if (currentPhase == PomodoroPhase.LongBreak)
                {
                    ShowNotification("Серия завершена! Отличная работа!");
                    ResetToInitialState();
                    return;
                }
                else
                {
                    currentPhase = PomodoroPhase.Work;
                    remainingSeconds = (int)nmrUpDnCycleLength.Value * 60;
                    currentCycle++;
                }
            }

            UpdateDisplay();
            mainTimer.Start();
            isRunning = true;
            btnStart.Text = "⏸️";
        }
        private void ShowNotification(string message)
        {
            ntfIcMain.Visible = true;
            ntfIcMain.ShowBalloonTip(4000, "Pomodoro", message, ToolTipIcon.Info);
            System.Media.SystemSounds.Exclamation.Play();
        }

        private void btnHide_Click(object sender, EventArgs e) => this.Hide();
        private void tlStpMnItmOpen_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
        private void tlStpMnItmClose_Click(object sender, EventArgs e)
        {
            mainTimer?.Stop();
            mainTimer?.Dispose();

            ntfIcMain?.Dispose();

            Application.Exit();
        }

        private void nmrCycleLength_ValueChanged(object sender, EventArgs e)
        {
            if (!isRunning && currentPhase == PomodoroPhase.Work)
            {
                remainingSeconds = (int)nmrUpDnCycleLength.Value * 60;
                UpdateDisplay();
            }
        }
        private void nmrShortBreak_ValueChanged(object sender, EventArgs e) => UpdateDisplay();
        private void nmrLongBreak_ValueChanged(object sender, EventArgs e) => UpdateDisplay();
        private void nmrCycles_ValueChanged(object sender, EventArgs e) => UpdateDisplay();
    }
}