using System;

namespace aumento
{
    class Program
    {
        public static void Aumento(){
            Console.WriteLine("Digite seu salario:\n");
            double salario = double.Parse(Console.ReadLine());

            if(salario >1250.00)
            {
                salario *= 1.10;
            }else
            {
                salario *= 1.15;
            }

            string message = String.Format("O novo salario será de R$ {0,2:C}",salario);
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Aumento();
        }
    }
}
