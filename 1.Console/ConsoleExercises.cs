using System;

namespace CSharpExercises{
    public class ConsoleExercises {
        public void AskAge(){
            Console.WriteLine("¿Cuántos años tenes?: ");
            string age = Console.ReadLine();
            Console.WriteLine("Wow, no pareces de " + age + " años");
            Console.WriteLine("¿Cual es tu nombre?: ");
            string name = Console.ReadLine();
            Console.WriteLine("¿Y tu apellido?: ");
            string lastName = Console.ReadLine();
             Console.WriteLine("¿cual es tu número de DNI?: ");
             string DNI= Console.ReadLine();
             Console.WriteLine("Según vos tu nombre es " + name + ",tu apellido es "+ lastName +" y tu dni es "+DNI+".");



            Console.ReadLine();
        }
    }
}