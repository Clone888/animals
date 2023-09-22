string[] list = File.ReadAllLines("../../../Husdjur.csv");


Dictionary<string, int> animal = new Dictionary<string, int>();


foreach (string row in list)
{
    string[] split = row.Split(",");
    if (int.TryParse(split[1], out int age))
    {
        animal.Add(split[0].ToLower(), age);
    }
    else
    {
        Console.WriteLine("failed to parse something");
    }

    Console.WriteLine(split[0]);
}

Console.WriteLine();
Console.WriteLine("Please choose a name: ");
string choice = Console.ReadLine().ToLower();

bool choosen = false;

while (!choosen)
{

    if (animal.ContainsKey(choice))
    {
        Console.WriteLine("The animals birthyear are: " + (2023 - animal[choice]));
        choosen = true;
    }
    else
    {
        Console.WriteLine("Name doesnt exist. Please try again");
        Console.WriteLine();
        choosen = false;
        choice = Console.ReadLine().ToLower();
    }

}

