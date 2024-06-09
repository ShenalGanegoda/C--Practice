using System.Diagnostics;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace consoletest {
    class Program {
        static void Main(string[] args){
            string str = "LSEG";
            FirstAndLastCharSwap(str);
        }

        static void SayHi(){
        Console.WriteLine("Hello User!");
    }

    static int Addition(int number1, int number2){
        return number1 + number2;
    }

    static void SwapNumbers(int numberA , int numberB){

        Console.WriteLine("Before swap: Number A - " + numberA + " Number B - " + numberB);
        
        // Swap 
        int temp = 0;
        temp = numberA;
        numberA = numberB;
        numberB = temp;

        // After Swap
        Console.WriteLine("After swap: Number A - " + numberA + " Number B - " + numberB);
    }

    static void MultiplicationTablePrint(int number){
        for (int i = 0; i < 10; i++){
            Console.WriteLine(number + " X " + i + "  = " + (number * i));
        }
    }

    static int CalculateAverage (int a, int b, int c, int d){
        return ((a + b + c + d) / 4);
    }

    static void PrintSpaceAndBlanks() {
        // Using String formatting = {0}
        Console.Write("Enter number here: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0} {0} {0} {0}" , number);
        Console.WriteLine("{0}{0}{0}{0}" , number);
    }

    static void CelciusToKelvinAndFahrenheit(){
        Console.WriteLine("Enter Celcius value here: ");
        double c = Convert.ToDouble(Console.ReadLine()); // Input of the Celcius value.

        double k = c + 273.15; // Kelvin calculation
        double f = (c * 9/5) + 32; // Fahrenheit calculation

        Console.WriteLine("Kelvin value: {0} \nFahrenheit value: {1}", k , f);
    }

    static void RemoveCharacterFromString(){
        string str = "Csharp";
        string newString = "";
        Console.WriteLine("Enter index here: ");
        int index = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < str.Length; i++) {
            if (i != index) {
                newString += str[i];
            }
        }

        Console.WriteLine("New String with removed index: {0}" , newString);
    }

    static void FirstAndLastCharSwap(string str) {
        // Using of the Substring() method.

        string newString = str.Substring(str.Length - 1) + str.Substring(1 , str.Length - 2) + str.Substring(0 , 1);
        Console.WriteLine("New string: {0}" , newString);
    }
    
    } 
}