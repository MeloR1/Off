namespace Enums
{
    class program
    {
        static void Main(string[] args)
        {
            //var day = (DAY.SATURDAY | DAY.SUNDAY);
            //if (day.HasFlag(DAY.WEEKEND))
            //{
            //    Console.WriteLine("Enjoy your weeknd");
            //}

            //var day = "Feb";

            //if (Enum.TryParse(day, out Month month))
            //{
            //    //Console.WriteLine(Enum.Parse(typeof(Month), day));
            //    Console.WriteLine(month);

            //}
            //else
            //{
            //    Console.WriteLine("Invalid entry");
            //}

            ////Console.WriteLine((int)Month.MARCH);


            foreach (var month in Enum.GetNames(typeof(Month)))
            {
                Console.WriteLine($"{month} = {(int)Enum.Parse(typeof(Month), month)}");
            }
            foreach (var month in Enum.GetValues(typeof(Month)))
            {
                Console.WriteLine($"{month.ToString()} = {(int)month}");
            }





            Console.ReadKey();
        }
    }
    //simple enum
    enum Month //default type for enum is int
    {
        //enum initialization starts from zero if value was not given
        //if value is given for first type it increments afterwards
        JAN=1,//
        Feb,//=11
        MARCH,//=12 and so on
        APRIL,
        JUNE,
        JULY,
        AUGUST,
        SEPTEMBER,
        OCTOBER,
        NOVEMBER,
        DECEMBER
    }
    //----------------------------------------------------------------------------
    //Flags enum

    //[Flags]
    //enum DAY
    //{
    //    NONE=0b_0000_0000,
    //    MONDAY= 0b_0000_0001,
    //    TUESDAY= 0b_0000_0010,
    //    WEDNESDAY= 0b_0000_0100,
    //    THURSDAY= 0b_0000_1000,
    //    FRIDAY= 0b_0001_0000,
    //    SATURDAY= 0b_0010_0000,
    //    SUNDAY= 0b_0100_0000,
    //    BUSDAY=MONDAY|WEDNESDAY|THURSDAY|SUNDAY|TUESDAY,
    //    WEEKEND=SATURDAY|FRIDAY
    //}
}