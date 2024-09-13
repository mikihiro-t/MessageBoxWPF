using System.Windows;
using System.Windows.Media;

namespace MessageBoxWPF.Demo.Service;

public interface IDialogService
{
    string WindowGuid { get; set; }

    #region Show Information Dialog

    MessageBoxResult ShowInformation(string message);

    MessageBoxResult ShowInformation(string message, string messageAppend);

    MessageBoxResult ShowInformation(string message, string messageAppend, string help);

    MessageBoxResult ShowInformationDialog(string message);

    MessageBoxResult ShowInformationDialog(string message, string messageAppend);

    MessageBoxResult ShowInformationDialog(string message, string messageAppend, string help);

    MessageBoxResult ShowInformationDialogOnWindow(string message);

    MessageBoxResult ShowInformationDialogOnWindow(string message, string messageAppend);

    MessageBoxResult ShowInformationDialogOnWindow(string message, string messageAppend, string help);

    #endregion

    #region Show Question YesNo Dialog

    MessageBoxResult ShowQuestionYesNoDialog(string message);

    MessageBoxResult ShowQuestionYesNoDialog(string message, string messageAppend);

    MessageBoxResult ShowQuestionYesNoDialog(string message, string messageAppend, string help);

    MessageBoxResult ShowQuestionYesNoDialogOnWindow(string message);

    MessageBoxResult ShowQuestionYesNoDialogOnWindow(string message, string messageAppend);

    MessageBoxResult ShowQuestionYesNoDialogOnWindow(string message, string messageAppend, string help);

    #endregion

    #region Show Question YesNoCancel Dialog

    MessageBoxResult ShowQuestionYesNoCancelDialog(string message);

    MessageBoxResult ShowQuestionYesNoCancelDialog(string message, string messageAppend);

    MessageBoxResult ShowQuestionYesNoCancelDialog(string message, string messageAppend, string help);

    MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialog(string message, string yesCaption, string noCaption, string cancelCaption);

    MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialog(string message, string messageAppend, string yesCaption, string noCaption, string cancelCaption);

    MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialog(string message, string messageAppend, string help, string yesCaption, string noCaption, string cancelCaption);

    MessageBoxResult ShowQuestionYesNoCancelDialogOnWindow(string message);

    MessageBoxResult ShowQuestionYesNoCancelDialogOnWindow(string message, string messageAppend);

    MessageBoxResult ShowQuestionYesNoCancelDialogOnWindow(string message, string messageAppend, string help);

    MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialogOnWindow(string message, string yesCaption, string noCaption, string cancelCaption);

    MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialogOnWindow(string message, string messageAppend, string yesCaption, string noCaption, string cancelCaption);

    MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialogOnWindow(string message, string messageAppend, string help, string yesCaption, string noCaption, string cancelCaption);

    #endregion

    #region Show Question OKCancel Dialog

    MessageBoxResult ShowQuestionOKCancelDialog(string message);

    MessageBoxResult ShowQuestionOKCancelDialog(string message, string messageAppend);

    MessageBoxResult ShowQuestionOKCancelDialog(string message, string messageAppend, string help);

    MessageBoxResult ShowQuestionOKCancelCustomCaptionDialog(string message, string okCaption, string cancelCaption);

    MessageBoxResult ShowQuestionOKCancelCustomCaptionDialog(string message, string messageAppend, string okCaption, string cancelCaption);

    MessageBoxResult ShowQuestionOKCancelCustomCaptionDialog(string message, string messageAppend, string help, string okCaption, string cancelCaption);

    MessageBoxResult ShowQuestionOKCancelDialogOnWindow(string message);

    MessageBoxResult ShowQuestionOKCancelDialogOnWindow(string message, string messageAppend);

    MessageBoxResult ShowQuestionOKCancelDialogOnWindow(string message, string messageAppend, string help);

