using System;

namespace Console
{
    public class ConsoleObserver<T> : IObserver<T>
    {
	private readonly string _name;

	public ConsoleObserver(string name = "")
	{
	    _name = name;
	}

	public void OnNext(T value)
	{
	    System.Console.WriteLine("{0} - OnNext({1})", _name, value);
	}

	public void OnError(Exception error)
	{
	    System.Console.WriteLine("{0} - OnError:", _name);
	    System.Console.WriteLine("\t {0}", error);
	}

	public void OnCompleted()
	{
	    System.Console.WriteLine("{0} - OnCompleted()", _name);
	}
    }
}
