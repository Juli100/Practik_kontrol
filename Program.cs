using static System.Console;

void PrintStringArray(string[] stringArray)
{
    Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Write($"\"{stringArray[i]}\"");
        if (i!=stringArray.Length - 1)
        {
            Write(", ");
        }
    }
    Write("]");
}
int FirstStringArray(string[] stringArray)
{
    int numberOfStrings = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length < 4)
        {
            numberOfStrings++;
        }
    }
    return numberOfStrings;
}





