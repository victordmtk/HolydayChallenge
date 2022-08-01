using System;
using HolidayIdentifier;




class program
{
    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Olá! qual data você deseja verificar se é um feriado?");
    //    Console.WriteLine("'Formato sugerido DD/MM/AAAA'");
    //    var dateInformed = Convert.ToDateTime(Console.ReadLine());
    //    var Holyday = new Holyday();


    //}
    static void Main(string[] args)
    {
        var holiday = new Holiday();
        var dateInformed = DateTime.Now;
        
        Console.WriteLine("Olá! qual data você deseja verificar se é um feriado?");
        Console.WriteLine("'Formato sugerido DD/MM/AAAA'");
        dateInformed = Convert.ToDateTime(Console.ReadLine());
        holiday.HolidayChecker(dateInformed);
        
        

    }

}