using System;


namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new NumbersObservable(5);
	    var subscription = numbers.Subscribe(new ConsoleObserver<int>("numbers"));
        }
    }
}
