using System ;
using System.Linq.Expressions;
namespace Csharp{
    class Nurs  {
        static void Main(){
          try {
 Console.Write("Inter a value :");
 string userAgeValue = Console.ReadLine();
 int userAge = Convert.ToInt32(userAgeValue);
 //Jasalma Qatalyk
 throw new IOException(); 

 Console.WriteLine(userAge);
 }
 catch (FormatException formatException) 
 {
Console.WriteLine("Oops . we could not concert you input value . ");
Console.WriteLine("Looks like the value you proveded is not interger. ");

 }
 //ashyp ketu katalygy 
 catch (OverflowException overflowException) 
 {
Console.WriteLine("Value you provided was either too large ar too small. ");
 }
 // belgilenbegen (catch qilinbagan) qayalyk 
 catch (Exception exception)
 {
  Console.WriteLine("Oops,something went wrong , contact support");
 }
        }
    }
  }

