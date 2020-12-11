using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits="0123456789";
      string specialChars="!£#";
      int score=0;

      Console.WriteLine("Please enter a new password that is at least eight characters long...");
      Console.WriteLine("It must contain at least one lower case letter, one upper case letter, one number and one special character (such as !, £ or #");
      string password = Console.ReadLine();

      //Check password is valid:
      if(password.Length>=minLength)
      {
        score++;
      }
      if(Tools.Contains(password,uppercase))
      {
        score++;
      }
      if(Tools.Contains(password,lowercase))
      {
        score++;
      }
      if(Tools.Contains(password,digits))
      {
        score++;
      }
      if(Tools.Contains(password,specialChars))
      {
        score++;
      }
      if(password == "password")
      {
        score =0;
      }

      switch(score)
      {
        case 1:
          Console.WriteLine("Your password is weak");
          break;
        case 2:
          Console.WriteLine("Your password is medium strength");
          break;
        case 3:
          Console.WriteLine("Your password is strong");
          break;
        case 4:
        case 5:
          Console.WriteLine("Your password is very strong");
          break;
        default:
          Console.WriteLine("Your password does not meet any of the standards required");
          break;
      }

      Console.WriteLine($"Your score is {score}");
    }
  }
}
