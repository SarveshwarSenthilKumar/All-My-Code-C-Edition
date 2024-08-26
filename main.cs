/*

using System;

namespace Sarveshwar
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      string myname = "Sarveshwar";
      Console.WriteLine("Hello Friend");
      Console.Write("What's your name? : ");
      string fname = Console.ReadLine();
      Console.WriteLine("Hi " + fname + ", my name is " + myname);
      Console.Write("What is your favorite subject in school? :");
      string fsubject = Console.ReadLine();
      string msubject = "Math";
      Console.WriteLine("oh, favorite subject in school is " + fsubject + ", my favorite subject in school is " + msubject);
      Console.WriteLine("Bye");
    }
  }
}
*/

//_______________________________________________________

/*
int[] num = {1, 2, 3, 4, 5, 6, 7, 8 ,9};
*/

//________________________________________________________

/*
using System;


namespace Sarvesh
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Name: ");
      string Name = Console.ReadLine();
      Console.WriteLine();
      Console.Clear();
      Console.WriteLine("Hi " + Name);
      Console.Write("How old are you?: ");
      string age = Console.ReadLine();
      int Age = Convert.ToInt32(age);
      Console.Clear();
      Console.WriteLine("Your name is " + Name + " and you are " + Age + " years old");
    }
  }
}
*/

//_______________________________________________________

/*
using System;

namespace C 
{
  class Program
  {
    static void Main(string[] args)
    {
      class Person
      {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

      }
    }
  }
}
  
  */

//_______________________________________________________

/*
using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Clear();
    Console.WriteLine ("Welcome to Find Factorial\n");
    int a, b = 1, num;
    Console.Write("Enter the number that you want to find the factorial of: ");
    string n = Console.ReadLine();
    num = int.Parse(n);
    Console.Clear();
    for (a = 1; a <= num; a++)
    {
      b = b * a;
    }
    Console.WriteLine("The factorial of " + num + " is " + b + "\n");
    Console.Write("Press enter to continue...")
    Console.Clear()

  }
}
*/

//________________________________________________________

/*
using System;

class MainClass {
  public static void Main (string[] args) {
    do {
      Console.Clear();
    Console.WriteLine("Welcome to Calculator\n");
    Console.WriteLine(@"    1. Addition
    2. Subtraction
    3. Division
    4. Multiplication
    5. Exit
    ");
    Console.Write("Enter the operation: ");
    string oper = Console.ReadLine();
    Console.Clear();
    string addit = (("ADDITION").ToLower());
    string subta = (("SUBTRACTION").ToLower());
    string divis = (("DIVISION").ToLower());
    string multi = (("MULTIPLICATION").ToLower());
    string exit = (("EXIT").ToLower());
    if (oper == "1" | oper == addit)
    {
      int fnum, snum, tnum;
      Console.Write("First number to add: ");
      fnum = Convert.ToInt32(Console.ReadLine());
      Console.Write("Second number to add: ");
      snum = Convert.ToInt32(Console.ReadLine());
      tnum = fnum + snum;
      Console.Clear();
      Console.WriteLine(fnum + " plus " + snum + " is " + tnum);
      Console.ReadLine();
      exi();
    }
    else if (oper == "2" | oper == subta)
    {
      int fnum, snum, tnum;
      Console.Write("Number to subtract from: ");
      fnum = Convert.ToInt32(Console.ReadLine());
      Console.Write("Number to subtract: ");
      snum = Convert.ToInt32(Console.ReadLine());
      tnum = fnum - snum;
      Console.Clear();
      Console.WriteLine(fnum + " taken away from " + snum + " is " + tnum);
      Console.ReadLine();
      exi();
    }
    else if (oper == "3" | oper == divis)
    {
      int fnum, snum, tnum;
      Console.Write("Number to divide: ");
      fnum = Convert.ToInt32(Console.ReadLine());
      Console.Write("The divisor: ");
      snum = Convert.ToInt32(Console.ReadLine());
      tnum = fnum / snum;
      Console.Clear();
      Console.WriteLine(fnum + " divided by " + snum + " is " + tnum);
      Console.ReadLine();
      exi();
    }
    else if (oper == "4" | oper == multi)
    {
      int fnum, snum, tnum;
      Console.Write("Number to multiply: ");
      fnum = Convert.ToInt32(Console.ReadLine());
      Console.Write("The number to multiply by: ");
      snum = Convert.ToInt32(Console.ReadLine());
      tnum = fnum * snum;
      Console.Clear();
      Console.WriteLine(fnum + " multiplied by " + snum + " is " + tnum);
      Console.ReadLine();
      exi();
    }

    else if (oper == "5" | oper == exit)
    {
      Console.Clear();
      break;
    }

    else 
    {
      Console.WriteLine("Invalid Input");
      exi();
    }

  } while (true);

    }
    
  static void exi()
  {
    Console.WriteLine();
    Console.Write("Press enter to continue...");
    Console.Clear();
  }
}
*/

