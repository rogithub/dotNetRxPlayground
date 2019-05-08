using System;
using System.Reactive.Disposables;

namespace Console
{
    public static class Extensions
    {
	public static IDisposable SubscribeConsole<T>(this IObservable<T> observable, string name = "")
	{
	    return observable.Subscribe(new ConsoleObserver<T>(name));
	}
	
    }
}
