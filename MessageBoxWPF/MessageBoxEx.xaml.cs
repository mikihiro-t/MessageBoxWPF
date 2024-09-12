using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace MessageBoxWPF;

public static class MessageEx
{
    #region Information Dialog

    /// <summary>
    /// Information Show
    /// </summary>
    /// <param name="message"></param>
    /// <returns>System.Windows.MessageBoxResult.None</returns>
    public static MessageBoxResult ShowInformation(string message)
    {
        return ShowInformation(message, "", "");
    }

    /// <summary>
    /// Information Show with Appended Message
    /// </summary>
    /// <param name="message"></param>
    /// <param name="appendedMessage"></param>
    /// <returns>System.Windows.MessageBoxResult.None</returns>
    public static MessageBoxResult ShowInformation(string message, string appendedMessage)
    {
        return ShowInformation(message, appendedMessage, "");
    }

    /// <summary>
    /// Information Show with Appended Message and Help
    /// </summary>
    /// <param name="message"></param>
    /// <param name="appendedMessage"></param>
    /// <param name="help"></param>
    /// <returns>System.Windows.MessageBoxResult.None</returns>
    public static MessageBoxResult ShowInformation(string message, string appendedMessage, string help)
    {
        var cls = new MessageBoxEx(message, appendedMessage, help, MessageBoxButton.OK, MessageBoxImage.Information);
        cls.Show();
        return cls.Result;
    }

    public static MessageBoxResult ShowInformationDialog(string message)
    {
        return ShowInformationDialog(message, "", "");
    }

    public static MessageBoxResult ShowInformationDialog(string message, string appendedMessage)
    {
        return ShowInformationDialog(message, appendedMessage, "");
    }

    public static MessageBoxResult ShowInformationDialog(string message, string appendedMessage, string help)
    {
        var cls = new MessageBoxEx(message, appendedMessage, help, MessageBoxButton.OK, MessageBoxImage.Information);
        cls.ShowDialog();
        return cls.Result;
    }

    public static MessageBoxResult ShowInformationDialog(string message, Window owner)
    {
        return ShowInformationDialog(message, "", "", owner);
    }

    public static MessageBoxResult ShowInformationDialog(string message, string appendedMessage, Window owner)
    {
        return ShowInformationDialog(message, appendedMessage, "", owner);
    }

    public static MessageBoxResult ShowInformationDialog(string message, string appendedMessage, string help, Window owner)
    {
        owner.Opacity = 0.7;
        var cls = new MessageBoxEx(message, appendedMessage, help, MessageBoxButton.OK, MessageBoxImage.Information, owner);
        cls.ShowDialog();
        owner.Opacity = 1;
        return cls.Result;
    }

    #endregion

    #region Question YesNo Dialog

    public static MessageBoxResult ShowQuestionYesNoDialog(string message)
    {
        return ShowQuestionYesNoDialog(message, "", "");
    }

    public static MessageBoxResult ShowQuestionYesNoDialog(string message, string appendedMessage)
    {
        return ShowQuestionYesNoDialog(message, appendedMessage, "");
    }

    public static MessageBoxResult ShowQuestionYesNoDialog(string message, string appendedMessage, string help)
    {
        var cls = new MessageBoxEx(message, appendedMessage, help, MessageBoxButton.YesNo, MessageBoxImage.Question);
        cls.ShowDialog();
        return cls.Result;
    }

    public static MessageBoxResult ShowQuestionYesNoDialog(string message, Window owner)
    {
        return ShowQuestionYesNoDialog(message, "", "", owner);
    }

    public static MessageBoxResult ShowQuestionYesNoDialog(string message, string appendedMessage, Window owner)
    {
        return ShowQuestionYesNoDialog(message, appendedMessage, "", owner);
    }

    public static MessageBoxResult ShowQuestionYesNoDialog(string message, string appendedMessage, string help, Window owner)
    {
        owner.Opacity = 0.7;
        var cls = new MessageBoxEx(message, appendedMessage, help, MessageBoxButton.YesNo, MessageBoxImage.Question, owner);
        cls.ShowDialog();
        owner.Opacity = 1;
        return cls.Result;
    }

    #endregion

