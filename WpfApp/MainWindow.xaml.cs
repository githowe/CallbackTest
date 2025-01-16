using System.Windows;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Interop.SetCallback(Callback);
            Task task = new Task(Interop.Start, TaskCreationOptions.LongRunning);
            task.Start();
        }

        private void Callback(IntPtr data)
        {
        }
    }
}