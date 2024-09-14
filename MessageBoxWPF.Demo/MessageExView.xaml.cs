using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MessageBoxWPF.Demo;

/// <summary>
/// The DI container is not used.
/// The MessageEx Class or MessageBoxEx Class is used.
/// </summary>
public partial class MessageExView : Window
{
    public MessageExView()
    {
        InitializeComponent();
    }

    private void ShowButton_Click(object sender, RoutedEventArgs e)
    {
        var message = Message.Text;
        var appended = Appended.Text;
        var help = Help.Text;

        switch (((ComboBoxItem)DialogType.SelectedItem).Content.ToString())
        {
            case "Information":
                MessageEx.ShowInformation(message);
                MessageEx.ShowInformation(message, appended);
                MessageEx.ShowInformation(message, appended, help);

                MessageEx.ShowInformationDialog(message);
                MessageEx.ShowInformationDialog(message, appended);
                MessageEx.ShowInformationDialog(message, appended, help);

                MessageEx.ShowInformationDialog(message, this);
                MessageEx.ShowInformationDialog(message, appended, this);
                MessageEx.ShowInformationDialog(message, appended, help, this);
                break;

            case "Question YesNo":
                MessageEx.ShowQuestionYesNoDialog(message);
                MessageEx.ShowQuestionYesNoDialog(message, appended);
                MessageEx.ShowQuestionYesNoDialog(message, appended, help);

                MessageEx.ShowQuestionYesNoDialog(message, this);
                MessageEx.ShowQuestionYesNoDialog(message, appended, this);
                MessageEx.ShowQuestionYesNoDialog(message, appended, help, this);
                break;

            case "Question YesNoCancel":
                MessageEx.ShowQuestionYesNoCancelDialog(message);
                MessageEx.ShowQuestionYesNoCancelDialog(message, appended);
                MessageEx.ShowQuestionYesNoCancelDialog(message, appended, help);

                MessageEx.ShowQuestionYesNoCancelCustomCaptionDialog(message, "yes", "no", "cancel");
                MessageEx.ShowQuestionYesNoCancelCustomCaptionDialog(message, appended, "yes", "no", "cancel");
                MessageEx.ShowQuestionYesNoCancelCustomCaptionDialog(message, appended, help, "yes", "no", "cancel");

                MessageEx.ShowQuestionYesNoCancelDialog(message, this);
                MessageEx.ShowQuestionYesNoCancelDialog(message, appended, this);
                MessageEx.ShowQuestionYesNoCancelDialog(message, appended, help, this);

                MessageEx.ShowQuestionYesNoCancelCustomCaptionDialog(message, "yes", "no", "cancel", this);
                MessageEx.ShowQuestionYesNoCancelCustomCaptionDialog(message, appended, "yes", "no", "cancel", this);
                MessageEx.ShowQuestionYesNoCancelCustomCaptionDialog(message, appended, help, "yes", "no", "cancel", this);
                break;

            case "Question OKCancel":
                MessageEx.ShowQuestionOKCancelDialog(message);
                MessageEx.ShowQuestionOKCancelDialog(message, appended);
                MessageEx.ShowQuestionOKCancelDialog(message, appended, help);

                MessageEx.ShowQuestionOKCancelCustomCaptionDialog(message, "ok", "cancel");
                MessageEx.ShowQuestionOKCancelCustomCaptionDialog(message, appended, "ok", "cancel");
                MessageEx.ShowQuestionOKCancelCustomCaptionDialog(message, appended, help, "ok", "cancel");

                MessageEx.ShowQuestionOKCancelDialog(message, this);
                MessageEx.ShowQuestionOKCancelDialog(message, appended, this);
                MessageEx.ShowQuestionOKCancelDialog(message, appended, help, this);

                MessageEx.ShowQuestionOKCancelCustomCaptionDialog(message, "ok", "cancel", this);
                MessageEx.ShowQuestionOKCancelCustomCaptionDialog(message, appended, "ok", "cancel", this);
                MessageEx.ShowQuestionOKCancelCustomCaptionDialog(message, appended, help, "ok", "cancel", this);
                break;

            case "Warning":
                MessageEx.ShowWarningDialog(message);
                MessageEx.ShowWarningDialog(message, appended);
                MessageEx.ShowWarningDialog(message, appended, help);

                MessageEx.ShowWarningDialog(message, this);
                MessageEx.ShowWarningDialog(message, appended, this);
                MessageEx.ShowWarningDialog(message, appended, help, this);
                break;

            case "Error":
                MessageEx.ShowErrorDialog(message);
                MessageEx.ShowErrorDialog(message, appended);
                MessageEx.ShowErrorDialog(message, appended, help);

                MessageEx.ShowErrorDialog(message, this);
                MessageEx.ShowErrorDialog(message, appended, this);
                MessageEx.ShowErrorDialog(message, appended, help, this);
                break;
        }
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

            case "Question YesNo":
            case "Question YesNoCancel":
            case "Question OKCancel":
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

        if (((Button)sender).Name == "ShowWithParameters")
        {
            MessageEx.Show(message, appended, messageBoxButton, messageBoxImage, brush);
            MessageEx.Show(message, appended, help, messageBoxButton, messageBoxImage, brush);
        }
        else if (((Button)sender).Name == "ShowDialogWithParameters")
        {
            MessageEx.ShowDialog(message, appended, messageBoxButton, messageBoxImage);
            MessageEx.ShowDialog(message, appended, help, messageBoxButton, messageBoxImage);

            MessageEx.ShowDialog(message, appended, messageBoxButton, messageBoxImage, this);
            MessageEx.ShowDialog(message, appended, help, messageBoxButton, messageBoxImage, this);

            MessageEx.ShowDialog(message, appended, messageBoxButton, messageBoxImage, brush);
            MessageEx.ShowDialog(message, appended, help, messageBoxButton, messageBoxImage, brush);

            MessageEx.ShowDialog(message, appended, messageBoxButton, messageBoxImage, brush, this);
            MessageEx.ShowDialog(message, appended, help, messageBoxButton, messageBoxImage, brush, this);
        }
        else
        {//Show With Options Button
            var cls = new MessageBoxEx()
            {
                //MessageBoxEx Property
                IsEnabledEffect = true,
                Color = brush,
                Message = Message.Text,
                AppendedMessage = Appended.Text,
                Help = Help.Text,
                Image = messageBoxImage,
                Button = messageBoxButton,
                //Owner = this,
                OKCaption = "ok",
                NoCaption = "no",
                YesCaption = "yes",
                CancelCaption = "cancel",
                BackgroundColor = (SolidColorBrush)new BrushConverter().ConvertFromString("#f3f2f1"),

                //WindowProperty
                SizeToContent = SizeToContent.Manual,
                Width = 500,
                Height = 500,
                MaxHeight = 500,
            };
            cls.ShowDialog();

            var cls2 = new MessageBoxEx()
            {
                //MessageBoxEx Property
                IsEnabledEffect = true,
                Color = brush,
                Message = Message.Text,
                AppendedMessage = Appended.Text,
                Help = Help.Text,
                Image = messageBoxImage,
                Button = messageBoxButton,
                Owner = this,
                OKCaption = "ok",
                NoCaption = "no",
                YesCaption = "yes",
                CancelCaption = "cancel",
                BackgroundColor = (SolidColorBrush)new BrushConverter().ConvertFromString("#f3f2f1"),

                //WindowProperty
                SizeToContent = SizeToContent.Manual,
                Width = 600,
                Height = 300,
                MaxHeight = 300,
            };
            cls2.ShowDialog();
        }
    }
}