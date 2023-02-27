int Prompt (string message)
{
    Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int inValue = Prompt("Веедите целое число");
int number = 2;

while (number <= inValue)
{
    Console.WriteLine(number);
    number += 2;
}
