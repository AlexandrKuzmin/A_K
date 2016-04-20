/*********
* This Gist was created at CSharpPad.com
* To run this file, open http://csharppad.com/gist/72842285041b10241bf214b22ddaa7c8
**********/

using System;
namespace rubberd
{
class Program
{
/* Определяет, введен ли символ a или b */
static void CountSimb(string c, out int v_a,
out int v_b)
{
int a=0,b=0;
switch(c)
{
case "a":
a = 1; /* Вариант присвоения значения v_a
или v_b не проходит: компилятор
не узнает выходных переменных */
break;
case "b":
b = 1;
break;
default: /* Введен какой-то другой символ
(не a и не b) */
break;
} // switch
v_a=a;
v_b=b;
}
public static void Main()
{
string s;
int v_a,v_b;
while(true)
{
Console.WriteLine("Введите символ, <Enter> >");
s=Console.ReadLine();
if(s==null) // нажали <Ctrl>+<Z>
break;
CountSimb(s,out v_a,out v_b); // Подсчет
// количества
// символов 'a', 'b'
Console.WriteLine("Введен а = {0}, " +
"введен b = {1} ", v_a,v_b);
Console.WriteLine("Для продолжения нажмите " +
"любой символ > ");
Console.ReadLine();
}
}
}
}	
