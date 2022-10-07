// Преобразование десятичного числа в двоичное
// 45 -> 101101, 3 -> 11, 2 -> 10

Console.Clear();
Console.Write("Введите число: ");
int number=int.Parse(Console.ReadLine());

string res1=Convert.ToString(number,2);
string res2=DecToNum(number,16);

Console.WriteLine($"{number} -> {res1}");
Console.WriteLine($"{number} -> {res2}");


//Универсальный математический для перевода из 10 в любую
string DecToNum(int decNumber, int otherSystem)
{
    string res="";
    string nums="0123456789ABCDEF";
    while(decNumber>0)
    {
        int ost=decNumber/otherSystem;
        res=nums[decNumber-otherSystem*ost]+res;
        decNumber/=otherSystem;
    }
    return res;
}
