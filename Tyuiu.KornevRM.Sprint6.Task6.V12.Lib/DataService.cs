using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KornevRM.Sprint6.Task6.V12.Lib
{
    public class DataService : ISprint6Task6V12
    {
        public string CollectTextFromFile(string path)
        {
            HashSet<string> uniqueWords = new HashSet<string>();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] temp = line.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string item in temp)
                    {
                        if (item.ToLower().Contains('w'))
                        {
                            uniqueWords.Add(item); 
                        }
                    }
                }
            }

            return string.Join(Environment.NewLine, uniqueWords); 
        }
    }
}
    

