using Game_State.Models;
using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;
using Avalonia;
using ReactiveUI;
using System.Reflection.Emit;
using System.Reactive;
using System.Windows.Input;
using System.Reactive.Linq;
using Microsoft.VisualBasic;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Controls;

namespace Game_State.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ObservableCollection<Game> games;
    public Interaction<AddGameWindow, AddGameWindow> ShowDialog { get; }
    public ObservableCollection<Game> Games
    {
        get => games;
        set
        {
            this.RaiseAndSetIfChanged(ref games, value);
        }
    }
    private string text;
    public string Text
    {
        get => text;
        set
        {
            this.RaisePropertyChanged(nameof(text));
        }
    }
    public MainWindowViewModel() 
    {

    }
    public void ShowWindowCommand()
    {
        var dialogWindow = new AddGameWindow();

        var owner = Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop ? desktop.MainWindow : null;
        dialogWindow.ShowDialog(owner);
    }
    public void AddGameCommand(string name)
    {
        List<Game> game = new()
        {
            new Game("Dota 3",0,0,0)
        };
        Games = new ObservableCollection<Game>(game);
    }
}