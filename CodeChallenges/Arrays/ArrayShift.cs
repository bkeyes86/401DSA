using System;


namespace CodeChallenges.Arrays
{
    public class ArrayShift

    {
        
        
           public static int[] insertShiftArray(int[] inArray, int input)
            {
                int n = inArray.Length;
                int pos = inArray.Length / 2;
                int[] outArray = new int[n + 1];

                foreach (int i in inArray)
                {
                    if (i < pos - 1)
                    {
                        outArray[i] = inArray[i];
                    }

                    else if (i == pos - 1)
                    {
                        outArray[i] = input;
                    }
                    else

                    {
                        outArray[i] = inArray[i - 1];
                    }

                }




            return outArray;

            }

        }
    }

