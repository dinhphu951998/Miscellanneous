using MySqlNormalization.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MySqlNormalization
{
    class Program
    {
        static thanhtamluxuryContext dbContext = new thanhtamluxuryContext();
        static Random random = new Random();

        static void Main(string[] args)
        {
            NormalizeServiceItem();
            NormalizaPriceDetail();
            dbContext.SaveChanges();

        }


        private static void NormalizeServiceItem()
        {
            List<Serviceitem> services = dbContext.Serviceitem.ToList();

            services.ForEach(s =>
            {
                s.IsActive = 1;
                s.Price = random.Next(5_000_000, 20_000_000);
                s.ServiceType = ServiceType.ServiceTypes[random.Next(0, 4)];

            });

        }

        private static void NormalizaPriceDetail()
        {
            var priceDetails = dbContext.Pricedetail.ToList();

            priceDetails.ForEach(p =>
            {
                if (p.StartDate > p.EndDate)
                {
                    p.StartDate = new DateTime(2019, random.Next(1,13), random.Next(1,30));
                    RandomDateTime datetimeGen = new RandomDateTime(p.StartDate.Value);
                    p.EndDate = datetimeGen.Next();
                    p.Price = random.Next(5_000_000, 20_000_000);
                    p.Title = RandomString(20);
                }
            });
        }

        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }


    }

    class ServiceType
    {
        public const string ALBUM = "Album";
        public const string WEDDING_DRESS = "Wedding dress";
        public const string WEDDING_VIDEO = "Wedding video";
        public const string FULL_WEDDING_DAY = "Full wedding day";

        public static string[] ServiceTypes = { ALBUM, WEDDING_DRESS, WEDDING_VIDEO, FULL_WEDDING_DAY };
    }

    class RandomDateTime
    {
        DateTime start;
        Random gen;
        int range;

        public RandomDateTime(DateTime baseLine)
        {
            start = new DateTime(2020, 1, 1);
            gen = new Random();
            range = (start - baseLine).Days;
        }

        public DateTime Next()
        {
            return start.AddDays(gen.Next(range)).AddHours(gen.Next(0, 24)).AddMinutes(gen.Next(0, 60)).AddSeconds(gen.Next(0, 60));
        }
    }


}
