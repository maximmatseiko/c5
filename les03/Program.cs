// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число :");
int Cube = Convert.ToInt32(Console.ReadLine());
void Cubea(int[] cube)
{
    int counter = 0;
    int Length = cube.Length;
    while (counter < Length)
    {
        cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
        counter = counter + 1;
    }
}
    void Printarry(int[] coll)
    {
        int count = coll.Length;
        int index = 0;
        while (index < count)
        {
            Console.Write(coll[index] + " ");
            index = index + 1;
        }
    }
    int[] arry = new int[Cube + 1];
    Cubea(arry);
    Printarry(arry);