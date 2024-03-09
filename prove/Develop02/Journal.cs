using System;
namespace Journal 
{
  class Journal
    {
    private List<Entry> _entries;
    public Journal()
        {
            _entries = new List<Entry>();
        }

        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }
        public void DisplayEntries()
        {
            foreach (var entry in _entries)
            {
                Console.WriteLine(entry.Date.ToString() + " " + entry.Prompt + " " + entry.Response);
            }
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
                }
            }
        }
        public void LoadFromFile(string filename)
        {
            _entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3 && DateTime.TryParse(parts[0], out DateTime date))
                    {
                        _entries.Add(new Entry(date, parts[1], parts[2]));
                    }
                }
            }
        }
    
    }  
}

