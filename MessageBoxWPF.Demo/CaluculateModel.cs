using CommunityToolkit.Mvvm.DependencyInjection;
using MessageBoxWPF.Demo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MessageBoxWPF.Demo;

public class CaluculateModel
{
    private readonly IDialogService _dialogService = Ioc.Default.GetRequiredService<IDialogService>();

    public CaluculateModel(string windowGuid)
    {
        _dialogService.WindowGuid = windowGuid;
    }

    public double Add(int a, int b)
    {
        var c = a + b;
        var result = _dialogService.ShowDialogOnWindow($"{a} + {b} = {c}", "", "", MessageBoxButton.OK, MessageBoxImage.None);
        if (result != MessageBoxResult.OK) return 0;
        return c;
    }
}