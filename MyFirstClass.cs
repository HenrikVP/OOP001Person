namespace OOP001
{
    internal class MyFirstClass
    {
        //Private field
        private string str;

        //Property
        public int Age { get; set; }

        //Constructor
        public MyFirstClass()
        {
            Console.WriteLine("Hello World");
        }

        //Method
        public void MyMethod()
        {
            Console.WriteLine("Welcome to my method. " + str);
        }
    }
}
