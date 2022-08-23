namespace OOP001
{
    internal class Person
    {
        public string Name { get; set; }
        //public int Age { get; set; }
        public DateTime DoB { get; set; }
        public string Email { get; set; }

        // public TimePeriod timePeriod { get; set; }
        public int Age { get { return GetAge(); } }
        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - DoB.Year;
            if (today < new DateTime(today.Year, DoB.Month, DoB.Day)) age--;
            return age;
        }
    }

    public class TimePeriod
    {
        private double _seconds;

        public double Hours
        {

            get { return _seconds / 3600; }
            set
            {
                if (value < 0 || value > 24)
                    throw new ArgumentOutOfRangeException(nameof(value),
                          "The valid range is between 0 and 24.");

                _seconds = value * 3600;
            }

        }
    }

}
