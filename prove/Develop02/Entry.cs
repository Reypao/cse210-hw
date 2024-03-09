using System;

namespace Journal
{
    class Entry
    
    {
        public DateTime Date { get; set; }
        public string Prompt { get; set; }
        public string Response { get; set; }

        public Entry(DateTime date, string prompt, string response)
        {
            Date = date;
            Prompt = prompt;
            Response = response;
        }
        public void Display()
        {
            Console.WriteLine(Date);
            Console.WriteLine(Prompt);
            Console.WriteLine(Response);
        }
    }
}
