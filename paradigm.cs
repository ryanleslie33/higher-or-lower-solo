using System;
using System.Collections.Generic;


public class paradigm
{
public  static void Main()
{
  var input =Console.ReadLine();
  var charArray = input.ToCharArray();
  Array.Reverse(charArray);
  var reversed = new string(charArray);
  Console.WriteLine(reversed);
  if( reversed == input)
  {
    Console.WriteLine("your word is a paradigm");
  }
}
}
