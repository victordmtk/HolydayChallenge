using System;

namespace HolidayIdentifier;


public class Holiday
{
    public DateTime dateInformed;

    public void HolidayChecker(DateTime dateInformed)
    {
        Console.WriteLine(WichHolidayIs(dateInformed));
    }

    public  static bool IsEasterHoliday(DateTime dateInformed)
    {
        DateTime easterDate = EasterCalculator(dateInformed);
        if (easterDate == dateInformed)
        {
            return true;
        }
        return false;
    }

    public static DateTime EasterCalculator(DateTime dateInformed)
    {
        int year = dateInformed.Year;
        int r1 = year % 19;
        int r2 = year % 4;
        int r3 = year % 7;
        int r4 = (19 * r1 + 24) % 30;
        int r5 = (6 * r4 + 4 * r3 + 2 * r2 + 5) % 7;
        DateTime easterDate = new DateTime(year, 3, 22).AddDays(r4 + r5);

        int day = easterDate.Day;
        if (day == 26)
        {
            easterDate = new DateTime(year, 4, 19);
        }
        else if (day == 25)
        {
            if (r1 > 10)
                easterDate = new DateTime(year, 4, 18);
        }
        return easterDate.Date;
    }

    public static string WichHolidayIs(DateTime dateInformed)
    {
        bool isEasterHoliday = IsEasterHoliday(dateInformed);
        string templateHoliday = $"É feriado de:";
        

        if (dateInformed.Day == 01 && dateInformed.Month == 01)
        {
            return $"{templateHoliday} Confraternização universal/Ano novo";
        }
        else if (dateInformed.Day == 21 && dateInformed.Month == 04)
        {
            return $"{templateHoliday} Tiradentes";
        }
        else if (dateInformed.Day == 01 && dateInformed.Month == 05)
        {
            return $"{templateHoliday} Dia do Trabalhador";
        }
        else if (dateInformed.Day == 07 && dateInformed.Month == 08)
        {
            return $"{templateHoliday} Independência do Brasil";
        }
        else if (dateInformed.Day == 12 && dateInformed.Month == 10)
        {
            return $"{templateHoliday} Nossa Senhora Aparecida(dia das crianças)";
        }
        else if (dateInformed.Day == 02 && dateInformed.Month == 11)
        {
            return $"{templateHoliday} Finados";
        }
        else if (dateInformed.Day == 25 && dateInformed.Month == 12)
        {
            return $"{templateHoliday} Natal";
        }
        else if (isEasterHoliday)
        {
            return $"{templateHoliday} Páscoa";
        }
        return HolidaisOutDate(dateInformed);
    }
    
    public static string HolidaisOutDate(DateTime date)
    {
        DateTime _easterDate = EasterCalculator(date);
        DateTime carnival = _easterDate.AddDays(-47);
        DateTime goodFriday = _easterDate.AddDays(-2);
        DateTime corpusChrist = _easterDate.AddDays(60);
        string templateHoliday = $"É feriado de:";

        if (carnival == date)
        {
            return $"{templateHoliday} Carnaval!";
        } else if (goodFriday == date)
        {
            return $"{templateHoliday} Sexta feira Santa";
        } else if (corpusChrist == date)
        {
            return $"{templateHoliday} Corpus Christ";
        }
        return "Não é um feriado";
    }
}
    