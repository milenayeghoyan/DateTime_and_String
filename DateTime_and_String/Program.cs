// See https://aka.ms/new-console-template for more information
// Task 3 
/*static int CountLeapYear(DateTime day)
{
    int year = day.Year; // 2000 , 2004 
    if (day.Month <= 2)
    {
        year--;

    }
    
    return (year/4)-(year/100)+(year/400);
   
} 

static int Count (DateTime day1, DateTime day2)
{  
    int count = DateTime.DaysInMonth(day1.Year, day1.Month); // 31
    int n1 = (day1.Year)* 365 + day1.Day+count+CountLeapYear(day1); //2000*365+1+31+ 2000/4-2000/100+2000/400=730517
    
    
    
    int count2 = DateTime.DaysInMonth(day2.Year, day2.Month);
    int n2 = (day2.Year) * 365 + day2.Day+count2 + CountLeapYear(day2); //2004*365+25+31+501-20+5=732002
    //int count2 = DateTime.DaysInMonth(day1.Year, day1.Month);

    
    return n2-n1;
}
DateTime day1 = new DateTime(2000, 12, 1);
DateTime day2 = new DateTime(2004, 12, 25);
int count = Count(day1, day2);
Console.WriteLine( count);
*/


//Task 4 -Write an extension method on DateTime which returns the name of it's weekday in provided language Armenian, English or Russian. 
/*
using System.Globalization;
using System.Text;

DateTime time = new DateTime();
string language = "Armenian";
Console.OutputEncoding = Encoding.UTF8;
string a = time.GetWeekday(language);
Console.WriteLine(a);

public static class DateTimeExtension
{
   public static string GetWeekday(this DateTime date, string language)
    {
        CultureInfo culture = CultureInfo.InvariantCulture; 
        switch(language)
        {
            case "Armenian":
                culture = new CultureInfo("hy-AM");
                    break;
            case "Russian":
                culture = new CultureInfo("ru-RU");
                break;
            case "English":
                culture = new CultureInfo("en-US");
                break;
            default:
                throw new Exception();

        }
        return culture.DateTimeFormat.GetDayName(date.DayOfWeek);
    }

}
*/

/*// Task 5

using Microsoft.VisualBasic;
using System;
using System.Globalization;

string code = "* 208 * 2000 * 1 #";
string[] words = code.Split(' '); // *208 *  2000 * 13
int value1 = int.Parse(words[3]);
int value2 = int.Parse(words[5]);
Ussd ussd = new Ussd(words[1], new int[] { value1, value2 });

Console.WriteLine($"{ussd.Code} {value1},{value2}");
class Ussd
{
    public string Code { get; set; }
    public int[] Action { get; set; }
    public Ussd(string code, int[] action)
    {
        Code = code;
        Action = action;
    }
}
*/

/*//Task1 
using System.Text;

DateTime day = new DateTime();
string text = "@expDate@";
string format = "MM/dd/yyyy h:mm tt.";
Console.WriteLine(text.DayAdded30(format));
public static class StringExtension
{
    public static string DayAdded30(this string text, string format) 
{ 
        DateTime dateTime = new DateTime(2023, 08, 16);
        DateTime date=dateTime.AddDays(30);
        string tostring =date.ToString(format);
        string replacedtext = text.Replace("@expDate@", tostring);
        return replacedtext;

    }

    }
    
    */



//Task 2-?
/*using System.Text;

DateTime day = new DateTime();
string text = "@expDate@";
string format = "yyyy-MM-dd HH:mm:ss.fff";
Console.WriteLine(text.DayAdded30(format));
public static class StringExtension
{
    public static string DayAdded30(this string text, string format)
    {
        DateTime dateTime = new DateTime(2023, 06,15, 18,58,59,999);
        DateTime date=dateTime.AddDays(30);
        string tostring = date.ToString(format);
        string replacedtext = text.Replace("@expDate@", tostring);
        return replacedtext;

    }

}
*/