    #region Question YesNoCancel Dialog

    public static MessageBoxResult ShowQuestionYesNoCancelDialog(string message)
    {
        return ShowQuestionYesNoCancelDialog(message, "", "");
    }

    public static MessageBoxResult ShowQuestionYesNoCancelDialog(string message, string appendedMessage)
    {
        return ShowQuestionYesNoCancelDialog(message, appendedMessage, "");
    }

    public static MessageBoxResult ShowQuestionYesNoCancelDialog(string message, string appendedMessage, string help)
    {
        var cls = new MessageBoxEx(message, appendedMessage, help, MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
        cls.ShowDialog();
        return cls.Result;
    }

    public static MessageBoxResult ShowQuestionYesNoCancelDialog(string message, Window owner)
    {
        return ShowQuestionYesNoCancelDialog(message, "", "", owner);
    }

    public static MessageBoxResult ShowQuestionYesNoCancelDialog(string message, string appendedMessage, Window owner)
    {
        return ShowQuestionYesNoCancelDialog(message, appendedMessage, "", owner);
    }

    public static MessageBoxResult ShowQuestionYesNoCancelDialog(string message, string appendedMessage, string help, Window owner)
    {
        owner.Opacity = 0.7;
        var cls = new MessageBoxEx(message, appendedMessage, help, MessageBoxButton.YesNoCancel, MessageBoxImage.Question, owner);
        cls.ShowDialog();
        owner.Opacity = 1;
        return cls.Result;
    }

    public static MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialog(string message, string yesCaption, string noCaption, string cancelCaption)
    {
        return ShowQuestionYesNoCancelCustomCaptionDialog(message, "", "", yesCaption, noCaption, cancelCaption);
    }

    public static MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialog(string message, string appendedMessage, string yesCaption, string noCaption, string cancelCaption)
    {
        return ShowQuestionYesNoCancelCustomCaptionDialog(message, appendedMessage, "", yesCaption, noCaption, cancelCaption);
    }

    public static MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialog(string message, string appendedMessage, string help, string yesCaption, string noCaption, string cancelCaption)
    {
        var cls = new MessageBoxEx(message, appendedMessage, help, MessageBoxButton.YesNoCancel, MessageBoxImage.Question)
        {
            YesCaption = yesCaption,
            NoCaption = noCaption,
            CancelCaption = cancelCaption,
        };
        cls.ShowDialog();
        return cls.Result;
    }

    public static MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialog(string message, string yesCaption, string noCaption, string cancelCaption, Window owner)
    {
        return ShowQuestionYesNoCancelCustomCaptionDialog(message, "", "", yesCaption, noCaption, cancelCaption, owner);
    }

    public static MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialog(string message, string appendedMessage, string yesCaption, string noCaption, string cancelCaption, Window owner)
    {
        return ShowQuestionYesNoCancelCustomCaptionDialog(message, appendedMessage, "", yesCaption, noCaption, cancelCaption, owner);
    }

    public static MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialog(string message, string appendedMessage, string help, string yesCaption, string noCaption, string cancelCaption, Window owner)
    {
        owner.Opacity = 0.7;
        var cls = new MessageBoxEx(message, appendedMessage, help, MessageBoxButton.YesNoCancel, MessageBoxImage.Question, owner)
        {
            YesCaption = yesCaption,
            NoCaption = noCaption,
            CancelCaption = cancelCaption,
        };
        cls.ShowDialog();
        owner.Opacity = 1;
        return cls.Result;
    }

    #endregion

    #region Question OKCancel Dialog

    public static MessageBoxResult ShowQuestionOKCancelDialog(string message)
    {
        return ShowQuestionOKCancelDialog(message, "", "");
    }

    public static MessageBoxResult ShowQuestionOKCancelDialog(string message, string appendedMessage)
    {
        return ShowQuestionOKCancelDialog(message, appendedMessage, "");
    }

    public static MessageBoxResult ShowQuestionOKCancelDialog(string message, string appendedMessage, string help)
    {
        var cls = new MessageBoxEx(message, appendedMessage, help, MessageBoxButton.OKCancel, MessageBoxImage.Question);
        cls.ShowDialog();
        return cls.Result;
    }

    public static MessageBoxResult ShowQuestionOKCancelCustomCaptionDialog(string message, string okCaption, string cancelCaption)
    {
        return ShowQuestionOKCancelCustomCaptionDialog(message, "", "", okCaption, cancelCaption);
    }

    public static MessageBoxResult ShowQuestionOKCancelCustomCaptionDialog(string message, string appendedMessage, string okCaption, string cancelCaption)
    {
        return ShowQuestionOKCancelCustomCaptionDialog(message, appendedMessage, "", okCaption, cancelCaption);
    }

    public static MessageBoxResult ShowQuestionOKCancelCustomCaptionDialog(string message, string appendedMessage, string help, string okCaption, string cancelCaption)
    {
        var cls = new MessageBoxEx(message, appendedMessage, help, MessageBoxButton.OKCancel, MessageBoxImage.Question)
        {
            OKCaption = okCaption,
            CancelCaption = cancelCaption
        };
        cls.ShowDialog();
        return cls.Result;
    }

    public static MessageBoxResult ShowQuestionOKCancelDialog(string message, Window owner)
    {
        return ShowQuestionOKCancelDialog(message, "", "", owner);
    }

    public static MessageBoxResult ShowQuestionOKCancelDialog(string message, string appendedMessage, Window owner)
    {
        return ShowQuestionOKCancelDialog(message, appendedMessage, "", owner);
    }

    public static MessageBoxResult ShowQuestionOKCancelDialog(string message, string appendedMessage, string help, Window owner)
    {
        owner.Opacity = 0.7;
        var cls = new MessageBoxEx(message, appendedMessage, help, MessageBoxButton.OKCancel, MessageBoxImage.Question, owner);
        cls.ShowDialog();
        owner.Opacity = 1;
        return cls.Result;
    }

    public static MessageBoxResult ShowQuestionOKCancelCustomCaptionDialog(string message, string okCaption, string cancelCaption, Window owner)
    {
        return ShowQuestionOKCancelCustomCaptionDialog(message, "", "", okCaption, cancelCaption, owner);
    }

    public static MessageBoxResult ShowQuestionOKCancelCustomCaptionDialog(string message, string appendedMessage, string okCaption, string cancelCaption, Window owner)
    {
        return ShowQuestionOKCancelCustomCaptionDialog(message, appendedMessage, "", okCaption, cancelCaption, owner);
    }

    public static MessageBoxResult ShowQuestionOKCancelCustomCaptionDialog(string message, string appendedMessage, string help, string okCaption, string cancelCaption, Window owner)
    {
        owner.Opacity = 0.7;
        var cls = new MessageBoxEx(message, appendedMessage, help, MessageBoxButton.OKCancel, MessageBoxImage.Question, owner)
        {
            OKCaption = okCaption,
            CancelCaption = cancelCaption
        };
        cls.ShowDialog();
        owner.Opacity = 1;
        return cls.Result;
    }

    #endregion

    #region Warning Dialog

    public static MessageBoxResult ShowWarningDialog(string message)
    {
        return ShowWarningDialog(message, "", "");
    }

    public static MessageBoxResult ShowWarningDialog(string message, string appendedMessage)
    {
        return ShowWarningDialog(message, appendedMessage, "");
    }

    public static MessageBoxResult ShowWarningDialog(string message, string appendedMessage, string help)
    {
        var cls = new MessageBoxEx(message, appendedMessage, help, MessageBoxButton.OK, MessageBoxImage.Warning);
        cls.ShowDialog();
        return cls.Result;
    }

    public static MessageBoxResult ShowWarningDialog(string message, Window owner)
    {
        return ShowWarningDialog(message, "", "", owner);
    }

    public static MessageBoxResult ShowWarningDialog(string message, string appendedMessage, Window owner)
    {
        return ShowWarningDialog(message, appendedMessage, "", owner);
    }

    public static MessageBoxResult ShowWarningDialog(string message, string appendedMessage, string help, Window owner)
    {
        owner.Opacity = 0.7;
        var cls = new MessageBoxEx(message, appendedMessage, help, MessageBoxButton.OK, MessageBoxImage.Warning, owner);
        cls.ShowDialog();
        owner.Opacity = 1;
        return cls.Result;
    }

    #endregion

    #region Error Dialog

    public static MessageBoxResult ShowErrorDialog(string message)
    {
        return ShowErrorDialog(message, "", "");
    }

    public static MessageBoxResult ShowErrorDialog(string message, string appendedMessage)
    {
        return ShowErrorDialog(message, appendedMessage, "");
    }

    public static MessageBoxResult ShowErrorDialog(string message, string appendedMessage, string help)
    {
        var cls = new MessageBoxEx(message, appendedMessage, help, MessageBoxButton.OK, MessageBoxImage.Error);
        cls.ShowDialog();
        return cls.Result;
    }

    public static MessageBoxResult ShowErrorDialog(string message, Window owner)
    {
        return ShowErrorDialog(message, "", "", owner);
    }

    public static MessageBoxResult ShowErrorDialog(string message, string appendedMessage, Window owner)
    {
        return ShowErrorDialog(message, appendedMessage, "", owner);
    }

    public static MessageBoxResult ShowErrorDialog(string message, string appendedMessage, string help, Window owner)
    {
        owner.Opacity = 0.7;
        var cls = new MessageBoxEx(message, appendedMessage, help, MessageBoxButton.OK, MessageBoxImage.Error, owner);
        cls.ShowDialog();
        owner.Opacity = 1;
        return cls.Result;
    }

    #endregion

    #region General Dialog

    /// <summary>
    /// General Show
    /// </summary>
    /// <param name="message"></param>
    /// <param name="appendedMessage"></param>
    /// <param name="messageBoxButton"></param>
    /// <param name="messageBoxImage"></param>
    /// <param name="color"></param>
    /// <returns></returns>
    public static MessageBoxResult Show(string message, string appendedMessage, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color)
    {
        return Show(message, appendedMessage, "", messageBoxButton, messageBoxImage, color);
    }

    public static MessageBoxResult Show(string message, string appendedMessage, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color)
    {
        var cls = new MessageBoxEx(message, appendedMessage, help, messageBoxButton, messageBoxImage, color);
        cls.Show();
        return cls.Result;
    }

    public static MessageBoxResult ShowDialog(string message, string appendedMessage, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage)
    {
        return ShowDialog(message, appendedMessage, "", messageBoxButton, messageBoxImage);
    }

    public static MessageBoxResult ShowDialog(string message, string appendedMessage, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage)
    {
        var cls = new MessageBoxEx(message, appendedMessage, help, messageBoxButton, messageBoxImage);
        cls.ShowDialog();
        return cls.Result;
    }

    public static MessageBoxResult ShowDialog(string message, string appendedMessage, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Window owner)
    {
        return ShowDialog(message, appendedMessage, "", messageBoxButton, messageBoxImage, owner);
    }

    public static MessageBoxResult ShowDialog(string message, string appendedMessage, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Window owner)
    {
        owner.Opacity = 0.7;
        var cls = new MessageBoxEx(message, appendedMessage, help, messageBoxButton, messageBoxImage, owner);
        cls.ShowDialog();
        owner.Opacity = 1;
        return cls.Result;
    }

    /// <summary>
    /// General Show Dialog
    /// </summary>
    /// <param name="message"></param>
    /// <param name="appendedMessage"></param>
    /// <param name="messageBoxButton"></param>
    /// <param name="messageBoxImage"></param>
    /// <param name="color"></param>
    /// <returns></returns>
    public static MessageBoxResult ShowDialog(string message, string appendedMessage, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color)
    {
        return ShowDialog(message, appendedMessage, "", messageBoxButton, messageBoxImage, color);
    }

    public static MessageBoxResult ShowDialog(string message, string appendedMessage, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color)
    {
        var cls = new MessageBoxEx(message, appendedMessage, help, messageBoxButton, messageBoxImage, color);
        cls.ShowDialog();
        return cls.Result;
    }

    /// <summary>
    /// General Show Dialog with OwnerWindow
    /// </summary>
    /// <param name="message"></param>
    /// <param name="appendedMessage"></param>
    /// <param name="messageBoxButton"></param>
    /// <param name="messageBoxImage"></param>
    /// <param name="color"></param>
    /// <param name="owner">Window</param>
    /// <returns></returns>
    public static MessageBoxResult ShowDialog(string message, string appendedMessage, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color, Window owner)
    {
        return ShowDialog(message, appendedMessage, "", messageBoxButton, messageBoxImage, color, owner);
    }

    public static MessageBoxResult ShowDialog(string message, string appendedMessage, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color, Window owner)
    {
        owner.Opacity = 0.7;
        var cls = new MessageBoxEx(message, appendedMessage, help, messageBoxButton, messageBoxImage, color, owner);
        cls.ShowDialog();
        owner.Opacity = 1;
        return cls.Result;
    }

    #endregion

    #region Dialog With Properties

    /// <summary>
    ///
    /// </summary>
    /// <param name="message"></param>
    /// <param name="appendedMessage"></param>
    /// <param name="help"></param>
    /// <param name="messageBoxButton"></param>
    /// <param name="messageBoxImage"></param>
    /// <param name="color"></param>
    /// <param name="properties">Properties of MessageBoxEx Class</param>
    /// <returns></returns>
    public static MessageBoxResult ShowMessageBoxEx(string message, string appendedMessage, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color, Dictionary<string, object> properties)
    {
        var cls = new MessageBoxEx(message, appendedMessage, help, messageBoxButton, messageBoxImage, color);
        foreach (var item in properties)
        {
            SetValue(cls, item.Key, item.Value);
        }
        cls.ShowDialog();
        return cls.Result;
    }

    public static MessageBoxResult ShowMessageBoxEx(string message, string appendedMessage, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color, Dictionary<string, object> properties, Window owner)
    {
        owner.Opacity = 0.7;
        var cls = new MessageBoxEx(message, appendedMessage, help, messageBoxButton, messageBoxImage, color, owner);
        foreach (var item in properties)
        {
            SetValue(cls, item.Key, item.Value);
        }
        cls.ShowDialog();
        owner.Opacity = 1;
        return cls.Result;
    }

    /// <summary>
    /// Dynamically set property value
    /// </summary>
    /// <param name="sender">Generic type</param>
    /// <param name="propertyName">Property name to set value for</param>
    /// <param name="value">Value to set for property</param>
    /// <remarks>
    /// Currently setup for general types and enum. For other types
    /// check out "Is" Properties and handles the type as done with enum below
    /// </remarks>
    /// <see href="https://github.com/karenpayneoregon/dynamic-property-value/blob/master/BaseLibrary/Extensions.cs"/>
    /// <see href="https://dev.to/karenpayneoregon/dynamically-set-property-value-in-a-class-at-runtime-ci6"/>
    public static void SetValue<T>(this T sender, string propertyName, object value)
    {
        var propertyInfo = sender.GetType().GetProperty(propertyName);

        if (propertyInfo is null) return;

        var type = Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType;

        if (propertyInfo.PropertyType.IsEnum)
        {
            propertyInfo.SetValue(sender, Enum.Parse(propertyInfo.PropertyType, value.ToString()!));
        }
        else
        {
            var safeValue = (value == null) ? null : Convert.ChangeType(value, type);
            propertyInfo.SetValue(sender, safeValue, null);
        }
    }

    #endregion
}

public partial class MessageBoxEx : Window
{
    #region Variables

