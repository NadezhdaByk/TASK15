// по введенной цифре определяется день недели и указывается, является ли он выходным
Console.WriteLine("Введите порядковый номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());

string DayWeek()
{
if (day >= 1 && day <= 7)
{
    if (day >= 1 && day <= 5)
    {
       return "Это не выходной";
    }
    else {
         return "Это выходной";
    }
}   
else {
     return "Вы ввыли не правильный порядковый номер ";
} 

}
Console.WriteLine(DayWeek());