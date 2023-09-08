Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[size];
void array(string[] stringArray)
{
	for (int i = 0; i < stringArray.Length; i++)
	{
		Console.WriteLine($"Введите {i} элемент массива");
		stringArray[i] = Console.ReadLine()!;
	}
}
string[] symbol(string[] stringArray)
{
	int n = 0;
	for (int i = 0; i < stringArray.Length; i++)
	{
		if (stringArray[i].Length <= 3)
			n++;
	}
	string[] result = new string[n];
	int j = 0;
	for (int i = 0; i < stringArray.Length; i++)
	{
		if (stringArray[i].Length <= 3)
		{
			result[j] = stringArray[i];
			j++;
		}
	}
	return result;
}
void printA(string[] stringArray)
{
	Console.Write("[");
	for (int i = 0; i < stringArray.Length; i++)
	{
		Console.Write(string.Join(",", stringArray));
	}
	Console.Write("]");
}
array(stringArray);
printA(symbol(stringArray));