    MessageBoxResult ShowQuestionOKCancelCustomCaptionDialogOnWindow(string message, string okCaption, string cancelCaption);

    MessageBoxResult ShowQuestionOKCancelCustomCaptionDialogOnWindow(string message, string messageAppend, string okCaption, string cancelCaption);

    MessageBoxResult ShowQuestionOKCancelCustomCaptionDialogOnWindow(string message, string messageAppend, string help, string okCaption, string cancelCaption);

    #endregion

    #region Show Warning Dialog

    MessageBoxResult ShowWarningDialog(string message);

    MessageBoxResult ShowWarningDialog(string message, string messageAppend);

    MessageBoxResult ShowWarningDialog(string message, string messageAppend, string help);

    MessageBoxResult ShowWarningDialogOnWindow(string message);

    MessageBoxResult ShowWarningDialogOnWindow(string message, string messageAppend);

    MessageBoxResult ShowWarningDialogOnWindow(string message, string messageAppend, string help);

    #endregion

    #region Show Error Dialog

    MessageBoxResult ShowErrorDialog(string message);

    MessageBoxResult ShowErrorDialog(string message, string messageAppend);

    MessageBoxResult ShowErrorDialog(string message, string messageAppend, string help);

    MessageBoxResult ShowErrorDialogOnWindow(string message);

    MessageBoxResult ShowErrorDialogOnWindow(string message, string messageAppend);

    MessageBoxResult ShowErrorDialogOnWindow(string message, string messageAppend, string help);

    #endregion

    #region General Dialog

    MessageBoxResult Show(string message, string messageAppend, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color);

    MessageBoxResult Show(string message, string messageAppend, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color);

    MessageBoxResult ShowDialog(string message, string messageAppend, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage);

    MessageBoxResult ShowDialog(string message, string messageAppend, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage);

    MessageBoxResult ShowDialog(string message, string messageAppend, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color);

    MessageBoxResult ShowDialog(string message, string messageAppend, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color);

    MessageBoxResult ShowDialogOnWindow(string message, string messageAppend, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage);

    MessageBoxResult ShowDialogOnWindow(string message, string messageAppend, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage);

    MessageBoxResult ShowDialogOnWindow(string message, string messageAppend, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color);

    MessageBoxResult ShowDialogOnWindow(string message, string messageAppend, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color);

    #endregion

    #region Dialog With Properties

    MessageBoxResult ShowMessageBoxEx(string message, string appendedMessage, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color, Dictionary<string, object> properties);

    MessageBoxResult ShowMessageBoxExOnWindow(string message, string appendedMessage, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color, Dictionary<string, object> properties);

    #endregion
}

public class DialogService : IDialogService
{
    /// <summary>
    /// Using set, you can set the Guid of an existing Window from outside and make that Window the Owner.
    /// setで、外部から、すでにあるWindowのGuidをセットして、そのWindowをOwnerにできる。
    /// </summary>
    public string WindowGuid { get; set; } = Guid.NewGuid().ToString("N"); 

    #region Show Information Dialog

    public MessageBoxResult ShowInformation(string message)
    {
        return MessageEx.ShowInformation(message);
    }

    public MessageBoxResult ShowInformation(string message, string messageAppend)
    {
        return MessageEx.ShowInformation(message, messageAppend);
    }

    public MessageBoxResult ShowInformation(string message, string messageAppend, string help)
    {
        return MessageEx.ShowInformation(message, messageAppend, help);
    }

    public MessageBoxResult ShowInformationDialog(string message)
    {
        return MessageEx.ShowInformationDialog(message);
    }

    public MessageBoxResult ShowInformationDialog(string message, string messageAppend)
    {
        return MessageEx.ShowInformationDialog(message, messageAppend);
    }

    public MessageBoxResult ShowInformationDialog(string message, string messageAppend, string help)
    {
        return MessageEx.ShowInformationDialog(message, messageAppend, help);
    }

