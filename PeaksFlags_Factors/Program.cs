using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        //Find the peaks
        int[] peakInPosition = new int[A.Length];
        int numberOfPeaks = 0;
        for (int i = 1; i < A.Length - 1; i++)
        {
            if (A[i] > A[i - 1] && A[i] > A[i+1])
            {
                peakInPosition[i] = 1;
                numberOfPeaks++;
            }
        }

        if(numberOfPeaks < 2)
        {
            return numberOfPeaks;
        }

        for(int flags = numberOfPeaks; flags > 0; flags--)
        {
            int flagsLeft = flags;
            int index = 0;
            while(index < A.Length && flagsLeft > 0)
            {
                if(peakInPosition[index] == 1)
                {
                    flagsLeft--;
                    index += flags;
                }
                else
                {
                    index++;
                }
            }
            if(flagsLeft == 0)
            {
                return flags;
            }
        }
        return 0;

    }
}