    /// <summary>
    /// Message
    /// </summary>
    public string Message { get; set; } = "";

    /// <summary>
    /// Appended Message in the Expander.
    /// </summary>
    public string AppendedMessage { get; set; } = "";

    /// <summary>
    /// Help URL
    /// </summary>
    public string Help { get; set; } = "";

    /// <summary>
    /// true : Appended Message Exsits.
    /// </summary>
    public bool HasAppendedMessage { get; private set; } = false;

    /// <summary>
    /// The icon to display.
    /// </summary>
    public MessageBoxImage Image { get; set; } = MessageBoxImage.Information;

    /// <summary>
    /// Button or buttons to display.
    /// </summary>
    public MessageBoxButton Button { get; set; } = MessageBoxButton.OK;

    /// <summary>
    /// The value that specifies which message box button is clicked by the user.
    /// </summary>
    public MessageBoxResult Result { get; private set; } = MessageBoxResult.None;

    /// <summary>
    /// The default result of the message box. If you specify something other than ButtonNone, focus on the button based on that DefaultResult.
    /// example: For YesNo Button, When DefaultResult set MessageBoxResult.Yes, YesButton wiil be forcused.
    /// </summary>
    public MessageBoxResult DefaultResult { get; set; } = MessageBoxResult.None;

    /// <summary>
    /// Shadow Effect
    /// </summary>
    public bool IsEnabledEffect { get; set; } = false;

