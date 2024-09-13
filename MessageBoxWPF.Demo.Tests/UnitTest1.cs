using Xunit;
using MessageBoxWPF.Demo;
using System.Reflection;
using MessageBoxWPF.Demo.Service;
using System.Windows;
using System.Windows.Media;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace MessageBoxWPF.Demo.Tests;

public class UnitTestFixture
{
    public UnitTestFixture()
    {
        Ioc.Default.ConfigureServices(
            new ServiceCollection()
            .AddTransient<IDialogService, DialogServiceTest>()
            .BuildServiceProvider());
    }
}

public class UnitTest1 : IClassFixture<UnitTestFixture>
{
    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(2, 3, 5)]
    public void CaluculateTest(int a, int b, double expected)
    {
        var cls = new CaluculateModel("");
        var actual = cls.Add(a, b);

        Assert.Equal(expected, actual);
    }
}

public class DialogServiceTest : IDialogService
{
    public string WindowGuid { get; set; }

    public MessageBoxResult Show(string message, string messageAppend, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult Show(string message, string messageAppend, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowDialog(string message, string messageAppend, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowDialog(string message, string messageAppend, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowDialog(string message, string messageAppend, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowDialog(string message, string messageAppend, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowDialogOnWindow(string message, string messageAppend, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowDialogOnWindow(string message, string messageAppend, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowDialogOnWindow(string message, string messageAppend, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowDialogOnWindow(string message, string messageAppend, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowErrorDialog(string message)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowErrorDialog(string message, string messageAppend)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowErrorDialog(string message, string messageAppend, string help)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowErrorDialogOnWindow(string message)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowErrorDialogOnWindow(string message, string messageAppend)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowErrorDialogOnWindow(string message, string messageAppend, string help)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowInformation(string message)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowInformation(string message, string messageAppend)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowInformation(string message, string messageAppend, string help)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowInformationDialog(string message)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowInformationDialog(string message, string messageAppend)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowInformationDialog(string message, string messageAppend, string help)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowInformationDialogOnWindow(string message)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowInformationDialogOnWindow(string message, string messageAppend)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowInformationDialogOnWindow(string message, string messageAppend, string help)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowMessageBoxEx(string message, string appendedMessage, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color, Dictionary<string, object> properties)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowMessageBoxExOnWindow(string message, string appendedMessage, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color, Dictionary<string, object> properties)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionOKCancelCustomCaptionDialog(string message, string okCaption, string cancelCaption)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionOKCancelCustomCaptionDialog(string message, string messageAppend, string okCaption, string cancelCaption)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionOKCancelCustomCaptionDialog(string message, string messageAppend, string help, string okCaption, string cancelCaption)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionOKCancelCustomCaptionDialogOnWindow(string message, string okCaption, string cancelCaption)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionOKCancelCustomCaptionDialogOnWindow(string message, string messageAppend, string okCaption, string cancelCaption)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionOKCancelCustomCaptionDialogOnWindow(string message, string messageAppend, string help, string okCaption, string cancelCaption)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionOKCancelDialog(string message)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionOKCancelDialog(string message, string messageAppend)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionOKCancelDialog(string message, string messageAppend, string help)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionOKCancelDialogOnWindow(string message)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionOKCancelDialogOnWindow(string message, string messageAppend)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionOKCancelDialogOnWindow(string message, string messageAppend, string help)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialog(string message, string yesCaption, string noCaption, string cancelCaption)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialog(string message, string messageAppend, string yesCaption, string noCaption, string cancelCaption)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialog(string message, string messageAppend, string help, string yesCaption, string noCaption, string cancelCaption)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialogOnWindow(string message, string yesCaption, string noCaption, string cancelCaption)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialogOnWindow(string message, string messageAppend, string yesCaption, string noCaption, string cancelCaption)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialogOnWindow(string message, string messageAppend, string help, string yesCaption, string noCaption, string cancelCaption)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionYesNoCancelDialog(string message)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionYesNoCancelDialog(string message, string messageAppend)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionYesNoCancelDialog(string message, string messageAppend, string help)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionYesNoCancelDialogOnWindow(string message)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionYesNoCancelDialogOnWindow(string message, string messageAppend)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionYesNoCancelDialogOnWindow(string message, string messageAppend, string help)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionYesNoDialog(string message)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionYesNoDialog(string message, string messageAppend)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionYesNoDialog(string message, string messageAppend, string help)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionYesNoDialogOnWindow(string message)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionYesNoDialogOnWindow(string message, string messageAppend)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowQuestionYesNoDialogOnWindow(string message, string messageAppend, string help)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowWarningDialog(string message)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowWarningDialog(string message, string messageAppend)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowWarningDialog(string message, string messageAppend, string help)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowWarningDialogOnWindow(string message)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowWarningDialogOnWindow(string message, string messageAppend)
    {
        return MessageBoxResult.OK;
    }

    public MessageBoxResult ShowWarningDialogOnWindow(string message, string messageAppend, string help)
    {
        return MessageBoxResult.OK;
    }
}