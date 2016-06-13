using System;

namespace _10._05_URLParser
{
    public class URLParser
    {
        public static void Main()
        {
            string url = Console.ReadLine();
            int protocolIndex = url.IndexOf("://");
            string protocol = "";

            if (protocolIndex > 0)
            {
                protocol = url.Substring(0, protocolIndex);
            }
            
            int resourceIndex = url.IndexOf("/", protocolIndex + 3);
            string server = "";
            string resources = "";

            if (resourceIndex > 0)
            {
                server = url.Substring(protocolIndex + 3, resourceIndex - protocolIndex - 3);
                resources = url.Substring(resourceIndex + 1);
            }
            else if(protocolIndex > 0)
            {
                server = url.Substring(protocolIndex + 3);
            }
            else
            {
                server = url.Substring(protocolIndex + 1);
            }
            
            Console.WriteLine("[protocol] = \"{0}\"", protocol);
            Console.WriteLine("[server] = \"{0}\"", server);
            Console.WriteLine("[resource] = \"{0}\"", resources);
        }
    }
}