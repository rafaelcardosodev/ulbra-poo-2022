using System;

namespace AtividadeAula02.Entities
{
    public class Hour
    {
        private int hours;
        private int minutes;
        private int seconds;

        public Hour(string dateTime)
        {
            string[] arrayDateTime = dateTime.Split(":");
            this.hours = int.Parse(arrayDateTime[0]);
            this.minutes = int.Parse(arrayDateTime[1]);
            this.seconds = int.Parse(arrayDateTime[2]);
        }

        public static Boolean isDateTimeValid(String dateTime)
        {
            string[] arrayDateTime = dateTime.Split(":");
            int hour = int.Parse(arrayDateTime[0]);
            int minute = int.Parse(arrayDateTime[1]);
            int second = int.Parse(arrayDateTime[2]);

            if (hour >= 24 || hour < 0 || minute >= 60 || minute < 0 || second >= 60 || second < 0)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return $"hour: {hours}, " + $"minutes: {minutes}, " + $"seconds: {seconds}";
        }
    }
}