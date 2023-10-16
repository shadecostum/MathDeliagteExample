using System.Net.Sockets;

namespace MathDeliagteExample
{
    delegate void DMathOperation(int n1, int n2);


    internal class Program
    {
        static void Main(string[] args)
        {
            DMathOperation problem;
            problem = AddOperation;

            problem += SubOpperation;

            problem += MultOpperation;
            problem += DiviOpperation;
            problem(15, 5);

            Console.WriteLine("=================================");

            PolimorphicDeligate(AddOperation);
            PolimorphicDeligate(AddOperation);



        }

        private static void PolimorphicDeligate(DMathOperation math)
        {
            Console.WriteLine("answer");
            math(4, 4);
        }

        static void AddOperation(int n1, int n2)
        {
            int c = n1 + n2;
            Console.WriteLine(c);
        }
        static void SubOpperation(int n1, int n2)
        {
            int c = n1 - n2;
            Console.WriteLine(c);
        }
        static void MultOpperation(int n1, int n2)
        {
            int c = n1 * n2;
            Console.WriteLine(c);
        }
        static void DiviOpperation(int n1, int n2)
        {
            int c = n1 / n2;
            Console.WriteLine(c);
        }
       
    }
}