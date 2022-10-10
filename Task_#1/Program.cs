﻿/*====== Работа с текстом
Дан текст. В тексте нужно все пробелы заменить черточками,
маленькие буквы "к" заменить большими "К",
а большие "С" заменить маленькими "с"

Ясна ли Задача? Необходимо сразу уточнять все ТРЕБОВАНИЯ !!!
Что значит "Дан текст" ?
Что значит "черточками" ?
Какого алфавита?
Маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "с"
*/

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нащего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля "
            + "Вы так красноречивы. Вы дадите мне чаю? ";

/*
string s = "qwerty"
            012345
s[3] r
*/

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ','|');

Console.WriteLine(newText);

Console.WriteLine();
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
Console.WriteLine();

