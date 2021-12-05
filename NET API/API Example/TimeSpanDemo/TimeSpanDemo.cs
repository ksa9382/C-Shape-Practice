using System;
// 시간차 구하기 예제

namespace TimeSpanDemo
{
    class TimeSpanDemo
    {
        static void Main(string[] args)
        {
            TimeSpan xmas_dday = Convert.ToDateTime("2021-12-25") - DateTime.Now;
            Console.WriteLine($"크리스마스 까지 D-{(int)xmas_dday.TotalDays} days");

            TimeSpan live_time = DateTime.Now - Convert.ToDateTime("1993-04-06");
            Console.WriteLine($"내가 살아온 시간은 총 {live_time.Days} 일.");


            Console.WriteLine(GetDateTimeFromYearlyHours(1));
            Console.WriteLine(GetDateTimeFromYearlyHours(8760/2));
            Console.WriteLine(GetDateTimeFromYearlyHours(8760));
        }

        public static DateTime GetDateTimeFromYearlyHours(int num)
        {
            return (new DateTime(2021, 1, 1, 0, 0, 0).AddHours(--num));
        }
    }
}