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
                /// Переменную a заносит пользователь
                /// Переменную b заносит пользователь
                /// Пользователь заносит знак математической операции над числами
                /// Результат математической операции
                double a; 
                double b; 
                double total;
                char oper; 

                ///Cчитывать данные, которые пользователь будет вводить на консоль
                /// Вывод на консоль запрос первого числа а
                Console.WriteLine("Введите первое число:");
                /// Введенное число имеет строковой формат string, а так как у нашей переменной тип double, то конвертируем string в double методом Convert
                a = Convert.ToDouble(Console.ReadLine());   
                ///Вывод на консоль знак математической операции b
                Console.WriteLine("Введите оператор/действие:"); 
                /// конвертируем string в char
                oper = Convert.ToChar(Console.ReadLine()); 
                ///Вывод на консоль числа
                Console.WriteLine("Введите второе число:");
                /// Введенное число имеет строковой формат string, а так как у нашей переменной тип double, то конвертируем string в double методом Convert
                b = Convert.ToDouble(Console.ReadLine());   
                ///Выполнение одной операции над числами
                if (oper == '+')
                /// Вывод на консоль результата сложения
                {
                    total = a + b;
                    Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");  
                }
                /// Вывод на консоль результата вычетания
                else if (oper == '-')
                {
                    total = a - b;
                    Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");   
                }
                /// Вывод на консоль результата умножения
                else if (oper == '*')
                {
                    total = a * b;
                    Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + "."); 
                }
                 /// Вывод на консоль результата деления
                else if (oper == '/')
                {
                    /// Добавил конструкцию Try/Catch/Finally для проверки корректности введённого значения
                    try
                    {
                        total = a / b;
                        Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");   
                    }
                    catch (FileNotFoundException ex)
                    {
                    }
                    finally
                    {
                        Console.WriteLine("На ноль делить нельзя.");
                    }
                }
                 /// Вывод на консоль предупреждения, что неизвестный оператор
                else
                {
                    Console.WriteLine("Неизвестный оператор."); 
                }
                ///  Вывод на консоль вопроса по продолжению или прекращению выполнения операций
                Console.WriteLine("Вы хотите продолжить работу с калькулятором? (д/н)"); 
                again = Convert.ToChar(Console.ReadLine());
            }
        }

 public class Logger
        {
            private const string FileName = "Logger.log";

            public float Divide(float a, float b)
            {
                File.WriteAllText(FileName, $"Running {a} / {b}");
                return a / b;
            }

            public float Multiply(float a, float b)
            {
                File.WriteAllText(FileName, $"Running {a} * {b}");
                return a * b;
            }

            public float Add(float a, float b)
            {
                File.WriteAllText(FileName, $"Running {a} + {b}");
                return a + b;
            }

            public float Subtract(float a, float b)
            {
                File.WriteAllText(FileName, $"Running {a} - {b}");
                return a - b;
            }
        }
    }
}
