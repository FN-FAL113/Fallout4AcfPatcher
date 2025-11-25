using Fallout4AcfPatcher.ViewModel;
using System.Diagnostics;
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
        // prevent other mouse event listeners from being triggered
        e.Handled = true; 

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

    private void Info_Button_Click(object sender, RoutedEventArgs e)
    {
        // prevent other mouse event listeners from being triggered
        e.Handled = true;

        MessageBox.Show(
            this,
            "Version: " + Environment.NewLine +
            "1.0.1" + Environment.NewLine +
            "Supported Game Version: " + Environment.NewLine +
            "Anniversary Update" + Environment.NewLine +
            Environment.NewLine +
            "Also works for Creation Kit, just patch the manifests file (appmanifest_1946160.acf)" + 
            Environment.NewLine +
            Environment.NewLine +
            "If you benefit from this app, a star on github repo is appreciated! Donations are also welcome." +
            Environment.NewLine +
            Environment.NewLine +
            "Please create an issue ticket on github if the patcher is not able to patch latest update.",
            "",
            MessageBoxButton.OK,
            MessageBoxImage.Information
        );
    }

    private void Github_Button_Click(object sender, RoutedEventArgs e)
    {
        // prevent other mouse event listeners from being triggered
        e.Handled = true; 

        Process.Start(new ProcessStartInfo
        {
            FileName = "https://github.com/FN-FAL113/Fallout4AcfPatcher",
            UseShellExecute = true
        });
    }
}