    #endregion

    #region Caption Variables

    public string OKCaption { get; set; } = "OK"; //OK
    public string YesCaption { get; set; } = "Yes"; //Yes
    public string NoCaption { get; set; } = "No"; //No
    public string CancelCaption { get; set; } = "Cancel";　//Cancel

    #endregion

    #region Color Variables

    /// <summary>
    /// Message Foreground
    /// </summary>
    public Brush Color { get; set; } = Brushes.Black;

    /// <summary>
    /// Border Background
    /// </summary>
    public Brush BackgroundColor { get; set; } = Brushes.White;

    /// <summary>
    /// ColorProperty for SetValue<T>
    /// </summary>
    public string BackgroundString
    {
        set
        {
            BackgroundColor = (SolidColorBrush)new BrushConverter().ConvertFromString(value);
        }
    }

    #endregion

    #region Initializer

    public MessageBoxEx()
    {
        InitializeComponent();
    }

    public MessageBoxEx(string message, Window? owner = null)
    {
        InitializeComponent();
        Message = message;
        if (owner is not null && PresentationSource.FromVisual(owner) is not null) this.Owner = owner;
    }

    public MessageBoxEx(string message, string appendedMessage, Window? owner = null)
    {
        InitializeComponent();
        Message = message;
        AppendedMessage = appendedMessage;
        if (owner is not null && PresentationSource.FromVisual(owner) is not null) this.Owner = owner;
    }

