using Calculator;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter 2 integers to add");
                    string[] addNumbers = Numbers.PickNumbers();

                    if (int.TryParse(addNumbers[0], out int addNumOne) && int.TryParse(addNumbers[1], out int addNumTwo))
                    {
                        Console.Write($"{addNumbers[0]} + {addNumbers[1]} = ");
                        Console.Write(calculator.Add(addNumOne, addNumTwo));
                    }
                    else
                    {
                        Numbers.ErrorMessage();
                    }
                    break;

                case "2":
                    Console.WriteLine("Enter 2 integers to subtract");
                    string[] subtractNumbers = Numbers.PickNumbers();

                    if (int.TryParse(subtractNumbers[0], out int subNumOne) && int.TryParse(subtractNumbers[1], out int subNumTwo))
                    {
                        Console.Write($"{subtractNumbers[0]} - {subtractNumbers[1]} = ");
                        Console.Write(calculator.Subtract(subNumOne, subNumTwo));
                    }
                    else
                    {
                        Numbers.ErrorMessage();
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter 2 integers to multiply");
                    string[] multiplyNumbers = Numbers.PickNumbers();

                    if (int.TryParse(multiplyNumbers[0], out int multiplyNumOne) && int.TryParse(multiplyNumbers[1], out int multiplyNumTwo))
                    {
                        Console.Write($"{multiplyNumbers[0]} * {multiplyNumbers[1]} = ");
                        Console.Write(calculator.Multiply(multiplyNumOne, multiplyNumTwo));
                    }
                    else
                    {
                        Numbers.ErrorMessage();
                    }
                    break;

                case "4":
                    Console.WriteLine("Enter 2 integers to divide");
                    string[] divideNumbers = Numbers.PickNumbers();

                    if (double.TryParse(divideNumbers[0], out double divNumOne) && double.TryParse(divideNumbers[1], out double divNumTwo))
                    {
                        Console.Write($"{divideNumbers[0]} / {divideNumbers[1]} = ");
                        Console.Write(calculator.Divide(divNumOne, divNumTwo));
                    }
                    else
                    {
                        Numbers.ErrorMessage();
                    }
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}
