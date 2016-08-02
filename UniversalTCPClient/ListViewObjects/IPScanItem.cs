namespace UniversalTCPClient
{
    class IPScanItem
    {
        public string HostName
        {
            get; set;
        }

        public string IP
        {
            get; set;
        }

        public IPScanItem()
        {

        }

        public IPScanItem(string IP)
        {
            this.IP = IP;
            if (!string.IsNullOrEmpty(IP))
            {
                try
                {
                    HostName = Net.HostNameRetriever.GetReverseDNS(IP);
                }
                catch
                {
                }
            }
        }
    }
}
