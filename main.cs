using System;

class Program {
  public static void Main (string[] args) {
    int[] temp = new int[5];
    bool cooler = true;
    bool warmer = true;
    bool mixed = false;
    int sum = 0;
    
    Console.WriteLine ("Enter five daily Fahrenheit temperatures: ");

     for (int i = 0; i < 5; i++){
       int t;
       do 
       {
        Console.Write($"Temperature {i + 1}: ");
        if (!int.TryParse(Console.ReadLine(), out t) || t < -30 || t > 130) 
        {Console.WriteLine($"Temperature {t} is invalid. Please enter a valid temperature between -30 and 130");}
      } while (t < -30 || t > 130);
        
        temp[i] = t;
        sum += t;

        if(i > 0){
          if (temp[i] < temp[i -1])
      {
          warmer = false;
      }
        else if (temp[i] > temp[i - 1])
      {
          cooler = false;
      }
    }
  }

    if (!cooler && !warmer)
    {
      mixed =true;
    }
    string[] messages = new string[] {
        "Getting cooler",
        "Getting warmer",
        "It's a mixed bag"
    };

    if (cooler) {
        Console.WriteLine(messages[0]);
    }
    else if (warmer) {
        Console.WriteLine(messages[1]);
    }
    else if (mixed) {
        Console.WriteLine(messages[2]);
    }
    
    Console.Write("5-day temperature [");
    foreach (int t in temp) {
        Console.Write(t + " ");
    }
    Console.WriteLine("]");
    
    double average =(double)sum / temp.Length;
    Console.WriteLine($"Average temperature is {average} degrees");

  }

}