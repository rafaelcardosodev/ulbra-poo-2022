using System;

namespace AtividadeAula02.Entities
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date(String date)
        {
            String[] arrayDate = date.Split("/");
            this.day = int.Parse(arrayDate[0]);
            this.month = int.Parse(arrayDate[1]);
            this.year = int.Parse(arrayDate[2]);
        }

        public static Boolean isDateValid(String date)
        {
            String[] arrayDate = date.Split("/");
            int dateDay = int.Parse(arrayDate[0]);
            int dateMonth = int.Parse(arrayDate[1]);
            int dateYear = int.Parse(arrayDate[2]);

            if (dateDay <= 0 || dateDay > 31 || dateMonth <= 0 || dateMonth > 12 || dateYear <= 0)
            {
                return false;
            }

            if (dateMonth == 4 ||
                dateMonth == 6 ||
                dateMonth == 9 ||
                dateMonth == 11)
            {
                if (dateDay > 30)
                {
                    return false;
                }

                return true;
            }

            if (dateMonth == 2)
            {
                if (isLeapYear(dateYear))
                {
                    if (dateDay > 29)
                    {
                        return false;
                    }

                    return true;
                }

                if (dateDay > 28)
                {
                    return false;
                }

                return true;
            }

            return true;
        }

        public static Boolean isLeapYear(int dateYear)
        {
            if (dateYear % 4 == 0)
            {
                if (dateYear % 100 != 0)
                {
                    return true;
                }
            }

            if (dateYear % 400 == 0)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"{nameof(day)}: {day}, {nameof(month)}: {month}, {nameof(year)}: {year}";
        }
    }
}