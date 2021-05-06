using marathon_session1.PageApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace marathon_session1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer Timer { get; set; }
        public DateTime StartTime = DateTime.Parse("2015-09-05 06:00");
        public TimeSpan UntilTime => StartTime - DateTime.Now;
        public MainWindow()
        {
            InitializeComponent();
            Timer = new DispatcherTimer();
            Timer.Tick += new EventHandler(TimerTick);
            Timer.Interval = new TimeSpan(0, 0, 1);
            TimerTick(null, null);
            Timer.Start();
            MainFrame.Navigate(new StartPage());
        }
        public string TextTimer { get; set; }
        private void TimerTick(object sender, EventArgs e)
        {
            TextBlockTimer.Text = string.Format("{0} days {1} hours and {2} minutes until the race starts!", UntilTime.Days.ToString(), UntilTime.Hours, UntilTime.Minutes);
        }
    }
}
