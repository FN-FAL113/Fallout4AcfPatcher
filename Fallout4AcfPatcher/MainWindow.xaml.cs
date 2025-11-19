using Fallout4AcfPatcher.ViewModel;
using System.Diagnostics;
using System.Text;
using System.Windows;

namespace Fallout4AcfPatcher;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        // fixes animations not working on window style set none
        WindowStyle = WindowStyle.SingleBorderWindow;

        MainWindowViewModel viewModel = new MainWindowViewModel();

        DataContext = viewModel;
    }

    private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        e.Handled = true; // prevent other mouse events from firing

        DragMove();
    }

    private void minimizeBtn_Click(object sender, RoutedEventArgs e)
    {
        WindowState = WindowState.Minimized;
    }

    private void closeBtn_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        e.Handled = true; // prevent other mouse events from firing

        Process.Start(new ProcessStartInfo
        {
            FileName = "https://github.com/FN-FAL113",
            UseShellExecute = true
        });
    }
}