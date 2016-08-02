using System.Windows.Forms;

namespace UniversalTCPClient.Controls
{
    class SendBox : TextBox
    {
        public SendBox()
        {
            Multiline = true;
        }

        protected override bool IsInputKey(Keys keyData)
        {
            if (keyData == (Keys.Shift | Keys.Enter)) return true;
            return base.IsInputKey(keyData);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Shift | Keys.Enter))
            {
                int pos = SelectionStart;
                SelectedText = System.Environment.NewLine;
                SelectionStart = pos + 2;
                e.Handled = e.SuppressKeyPress = true;
                return;
            }
            base.OnKeyDown(e);
        }
    }
}
