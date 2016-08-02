using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using UniversalTCPClient.Controls;
using UniversalTCPClient.Net;

namespace UniversalTCPClient
{
    public partial class MainForm : Form
    {
        int LastLanguageIndex = 0;
        int IPScanProgress = 0;
        bool ipscan = false;
        int PortScanProgress = 0;
        bool portscan = false;
        bool disconnecting = false;
        IPAddress PortScanIP;
        IPAddress MinIP;
        IPAddress MaxIP;

        Socket client;
        Thread CThread;
        List<byte[]> receiveBuffer = new List<byte[]>();
        List<byte[]> sendBuffer = new List<byte[]>();

        List<IPScanItem> ipScanItems = new List<IPScanItem>();
        List<PortScanItem> portScanItems = new List<PortScanItem>();

        List<EncodingInfo> encodings;

        enum ConnectButtonState
        {
            WouldConnect,
            WouldAbort,
            WouldDisconnect,
        }

        ConnectButtonState connectButtonState = ConnectButtonState.WouldConnect;

        public MainForm()
        {
            encodings = new List<EncodingInfo>(Encoding.GetEncodings());
            InitializeComponent();
            if (comboBoxLanguage.Items.Count < 6)
            {
                comboBoxLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            UpdateLanguage("auto");
            comboBoxLanguage.SelectedIndex = 0;
            comboBoxEncoding.Items.Clear();
            int selectIndex = 0;
            int i = 0;
            foreach (EncodingInfo ef in encodings)
            {
                comboBoxEncoding.Items.Add(ef.DisplayName);
                if (ef.CodePage == Encoding.ASCII.CodePage)
                {
                    selectIndex = i;
                }
                i++;
            }
            comboBoxEncoding.SelectedIndex = selectIndex;
            comboBoxLineending.SelectedIndex = 0;
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LastLanguageIndex != comboBoxLanguage.SelectedIndex)
            {
                LastLanguageIndex = comboBoxLanguage.SelectedIndex;
                switch (comboBoxLanguage.SelectedIndex)
                {
                    case 0:
                        {
                            UpdateLanguage("auto");
                            break;
                        }
                    case 1:
                        {
                            UpdateLanguage("en");
                            break;
                        }
                    case 2:
                        {
                            UpdateLanguage("de");
                            break;
                        }
                    case 3:
                        {
                            UpdateLanguage("zh-CN");
                            break;
                        }
                }
            }
        }

