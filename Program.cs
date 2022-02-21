using System;

interface TesterInterface
{
	//instance methods
	void testMethod();

	//property
	string testString { get; set; }

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
	public void testMethod()
	{
		Console.WriteLine("Hello!");
	}

	//property
	private string name = "Test Name";

	public string testString
	{
		get { return name; }
		set { name = value; }
	}

	//indexer
	private string[] arr = new string[100];

	public string this[int i] {
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
		tc1.testString = "test string";
		Console.WriteLine(tc1.testString);

		//indexer
		tc1[5] = "Hello";

		Console.WriteLine(tc1[4]);
		Console.WriteLine(tc1[5]);
	}
}