using System;

namespace String_Metotları
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Dersimiz CSharp, Hoşgeldiniz!";
            string value2 = "CSharp";

            //Length
            System.Console.WriteLine("*** Length ***");
            System.Console.WriteLine(value.Length);
            

            //ToUpper, ToLower
            System.Console.WriteLine("*** ToUpper,ToLower ***");
            System.Console.WriteLine(value.ToUpper());
            System.Console.WriteLine(value.ToLower());

            //Concat
            System.Console.WriteLine("*** Concat ***");
            System.Console.WriteLine(String.Concat(value," Merhaba!"));

            //Compare, CompareTo
            System.Console.WriteLine("*** Compare, CompareTo ***");
            System.Console.WriteLine(value2.CompareTo(value));// 0,1,-1
            System.Console.WriteLine(String.Compare(value,value2,true));
            System.Console.WriteLine(String.Compare(value,value2,false));

            //Contains
            System.Console.WriteLine("*** Contains ***");
            System.Console.WriteLine(value.Contains(value2));
            System.Console.WriteLine(value.EndsWith("Hoşgeldiniz!"));
            System.Console.WriteLine(value.StartsWith("Dersimiz"));

            //IndexOf
            System.Console.WriteLine("*** IndexOf ***");
            System.Console.WriteLine(value.IndexOf("CS"));
            System.Console.WriteLine(value.IndexOf("askgh"));
            System.Console.WriteLine(value.LastIndexOf("i"));
        
            //Insert
            System.Console.WriteLine("*** Insert ***");
            System.Console.WriteLine(value.Insert(0,"Merhaba! "));

            //PadLeft, PadRight
            System.Console.WriteLine("*** PadLeft, PadRight ***");
            System.Console.WriteLine(value + value2.PadLeft(30));
            System.Console.WriteLine(value + value2.PadLeft(30,'*'));
            System.Console.WriteLine(value.PadRight(50) + value2);
            System.Console.WriteLine(value.PadRight(50,'-') + value2);            

            //Remove
            System.Console.WriteLine("*** Remove ***");
            System.Console.WriteLine(value.Remove(10));
            System.Console.WriteLine(value.Remove(5,3));
            System.Console.WriteLine(value.Remove(0,1));
            
            //Replace
            System.Console.WriteLine("*** Replace ***");
            System.Console.WriteLine(value.Replace("CSharp","C#"));
            System.Console.WriteLine(value.Replace(" ","*"));

            //Split
            System.Console.WriteLine("*** Split ***");
            System.Console.WriteLine(value.Split(' ')[1]);

            //Substring
            System.Console.WriteLine("*** Substring ***");
            System.Console.WriteLine(value.Substring(4));
            System.Console.WriteLine(value.Substring(4,6));

        }
    }
}
