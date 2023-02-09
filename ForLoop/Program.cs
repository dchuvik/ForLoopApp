string firstName = string.Empty;
List<string> firstNames = new List<string>();

Console.WriteLine("Please enter a comma seperated list of first names: ");
string firstNameList = Console.ReadLine();

string[] ArrayOfFirstNames = firstNameList.Split(',').ToArray();

for (int i = 0;i < ArrayOfFirstNames.Length; i++) 
    {
        Console.WriteLine($"Hello {ArrayOfFirstNames[i]}");
    }



