using System;

namespace UniversalTCPClient.Controls
{
    class IPValidChangedEventArgs : EventArgs
    {
        public HostTextBox.ValidationStateType ValidationChangeType
        {
            get; set;
        }
    }
}
