using System;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            String documentName;
            String content;
            String fileName;

            try
            {
                Console.WriteLine("Document");
                Console.WriteLine("Type in name of document");
                documentName = Console.ReadLine();

                Console.WriteLine("What's gonna go in the document?");
                content = Console.ReadLine();

                fileName = documentName + ".txt";

                string path = Environment.CurrentDirectory + "/" + fileName;
                if (!File.Exists(path))
                {
                    File.WriteAllText(path, content);
                }
                Console.WriteLine(fileName + " was successfully saved. The document contains " + content.Length + " characters");
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }
    }
}
