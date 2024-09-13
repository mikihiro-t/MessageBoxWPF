using CommunityToolkit.Mvvm.DependencyInjection;
using MessageBoxWPF.Demo.Service;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MessageBoxWPF.Demo;

public partial class MainWindow : Window
{
    private readonly IDialogService _dialogService = Ioc.Default.GetRequiredService<IDialogService>();

    public MainWindow()
    {
        InitializeComponent();

        Tag = _dialogService.WindowGuid;
    }

    private void ShowInformationButton_Click(object sender, RoutedEventArgs e)
    {
        var message = Message.Text;
        var appended = Appended.Text;
        var help = Help.Text;

        _dialogService.ShowInformation(message);
        _dialogService.ShowInformation(message, appended);
        _dialogService.ShowInformation(message, appended, help);

        _dialogService.ShowInformationDialog(message);
        _dialogService.ShowInformationDialog(message, appended);
        _dialogService.ShowInformationDialog(message, appended, help);

        _dialogService.ShowInformationDialogOnWindow(message);
        _dialogService.ShowInformationDialogOnWindow(message, appended);
        _dialogService.ShowInformationDialogOnWindow(message, appended, help);
    }

    private void ShowQuestionYesNoButton_Click(object sender, RoutedEventArgs e)
    {
        var message = Message.Text;
        var appended = Appended.Text;
        var help = Help.Text;

        _dialogService.ShowQuestionYesNoDialog(message);
        _dialogService.ShowQuestionYesNoDialog(message, appended);
        _dialogService.ShowQuestionYesNoDialog(message, appended, help);

        _dialogService.ShowQuestionYesNoDialogOnWindow(message);
        _dialogService.ShowQuestionYesNoDialogOnWindow(message, appended);
        _dialogService.ShowQuestionYesNoDialogOnWindow(message, appended, help);
    }

    private void ShowQuestionYesNoCancelButton_Click(object sender, RoutedEventArgs e)
    {
        var message = Message.Text;
        var appended = Appended.Text;
        var help = Help.Text;

        _dialogService.ShowQuestionYesNoCancelDialog(message);
        _dialogService.ShowQuestionYesNoCancelDialog(message, appended);
        _dialogService.ShowQuestionYesNoCancelDialog(message, appended, help);

        _dialogService.ShowQuestionYesNoCancelCustomCaptionDialog(message, "yes", "no", "cancel");
        _dialogService.ShowQuestionYesNoCancelCustomCaptionDialog(message, appended, "yes", "no", "cancel");
        _dialogService.ShowQuestionYesNoCancelCustomCaptionDialog(message, appended, help, "yes", "no", "cancel");

        _dialogService.ShowQuestionYesNoCancelDialogOnWindow(message);
        _dialogService.ShowQuestionYesNoCancelDialogOnWindow(message, appended);
        _dialogService.ShowQuestionYesNoCancelDialogOnWindow(message, appended, help);

        _dialogService.ShowQuestionYesNoCancelCustomCaptionDialogOnWindow(message, "yes", "no", "cancel");
        _dialogService.ShowQuestionYesNoCancelCustomCaptionDialogOnWindow(message, appended, "yes", "no", "cancel");
        _dialogService.ShowQuestionYesNoCancelCustomCaptionDialogOnWindow(message, appended, help, "yes", "no", "cancel");
    }

    private void ShowQuestionOKCancelButton_Click(object sender, RoutedEventArgs e)
    {
        var message = Message.Text;
        var appended = Appended.Text;
        var help = Help.Text;

        _dialogService.ShowQuestionOKCancelDialog(message);
        _dialogService.ShowQuestionOKCancelDialog(message, appended);
        _dialogService.ShowQuestionOKCancelDialog(message, appended, help);

        _dialogService.ShowQuestionOKCancelCustomCaptionDialog(message, "ok", "cancel");
        _dialogService.ShowQuestionOKCancelCustomCaptionDialog(message, appended, "ok", "cancel");
        _dialogService.ShowQuestionOKCancelCustomCaptionDialog(message, appended, help, "ok", "cancel");

        _dialogService.ShowQuestionOKCancelDialogOnWindow(message);
        _dialogService.ShowQuestionOKCancelDialogOnWindow(message, appended);
        _dialogService.ShowQuestionOKCancelDialogOnWindow(message, appended, help);

        _dialogService.ShowQuestionOKCancelCustomCaptionDialogOnWindow(message, "ok", "cancel");
        _dialogService.ShowQuestionOKCancelCustomCaptionDialogOnWindow(message, appended, "ok", "cancel");
        _dialogService.ShowQuestionOKCancelCustomCaptionDialogOnWindow(message, appended, help, "ok", "cancel");
    }

    private void ShowWarningButton_Click(object sender, RoutedEventArgs e)
    {
        var message = Message.Text;
        var appended = Appended.Text;
        var help = Help.Text;

        _dialogService.ShowWarningDialog(message);
        _dialogService.ShowWarningDialog(message, appended);
        _dialogService.ShowWarningDialog(message, appended, help);

        _dialogService.ShowWarningDialogOnWindow(message);
        _dialogService.ShowWarningDialogOnWindow(message, appended);
        _dialogService.ShowWarningDialogOnWindow(message, appended, help);
    }

