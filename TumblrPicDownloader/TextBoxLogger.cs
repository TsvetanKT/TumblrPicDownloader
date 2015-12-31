namespace TumblrPicDownloader
{
    using System;
    using System.Windows;
    using System.Windows.Forms;

    public class TextBoxLogger : ILogger
    {
        private Form mainForm;
        private RichTextBox ouputbox;

        public TextBoxLogger(Form currentForm, RichTextBox outputBox)
        {
            this.mainForm = currentForm;
            this.ouputbox = outputBox;
        }

        public void Log(string message)
        {
            if (this.mainForm.InvokeRequired)
            {
                this.mainForm.Invoke(new Action<string>(this.Log), new object[] { message });
                return;
            }

            this.ouputbox.Text += message + Environment.NewLine;
        }
    }
}
