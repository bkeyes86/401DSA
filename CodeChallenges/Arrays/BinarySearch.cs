using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges.Arrays
{
    public class BinarySearch
    {
        public static int Search(int[] array, int searchKey)
        {
            int minIndex = 0;
            int maxIndex = array.Length - 1;
            {
                while (minIndex <= maxIndex) 
                {
                    int middleIndex = (minIndex + maxIndex) / 2;
                    if (searchKey == array[middleIndex]) 
                    {
                        return middleIndex;
                    }
                    else if (searchKey < array[middleIndex])
                    {
                        maxIndex = middleIndex - 1;
                    }
                    else
                    {
                        minIndex = middleIndex + 1;

                    }
                }
                return -1;

                }
                        
                    
                   
            }

        }

    }


         
            
    

