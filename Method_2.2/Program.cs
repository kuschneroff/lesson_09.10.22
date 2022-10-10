//ВИД 2.3 Что-то принимают, ничего не возвращают
void Method21(string msg, int count)
{
   int i = 0;
   while (i < count)
   {
    Console.WriteLine(msg);
    i++;
   }
}
Method21(count: 4, msg: "Новый текст");