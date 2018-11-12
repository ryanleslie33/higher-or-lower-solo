using System;
using System.Collections.Generic;


public class paradigm
{
public  static void Main()
  {
    List<string> numbersInput = new List<string>();

              Console.WriteLine("enter a word bro");
            string input = Console.ReadLine();
            numbersInput.Add(input);
            string[] terms = numbersInput.ToArray();
    Array.Reverse(terms);

  Console.WriteLine(numbersInput) ;
  }

}
