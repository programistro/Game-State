using Avalonia.Controls;
using Avalonia.ReactiveUI;
using Game_State.ViewModels;
using ReactiveUI;
using System;
using System.Threading.Tasks;

namespace Game_State.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void MenuItemExit_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Environment.Exit(0);
    }
}