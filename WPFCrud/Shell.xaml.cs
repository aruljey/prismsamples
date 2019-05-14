using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
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

namespace WPFCrud
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    [Export] 
    public partial class Shell : Window
    {
        private readonly DispatcherTimer _timer;
        public Shell()
        {
            InitializeComponent();

            _timer=new DispatcherTimer();
            _timer.Tick += TimerTick;
            TimeLabel.Text = "...";
        }

        private void TimerTick(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortDateString();
            TimeLabel.Text = TimeLabel.Text.Contains(":") ? time.Replace(":", " ") : time;
        }

        private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Start();
        }

        private void UIElement_OnMouseWheel(object sender, MouseWheelEventArgs e)
        {
                
        }

        private void TextBlockMouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
