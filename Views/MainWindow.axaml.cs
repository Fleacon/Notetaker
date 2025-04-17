using Avalonia.Controls;
using Notetaker.ViewModels;

namespace Notetaker.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
    
}