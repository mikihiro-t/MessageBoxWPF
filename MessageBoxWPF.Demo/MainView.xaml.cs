using System;
using System.Collections.Generic;
using System.Linq;
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

public partial class MainView : Window
{
    public MainView()
    {
        InitializeComponent();
    }
    private void ShowButton_Click(object sender, RoutedEventArgs e)
    {
        switch (((ComboBoxItem)DialogType.SelectedItem).Content.ToString())
        {
            case "Information":
                MessageEx.ShowInformationDialog(Message.Text);
                MessageEx.ShowInformationDialog(Message.Text, Appended.Text);
                MessageEx.ShowInformationDialog(Message.Text, Appended.Text, Help.Text);
                MessageEx.ShowInformationDialog(Message.Text, this);
                MessageEx.ShowInformationDialog(Message.Text, Appended.Text, this);
                MessageEx.ShowInformationDialog(Message.Text, Appended.Text, Help.Text, this);
                break;
            case "Question":
                MessageEx.ShowQuestionYesNoDialog(Message.Text);
                MessageEx.ShowQuestionYesNoDialog(Message.Text, Appended.Text);
                MessageEx.ShowQuestionYesNoDialog(Message.Text, Appended.Text, Help.Text);
                MessageEx.ShowQuestionYesNoDialog(Message.Text, this);
                MessageEx.ShowQuestionYesNoDialog(Message.Text, Appended.Text, this);
                MessageEx.ShowQuestionYesNoDialog(Message.Text, Appended.Text, Help.Text, this);
                break;
            case "Warning":
                MessageEx.ShowWarningDialog(Message.Text);
                MessageEx.ShowWarningDialog(Message.Text, Appended.Text);
                MessageEx.ShowWarningDialog(Message.Text, Appended.Text, Help.Text);
                MessageEx.ShowWarningDialog(Message.Text, this);
                MessageEx.ShowWarningDialog(Message.Text, Appended.Text, this);
                MessageEx.ShowWarningDialog(Message.Text, Appended.Text, Help.Text, this);
                break;
            case "Error":
                MessageEx.ShowErrorDialog(Message.Text);
                MessageEx.ShowErrorDialog(Message.Text, Appended.Text);
                MessageEx.ShowErrorDialog(Message.Text, Appended.Text, Help.Text);
                MessageEx.ShowErrorDialog(Message.Text, this);
                MessageEx.ShowErrorDialog(Message.Text, Appended.Text, this);
                MessageEx.ShowErrorDialog(Message.Text, Appended.Text, Help.Text, this);
                break;
        }
    }
    private void ShowInformationButton_Click(object sender, RoutedEventArgs e)
    {
        MessageEx.ShowInformation(Message.Text);
        MessageEx.ShowInformation(Message.Text, Appended.Text);
        MessageEx.ShowInformation(Message.Text, Appended.Text, Help.Text);
    }
    private void ShowWithGeneralOptionButton_Click(object sender, RoutedEventArgs e)
    {
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

        if (((Button)sender).Name == "ShowWithColorButton")
        {
            MessageEx.Show(Message.Text, Appended.Text, messageBoxButton, messageBoxImage, brush);
            MessageEx.Show(Message.Text, Appended.Text, Help.Text, messageBoxButton, messageBoxImage, brush);
        }
        else if (((Button)sender).Name == "ShowDialogWithColorButton")
        {
            MessageEx.ShowDialog(Message.Text, Appended.Text, messageBoxButton, messageBoxImage, brush);
            MessageEx.ShowDialog(Message.Text, Appended.Text, messageBoxButton, messageBoxImage, brush, this);
            MessageEx.ShowDialog(Message.Text, Appended.Text, Help.Text, messageBoxButton, messageBoxImage, brush, this);
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
                MaxHeight=500,
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
