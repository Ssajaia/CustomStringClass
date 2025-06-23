using DS;

class Program
{
    static void Main()
    {
        Nstring a = new Nstring("hello");
        Nstring b = new Nstring("world");
        Nstring c;

        Console.WriteLine("Original a: " + a);
        Console.WriteLine("Original b: " + b);

        // Test +
        c = a + b;
        Console.WriteLine("a + b: " + c);

        // Test *
        c = a * 3;
        Console.WriteLine("a * 3:\n" + c);

        // Test -
        c = c - new Nstring("lo");
        Console.WriteLine("After removing 'lo':\n " + c);

        // Test /
        int count = c / new Nstring("l");
        Console.WriteLine("Count of 'l' in c: " + count);

        // Test ++
        Console.WriteLine("a before ++: " + a);
        a++;
        Console.WriteLine("a after ++: " + a);

        // Test --
        Console.WriteLine("a before --: " + a);
        a--;
        Console.WriteLine("a after --: " + a);

        // Test %
        c = a % 3;
        Console.WriteLine("a % 3 (last length % 3 chars): " + c);

        // Test Equals and ==
        Nstring d = new Nstring("hello");
        Console.WriteLine($"a.Equals(d): {a.Equals(d)}");
        Console.WriteLine($"a == d: {a == d}");
        Console.WriteLine($"a != b: {a != b}");

        // Test toString method
        Nstring E = new Nstring("ToString() works");
        Console.WriteLine(E);
    }
}
