using System;
using System.Net;

namespace UniversalTCPClient.Net
{
    class HostNameRetriever
    {
        public static int timeout = 100;

        private delegate IPHostEntry GetHostEntryHandler(string ip);

        public static string GetReverseDNS(string ip)
        {
            try
            {
                GetHostEntryHandler callback = new GetHostEntryHandler(Dns.GetHostEntry);
                IAsyncResult result = callback.BeginInvoke(ip, null, null);
                if (result.AsyncWaitHandle.WaitOne(timeout, false))
                {
                    return callback.EndInvoke(result).HostName;
                }
                else
                {
                    return ip;
                }
            }
            catch (Exception)
            {
                return ip;
            }
        }
    }
}
