internal class Program
{
    static void Main(string[] args)
    {
        //Arrays
        //string[] students = new string[3] { "Engin", "Derin", "Salih" };

        //string[] students2 = { "Engin", "Derin", "Salih" }; 

        //foreach (var student in students)
        //{
        //    Console.WriteLine(student);
        //}

        //Multidimensional Arrays
        string[,] regions = new string[7, 3]
        {
            {"İstanbul","Bursa","Yalova" },
            {"Ankara","Sivas","Konya" },
            {"Antalya","Adana","Mersin" },
            {"Trabzon","Samsun","Rize" },
            {"İzmir","Muğla","Aydın" },
            {"Erzincan","Malatya","Van" },
            {"Diyarbakır","Gaziantep","Şanlıurfa" },
        };

        for (int i = 0; i <= regions.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= regions.GetUpperBound(1); j++)
            {
                Console.WriteLine(regions[i, j]);
            }
            Console.WriteLine("*********");
        }

        Console.ReadLine();

    }
}