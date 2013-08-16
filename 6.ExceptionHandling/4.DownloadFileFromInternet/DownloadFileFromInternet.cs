//4. Write a program that downloads a file from internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory.
//Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Collections.Generic;
using System.Net;
    class DownloadFileFromInternet
    {
        static void Main()
        {
            try
            {
                WebClient webClient = new WebClient();
                string url = Console.ReadLine();
                string fileName = Console.ReadLine();
                string myStringWebResource = null;
                myStringWebResource = url + fileName;
                Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n\n", fileName, myStringWebResource);
                webClient.DownloadFile(myStringWebResource, fileName);
                Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, myStringWebResource);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The address parameter is null.");
            }
            catch (WebException)
            {
                Console.WriteLine("The URI formed by combining BaseAddress and address is invalid. -or- Filename is null or Empty. -or- The file does not exist. -or- An error occurred while downloading data.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
            }
        }
    }
