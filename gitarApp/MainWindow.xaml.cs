using Microsoft.Win32;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace gitarApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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
    }
}