    public MessageBoxEx(string message, MessageBoxButton button, MessageBoxImage image, Window? owner = null)
    {
        InitializeComponent();
        Message = message;
        Button = button;
        Image = image;
        if (owner is not null && PresentationSource.FromVisual(owner) is not null) this.Owner = owner;
    }

    public MessageBoxEx(string message, string appendedMessage, MessageBoxButton button, MessageBoxImage image, Window? owner = null)
    {
        InitializeComponent();
        Message = message;
        AppendedMessage = appendedMessage;
        Button = button;
        Image = image;
        if (owner is not null && PresentationSource.FromVisual(owner) is not null) this.Owner = owner;
    }

    public MessageBoxEx(string message, string appendedMessage, string help, MessageBoxButton button, MessageBoxImage image, Window? owner = null)
    {
        InitializeComponent();
        Message = message;
        AppendedMessage = appendedMessage;
        Help = help;
        Button = button;
        Image = image;
        if (owner is not null && PresentationSource.FromVisual(owner) is not null) this.Owner = owner;
    }

    public MessageBoxEx(string message, MessageBoxButton button, MessageBoxImage image, Brush color, Window? owner = null)
    {
        InitializeComponent();
        Message = message;
        Button = button;
        Image = image;
        Color = color;
        if (owner is not null && PresentationSource.FromVisual(owner) is not null) this.Owner = owner;
    }

