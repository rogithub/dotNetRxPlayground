using System;
using System.Reactive.Disposables;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive;


namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new NumbersObservable(5);
	    var subscription = numbers.SubscribeConsole("numbers");

	    IEnumerable<string> names = new []{ "Paola", "Maura", "Corina", "Alejandra" };
	    IObservable<string> namesObservable = names.ToObservable();

	    namesObservable.SubscribeConsole("names");

	    // Using existing factories.
	    var observer = Observer.Create<string>(x => System.Console.WriteLine(x));
	    
	    Observable.Interval(TimeSpan.FromSeconds(1))
		.Select(x => "X" + x)
		.Subscribe(observer);


	    Observable.Interval(TimeSpan.FromSeconds(2))
		.Select(x => "YY" + x)
		.Subscribe(observer);
	    
	    System.Console.ReadLine();
        }
    }
}
