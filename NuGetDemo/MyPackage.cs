using System;
using System.Collections.Generic;
using System.Text;

namespace NuGetDemo
{
    public class MyPackage
    {
        public void DiaplayText(string text)
        {
            Console.WriteLine(text);


        }
        public void displayDate()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }
    }
}
