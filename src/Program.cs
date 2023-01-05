String[] ProcessArray(String[] strings)
{
    String[] result = new String[strings.Length];
    for (int i = 0; i < strings.GetLength(0); i++)
    {
        int randomLength = Math.Min(new Random().Next(0,4), strings[i].Length);
        for (int j = 0; j < randomLength; j++)
            result[i] += strings[i][j];
            
    }
    return result;
}


Console.Clear();
Console.Write("Enter the strings, separated by a space: ");
String[] strings = {"asdfasdf","12341234","/*-/*--/*-","kl;kl;","ffffffffff", "555555555555"};//Console.ReadLine().Split(" ");

Console.WriteLine($"Result :[{string.Join("][", ProcessArray(strings))}]");