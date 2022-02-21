using System;

public delegate void ExampleDelegate();

interface TesterInterface
{
	//instance methods
	void testMethod();

	//property
	string Item { get; set; }

	//indexer
	string this[int i] 
    {
		get;
		set;
    }
}

class TesterClass : TesterInterface
{
	//instance method
	void testMethod()
    {
		Console.WriteLine("Hello!");
    }

	//property
	private string name = "Test Name";
	public string Item
    {
		get
        {
			return name;
        }
		set
        {
			name = value;
        }
    }

	//indexer
	private string[] arr = new string[100];
	
	public string this[int i]
	{
		get { return arr[i]; }
		set { arr[i] = value; }
	}
}

class Program
{
	static void Main()
    {
		TesterClass tc1 = new TesterClass();

		//instance method
		tc1.testMethod();

		//property
		tc1.Item = "test string";
		Console.WriteLine(tc1.Item);

		//indexer
		tc1[5] = 100;

		Console.WriteLine(tc1[4]);
		Console.WriteLine(tc1[5]);
	}
}

/*
 * Has an interface
 * Three different properties: Instance methods, properties, events, indexers
 */