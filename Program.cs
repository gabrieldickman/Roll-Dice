using System;

class MainClass{
  public static void Main (string[] args){
    int roll = 1;

    while(roll != 3)
    {
      Menu();
      roll=int.Parse(Console.ReadLine());
      switch(roll)
      {
        case 1:
          Console.WriteLine(GetRandomNumber());
          break;
        case 2:
          break;
        default:
          System.Environment.Exit(0);
          break;
      }
    }
  }

  public static void Menu()
  {
    Console.WriteLine("do you want to roll the dice?");
    Console.WriteLine("[1] yes");
    Console.WriteLine("[2] no");
    Console.WriteLine("[3] exit");
  }
  public static int GetRandomNumber()
  {
    Random randNum = new Random();
    return randNum.Next(1, 20);
  }
}