namespace OOP001
{
    public class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in args)
            {
                Console.WriteLine(item);
            }
            
            //Type       Referencenavn      Instans (Parentheses is the Constructor)
            MyFirstClass myFirstObject = new MyFirstClass();
            //myFirstObject.str = "Some text";
            myFirstObject.MyMethod();
            myFirstObject.Age = 55;

            //new instance of an object without reference
            new MyFirstClass().MyMethod();

            Person myPerson = new Person();
            myPerson.Name = "Hugo";

            myPerson.DoB = new DateTime(2000, 1, 1);
            //Console.WriteLine(myPerson.GetAge() ); 
            myPerson.DoB = new DateTime(2000, 12, 1);
            //Console.WriteLine(myPerson.GetAge() );

            Console.WriteLine(myPerson.Age);
            //myPerson.Age = 25;

            TimePeriod tp = new TimePeriod();
            tp.Hours = 24;
            //myPerson.timePeriod = tp;
            Console.ReadKey();
        }
    }
}
