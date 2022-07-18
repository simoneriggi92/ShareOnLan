using System;
using System.Windows.Forms;

namespace ShareOnLan
{
    public partial class MaterialMessageBox : MaterialFormTemplate
    {
        public MaterialMessageBox()
        {
            InitializeComponent();
        }

        static MaterialMessageBox MsgBox;
        static DialogResult result = DialogResult.No;

        public static DialogResult Show(string Text)
        {
            MsgBox = new MaterialMessageBox();
            MsgBox.msgLabel.Text = Text;
            result = DialogResult.No;
            MsgBox.ShowDialog();
            return result;
        }

        public static DialogResult Show(string Text, string Caption, string btnOK)
        {
            MsgBox = new MaterialMessageBox();
            MsgBox.msgLabel.Text = Text;
            MsgBox.Text = Caption;
            MsgBox.closeButton.Text = btnOK;
            result = DialogResult.No;
            MsgBox.ShowDialog();
            return result;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes; MsgBox.Close();
        }
    }
}