    public MessageBoxEx(string message, string appendedMessage, MessageBoxButton button, MessageBoxImage image, Brush color, Window? owner = null)
    {
        InitializeComponent();
        Message = message;
        AppendedMessage = appendedMessage;
        Button = button;
        Image = image;
        Color = color;
        if (owner is not null && PresentationSource.FromVisual(owner) is not null) this.Owner = owner;
    }

    public MessageBoxEx(string message, string appendedMessage, string help, MessageBoxButton button, MessageBoxImage image, Brush color, Window? owner = null)
    {
        InitializeComponent();
        Message = message;
        AppendedMessage = appendedMessage;
        Help = help;
        Button = button;
        Image = image;
        Color = color;
        if (owner is not null && PresentationSource.FromVisual(owner) is not null) this.Owner = owner;
    }

    #endregion

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        DataContext = this;
        HasAppendedMessage = !string.IsNullOrEmpty(AppendedMessage);

        //RichTextBox
        FlowDocument document = MessageRichTextBox.Document;
        document.PagePadding = new Thickness(0); //Paragraph spacing
        TextRange range = new TextRange(document.ContentStart, document.ContentEnd);
        range.Text = Message;

        SetupIconVisibility();
        SetupButton();
    }

    private void CopyMenuItem_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            var ctrl = (MenuItem)sender;
            if (ctrl is not null)
            {
                var s = Message + (string.IsNullOrEmpty(AppendedMessage) ? "" : "\r\n" + AppendedMessage);
                Clipboard.SetText(s);
            }
        }
        catch (Exception)
        {
        }
    }

    protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
    {
        base.OnMouseLeftButtonDown(e);
        this.DragMove();
    }

    private void SetupIconVisibility()
    {
        switch (Image)
        {
            case MessageBoxImage.None:
                break;

            case MessageBoxImage.Error:  //Same : MessageBoxImage.Stop, Hand
                ErrorIcon.Visibility = Visibility.Visible;
                break;

            case MessageBoxImage.Question:
                QuestionIcon.Visibility = Visibility.Visible;
                break;

            case MessageBoxImage.Warning:  //Same : Exclamation
                WarningIcon.Visibility = Visibility.Visible;
                break;

            case MessageBoxImage.Information:  //Same : Asterisk
                InfomationIcon.Visibility = Visibility.Visible;
                break;

            default:
                break;
        }
        if (!string.IsNullOrEmpty(Help))
        {
            HelpButton.Visibility = Visibility.Visible;
        }
    }

    private void SetupButton()
    {
        switch (Button)
        {
            case MessageBoxButton.OK:
                LeftButton.Visibility = Visibility.Collapsed;
                MiddleButton.Visibility = Visibility.Collapsed;
                RightButton.Content = OKCaption;
                RightButton.Tag = MessageBoxResult.OK; //Set MessageBoxResult to Tag
                Keyboard.Focus(RightButton);
                break;

            case MessageBoxButton.OKCancel:
                LeftButton.Visibility = Visibility.Collapsed;
                MiddleButton.Content = OKCaption;
                RightButton.Content = CancelCaption;
                MiddleButton.Tag = MessageBoxResult.OK;
                RightButton.Tag = MessageBoxResult.Cancel;
                if (DefaultResult == MessageBoxResult.OK)
                    Keyboard.Focus(MiddleButton);
                else
                    Keyboard.Focus(RightButton);
                break;

            case MessageBoxButton.YesNoCancel:
                LeftButton.Content = YesCaption;
                MiddleButton.Content = NoCaption;
                RightButton.Content = CancelCaption;
                LeftButton.Tag = MessageBoxResult.Yes;
                MiddleButton.Tag = MessageBoxResult.No;
                RightButton.Tag = MessageBoxResult.Cancel;
                if (DefaultResult == MessageBoxResult.Yes)
                    Keyboard.Focus(LeftButton);
                else if (DefaultResult == MessageBoxResult.No)
                    Keyboard.Focus(MiddleButton);
                else
                    Keyboard.Focus(RightButton);
                break;

            case MessageBoxButton.YesNo:
                LeftButton.Visibility = Visibility.Collapsed;
                MiddleButton.Content = YesCaption;
                RightButton.Content = NoCaption;
                MiddleButton.Tag = MessageBoxResult.Yes;
                RightButton.Tag = MessageBoxResult.No;
                if (DefaultResult == MessageBoxResult.Yes)
                    Keyboard.Focus(MiddleButton);
                else
                    Keyboard.Focus(RightButton);
                break;

            default:
                break;
        }
    }

    /// <summary>
    /// Left, Middle, Right Button Click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        var button = (Button)sender;
        Result = (MessageBoxResult)button.Tag; //Get MessageBoxResult from Tag
        this.Close();
    }

    private void HelpButton_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(Help)) return;
            Process.Start(new ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = Help,
            });
        }
        catch
        {
        }
    }
}