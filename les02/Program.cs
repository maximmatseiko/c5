internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
        int x1 = Coordinate("x", "a");
        int y1 = Coordinate("y", "a");
        int c1 = Coordinate("c", "a");
        int x2 = Coordinate("x", "b");
        int y2 = Coordinate("y", "b");
        int c2 = Coordinate("c", "b");
        int Coordinate(string coorname, string pointname)
        {
            Console.Write($"Введите координату {coorname} и точки {pointname} :");
            return Convert.ToInt32(Console.ReadLine());
        }
        double Decision(double x1, double x2,
                        double y1, double y2,
                        double c1, double c2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                             Math.Pow((y2 - y1), 2) +
                             Math.Pow((c2 - c1), 2));
        }
        double segmentLength = Math.Round(Decision(x1, x2, y1, y2, c1, c2), 2);
        Console.WriteLine($"Длина отрезка :{segmentLength}");
    }
}