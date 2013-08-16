//3. Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(...).
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.Collections.Generic;
using System.IO;
    class ReadAndPrintFIle
    {
        static void Main()
        {
            Console.WriteLine("Enter your fail path:");
            string path = Console.ReadLine();
            try
            {
                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file specified in path was not found.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive).");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("path is null.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("path is a zero-length string, contains only white space, or contains one or more invalid characters as defined by InvalidPathChars.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("path is in an invalid format.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Path specified a file that is read-only. -or- This operation is not supported on the current platform. -or- Path specified a directory. -or- The caller does not have the required permission.");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occurred while opening the file.");
            }
        }
    }
