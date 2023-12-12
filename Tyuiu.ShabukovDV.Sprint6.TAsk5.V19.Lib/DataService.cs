using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShabukovDV.Sprint6.TAsk5.V19.Lib
{
    public class DataService : ISprint6Task5V19
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            List<double> numbers = new List<double>();

            using (StreamReader reader = new StreamReader(path))
            {

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                    double number;
                    if (double.TryParse(line, out number))
                    {
                        if (Math.Abs(number - Math.Round(number)) < 0.001)
                        {
                            numbers.Add(Math.Round(number, 3));
                        }
                    }

                }
            }

            return numbers.ToArray();
        }
    }
}
