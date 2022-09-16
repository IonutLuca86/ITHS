// See https://aka.ms/new-console-template for more information
string[] techniques = { "   C#", "daTAbaser", "WebbuTVeCkling ", "clean Code   " };                 
string[] messagesToClass = { "Glöm inte att övning ger färdighet!", "Öppna boken på sida 257." };   
string className = ".NET Distans 2022";                                                             
string color = "red";                                                                               



WebsiteGenerator myWebsite = new WebsiteGenerator(className, messagesToClass, techniques);

StyledWebsiteGenerator styledWebsite = new StyledWebsiteGenerator(className, messagesToClass, techniques, color);





        FileStream outputStream;
        StreamWriter writer;
        TextWriter textWriter = Console.Out;
        try
        {
            outputStream = new FileStream(@"D:\WebsiteGenerator.html", FileMode.OpenOrCreate, FileAccess.Write);
            writer = new StreamWriter(outputStream);
        }
        catch (Exception e)
        {
            Console.WriteLine("Cannot open WebsiteGenerator.html for writing");
            Console.WriteLine(e.Message);
            return;
        }
        Console.SetOut(writer);
        styledWebsite.PrintWebsite();
        Console.SetOut(textWriter);
        writer.Close();
        outputStream.Close();
        Console.WriteLine("Done");
    




    //abstract class Generator
    //{ 
    //    public abstract void PrintWebsite();
    //    public abstract void PrintStart();
    //    public abstract void PrintHeader();
    //    public abstract void PrintCourses(); 
    //    public abstract void PrintEnd();
    //}
    interface IGenerator
    {
        void PrintWebsite();
        void PrintStart();
        void PrintHeader();
        void PrintCourses();
        void PrintEnd();
    }
    class WebsiteGenerator : IGenerator
    {
        protected string start = "<!DOCTYPE HTML>\n<html>\n<body>\n<main>\n";
        protected string end = "</main>\n</body>\n</html>\n";
        protected string[] techniques, messageToClass;
        protected string className;

        public WebsiteGenerator(string className, string[] messageToClass, string[] techniques)
        {
            this.className = className;
            this.messageToClass = messageToClass;
            this.techniques = FixArray(techniques);
        }

        public void PrintWebsite()
        {
            PrintStart();
            PrintHeader();
            PrintCourses();
            PrintEnd();
        }

        public void PrintHeader()
        {
            Console.WriteLine($"<h1>Välkomna {this.className}</h1>");
            foreach (string msg in this.messageToClass)
            {
                Console.WriteLine($"<p><b>Meddelande: </b>{msg}</p>");
            }
        }

        public void PrintCourses()
        {
            foreach (var course in this.techniques)
            {
                Console.WriteLine(course);
            }
        }

        public void PrintStart()
        {
            Console.Write(this.start);
        }

        public void PrintEnd()
        {
            Console.Write(this.end);
        }

        protected string[] FixArray(string[] techniques)
        {
            string[] temp = new string[techniques.Length];
            for (int i = 0; i < techniques.Length; i++)
            {
                temp[i] = "<p>Kurs i " + techniques[i].Trim().ToUpper().Substring(0, 1) + techniques[i].Trim().Substring(1).ToLower() + "<p/>";
            }
            return temp;
        }
    }

    class StyledWebsiteGenerator : WebsiteGenerator, IGenerator
    {
        private string color;

        public StyledWebsiteGenerator(string className, string[] messageToClass, string[] techniques, string color) : base(className, messageToClass, techniques)
        {
            this.color = color;
        }
        public void PrintWebsite()
        {
            PrintStyledStart();
            PrintHeader();
            PrintCourses();
            PrintEnd();
        }

        private void PrintStyledStart()
        {
            Console.Write(this.start.Insert(23, $"<head>\n<style>\np {{ color: {this.color}; }}\n</style>\n</head>\n"));
        }
    }
