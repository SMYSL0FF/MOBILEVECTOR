using MOBILEVECTOR.Core;
using MOBILEVECTOR.View;
using System.Windows;
using System.Windows.Input;

namespace MOBILEVECTOR
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FrameNavigate.FrameObject = MainWindowFrame;
        }

        private void Btn_new_employee_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new New_employee());
        }

        private void Btn_Authorization_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new Authorization());
        }

        private void Btn_status_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new Status());
        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove(); 
        }
    }
}