    private void ShowErrorButton_Click(object sender, RoutedEventArgs e)
    {
        var message = Message.Text;
        var appended = Appended.Text;
        var help = Help.Text;

        _dialogService.ShowErrorDialog(message);
        _dialogService.ShowErrorDialog(message, appended);
        _dialogService.ShowErrorDialog(message, appended, help);

        _dialogService.ShowErrorDialogOnWindow(message);
        _dialogService.ShowErrorDialogOnWindow(message, appended);
        _dialogService.ShowErrorDialogOnWindow(message, appended, help);
    }

    private void ShowWithGeneralOptionButton_Click(object sender, RoutedEventArgs e)
    {
        var message = Message.Text;
        var appended = Appended.Text;
        var help = Help.Text;

        MessageBoxButton messageBoxButton;
        MessageBoxImage messageBoxImage;
        switch (((ComboBoxItem)DialogType.SelectedItem).Content.ToString())
        {
            case "Information":
                messageBoxImage = MessageBoxImage.Information;
                break;

            case "Question":
                messageBoxImage = MessageBoxImage.Question;
                break;

            case "Warning":
                messageBoxImage = MessageBoxImage.Warning;
                break;

            case "Error":
                messageBoxImage = MessageBoxImage.Error;
                break;

            default:
                return;
        }
        switch (((ComboBoxItem)ButtonType.SelectedItem).Content.ToString())
        {
            case "OK":
                messageBoxButton = MessageBoxButton.OK;
                break;

            case "OKCancel":
                messageBoxButton = MessageBoxButton.OKCancel;
                break;

            case "YesNo":
                messageBoxButton = MessageBoxButton.YesNo;
                break;

            case "YesNoCancel":
                messageBoxButton = MessageBoxButton.YesNoCancel;
                break;

            default:
                return;
        }

        SolidColorBrush brush;
        try
        {
            brush = (SolidColorBrush)new BrushConverter().ConvertFromString(Color.Text);
            if (brush is null) return;
        }
        catch (Exception ex)
        {
            MessageEx.ShowErrorDialog("Color is Invalid", ex.Message, this);
            return;
        }
        if (((Button)sender).Name == "ShowDialogButton")
        {
            _dialogService.ShowDialogOnWindow(message, appended, messageBoxButton, messageBoxImage);

            _dialogService.ShowDialogOnWindow(message, appended, help, messageBoxButton, messageBoxImage);
            _dialogService.ShowDialogOnWindow(message, appended, messageBoxButton, messageBoxImage, brush);
            _dialogService.ShowDialogOnWindow(message, appended, help, messageBoxButton, messageBoxImage, brush);
        }
        else if (((Button)sender).Name == "ShowWithColorButton")
        {
            _dialogService.Show(message, appended, messageBoxButton, messageBoxImage, brush);
            _dialogService.Show(message, appended, help, messageBoxButton, messageBoxImage, brush);
        }
        else if (((Button)sender).Name == "ShowDialogWithColorButton")
        {
            _dialogService.ShowDialog(message, appended, messageBoxButton, messageBoxImage);
            _dialogService.ShowDialog(message, appended, help, messageBoxButton, messageBoxImage);
            _dialogService.ShowDialog(message, appended, messageBoxButton, messageBoxImage, brush);
            _dialogService.ShowDialog(message, appended, help, messageBoxButton, messageBoxImage, brush);
        }
        else
        {//Show With Options Button
            var properties = new Dictionary<string, object>()
            {
                 //MessageBoxEx Property
                { "IsEnabledEffect", true},
                //{ "Owner", this},　//SetValueでエラー
                { "OKCaption" ,   "ok"},
                { "NoCaption" ,  "no"},
                { "YesCaption" ,  "yes"},
                { "CancelCaption" ,   "cancel"},
                { "BackgroundString" ,"#f3f2f1"}, //System.Windows.Media.Brushを、BackgroundColorに、直接SetValueすると、エラーになるため文字列を利用にした。

                //WindowProperty
                { "SizeToContent", SizeToContent.Manual },
                { "Width", 500 },
                { "Height", 500 },
                { "MaxHeight", 500 },
            };

            _dialogService.ShowMessageBoxEx(message, appended, help, messageBoxButton, messageBoxImage, brush, properties);

            var properties2 = new Dictionary<string, object>()
            {
                 //MessageBoxEx Property
                { "IsEnabledEffect", true},
                { "OKCaption" ,   "ok"},
                { "NoCaption" ,  "no"},
                { "YesCaption" ,  "yes"},
                { "CancelCaption" ,   "cancel"},
                { "BackgroundString" ,"#f3f2f1"},

                //WindowProperty
                { "SizeToContent", SizeToContent.Manual },
                { "Width", 600 },
                { "Height", 300 },
                { "MaxHeight", 300 },
            };
            _dialogService.ShowMessageBoxExOnWindow(message, appended, help, messageBoxButton, messageBoxImage, brush, properties2);
        }
    }
}