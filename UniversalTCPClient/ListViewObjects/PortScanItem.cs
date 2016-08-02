namespace UniversalTCPClient
{
    class PortScanItem
    {

        public PortScanItem(string ip, string hostname, int port)
        {
            IP = ip;
            HostName = hostname;
            Port = port;
        }

        public PortScanItem()
        {

        }

        public override bool Equals(object obj)
        {
            if (obj != null && IP.Equals(((PortScanItem)obj).IP) && Port.Equals(((PortScanItem)obj).Port))
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + IP.GetHashCode();
            hash = (hash * 7) + hostname.GetHashCode();
            hash = (hash * 7) + Port.GetHashCode();
            return hash;
        }

        private string ip = "";
        private string hostname;
        private int port = 0;

        public string IP
        {
            get
            {
                return ip;
            }
            set
            {
                ip = value;
            }
        }

        public string HostName
        {
            get
            {
                return hostname;
            }
            set
            {
                hostname = value;
            }
        }

        public int Port
        {
            get
            {
                return port;
            }
            set
            {
                port = value;
            }
        }
    }
}
