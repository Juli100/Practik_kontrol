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




