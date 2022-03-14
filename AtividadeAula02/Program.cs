using System;
using AtividadeAula02.Entities;

namespace AtividadeAula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(("SELECIONE UMA OPÇÃO\n" +
                           "1 - CALCULAR ÁREA DE UM TRIÂNGULO\n" +
                           "2 - VALIDAR UMA DATA\n" +
                           "3 - VALIDAR UM HORÁRIO\n" +
                           "R: "));
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    calculateTriangleArea();
                    break;
                case 2:
                    validateDate();
                    break;
                case 3:
                    validateDateTime();
                    break;
            }

            void calculateTriangleArea()
            {
                Console.Write("Digite o tipo do triângulo: ");
                String triangleType = Console.ReadLine();
            
                Console.Write("Digite o comprimento do triângulo: ");
                int width = int.Parse(Console.ReadLine());
            
                Console.Write("Digite a altura do triângulo: ");
                int heigth = int.Parse(Console.ReadLine());
            
                Triangle triangle = new Triangle(width, heigth);
            
                Console.Write("\n" + "Área do triângulo: " + triangle.GetTotalArea(triangleType) + "m²");
            }

            void validateDate()
            {
                Console.Write(("DIGITE UMA DATA - (dd/MM/yyyy): "));
                String date = Console.ReadLine();
            
                if (Date.isDateValid(date))
                {
                    Date objDate = new Date(date);
                    Console.WriteLine(objDate.ToString());
                    Console.Write(("DATA VÁLIDA"));
                }
                else
                {
                    Console.Write("DIGITE UMA DATA VÁLIDA");
                }
            }

            void validateDateTime()
            {
                Console.Write(("DIGITE UM HORÁRIO - (HH:mm:ss): "));
                String dateTime = Console.ReadLine();

                if (Hour.isDateTimeValid(dateTime))
                {
                    Hour objDateTime = new Hour(dateTime);
                    Console.WriteLine(objDateTime);
                    Console.Write(("HORÁRIO VÁLIDO"));
                }
                else
                {
                    Console.Write(("DIGITE UM HORÁRIO VÁLIDO"));
                }
            }
        }
    }
}
