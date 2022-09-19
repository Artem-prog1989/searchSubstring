string text = "heromeroomerovvkj";
string substring = "mero";
int t = 0;

//// поиск индекса вхождения подстроки в строке
while(t<=(text.Length-substring.Length))
{
    int p = 0;
    while (p<substring.Length && (text[t + p] == substring[p]))
    {
        p++;
    }
    
    if (p == (substring.Length))
    {
        Console.WriteLine(t);
    }
    t++;
}