//_______________________________________________________

/*
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Per {
  
  public class Person
  {   
    public string name;
    public int age;
  }

  class MainClass {
    public static void Main (string[] args) {
      Person Sarv = new Person();
      Sarv.name = "Sarveshwar";
      Sarv.age = 12;
      Console.WriteLine(Sarv.name + " is " + Sarv.age + " years old ");
  }
}
}

*/

//_______________________________________________________

/*
using System;

class Program
{
  static void Main(string [] args)
  {
    Console.Clear();
    Console.Write("Enter a number: ");
    string oper = Console.ReadLine();
    try
    {
      int ope = int.Parse(oper);
    }
    catch (Exception o)
    {
      Console.Clear();
      Console.WriteLine(o.Message);
      Console.ReadLine();

    }
  }
}
*/

//_______________________________________________________

/*
using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Clear();

    do
    {
      Console.Write("Enter a number (Q to exit): ");
      try
      {
        int num = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    if (num % 2 == 0)
    {
      Console.WriteLine(num + " is an even number");
    }
    else
    {
      Console.WriteLine(num + " is an odd number");
    }

      }

      catch (Exception o)
      {
        Console.Clear();
        break;
      }
    

    } while (true);
    
  }
}
*/

//_________________________________________________________

/*
using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    Console.Clear();
    do{
      Console.Write ("Enter how many fibonacci numbers you want (Q to exit): ");
    string fib = Console.ReadLine();
    try
    {
      int fibnu = int.Parse(fib);
    int fibnum = fibnu - 2;
    int numbo = 2;
    Console.Clear();
    int a = 0;
    int b = 1;
    Console.WriteLine("1. 0");
    Console.WriteLine("2. 1");


    do
    {
      fibnum --;
      numbo ++;
      int c = a + b;
      Console.WriteLine(numbo + ". " + c);
      a = b;
      b = c;

    } while (fibnum > 0);

    Console.WriteLine("\n");
    Console.WriteLine("Press enter to continue...");
    Console.ReadLine();
    Console.Clear();

    }

    catch (Exception o)
    {
      Console.Clear();
      break;
    }
    } while (true);
    
  }
}
*/

//_______________________________________________________

/*
using System;
using System.Linq;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    do{
      Console.Clear();
      Console.Write("Enter the number you want to get multiples of (Q to exit): ");
      try{
        int multi = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter how many multiples you want to get: ");
      int multip = Convert.ToInt32(Console.ReadLine());
      int multin = multip + 1;
      Console.Clear();

      IEnumerable<int> multiplie = Enumerable.Range(1, multip);

      foreach (int i in multiplie)
      {
        int a = i  * multi;
        Console.WriteLine(i + ". " + a);
      }
      
      Console.Write("\nPress enter to continue...");
      Console.ReadLine();

      }

      catch (Exception i)
      {
        Console.Clear();
        break;
      }
      
    } while (true);
  

  }
}
*/

//_______________________________________________________

/*
using System;
using System.Linq;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Console.Clear();
    do{
      Console.WriteLine();
      Console.Write ("Enter a number you want to find the divisibles of (Q to exit): ");
      try
      {
        int div = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        IEnumerable<int> divis = Enumerable.Range(1, div);
        List<int> divsible = new List<int>();
        foreach (int value in divis)
        {
          if (div % value == 0)
          {
            divsible.Add(value);
          }
        }
        int o = 0;
        Console.WriteLine(div + " is divisble by ");
        Console.WriteLine();

        foreach (int value in divsible)
        {
          o ++;
          Console.WriteLine(o + ". " + value);
        }

      }

      catch (Exception o)
      {
        Console.Clear();
        break;
      }
      

    } while (true);
   
  }
}
*/

