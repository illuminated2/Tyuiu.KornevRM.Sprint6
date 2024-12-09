using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KornevRM.Sprint6.Task5.V8.Lib
{
    public class DataService : ISprint6Task5V8
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                string line;
                while ((line = file.ReadLine()) != null) len++;
            }

            double[] array = new double[len];
            int index = 0;

            using (StreamReader file = new StreamReader(path))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) < 0) array[index] = Math.Round(Convert.ToDouble(line), 2);
                    index++;
                }
            }
            return array;
        }
    }
}