    public MessageBoxResult ShowInformationDialogOnWindow(string message)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowInformationDialog(message, w) : MessageEx.ShowInformationDialog(message);
    }

    public MessageBoxResult ShowInformationDialogOnWindow(string message, string messageAppend)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowInformationDialog(message, messageAppend, w) : MessageEx.ShowInformationDialog(message, messageAppend);
    }

    public MessageBoxResult ShowInformationDialogOnWindow(string message, string messageAppend, string help)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowInformationDialog(message, messageAppend, help, w) : MessageEx.ShowInformationDialog(message, messageAppend, help);
    }

    #endregion

    #region Show Question YesNo Dialog

    public MessageBoxResult ShowQuestionYesNoDialog(string message)
    {
        return MessageEx.ShowQuestionYesNoDialog(message);
    }

    public MessageBoxResult ShowQuestionYesNoDialog(string message, string messageAppend)
    {
        return MessageEx.ShowQuestionYesNoDialog(message, messageAppend);
    }

    public MessageBoxResult ShowQuestionYesNoDialog(string message, string messageAppend, string help)
    {
        return MessageEx.ShowQuestionYesNoDialog(message, messageAppend, help);
    }

    public MessageBoxResult ShowQuestionYesNoDialogOnWindow(string message)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowQuestionYesNoDialog(message, w) : MessageEx.ShowQuestionYesNoDialog(message);
    }

    public MessageBoxResult ShowQuestionYesNoDialogOnWindow(string message, string messageAppend)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowQuestionYesNoDialog(message, messageAppend, w) : MessageEx.ShowQuestionYesNoDialog(message, messageAppend);
    }

    public MessageBoxResult ShowQuestionYesNoDialogOnWindow(string message, string messageAppend, string help)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowQuestionYesNoDialog(message, messageAppend, help, w) : MessageEx.ShowQuestionYesNoDialog(message, messageAppend, help);
    }

    #endregion

    #region Show Question YesNoCancel Dialog

    public MessageBoxResult ShowQuestionYesNoCancelDialog(string message)
    {
        return MessageEx.ShowQuestionYesNoCancelDialog(message);
    }

    public MessageBoxResult ShowQuestionYesNoCancelDialog(string message, string messageAppend)
    {
        return MessageEx.ShowQuestionYesNoCancelDialog(message, messageAppend);
    }

    public MessageBoxResult ShowQuestionYesNoCancelDialog(string message, string messageAppend, string help)
    {
        return MessageEx.ShowQuestionYesNoCancelDialog(message, messageAppend, help);
    }

    public MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialog(string message, string yesCaption, string noCaption, string cancelCaption)
    {
        return MessageEx.ShowQuestionYesNoCancelCustomCaptionDialog(message, yesCaption, noCaption, cancelCaption);
    }

    public MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialog(string message, string messageAppend, string yesCaption, string noCaption, string cancelCaption)
    {
        return MessageEx.ShowQuestionYesNoCancelCustomCaptionDialog(message, messageAppend, yesCaption, noCaption, cancelCaption);
    }

    public MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialog(string message, string messageAppend, string help, string yesCaption, string noCaption, string cancelCaption)
    {
        return MessageEx.ShowQuestionYesNoCancelCustomCaptionDialog(message, messageAppend, help, yesCaption, noCaption, cancelCaption);
    }

    public MessageBoxResult ShowQuestionYesNoCancelDialogOnWindow(string message)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowQuestionYesNoCancelDialog(message, w) : MessageEx.ShowQuestionYesNoCancelDialog(message);
    }

    public MessageBoxResult ShowQuestionYesNoCancelDialogOnWindow(string message, string messageAppend)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowQuestionYesNoCancelDialog(message, messageAppend, w) : MessageEx.ShowQuestionYesNoCancelDialog(message, messageAppend);
    }

    public MessageBoxResult ShowQuestionYesNoCancelDialogOnWindow(string message, string messageAppend, string help)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowQuestionYesNoCancelDialog(message, messageAppend, help, w) : MessageEx.ShowQuestionYesNoCancelDialog(message, messageAppend, help);
    }

    public MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialogOnWindow(string message, string yesCaption, string noCaption, string cancelCaption)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowQuestionYesNoCancelCustomCaptionDialog(message, yesCaption, noCaption, cancelCaption, w) : MessageEx.ShowQuestionYesNoCancelCustomCaptionDialog(message, yesCaption, noCaption, cancelCaption);
    }

    public MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialogOnWindow(string message, string messageAppend, string yesCaption, string noCaption, string cancelCaption)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowQuestionYesNoCancelCustomCaptionDialog(message, messageAppend, yesCaption, noCaption, cancelCaption, w) : MessageEx.ShowQuestionYesNoCancelCustomCaptionDialog(message, messageAppend, yesCaption, noCaption, cancelCaption);
    }

    public MessageBoxResult ShowQuestionYesNoCancelCustomCaptionDialogOnWindow(string message, string messageAppend, string help, string yesCaption, string noCaption, string cancelCaption)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowQuestionYesNoCancelCustomCaptionDialog(message, messageAppend, help, yesCaption, noCaption, cancelCaption, w) : MessageEx.ShowQuestionYesNoCancelCustomCaptionDialog(message, messageAppend, help, yesCaption, noCaption, cancelCaption);
    }

    #endregion

    #region Show Question OKCancel Dialog

    public MessageBoxResult ShowQuestionOKCancelDialog(string message)
    {
        return MessageEx.ShowQuestionOKCancelDialog(message);
    }

    public MessageBoxResult ShowQuestionOKCancelDialog(string message, string messageAppend)
    {
        return MessageEx.ShowQuestionOKCancelDialog(message, messageAppend);
    }

    public MessageBoxResult ShowQuestionOKCancelDialog(string message, string messageAppend, string help)
    {
        return MessageEx.ShowQuestionOKCancelDialog(message, messageAppend, help);
    }

    public MessageBoxResult ShowQuestionOKCancelCustomCaptionDialog(string message, string okCaption, string cancelCaption)
    {
        return MessageEx.ShowQuestionOKCancelCustomCaptionDialog(message, okCaption, cancelCaption);
    }

    public MessageBoxResult ShowQuestionOKCancelCustomCaptionDialog(string message, string messageAppend, string okCaption, string cancelCaption)
    {
        return MessageEx.ShowQuestionOKCancelCustomCaptionDialog(message, messageAppend, okCaption, cancelCaption);
    }

    public MessageBoxResult ShowQuestionOKCancelCustomCaptionDialog(string message, string messageAppend, string help, string okCaption, string cancelCaption)
    {
        return MessageEx.ShowQuestionOKCancelCustomCaptionDialog(message, messageAppend, help, okCaption, cancelCaption);
    }

    public MessageBoxResult ShowQuestionOKCancelDialogOnWindow(string message)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowQuestionOKCancelDialog(message, w) : MessageEx.ShowQuestionOKCancelDialog(message);
    }

    public MessageBoxResult ShowQuestionOKCancelDialogOnWindow(string message, string messageAppend)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowQuestionOKCancelDialog(message, messageAppend, w) : MessageEx.ShowQuestionOKCancelDialog(message, messageAppend);
    }

    public MessageBoxResult ShowQuestionOKCancelDialogOnWindow(string message, string messageAppend, string help)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowQuestionOKCancelDialog(message, messageAppend, help, w) : MessageEx.ShowQuestionOKCancelDialog(message, messageAppend, help);
    }

    public MessageBoxResult ShowQuestionOKCancelCustomCaptionDialogOnWindow(string message, string okCaption, string cancelCaption)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowQuestionOKCancelCustomCaptionDialog(message, okCaption, cancelCaption, w) : MessageEx.ShowQuestionOKCancelCustomCaptionDialog(message, okCaption, cancelCaption);
    }

    public MessageBoxResult ShowQuestionOKCancelCustomCaptionDialogOnWindow(string message, string messageAppend, string okCaption, string cancelCaption)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowQuestionOKCancelCustomCaptionDialog(message, messageAppend, okCaption, cancelCaption, w) : MessageEx.ShowQuestionOKCancelCustomCaptionDialog(message, messageAppend, okCaption, cancelCaption);
    }

    public MessageBoxResult ShowQuestionOKCancelCustomCaptionDialogOnWindow(string message, string messageAppend, string help, string okCaption, string cancelCaption)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowQuestionOKCancelCustomCaptionDialog(message, messageAppend, help, okCaption, cancelCaption, w) : MessageEx.ShowQuestionOKCancelCustomCaptionDialog(message, messageAppend, help, okCaption, cancelCaption);
    }

    #endregion

    #region Show Warning Dialog

    public MessageBoxResult ShowWarningDialog(string message)
    {
        return MessageEx.ShowWarningDialog(message);
    }

    public MessageBoxResult ShowWarningDialog(string message, string messageAppend)
    {
        return MessageEx.ShowWarningDialog(message, messageAppend);
    }

    public MessageBoxResult ShowWarningDialog(string message, string messageAppend, string help)
    {
        return MessageEx.ShowWarningDialog(message, messageAppend, help);
    }

    public MessageBoxResult ShowWarningDialogOnWindow(string message)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowWarningDialog(message, w) : MessageEx.ShowWarningDialog(message);
    }

    public MessageBoxResult ShowWarningDialogOnWindow(string message, string messageAppend)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowWarningDialog(message, messageAppend, w) : MessageEx.ShowWarningDialog(message, messageAppend);
    }

    public MessageBoxResult ShowWarningDialogOnWindow(string message, string messageAppend, string help)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowWarningDialog(message, messageAppend, help, w) : MessageEx.ShowWarningDialog(message, messageAppend, help);
    }

    #endregion

    #region Show Error Dialog

    public MessageBoxResult ShowErrorDialog(string message)
    {
        return MessageEx.ShowErrorDialog(message);
    }

    public MessageBoxResult ShowErrorDialog(string message, string messageAppend)
    {
        return MessageEx.ShowErrorDialog(message, messageAppend);
    }

    public MessageBoxResult ShowErrorDialog(string message, string messageAppend, string help)
    {
        return MessageEx.ShowErrorDialog(message, messageAppend, help);
    }

    public MessageBoxResult ShowErrorDialogOnWindow(string message)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowErrorDialog(message, w) : MessageEx.ShowErrorDialog(message);
    }

    public MessageBoxResult ShowErrorDialogOnWindow(string message, string messageAppend)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowErrorDialog(message, messageAppend, w) : MessageEx.ShowErrorDialog(message, messageAppend);
    }

    public MessageBoxResult ShowErrorDialogOnWindow(string message, string messageAppend, string help)
    {
        var w = GetWindow();
        return w is not null ? MessageEx.ShowErrorDialog(message, messageAppend, help, w) : MessageEx.ShowErrorDialog(message, messageAppend, help);
    }

    #endregion

    #region General Dialog

    public MessageBoxResult Show(string message, string messageAppend, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color)
    {
        return MessageEx.Show(message, messageAppend, messageBoxButton, messageBoxImage, color);
    }

    public MessageBoxResult Show(string message, string messageAppend, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color)
    {
        return MessageEx.Show(message, messageAppend, help, messageBoxButton, messageBoxImage, color);
    }

    public MessageBoxResult ShowDialog(string message, string messageAppend, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage)
    {
        return MessageEx.ShowDialog(message, messageAppend, messageBoxButton, messageBoxImage);
    }

    public MessageBoxResult ShowDialog(string message, string messageAppend, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage)
    {
        return MessageEx.ShowDialog(message, messageAppend, help, messageBoxButton, messageBoxImage);
    }

    public MessageBoxResult ShowDialog(string message, string messageAppend, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color)
    {
        return MessageEx.ShowDialog(message, messageAppend, messageBoxButton, messageBoxImage, color);
    }

    public MessageBoxResult ShowDialog(string message, string messageAppend, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color)
    {
        return MessageEx.ShowDialog(message, messageAppend, help, messageBoxButton, messageBoxImage, color);
    }

    public MessageBoxResult ShowDialogOnWindow(string message, string messageAppend, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage)
    {
        var w = GetWindow();
        if (w is not null)
            return MessageEx.ShowDialog(message, messageAppend, messageBoxButton, messageBoxImage, w);
        else
            return MessageEx.ShowDialog(message, messageAppend, messageBoxButton, messageBoxImage);
    }

    public MessageBoxResult ShowDialogOnWindow(string message, string messageAppend, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage)
    {
        var w = GetWindow();
        if (w is not null)
            return MessageEx.ShowDialog(message, messageAppend, help, messageBoxButton, messageBoxImage, w);
        else
            return MessageEx.ShowDialog(message, messageAppend, help, messageBoxButton, messageBoxImage);
    }

    public MessageBoxResult ShowDialogOnWindow(string message, string messageAppend, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color)
    {
        var w = GetWindow();
        if (w is not null)
            return MessageEx.ShowDialog(message, messageAppend, messageBoxButton, messageBoxImage, color, w);
        else
            return MessageEx.ShowDialog(message, messageAppend, messageBoxButton, messageBoxImage, color);
    }

    public MessageBoxResult ShowDialogOnWindow(string message, string messageAppend, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color)
    {
        var w = GetWindow();
        if (w is not null)
            return MessageEx.ShowDialog(message, messageAppend, help, messageBoxButton, messageBoxImage, color, w);
        else
            return MessageEx.ShowDialog(message, messageAppend, help, messageBoxButton, messageBoxImage, color);
    }

    #endregion

    #region Dialog With Properties

    public MessageBoxResult ShowMessageBoxEx(string message, string appendedMessage, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color, Dictionary<string, object> properties)
    {
        return MessageEx.ShowMessageBoxEx(message, appendedMessage, help, messageBoxButton, messageBoxImage, color, properties);
    }

    public MessageBoxResult ShowMessageBoxExOnWindow(string message, string appendedMessage, string help, MessageBoxButton messageBoxButton, MessageBoxImage messageBoxImage, Brush color, Dictionary<string, object> properties)
    {
        var w = GetWindow(); if (w is not null)
            return MessageEx.ShowMessageBoxEx(message, appendedMessage, help, messageBoxButton, messageBoxImage, color, properties, w);
        else
            return MessageEx.ShowMessageBoxEx(message, appendedMessage, help, messageBoxButton, messageBoxImage, color, properties);
    }

    #endregion

    /// <summary>
    /// Returns the window that matches the GuId set in the tag. If there is none, returns null.
    /// Tagにセットされている、識別用のGuIdが一致するWinodowを返す。無い時は、null。
    /// </summary>
    /// <returns></returns>
    private Window? GetWindow()
    {
        if (!string.IsNullOrEmpty(WindowGuid))
        {
            //When you call GetWindow from another thread, Application.Current.Windows returns the following error: "System.InvalidOperationException: 'The calling thread cannot access this object because it is owned by another thread.'"
            //Application.Current.Windowsは、別スレッドからGetWindowを呼び出すと、「System.InvalidOperationException: 'このオブジェクトは別のスレッドに所有されているため、呼び出しスレッドはこのオブジェクトにアクセスできません。'」となる。
            foreach (Window window in Application.Current.Windows)
            {
                if (window.Tag?.ToString() == WindowGuid)
                    return window;
            }
        }
        return null;
    }
}