namespace Z1051
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// 
            char again = 'д';

            while (again == 'д')
            {
                /// Объявляем переменные
                double a; // В переменную a мы внесём первое число, которое запишет пользователь
                double b; // В переменную b — второе число
                double total; // Выводит результат математических операций с переменными а и b
                char oper; //  В переменную мы будем заносить знак математической операции над числами

                ///Cчитыват данные, которые пользователь будет вводить на консоль

                Console.WriteLine("Введите первое число:"); // Вывод на консоль числа
                a = Convert.ToDouble(Console.ReadLine());   // Введенные пользователем данные имеют строковой формат string, а так как у нашей переменной тип double, то конвертируем string в double методом Convert

                Console.WriteLine("Введите оператор/действие:"); //Вывод на консоль знак математической операции
                oper = Convert.ToChar(Console.ReadLine()); // конвертируем string в char,

                Console.WriteLine("Введите второе число:"); //Вывод на консоль числа
                b = Convert.ToDouble(Console.ReadLine());   // Введенные пользователем данные имеют строковой формат string, а так как у нашей переменной тип double, то конвертируем string в double методом Convert

                ///Выполнение одной операции над числами

                if (oper == '+')
                {
                    total = a + b;
                    Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");  // Вывод на консоль результата сложения
                }

                else if (oper == '-')
                {
                    total = a - b;
                    Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");   // Вывод на консоль результата вычетания
                }

                else if (oper == '*')
                {
                    total = a * b;
                    Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + "."); // Вывод на консоль результата умножения
                }

                else if (oper == '/')
                {
                    try// добавил конструкцию Try/Catch/Finally для проверки корректности введённого значения
                    {
                        total = a / b;
                        Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");   // Вывод на консоль результата деления
                    }
                    catch (FileNotFoundException ex)
                    {
                    }
                    finally
                    {
                        Console.WriteLine("На ноль делить нельзя.");
                    }
                }

                else
                {
                    Console.WriteLine("Неизвестный оператор."); // Вывод на консоль предупреждения, что неизвестный оператор
                }
                Console.WriteLine("Вы хотите продолжить работу с калькулятором? (д/н)"); //  Продолжение/прекращение выполнения операций
                again = Convert.ToChar(Console.ReadLine());
            }


        }
    }
}
