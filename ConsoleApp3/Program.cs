namespace ConsoleApp3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите имя: ");
            var firstName = Console.ReadLine();

            Console.WriteLine("Введите фамилию: ");
            var lastName = Console.ReadLine();

            Console.WriteLine("Введите отчество: ");
            var fatherName = Console.ReadLine();

            Console.WriteLine("Введи дату рожднения (формат день.месяц.год):");
            var Date = Console.ReadLine();
            //123
            
            Console.WriteLine($"Ваши данные: {firstName} {lastName} {fatherName} ,дата рождения: {Date}");

            Console.ReadLine();
            Console.ReadKey();
            //88
        }
    }
}
