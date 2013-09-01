//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elelemnts.
//For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//[protocol] = "http"
//[server] = "www.devbg.org"
//[resource] = "/forum/index.php"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class ParseAndExtractURL
    {
        static void Main()
        {
            Console.WriteLine("Enter the URL address:");
            string url = Console.ReadLine();
            int endProtocol = url.IndexOf(":");
            string protocol = url.Substring(0, endProtocol);
            Console.WriteLine("[protocol] = {0}", protocol);
            string withoutProtocol = url.Remove(0, protocol.Length + 3);
            int endServer = withoutProtocol.IndexOf("/");
            string server = withoutProtocol.Substring(0, endServer);
            Console.WriteLine("[server] = {0}", server);
            string resource = withoutProtocol.Remove(0, server.Length);
            Console.WriteLine("[resource] = {0}", resource);
            Console.WriteLine();
        }
    }