        public void UpdateLanguage(string Lang)
        {
            int LineEndingIndex = comboBoxLineending.SelectedIndex;
            int EncodingIndex = comboBoxEncoding.SelectedIndex;
            if (Lang == null || Lang.ToLower() == "auto")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(CultureInfo.InstalledUICulture.TwoLetterISOLanguageName);
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Lang);
            }
            Text = strings.MainForm_Title;
            groupBoxIPScanner.Text = strings.MainForm_GroupBoxIPScan;
            labelMinIP.Text = strings.MainForm_Label_MinIP;
            labelMaxIP.Text = strings.MainForm_Label_MaxIP;
            labelAttempts.Text = strings.MainForm_Label_Attempts;
            labelTimeout1.Text = labelTimeout2.Text = strings.MainForm_Label_Attempts;
            buttonIPScan.Text = ipscan ? strings.MainForm_Button_Connect_Abort : strings.MainForm_Button_Scan;
            buttonClearIP.Text = buttonClearPort.Text = strings.MainForm_Button_ClearList;
            labelProgress1.Text = labelProgress2.Text = strings.MainForm_Label_Progress;
            infoProgressBarIPScanner.CustomText = infoProgressBarPortScanner.CustomText = strings.MainForm_ProgressBar_Done;
            labelResults1.Text = labelResults2.Text = strings.MainForm_Label_Results;
            IPScanColumnIP.Text = PortScanColumnIP.Text = strings.MainForm_ObjectListView_Column_IP;
            IPScanColumnHostName.Text = PortScanColumnHostName.Text = strings.MainForm_ObjectListView_Column_HostName;
            groupBoxPortScanner.Text = strings.MainForm_GroupBoxPortScan;
            labelHost1.Text = labelHost2.Text = strings.MainForm_Label_Host;
            labelMinPort.Text = strings.MainForm_Label_MinPort;
            labelMaxPort.Text = strings.MainForm_Label_MaxPort;
            buttonPortScan.Text = portscan ? strings.MainForm_Button_Connect_Abort : strings.MainForm_Button_Scan;
            PortScanColumnPort.Text = strings.MainForm_ObjectListview_Column_Port;
            groupBoxClient.Text = strings.MainForm_GroupBoxClient;
            labelPort.Text = strings.MainForm_Label_Port;
            switch (connectButtonState)
            {
                default:
                    {
                        buttonConnect.Text = strings.MainForm_Button_Connect_Connect;
                        break;
                    }
                case ConnectButtonState.WouldDisconnect:
                    {
                        buttonConnect.Text = strings.MainForm_Button_Connect_Disconnect;
                        break;
                    }
                case ConnectButtonState.WouldAbort:
                    {
                        buttonConnect.Text = strings.MainForm_Button_Connect_Abort;
                        break;
                    }
            }
            buttonSend.Text = strings.MainForm_Button_Send;
            checkBoxAutoClear.Text = strings.MainForm_CheckBox_AutoClear;
            contextMenuStripClear.Items[0].Text = strings.MainForm_ContextMenuStrip_Clear;
            labelCharset.Text = strings.MainForm_Label_Charset;
            labelLineending.Text = strings.MainForm_Label_Lineending;
            comboBoxLineending.Items.Clear();
            comboBoxLineending.Items.AddRange(new string[] {strings.MainForm_ComboBox_Lineending_NoLineEnding,
                                                            strings.MainForm_ComboBox_Lineending_LF,
                                                            strings.MainForm_ComboBox_Lineending_CR,
                                                            strings.MainForm_ComboBox_Lineending_CRLF});
            checkBoxAutoScroll.Text = strings.MainForm_CheckBox_AutoScroll;
            labelGreen.Text = strings.MainForm_Label_Color_Send;
            labelRed.Text = strings.MainForm_Label_Color_Receive;
            labelLanguage.Text = strings.MainForm_Label_Language;
            comboBoxLanguage.Items[0] = strings.MainForm_ComboBox_Language_Auto;
            comboBoxLineending.SelectedIndex = LineEndingIndex;
            comboBoxEncoding.SelectedIndex = EncodingIndex;
        }

        #region Actual Client
        private void numericUpDownPortConnect_Enter(object sender, EventArgs e)
        {
            AcceptButton = buttonConnect;
            numericUpDownPortConnect.Select(0, numericUpDownPortConnect.Text.Length);
        }

        private void textBoxSend_Enter(object sender, EventArgs e)
        {
            AcceptButton = buttonSend;
        }

        private void hostTextBoxHostConnect_IPValidChanged(object sender, IPValidChangedEventArgs args)
        {
            if (args.ValidationChangeType != HostTextBox.ValidationStateType.Invalid)
            {
                buttonConnect.Enabled = true;
            }
            else
            {
                buttonConnect.Enabled = false;
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            switch (connectButtonState)
            {
                default:
                    {
                        Connect();
                        break;
                    }
                case ConnectButtonState.WouldDisconnect:
                    {
                        Disconnect();
                        EnableClientControls(false);
                        break;
                    }
                case ConnectButtonState.WouldAbort:
                    {
                        client.Dispose();
                        client = null;
                        connectButtonState = ConnectButtonState.WouldConnect;
                        buttonConnect.Text = strings.MainForm_Button_Connect_Connect;
                        break;
                    }
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string tosend = sendBoxSend.Text;
            switch (comboBoxLineending.SelectedIndex)
            {
                case 1:
                    {
                        tosend += "\n";
                        break;
                    }
                case 2:
                    {
                        tosend += "\r";
                        break;
                    }
                case 3:
                    {
                        tosend += "\r\n";
                        break;
                    }
            }
            AddText(richTextBoxLog, tosend, Color.Green);
            Send(GetSelectedEncoding().GetBytes(tosend));
            if (checkBoxAutoClear.Checked)
            {
                sendBoxSend.SelectAll();
            }
        }

        private void OnReceive()
        {
            AddText(richTextBoxLog, GetSelectedEncoding().GetString(GetLastReceived()), Color.Red);
        }

        private void Send(byte[] bytes)
        {
            sendBuffer.Add(bytes);
        }

        private byte[] GetLastReceived()
        {
            if (receiveBuffer.Count > 0)
            {
                byte[] result = receiveBuffer[0];
                receiveBuffer.RemoveAt(0);
                return result;
            }
            return null;
        }

        private void OnDisconnected()
        {
            MessageBox.Show(strings.MessageBox_Error_ConnectionLost, strings.MessageBox_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            Disconnect();
        }

        private void Connect()
        {
            receiveBuffer.Clear();
            sendBuffer.Clear();
            connectButtonState = ConnectButtonState.WouldAbort;
            buttonConnect.Text = strings.MainForm_Button_Connect_Abort;
            disconnecting = false;
            retry:
            try
            {
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                client.Blocking = false;
                client.Connect(new IPEndPoint(hostTextBoxHostConnect.Address, (int)numericUpDownPortConnect.Value));
            }
            catch (Win32Exception ex)
            {
                if (ex.ErrorCode == 10035)
                { 
                    // WSAEWOULDBLOCK is expected, means connect is in progress
                    WaitForConnection();
                }
            }
            catch
            {
                if (MessageBox.Show(strings.MessageBox_Error_Connect, strings.MessageBox_Error, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    goto retry;
                }
            }
        }

        private async void WaitForConnection()
        {
            while (connectButtonState == ConnectButtonState.WouldAbort)
            {
                Application.DoEvents();
                await Task.Delay(10);
                try
                {
                    if (client.Poll(1, SelectMode.SelectWrite))
                    {
                        connectButtonState = ConnectButtonState.WouldDisconnect;
                    }
                }
                catch
                {
                    return;
                }
            }
            CThread = new Thread(ConnectionThread);
            CThread.Start();
            buttonConnect.Text = strings.MainForm_Button_Connect_Disconnect;
            EnableClientControls(true);
            sendBoxSend.Focus();
        }

        private async void Disconnect()
        {
            disconnecting = true;
            while (!CThread.IsAlive)
            {
                await Task.Delay(10);
            }
            if (client.Connected)
            {
                client.Shutdown(SocketShutdown.Both);
                client.Disconnect(false);
                client.Close();
            }
            EnableClientControls(false);
            connectButtonState = ConnectButtonState.WouldConnect;
            buttonConnect.Text = strings.MainForm_Button_Connect_Connect;
            buttonConnect.Focus();
        }

        private void ConnectionThread()
        {
            try
            {
                while (client.Connected && !disconnecting && !Program.Exit)
                {
                    int available = client.Available;
                    if (available > 0)
                    {
                        byte[] data = new byte[available];
                        client.Receive(data, available, SocketFlags.None);
                        receiveBuffer.Add(data);
                        Invoke((MethodInvoker)(() => OnReceive()));
                    }
                    if (sendBuffer.Count > 0)
                    {
                        byte[] temp = sendBuffer[0];
                        while (temp == null)
                        {
                            temp = sendBuffer[0];
                        }
                        sendBuffer.RemoveAt(0);
                        client.Send(temp, temp.Length, SocketFlags.None);
                    }
                }
            }
            catch
            {
                Invoke((MethodInvoker)(() => OnDisconnected()));
            }
        }

        private void EnableClientControls(bool enable)
        {
            sendBoxSend.Enabled = enable;
            buttonSend.Enabled = enable;
        }

        private void toolStripMenuItemClear_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Text = "";
        }
        #endregion Actual Client

        #region IP-Scanner
        List<IPAddress> Range = new List<IPAddress>();

        private void numericUpDownIPScanTimeout_Enter(object sender, EventArgs e)
        {
            AcceptButton = buttonIPScan;
        }

        private void buttonIPScan_Click(object sender, EventArgs e)
        {
            ipscan = !ipscan;
            if (ipscan)
            {
                HostNameRetriever.timeout = (int)numericUpDownIPScanTimeout.Value;
                Range.Clear();
                Range = new IPRange(MinIP, MaxIP).GetAllIPs();
                IPScanUIUpdate();
                new Thread(IPScanThread).Start();
                buttonIPScan.Text = strings.MainForm_Button_Connect_Abort;
                EnableIPScanControls(false);
            }
            else
            {
                buttonPortScan.Text = strings.MainForm_Button_Scan;
            }
        }

        private async void IPScanUIUpdate()
        {
            IPScanProgress = 0;
            infoProgressBarIPScanner.Maximum = Range.Count;
            infoProgressBarIPScanner.DisplayStyle = ProgressBarDisplayText.Percentage;
            while (ipscan)
            {
                infoProgressBarIPScanner.Value = IPScanProgress;
                await Task.Delay(100);
            }
            EnableIPScanControls(true);
            buttonIPScan.Text = strings.MainForm_Button_Scan;
            infoProgressBarIPScanner.DisplayStyle = ProgressBarDisplayText.CustomText;
            infoProgressBarIPScanner.Maximum = 1;
            infoProgressBarIPScanner.Value = 1;
        }

        private void IPScanThread()
        {
            try
            {
                foreach (IPAddress ip in Range)
                {
                    if (!ipscan || Program.Exit)
                    {
                        break;
                    }

                    if (Ping(ip.ToString(), (int)numericUpDownScanIPAttempts.Value, (int)numericUpDownIPScanTimeout.Value))
                    {
                        AddIP(ip.ToString());
                    }
                    IPScanProgress++;
                }
            }
            catch
            {

            }
            ipscan = false;
        }

        public bool Ping(string host, int attempts, int timeout)
        {
            System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();

            System.Net.NetworkInformation.PingReply pingReply;

            for (int i = 0; i < attempts; i++)
            {
                try
                {
                    pingReply = ping.Send(host, timeout);
                    if (pingReply != null && pingReply.Status == System.Net.NetworkInformation.IPStatus.Success)
                    {
                        return true;
                    }
                }
                catch
                {
                }
            }
            return false;
        }

        private void EnableIPScanControls(bool enable)
        {
            ipAddressControlMinIP.Enabled = enable;
            ipAddressControlMaxIP.Enabled = enable;
            numericUpDownScanIPAttempts.Enabled = enable;
            numericUpDownIPScanTimeout.Enabled = enable;
        }
        
        private void ipAddressControlMaxIP_TextChanged(object sender, EventArgs e)
        {
            CheckIPs();
        }

        private void ipAddressControlMinIP_TextChanged(object sender, EventArgs e)
        {
            CheckIPs();
        }
        
        private bool IPCheck(IPAddress IP1, IPAddress IP2)
        {
            byte[] bytes1 = IP1.GetAddressBytes();
            byte[] bytes2 = IP2.GetAddressBytes();
            for (int i = 0; i < bytes1.Length; i++)
            {
                if (bytes1[i] < bytes2[i])
                {
                    return false;
                }
            }
            return true;
        }

        private void CheckIPs()
        {

            if (IPAddress.TryParse(ipAddressControlMaxIP.Text, out MaxIP) && IPAddress.TryParse(ipAddressControlMinIP.Text, out MinIP) && IPCheck(MaxIP, MinIP))
            {
                buttonIPScan.Enabled = true;
            }
            else
            {
                buttonIPScan.Enabled = false;
            }
        }

        private void buttonClearIP_Click(object sender, EventArgs e)
        {
            ClearIPs();
        }

        private void listViewIPScan_SelectionChanged(object sender, EventArgs e)
        {
            if (listViewIPScan.SelectedIndex > -1)
            {
                hostTextBoxPortScanHost.Text = ((IPScanItem)listViewIPScan.SelectedObject).HostName;
                hostTextBoxPortScanHost.StartCheck();
            }
        }
        #endregion IP-Scanner

        #region Port-Scanner
        private void numericUpDownPortScanTimeout_Enter(object sender, EventArgs e)
        {
            AcceptButton = buttonPortScan;
        }

        private void buttonPortScan_Click(object sender, EventArgs e)
        {
            portscan = !portscan;
            if (portscan)
            {
                PortScanUIUpdate();
                new Thread(PortScanThread).Start();
                buttonPortScan.Text = strings.MainForm_Button_Connect_Abort;
                EnablePortScanControls(false);
            }
            else
            {
                buttonPortScan.Text = strings.MainForm_Button_Scan;
            }
        }

        private async void PortScanUIUpdate()
        {
            PortScanProgress = 0;
            infoProgressBarPortScanner.Maximum = (int)numericUpDownMaxPort.Value - (int)numericUpDownMinPort.Value;
            infoProgressBarPortScanner.DisplayStyle = ProgressBarDisplayText.Percentage;
            while (portscan)
            {
                infoProgressBarPortScanner.Value = PortScanProgress;
                await Task.Delay(100);
            }
            EnablePortScanControls(true);
            buttonPortScan.Text = strings.MainForm_Button_Scan;
            infoProgressBarPortScanner.DisplayStyle = ProgressBarDisplayText.CustomText;
            infoProgressBarPortScanner.Maximum = 1;
            infoProgressBarPortScanner.Value = 1;
        }

        private void PortScanThread()
        {
            for (int port = (int)numericUpDownMinPort.Value; port <= (int)numericUpDownMaxPort.Value; port++)
            {
                if (!portscan || Program.Exit)
                {
                    break;
                }

                using (TcpClient tcp = new TcpClient())
                {
                    IAsyncResult ar = tcp.BeginConnect(PortScanIP.ToString(), port, null, null);
                    using (ar.AsyncWaitHandle)
                    {
                        if (ar.AsyncWaitHandle.WaitOne((int)numericUpDownPortScanTimeout.Value, false))
                        {
                            try
                            {
                                tcp.EndConnect(ar);
                                PortScanItem item = new PortScanItem(PortScanIP.ToString(), hostTextBoxPortScanHost.Text, port);
                                AddPort(item);
                            }
                            catch
                            {
                            }
                        }
                        else
                        {
                        }
                    }
                }
                PortScanProgress = port - (int)numericUpDownMinPort.Value;
            }
            portscan = false;
        }

        private void EnablePortScanControls(bool enable)
        {
            hostTextBoxPortScanHost.Enabled = enable;
            numericUpDownMinPort.Enabled = enable;
            numericUpDownMaxPort.Enabled = enable;
            numericUpDownPortScanTimeout.Enabled = enable;
        }

        private void hostTextBoxPortScannerHost_IPValidChanged(object sender, IPValidChangedEventArgs args)
        {
            checkInput();
        }

        private void numericUpDownMinPort_ValueChanged(object sender, EventArgs e)
        {
            checkInput();
        }

        private void numericUpDownMaxPort_ValueChanged(object sender, EventArgs e)
        {
            checkInput();
        }

        private void checkInput()
        {
            if (hostTextBoxPortScanHost.ValidationState != HostTextBox.ValidationStateType.Invalid && numericUpDownMaxPort.Value >= numericUpDownMinPort.Value)
            {
                PortScanIP = hostTextBoxPortScanHost.Address;
                buttonPortScan.Enabled = true;
            }
            else
            {
                buttonPortScan.Enabled = false;
            }
        }

        private void buttonClearPort_Click(object sender, EventArgs e)
        {
            ClearPorts();
        }

        private void listViewPortScan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPortScan.SelectedIndex > -1)
            {
                hostTextBoxHostConnect.Text = ((PortScanItem)listViewPortScan.SelectedObject).HostName;
                numericUpDownPortConnect.Value = ((PortScanItem)listViewPortScan.SelectedObject).Port;
                hostTextBoxHostConnect.StartCheck();
            }
        }
        #endregion Port-Scanner

        #region ListView utils
        private void AddIP(string IP)
        {
            IPScanItem item = new IPScanItem(IP);
            bool add = true;
            foreach (IPScanItem ip in ipScanItems)
            {
                if (ip.IP.Equals(IP))
                {
                    add = false;
                    break;
                }
            }
            if (add)
            {
                ipScanItems.Add(item);
                listViewIPScan.SetObjects(ipScanItems);
                Invoke((MethodInvoker)(() => AutosizeColumns(ref listViewIPScan)));
            }
        }

        private void ClearIPs()
        {
            ipScanItems.Clear();
            listViewIPScan.SetObjects(ipScanItems);
        }

        private void AddPort(PortScanItem item)
        {
            bool add = true;
            foreach (PortScanItem psi in portScanItems)
            {
                if (psi.Equals(item))
                {
                    add = false;
                    break;
                }
            }
            if (add)
            {
                portScanItems.Add(item);
                listViewPortScan.SetObjects(portScanItems);
                Invoke((MethodInvoker)(() => AutosizeColumns(ref listViewPortScan)));
            }
        }

        private void ClearPorts()
        {
            portScanItems.Clear();
            listViewPortScan.SetObjects(portScanItems);
        }

        private void AutosizeColumns(ref FastObjectListView list)
        {
            list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        #endregion ListView utils

        #region RichTextBox utils
        private void AddText(RichTextBox rtb, string txt, Color col)
        {
            rtb.Enabled = false;
            int pos = rtb.TextLength;
            rtb.AppendText(txt);
            rtb.Select(pos, txt.Length);
            rtb.SelectionColor = col;
            if (checkBoxAutoScroll.Checked)
            {
                rtb.Select();
                rtb.SelectionStart = rtb.Text.Length;
                rtb.ScrollToCaret();
            }
            rtb.Enabled = true;
        }

        #endregion RichTextBox utils

        #region Encoding utils
        private Encoding GetSelectedEncoding()
        {
            if (comboBoxEncoding.SelectedIndex > -1)
            {
                return Encoding.GetEncoding(encodings[comboBoxEncoding.SelectedIndex].CodePage);
            }
            return null;
        }
        #endregion Encoding utils

        #region Cleanup on close
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Disconnect();
            Program.Exit = true;
            Application.Exit();
            try
            {
                Environment.Exit(0);
            }
            catch {}
        }
        #endregion Cleanup on close
    }
}