//_______________________________________________________

/*
using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Clear();
    Console.WriteLine("Welcome to Dice\n");
    do
    {
      
      Console.Write("Enter the maximum you want on the dice (Q to exit): ");
      try
      {
        int max = Convert.ToInt32(Console.ReadLine());
      Random r = new Random();
      int dicnum = r.Next(1,max);
      Console.Clear();
      Console.WriteLine(dicnum + "\n");
        
      }

      catch (Exception o)
      {
        Console.Clear();
        break;
      }
      

    } while (true);
    
  }
}
*/

//_______________________________________________________


/*
using System;
using System.IO;
using System.Globalization;

class MainClass 
{
  static void Main(string[] args)
    {
      Console.Clear();

      Console.WriteLine("Welcome to Sarveshwar's Rock Paper Scissors - C# Edition\n");

      Console.Write("Enter your name: ");
      string na = Console.ReadLine();
      Console.Clear();
      Console.WriteLine("If you have 50 credits enter '50' as an option\n");
      Console.Write("Press enter to continue... ");
      Console.ReadLine();
      Console.Clear();
      Console.WriteLine("Welcome to Sarveshwar's Rock Paper Scissors\n");
      Console.Write("Press enter to continue... ");
      Console.ReadLine();
      int credits = 0;
      titlescreen(na, credits);


    }

    static void guide(string na, int credits)
    {
      Console.Clear();
      Console.WriteLine("In Sarveshwar's Rock Paper Scissors you have to choose either a low, medium or high credits game and then you go against a robot for either 1, 3, 7 or 200 credits, you have to pick rock, paper or scissors ,if you win you get one point and if you get 3 points before the robot you win the credits for that game.\n");
      Console.Write("Press enter to continue...");
      Console.ReadLine();
      Console.Clear();
      titlescreen(na, credits);

    }

    static void titlescreen(string na, int credits)
    {
      Console.Clear();
      Console.WriteLine("Welcome to Sarveshwar's Rock Paper Scissors\n");
      Console.WriteLine("Credits:" + credits + "\n");
      Console.WriteLine(@"      1. Low Credits(0 credits to enter)
      2. Good Credits(1 credit to enter)
      3. Great Credits(5 credits to enter)
      4. HELP GUIDE
      5. QUIT");
      Console.WriteLine();
      Console.Write("Which one do you want to go for? (Enter the number): ");
      int gameopt = Convert.ToInt32(Console.ReadLine());
      Console.Clear();

      if (gameopt == 1)
      {
        easygame(na, credits);
      } 

      else if (gameopt == 2)
      {
        if (credits >= 1)
        {
          credits = credits - 1;
          medgame(na, credits);

        }

        else
        {
          Console.WriteLine("Hey, stop trying to break the game. Insufficient Credits\n");
          Console.Write("Press enter to continue...");
          Console.ReadLine();
          titlescreen(na, credits);
        }
        
      }

      else if (gameopt == 3)
      {
        if (credits >= 5)
        {
          credits = credits - 5;
          hardgame(na, credits);

        }

        else
        {
          Console.WriteLine("Hey, stop trying to break the game. Insufficient Credits\n");
          Console.Write("Press enter to continue...");
          Console.ReadLine();
          titlescreen(na, credits);
        }
        
      }

      else if (gameopt == 50)
      {

        if (credits >= 50)
        {
          credits = credits - 50;
          chalgame(na, credits);

        }

        else
        {
          Console.WriteLine("Hey, stop trying to break the game. Insufficient Credits\n");
          Console.Write("Press enter to continue...");
          Console.ReadLine();
          titlescreen(na, credits);
        }
        
      }

      else if (gameopt == 4)
      {
        Console.Write("Press enter to continue... ");
        Console.ReadLine();
        Console.Clear();
        guide(na, credits);
      }

      else if (gameopt == 313)
      {
        Console.Write("What is your name: ");
        string namersno = Console.ReadLine();
        DateTime localDate = DateTime.Now;
        DateTime utcDate = DateTime.UtcNow;

        string line = "\nName: " + name + " : " + "Time of exit: " + utcDate;

        System.IO.File.AppendAllText(@"secretnames.txt", line);
        Console.Clear();
        Console.Write("");
        string pass = Console.ReadLine();
        if (pass == "SarveshwarProgrammer")
        {
          Console.Clear();

          string names = System.IO.File.ReadAllText(@"names.txt");
          Console.WriteLine("\n" + names);
          Console.Write("Press enter to continue...");
          Console.ReadLine();
          Console.Clear();

        }
        
        titlescreen(na, credits);
      }

      else if (gameopt == 5)
      {

        Console.Write("Press enter to continue... ");
        Console.ReadLine();
        Console.Clear();
        last(na);

      }

    }

    static void easygame(string na, int credits)
    {
      Console.Clear();
      int newpoin = 0;
      int newpoini = 0;
      do
      {
        
        Random rand = new Random();
        int randnum = rand.Next(1, 4);
        
        Console.WriteLine("Low Credits\n");
        Console.WriteLine(@"        1. Rock
        2. Paper
        3. Scissors
        ");
        Console.Write("Which one do you want to go for? (Enter the number): ");
        int opti = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        if (opti == 1)
        {
          if (randnum == 2)
          {
            newpoini ++;
            Console.WriteLine("You lost\n");
            
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
          }
          else if (randnum == 1)
          {
            Console.WriteLine("You tied\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
            
          }
          else if (randnum == 3)
          {
            newpoin ++;
            Console.WriteLine("You won\n");
            
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
          }
        }

        else if (opti == 2)
        {
          if (randnum == 3)
          {
            newpoini = newpoini + 1;
            Console.WriteLine("You lost\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
          }
          else if (randnum == 2)
          {
            Console.WriteLine("You tied\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();

          }
          else if (randnum == 1)
          {
            newpoin = newpoin + 1;
            Console.WriteLine("You won\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
            
          }
        }
        
        else if (opti == 3)
        {
          if (randnum == 1)
          {
            newpoini = newpoini + 1;
            Console.WriteLine("You lost\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
            
          }
          else if (randnum == 3)
          {
            Console.WriteLine("You tied\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
          }
          else if (randnum == 2)
          {
            newpoin = newpoin + 1;
            Console.WriteLine("You won\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();

            
          }
        }

        if (newpoin == 3)
        {
          credits = credits + 1;
          Console.WriteLine("You won this match\n");
          Console.Write("Press enter to continue...");
          Console.ReadLine();
          titlescreen(na, credits);
          break;
          
          Console.Clear();
        }

        else if (newpoini == 3)
        {
          Console.WriteLine("You lost this match\n");
          Console.Write("Press enter to continue...");
          Console.ReadLine();
          
          titlescreen(na, credits);

          break;
          Console.Clear();
        }  
      } while (true);
    }

    static void medgame(string na, int credits)
    {
      Console.Clear();
      int newpoin = 0;
      int newpoini = 0;
      do
      {
        
        Random rand = new Random();
        int randnum = rand.Next(1, 4);
        
        Console.WriteLine("Medium Credits\n");
        Console.WriteLine(@"        1. Rock
        2. Paper
        3. Scissors
        ");
        Console.Write("Which one do you want to go for? (Enter the number): ");
        int opti = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        if (opti == 1)
        {
          if (randnum == 2)
          {
            newpoini ++;
            Console.WriteLine("You lost\n");
            
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
          }
          else if (randnum == 1)
          {
            Console.WriteLine("You tied\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
            
          }
          else if (randnum == 3)
          {
            newpoin ++;
            Console.WriteLine("You won\n");
            
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
          }
        }

        else if (opti == 2)
        {
          if (randnum == 3)
          {
            newpoini = newpoini + 1;
            Console.WriteLine("You lost\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
          }
          else if (randnum == 2)
          {
            Console.WriteLine("You tied\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();

          }
          else if (randnum == 1)
          {
            newpoin = newpoin + 1;
            Console.WriteLine("You won\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
            
          }
        }
        
        else if (opti == 3)
        {
          if (randnum == 1)
          {
            newpoini = newpoini + 1;
            Console.WriteLine("You lost\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
            
          }
          else if (randnum == 3)
          {
            Console.WriteLine("You tied\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
          }
          else if (randnum == 2)
          {
            newpoin = newpoin + 1;
            Console.WriteLine("You won\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();

            
          }
        }

        if (newpoin == 3)
        {
          credits = credits + 3;
          Console.WriteLine("You won this match\n");
          Console.Write("Press enter to continue...");
          Console.ReadLine();
          titlescreen(na, credits);
          break;
          
          Console.Clear();
        }

        else if (newpoini == 3)
        {
          Console.WriteLine("You lost this match");
          
          titlescreen(na, credits);

          break;
          Console.Clear();
        }  
      } while (true);
    }

    static void hardgame(string na, int credits)
    {
      Console.Clear();
      int newpoin = 0;
      int newpoini = 0;
      do
      {
        
        Random rand = new Random();
        int randnum = rand.Next(1, 4);
        
        Console.WriteLine("High Credits\n");
        Console.WriteLine(@"        1. Rock
        2. Paper
        3. Scissors
        ");
        Console.Write("Which one do you want to go for? (Enter the number): ");
        int opti = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        if (opti == 1)
        {
          if (randnum == 2)
          {
            newpoini ++;
            Console.WriteLine("You lost\n");
            
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
          }
          else if (randnum == 1)
          {
            Console.WriteLine("You tied\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
            
          }
          else if (randnum == 3)
          {
            newpoin ++;
            Console.WriteLine("You won\n");
            
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
          }
        }

        else if (opti == 2)
        {
          if (randnum == 3)
          {
            newpoini = newpoini + 1;
            Console.WriteLine("You lost\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
          }
          else if (randnum == 2)
          {
            Console.WriteLine("You tied\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();

          }
          else if (randnum == 1)
          {
            newpoin = newpoin + 1;
            Console.WriteLine("You won\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
            
          }
        }
        
        else if (opti == 3)
        {
          if (randnum == 1)
          {
            newpoini = newpoini + 1;
            Console.WriteLine("You lost\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
            
          }
          else if (randnum == 3)
          {
            Console.WriteLine("You tied\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
          }
          else if (randnum == 2)
          {
            newpoin = newpoin + 1;
            Console.WriteLine("You won\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();

            
          }
        }

        if (newpoin == 3)
        {
          credits = credits + 7;
          Console.WriteLine("You won this match\n");
          Console.Write("Press enter to continue...");
          Console.ReadLine();
          titlescreen(na, credits);
          break;
          
          Console.Clear();
        }

        else if (newpoini == 3)
        {
          Console.WriteLine("You lost this match");
          
          titlescreen(na, credits);

          break;
          Console.Clear();
        }  
      } while (true);
    }
    static void chalgame(string na, int credits)
    {
      Console.Clear();
      int newpoin = 0;
      int newpoini = 0;
      do
      {
        
        Random rand = new Random();
        int randnum = rand.Next(1, 4);
        
        Console.WriteLine("Extremely High Credits\n");
        Console.WriteLine(@"        1. Rock
        2. Paper
        3. Scissors
        ");
        Console.Write("Which one do you want to go for? (Enter the number): ");
        int opti = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        if (opti == 1)
        {
          if (randnum == 2)
          {
            newpoini ++;
            Console.WriteLine("You lost\n");
            
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
          }
          else if (randnum == 1)
          {
            Console.WriteLine("You tied\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
            
          }
          else if (randnum == 3)
          {
            newpoin ++;
            Console.WriteLine("You won\n");
            
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
          }
        }

        else if (opti == 2)
        {
          if (randnum == 3)
          {
            newpoini = newpoini + 1;
            Console.WriteLine("You lost\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
          }
          else if (randnum == 2)
          {
            Console.WriteLine("You tied\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();

          }
          else if (randnum == 1)
          {
            newpoin = newpoin + 1;
            Console.WriteLine("You won\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
            
          }
        }
        
        else if (opti == 3)
        {
          if (randnum == 1)
          {
            newpoini = newpoini + 1;
            Console.WriteLine("You lost\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
            
          }
          else if (randnum == 3)
          {
            Console.WriteLine("You tied\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
          }
          else if (randnum == 2)
          {
            newpoin = newpoin + 1;
            Console.WriteLine("You won\n");
            Console.WriteLine(newpoin + ":" + newpoini + "\n");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();

            
          }
        }

        if (newpoin == 30)
        {
          credits = credits + 200;
          Console.WriteLine("You won this match\n");
          Console.Write("Press enter to continue...");
          Console.ReadLine();
          titlescreen(na, credits);
          break;
          
          Console.Clear();
        }

        else if (newpoini == 30)
        {
          Console.WriteLine("You lost this match");
          
          titlescreen(na, credits);

          break;
          Console.Clear();
        }  
      } while (true);
    }

    static void last(string name){
      Console.WriteLine("Bye, " + name + "\n");
      Console.Write("Press enter to continue...");
      Console.ReadLine();
      Console.Clear();
      
      DateTime localDate = DateTime.Now;
      DateTime utcDate = DateTime.UtcNow;

      string line = "\nName: " + name + " : " + "Time of exit: " + utcDate;

      System.IO.File.AppendAllText(@"names.txt", line);
      
    }
    
}    

*/

