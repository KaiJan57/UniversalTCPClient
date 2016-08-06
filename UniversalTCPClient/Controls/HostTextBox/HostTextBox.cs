using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace UniversalTCPClient.Controls
{
    class HostTextBox : TextBox
    {
        private IPAddress ipaddress = IPAddress.None;
        private ValidationStateType valid;
        private Thread ACheck;
        private int newestThreadID;

        public delegate void IPValidationChangedEventHandler(object sender, IPValidChangedEventArgs args);
        public event IPValidationChangedEventHandler IPValidChanged;

        public enum ValidationStateType
        {
            Invalid,
            ValidIP,
            ValidDomain,
        }

        public IPAddress Address
        {
            get
            {
                return ipaddress;
            }
        }

        public ValidationStateType ValidationState
        {
            get
            {
                return valid;
            }
        }

        public void StartCheck()
        {
            if (valid == ValidationStateType.Invalid)
            {
                new Thread(checkHost).Start();
            }
        }

        protected virtual void OnIPValidChanged(IPValidChangedEventArgs e)
        {
            valid = e.ValidationChangeType;
            Invoke((MethodInvoker)(() => IPValidChanged?.Invoke(this, e)));
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            ipaddress = IPAddress.None;
            IPValidChangedEventArgs args = new IPValidChangedEventArgs();
            args.ValidationChangeType = ValidationStateType.Invalid;
            if (valid != ValidationStateType.Invalid)
            {
                OnIPValidChanged(args);
            }
            ACheck = new Thread(checkHost);
            ACheck.Start();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            SelectAll();
        }


        private void checkHost()
        {
            newestThreadID = Thread.CurrentThread.ManagedThreadId;
            try
            {
                if (valid == ValidationStateType.Invalid)
                {
                    IPValidChangedEventArgs args = new IPValidChangedEventArgs();
                    if (!string.IsNullOrWhiteSpace(Text))
                    {
                        if (IPAddress.TryParse(Text, out ipaddress))
                        {
                            if (newestThreadID != Thread.CurrentThread.ManagedThreadId)
                            {
                                return;
                            }
                            args.ValidationChangeType = ValidationStateType.ValidIP;
                            if (valid != ValidationStateType.ValidIP)
                            {
                                OnIPValidChanged(args);
                            }
                            return;
                        }
                        if (Text.ToLower() == "localhost")
                        {
                            ipaddress = new IPAddress(new byte[] { 127, 0, 0, 1 });
                            if (newestThreadID != Thread.CurrentThread.ManagedThreadId)
                            {
                                return;
                            }
                            args.ValidationChangeType = ValidationStateType.ValidIP;
                            if (valid != ValidationStateType.ValidIP)
                            {
                                OnIPValidChanged(args);
                            }
                            return;
                        }
                        try
                        {
                            IPAddress check = Dns.GetHostAddresses(Text)[0];
                            if (check != IPAddress.None)
                            {
                                if (newestThreadID != Thread.CurrentThread.ManagedThreadId)
                                {
                                    return;
                                }
                                ipaddress = check;
                                args.ValidationChangeType = ValidationStateType.ValidDomain;
                                if (valid != ValidationStateType.ValidDomain)
                                {
                                    OnIPValidChanged(args);
                                }
                                return;
                            }
                        }
                        catch
                        {
                        }
                    }
                    if (newestThreadID != Thread.CurrentThread.ManagedThreadId)
                    {
                        return;
                    }
                    args.ValidationChangeType = ValidationStateType.Invalid;
                    if (valid != ValidationStateType.Invalid)
                    {
                        OnIPValidChanged(args);
                    }
                    ipaddress = IPAddress.None;
                }
            }
            catch
            {

            }
        }
    }
}