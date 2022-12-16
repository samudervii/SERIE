using System;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
    List<string> retVal = new List<string>();

        if( sliceLength <= 0 )
            throw new ArgumentException();
        
        if(numbers.Length < sliceLength)
            throw new ArgumentException();
            
        int giri = numbers.Length - sliceLength+1;

        for(int x=0;x<giri;x++)
        {
            string s = numbers.Substring(x, sliceLength);
            retVal.Add(s);
        }           
        
        return retVal.ToArray();
    
    
    
    }
}
