using System;
using System.Reactive.Disposables;
using System.Collections.Generic;
using System.Reactive.Linq;

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
        }
    }
}
