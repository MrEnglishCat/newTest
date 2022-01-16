using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("asda");
    int[] id = new int [10];
    string[] names = new string[10] {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"};
    string[] books = new string[10] {"A_book", "B_book", "C_book", "D_book", "E_book", "F_book", "G_book", "H_book", "I_book", "J_book"};

    for (int i = 0; i < 10; i++)
    {
        id[i] = i;
    }

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"id: {id[i]}\t Name: {names[i]}\t Book: {books[i]}");
    }
  }

}
