using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHW
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
        }

        private static void SecondTask()
        {
            char[] mas;
            List<int> mas2 = new List<int>();
            int sum = 0;

            using (FileStream stream = new FileStream("INPUT.txt", FileMode.OpenOrCreate))
            {
                byte[] bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                mas = Encoding.UTF8.GetChars(bytes);

                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] != ' ')
                    {
                        mas2.Add((int)Char.GetNumericValue(mas[i]));
                        sum += (int)Char.GetNumericValue(mas[i]);
                    }
                }
            }

            using (StreamWriter stream = new StreamWriter("OUTPUT.txt"))
            {
                stream.WriteLine(sum);
            }
        }

        private static void FirstTask()
        {
            byte[] array;

            using (FileStream stream = new FileStream("FirstTask.txt", FileMode.Open))
            {
                array = new byte[stream.Length];
                stream.Read(array, 0, array.Length);
            }

            using (FileStream stream = new FileStream("FirstTask.txt", FileMode.Append))
            {
                stream.Write(array, 0, array.Length);
            }
        }
    }
}
