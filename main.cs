using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public  class Subscriber
  {
      public uint id = 0;
      public string names = "";
      public string books = "";
  }
  public static void Main()
  {
    
    uint[] id = new uint [10];
    string[] names = new string[10] {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"};
    string[] books = new string[10] {"A_book", "B_book", "C_book", "D_book", "E_book", "F_book", "G_book", "H_book", "I_book", "J_book"};

    for (uint i = 0; i < 10; i++)
    {
        id[i] = i;
    }

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"id: {id[i]}\t Name: {names[i]}\t Book: {books[i]}");
    }

    Subscriber newSubscriber = new Subscriber();
    newSubscriber.id = 101;
    newSubscriber.names = "Mark";
    newSubscriber.books = "Mark_book";
    Console.WriteLine($"ID: {newSubscriber.id}\t Names: {newSubscriber.names} \t Book: {newSubscriber.books}");
  }

}
