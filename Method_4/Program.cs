﻿// ВИД 4 Что-то принимают, что-то возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + text;
        i++; 
    }
    return result;
}
string res = Method4(10, "БРАВО>");
Console.WriteLine(res);