using System;
using System.Collections.Generic;

namespace mobilebill
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<MobileBill> HourlyRate = new List<MobileBill>();
            MobileBill PickHour = new MobileBill();
            PickHour.Name = "PickHour";
            PickHour.SessionStart = DateTime.ParseExact("9:00:00 AM", "hh:mm:ss tt", null);
            PickHour.SessionEnd = DateTime.ParseExact("10:59:59 PM", "hh:mm:ss tt", null);
            PickHour.Rate = 0;
            PickHour.PulseRate = 0.3;
            PickHour.PulseDuration = 20;
            HourlyRate.Add(PickHour);
            MobileBill OffPickHour1 = new MobileBill();
            PickHour.Name = "OffPickHour";
            PickHour.SessionStart = DateTime.ParseExact("12:00:00 AM", "hh:mm:ss tt", null);
            PickHour.SessionEnd = DateTime.ParseExact("8:59:59 AM", "hh:mm:ss tt", null);
            PickHour.Rate = 0;
            PickHour.PulseRate = 0.2;
            PickHour.PulseDuration = 20;
            HourlyRate.Add(PickHour);
            MobileBill OffPickHour2 = new MobileBill();
            PickHour.Name = "OffPickHour";
            PickHour.SessionStart = DateTime.ParseExact("11:00:00 PM", "hh:mm:ss tt", null);
            PickHour.SessionEnd = DateTime.ParseExact("11:59:59 PM", "hh:mm:ss tt", null);
            PickHour.Rate = 0;
            PickHour.PulseRate = 0.2;
            PickHour.PulseDuration = 20;
            HourlyRate.Add(PickHour);
            Console.WriteLine("Start Time: ");
            DateTime CallStartTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("End Time: ");
            DateTime CallEndTime = DateTime.Parse(Console.ReadLine());
            double TotalBill = 0.0;
            foreach (var item in HourlyRate)
            {
                if (item.SessionStart <= CallStartTime && item.SessionEnd <= CallEndTime)
                {
                    TotalBill += item.PulseRate;
                }
            }
            Console.WriteLine("Total Bill: ", TotalBill);

            Console.ReadKey();
        }
    }
}

