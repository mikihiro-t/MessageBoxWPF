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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MessageBoxWPF
{
    public static class MessageEx
    {
        #region Information Dialog
        public static MessageBoxResult ShowInformationDialog(string message)
        {
            return ShowInformationDialog(message, "");
        }
        public static MessageBoxResult ShowInformationDialog(string message, string appendedMessage)
        {
            var cls = new MessageBoxEx(message, appendedMessage, MessageBoxButton.OK, MessageBoxImage.Information);
            cls.ShowDialog();
            return cls.Result;
        }
        public static MessageBoxResult ShowInformationDialog(string message, Window owner)
        {
            return ShowInformationDialog(message, "", owner);
        }
        public static MessageBoxResult ShowInformationDialog(string message, string appendedMessage, Window owner)
        {
            owner.Opacity = 0.7;
            var cls = new MessageBoxEx(message, appendedMessage, MessageBoxButton.OK, MessageBoxImage.Information, owner);
            cls.ShowDialog();
            owner.Opacity = 1;
            return cls.Result;
        }
        /// <summary>
        /// Information Show
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static MessageBoxResult ShowInformation(string message)
        {
            return ShowInformation(message, "");
        }
        /// <summary>
        /// Information Show with th Appended Message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="appendedMessage"></param>
        /// <returns></returns>
        public static MessageBoxResult ShowInformation(string message, string appendedMessage)
        {
            var cls = new MessageBoxEx(message, appendedMessage, MessageBoxButton.OK, MessageBoxImage.Information);
            cls.Show();
            return cls.Result;
        }
        #endregion
        //
        #region Question Dialog
        public static MessageBoxResult ShowQuestionDialog(string message)
        {
            return ShowQuestionDialog(message, "");
        }
        public static MessageBoxResult ShowQuestionDialog(string message, string appendedMessage)
        {
            var cls = new MessageBoxEx(message, appendedMessage, MessageBoxButton.YesNo, MessageBoxImage.Question);
            cls.ShowDialog();
            return cls.Result;
        }
        public static MessageBoxResult ShowQuestionDialog(string message, Window owner)
        {
            return ShowQuestionDialog(message, "", owner);
        }
        public static MessageBoxResult ShowQuestionDialog(string message, string appendedMessage, Window owner)
        {
            owner.Opacity = 0.7;
            var cls = new MessageBoxEx(message, appendedMessage, MessageBoxButton.YesNo, MessageBoxImage.Question, owner);
            cls.ShowDialog();
            owner.Opacity = 1;
            return cls.Result;
        }
        #endregion
        //
        #region Warning Dialog
        public static MessageBoxResult ShowWarningDialog(string message)
        {
            return ShowWarningDialog(message, "");
        }
        public static MessageBoxResult ShowWarningDialog(string message, string appendedMessage)
        {
            var cls = new MessageBoxEx(message, appendedMessage, MessageBoxButton.OK, MessageBoxImage.Warning);
            cls.ShowDialog();
            return cls.Result;
        }
        public static MessageBoxResult ShowWarningDialog(string message, Window owner)
        {
            return ShowWarningDialog(message, "", owner);
        }
        public static MessageBoxResult ShowWarningDialog(string message, string appendedMessage, Window owner)
        {
            owner.Opacity = 0.7;
            var cls = new MessageBoxEx(message, appendedMessage, MessageBoxButton.OK, MessageBoxImage.Warning, owner);
            cls.ShowDialog();
            owner.Opacity = 1;
            return cls.Result;
        }
        #endregion
        //
        #region Error Dialog
        public static MessageBoxResult ShowErrorDialog(string message)
        {
            return ShowErrorDialog(message, "");
        }
        public static MessageBoxResult ShowErrorDialog(string message, string appendedMessage)
        {
            var cls = new MessageBoxEx(message, appendedMessage, MessageBoxButton.OK, MessageBoxImage.Error);
            cls.ShowDialog();
            return cls.Result;
        }
        public static MessageBoxResult ShowErrorDialog(string message, Window owner)
        {
            return ShowErrorDialog(message, "", owner);
        }
        public static MessageBoxResult ShowErrorDialog(string message, string appendedMessage, Window owner)
        {
            owner.Opacity = 0.7;
            var cls = new MessageBoxEx(message, appendedMessage, MessageBoxButton.OK, MessageBoxImage.Error, owner);
            cls.ShowDialog();
            owner.Opacity = 1;
            return cls.Result;
        }
        #endregion
        //
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
            var cls = new MessageBoxEx(message, appendedMessage, messageBoxButton, messageBoxImage, color);
            cls.Show();
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
            var cls = new MessageBoxEx(message, appendedMessage, messageBoxButton, messageBoxImage, color);
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
            owner.Opacity = 0.7;
            var cls = new MessageBoxEx(message, appendedMessage, messageBoxButton, messageBoxImage, color, owner);
            cls.ShowDialog();
            owner.Opacity = 1;
            return cls.Result;
        }
        #endregion
    }
    //
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
        //
        #region Caption Variables
        public string OKCaption { get; set; } = "OK";
        public string YesCaption { get; set; } = "Yes";
        public string NoCaption { get; set; } = "No";
        public string CancelCaption { get; set; } = "Cancel";
        #endregion
        //
        #region Color Variables
        /// <summary>
        /// Message Foreground
        /// </summary>
        public Brush Color { get; set; } = Brushes.Black;
        /// <summary>
        /// Border Background
        /// </summary>
        public Brush BackgroundColor { get; set; } = Brushes.White;
        #endregion
        //
        #region Initializer
        public MessageBoxEx()
        {
            InitializeComponent();
        }
        public MessageBoxEx(string message, Window? owner = null)
        {
            InitializeComponent();
            Message = message;
            if (owner is not null) this.Owner = owner;
        }
        public MessageBoxEx(string message, string appendedMessage, Window? owner = null)
        {
            InitializeComponent();
            Message = message;
            AppendedMessage = appendedMessage;
            if (owner is not null) this.Owner = owner;
        }
        public MessageBoxEx(string message, MessageBoxButton button, MessageBoxImage image, Window? owner = null)
        {
            InitializeComponent();
            Message = message;
            Button = button;
            Image = image;
            if (owner is not null) this.Owner = owner;
        }
        public MessageBoxEx(string message, string appendedMessage, MessageBoxButton button, MessageBoxImage image, Window? owner = null)
        {
            InitializeComponent();
            Message = message;
            AppendedMessage = appendedMessage;
            Button = button;
            Image = image;
            if (owner is not null) this.Owner = owner;
        }
        public MessageBoxEx(string message, MessageBoxButton button, MessageBoxImage image, Brush color, Window? owner = null)
        {
            InitializeComponent();
            Message = message;
            Button = button;
            Image = image;
            Color = color;
            if (owner is not null) this.Owner = owner;
        }
        public MessageBoxEx(string message, string appendedMessage, MessageBoxButton button, MessageBoxImage image, Brush color, Window? owner = null)
        {
            InitializeComponent();
            Message = message;
            AppendedMessage = appendedMessage;
            Button = button;
            Image = image;
            Color = color;
            if (owner is not null) this.Owner = owner;
        }
        #endregion
        //
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = this;
            HasAppendedMessage = !string.IsNullOrEmpty(AppendedMessage);
            //
            //RichTextBox
            FlowDocument document = MessageRichTextBox.Document;
            document.PagePadding = new Thickness(0); //Paragraph spacing
            TextRange range = new TextRange(document.ContentStart, document.ContentEnd);
            range.Text = Message;
            //
            SetupIconVisibility();
            SetupButton();
        }
        private void CopyMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var ctrl = (MenuItem)sender;
            if (ctrl is not null)
            {
                var s = Message + (string.IsNullOrEmpty(AppendedMessage) ? "" : "\r\n" + AppendedMessage);
                Clipboard.SetText(s);
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
    }
}
