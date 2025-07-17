internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("--------------------------");

        Console.WriteLine("Hello, World!");


        Console.WriteLine("                                    _       ");
          Console.WriteLine(" ___ ___   ___ __ _        ___ ___ | | __ _ ")   ;
          Console.WriteLine(" / __/ _ \\ / __/ _` |_____ / __/ _ \\| |/ _` |");
          Console.WriteLine("| (_| (_) | (_| (_| |_____| (_| (_) | | (_| |");
        Console.WriteLine(" \\___\\___/ \\___\\__,_|     \\___\\___/|_|\\__,_|");
        Console.WriteLine("soft drink - coke - The Coca-Cola company");
        int dia = 8;
        do
        {
            Console.WriteLine("Introduce un dia de la semana");
            try
            {
                dia = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("No es un dia de la semana." + e.Message + "");
            }

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("No es un dia de la semana");
                    break;
            }
            if (dia == 0)
            {
                Console.WriteLine("Estas saliendo del programa");
                break;
            }
        }
        while (dia >= 0 && dia <= 7);    
    }
}