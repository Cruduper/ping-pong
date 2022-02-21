using System;



class Program
{
  static void Main()
  {

    Console.WriteLine("please type a number: ");
    string response = Console.ReadLine();

    int yourNumber = int.Parse(response);

    for(int i = 1; i <= yourNumber ; i++){
      if( (i % 3 == 0) && (i % 5 == 0) ){
        Console.WriteLine("ping-pong");
      } else if ( i % 5 == 0 ){
        Console.WriteLine("pong");
      } else if ( i % 3 == 0 ){
        Console.WriteLine("ping");
      } else {
        Console.WriteLine( i );
      }
    }
    // program code goes here
  }
}