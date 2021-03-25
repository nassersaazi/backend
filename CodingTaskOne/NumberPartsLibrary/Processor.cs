using System;

namespace NumberPartsLibrary
{
    public class Processor
    {
        public int[] DoWork(int number, int parts) {
            
            int[] partsArray = new int[parts];
            if (number % parts == 0)
            {
                for (int i = 0; i < partsArray.Length; i++)
                {
                    partsArray[i] = number / parts;
                }
                return partsArray;
            }

            throw new NotImplementedException("Not fully implemented.");
        }
        
    }
}