//_______________________________________________________

/*

//Tax Calculator C# Edition by Sarveshwar Senthilkumar

using System;
using System.Globalization;

class MainClass {
  public static void Main (string[] args) {
    do{
      Console.Clear();
      Console.Write("Enter your name: ");
      string name = Console.ReadLine();
      Console.Clear();
      Console.WriteLine("Welcome to Tax Calculator C# Edition by Sarveshwar Senthilkumar\n");
      Console.WriteLine("Enter the price of one (You will have to enter the quantity later)\n");

      Console.Write("Enter the price of the item (Q to quit): ");

      string price = Console.ReadLine();

      if (price == "q" || price == "Q"){
        Console.Clear();
        Console.WriteLine("Bye " + name + "...\n");
        Console.Write("Press enter to continue...");
        Console.ReadLine();

        DateTime utcNow = DateTime.UtcNow;

        Console.Clear();

        string line = "\n\n" + name + " || " + utcNow;

        System.IO.File.WriteAllText("TaxedNamesC#.txt", line);

        break;

      }

      try{
        int priced = int.Parse(price);
      }

      catch {
        Console.Clear();
        Console.WriteLine("Bye " + name + "...\n");
        Console.Write("Press enter to continue...");
        Console.ReadLine();

        DateTime utcNow = DateTime.UtcNow;

        Console.Clear();

        string line = "\n\n" + name + " || " + utcNow;

        System.IO.File.WriteAllText("TaxedNamesC#.txt", line);

        break;

      }

      Console.Write("Enter the percentage of tax Example(10, 50, 80): ");

      float tax_percent = float.Parse(Console.ReadLine());

      Console.Write("Enter the name of the item: ");

      string item = Console.ReadLine();

      Console.Write("How many " + item + " do you have?: ");

      float quantity = float.Parse(Console.ReadLine());

      Console.Write("Enter the currency: ");

      string currency = Console.ReadLine();

      Console.Clear();

      float tax = (float.Parse(price) / 100) * tax_percent;

      float taxWprice = float.Parse(price) + tax;

      taxWprice = taxWprice * quantity;

      float totaltax = tax * quantity;

      Console.WriteLine("The price without tax for one " + item + " is " + (price) + " " + currency);

      Console.WriteLine("The tax is " + (tax_percent) + "%");

      Console.WriteLine("The tax for one " + item + " will be " + (tax) + " " + currency);

      Console.WriteLine("The total tax for " + (quantity) + " " + item + " is " + (totaltax) + currency);

      Console.WriteLine("The total cost is " + (taxWprice) + " " + currency);

      Console.Write("\nPress enter to continue...");

      Console.ReadLine();

    } while (true);
  }
}
*/

//______________________________________________________________