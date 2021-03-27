using System;
using NumberPartsLibrary;
namespace NumberParts
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Program p = new Program();
            var myArray = p.Splitter(9,4);

            Console.WriteLine("Code wars first task!\n\n" 
            + "[{0}]", string.Join(", ", myArray));
        }

        public int[] Splitter(int number, int parts){
                
                int[] partsArray = new int[parts];
                int c1 = number - (number % parts);
                for (int i = 0; i < partsArray.Length; i++)
                {
                    if (i == partsArray.Length - 1)
                    {
                        partsArray[i] = number % parts;
                    }
                    else
                    {
                        partsArray[i] = c1 / parts;
                    }
                    
                }
                return partsArray;
            }
            // Processor proc = new Processor();
            // proc.DoWork(11,3);
       
    }
}
