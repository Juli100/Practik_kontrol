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
string[] SecondStringArray (string[] stringArray, int sizeNewArray)
{
    string[] newStringArray = new string[sizeNewArray];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length < 4)
        {
            newStringArray[j] = stringArray[i];
            j++;
        } 
    }
    return newStringArray;
}

string[] stringArray = {"Hello", "z", "World",";-)", "green", "to"};
PrintStringArray(stringArray);
//WriteLine(SearchStringsWithSizeLessOrEqual3(stringArray));
int sizeNewArray = FirstStringArray(stringArray);
string[] newStringArray = SecondStringArray(stringArray,sizeNewArray);
WriteLine(" -> ");
PrintStringArray(newStringArray);
WriteLine();




