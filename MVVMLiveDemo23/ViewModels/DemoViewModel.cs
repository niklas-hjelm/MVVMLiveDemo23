﻿using System.Threading;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVMLiveDemo23.Models;

namespace MVVMLiveDemo23.ViewModels;

public class DemoViewModel : ObservableObject
{
    private readonly DemoModel _demoModel;
    public string MyText
    {
        get { return _demoModel.MyText; }
        set
        {
            _demoModel.MyText = value;
            OnPropertyChanged();
        }
    }

    private string _myTextReversed;

    public string MyTextReversed
    {
        get { return _myTextReversed; }
        set
        {
            _myTextReversed = value;
            OnPropertyChanged();
        }
    }

    public IRelayCommand UpdateTextReversedCommand { get; }

    public DemoViewModel(DemoModel demoModel)
    {
        _demoModel = demoModel;

        UpdateTextReversedCommand = new RelayCommand(UpdateTextReversedCommandExecute);
    }

    private void UpdateTextReversedCommandExecute()
    {
        MyTextReversed = _demoModel.ReverseMyText();
    }
}