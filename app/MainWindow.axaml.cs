using Avalonia.Controls;
using Avalonia.Interactivity;

namespace app;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object? sender, RoutedEventArgs e)
    {
        textBox.Text = "click";
    }
}