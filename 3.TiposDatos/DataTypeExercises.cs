using System;

namespace CSharpExercises{
    public class DataTypeExercises{
        public void ValueSum(){
            Console.WriteLine("Ingrese un valor a sumar:");
            var firstValue = Console.ReadLine();
            Console.WriteLine("Ingrese otro valor a sumar:");
            var secondValue = Console.ReadLine();
            int first=0;
            int second=0;
            bool firstNumber = Int32.TryParse (firstValue, out first );
            bool secondNumber = Int32.TryParse (secondValue, out second );
            
                if(firstNumber && secondNumber){
                    Console.WriteLine("El resultado de la suma es: {0}", first + second);
            }
            else if (firstNumber){
                Console.WriteLine("El primer parametro no es entero");
            }
            else if (secondNumber) {
                Console.WriteLine("El segundo parametro no es entero");
            }
           
            
        }
    }
}