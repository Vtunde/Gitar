using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace gitarApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isScrolling = false;
        private DispatcherTimer scrollTimer;
        public MainWindow()
        {
            InitializeComponent();
            scrollTimer = new DispatcherTimer();
            scrollTimer.Interval = TimeSpan.FromMilliseconds(50); // Állítsd be a kívánt sebességet
            scrollTimer.Tick += ScrollTimer_Tick;
        }


        private void paranoid_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FilePathTextBlock.Text = File.ReadAllText("paranoid.txt");
                mainWindow.Title = File.ReadLines("paranoid.txt").First();
            }
            catch { MessageBox.Show("A fájl nem található"); }
        }

        private void sweet_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FilePathTextBlock.Text = File.ReadAllText("sweethome.txt");
                mainWindow.Title = File.ReadLines("sweethome.txt").First();
            }
            catch { MessageBox.Show("A fájl nem található"); }
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FilePathTextBlock.Text = File.ReadAllText("threelittlebirds.txt");
                mainWindow.Title = File.ReadLines("threelittlebirds.txt").First();
            }
            catch { MessageBox.Show("A fájl nem található"); }
        }

        private void openFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true) { FilePathTextBlock.Text = File.ReadAllText(openFileDialog.FileName); }
        }

        private void consolas_Click(object sender, RoutedEventArgs e)
        {
            FilePathTextBlock.FontFamily = new FontFamily("Consolas");
        }

        private void cascadiamono_Click(object sender, RoutedEventArgs e)
        {
            FilePathTextBlock.FontFamily = new FontFamily("Cascadia Mono");
        }

        private void cascadiamonosemibold_Click(object sender, RoutedEventArgs e)
        {
            FilePathTextBlock.FontFamily = new FontFamily("Cascadia Mono SemiBold");
        }


        private void ScrollTimer_Tick(object sender, EventArgs e)
        {
            if (myScrollViewer.VerticalOffset < myScrollViewer.ScrollableHeight)
            {
                myScrollViewer.ScrollToVerticalOffset(myScrollViewer.VerticalOffset + 1);
            }
            else
            {
                scrollTimer.Stop(); // Állítsd le a scrollt, ha elérted az alját
                isScrolling = false;
            }
        }

        private void autoscroll_Click(object sender, RoutedEventArgs e)
        {
            if (isScrolling)
            {
                scrollTimer.Stop();
                isScrolling = false;
            }
            else
            {
                scrollTimer.Start();
                isScrolling = true;
            }
        }
        int defaultFontSize = 12;
        private void increaseFontSizeBtn_Click(object sender, RoutedEventArgs e)
        {
            FilePathTextBlock.FontSize++;
        }
        private void defaultFontSizeBtn_Click(object sender, RoutedEventArgs e)
        {
            FilePathTextBlock.FontSize = defaultFontSize;
        }

        private void decreaseFontSizeBtn_Click(object sender, RoutedEventArgs e)
        {
            FilePathTextBlock.FontSize--;
        }

    }
}

