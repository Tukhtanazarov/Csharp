using System ;
namespace Csharp {
    class Nurs  {
        static void Main(){
            Console.Write("Enter values: ");
            Console.Write("First number: ");
        string firstUserValue = Console.ReadLine();
        Console.Write("Second number: ");
        string secondUserValue =Console.ReadLine();
         
        decimal firstNumber =Convert.ToDecimal(firstUserValue);
        decimal secondNumber = Convert.ToDecimal(secondUserValue);

        Console.WriteLine("Here are you results: ");
        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
          Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
              Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
        
        }
    }


}