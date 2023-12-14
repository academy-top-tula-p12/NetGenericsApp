using NetGenericsApp;

Person<int> person1 = new(123, "Bob");
Person<string> person2 = new Student<string>("ggfgf", "Tom");
Student<int> student1 = new(65675, "Jimmy");


void GenericWhereExample()
{
    SendMessage(new Message("Hello world"));

    SendMessage(new EmailMessage("Hello world from email"));
    SendMessage<SmsMessage>(new SmsMessage("Hello world from sms"));

    void SendMessage<T>(T message) where T : Message
    {
        Console.WriteLine(message.Text);
    }
}

void GenericExample()
{
    // Bad solution
    /*
    Employee joe = new Employee(123, "Joe", 25);
    Employee tom = new Employee("XI-1234", "Tom", 32);

    object obj =  joe;

    int idJoe = (int)joe.Id;
    string idTom = (string)tom.Id;

    string idJoeS = (string)joe.Id;
    */


    Employee<int, int> tom = new Employee<int, int>(123, "Tom", 25);
    Employee<int, int>.Code = 123456;

    Employee<string, string> joe = new("XI-876", "Joe", 32);
    Employee<string, string>.Code = "123456";

    //Employee<int> sam = new("123", "Tom", 25);

    int idTom = tom.Id;

    Employee<Passport<string>, string> leo = new(
        new()
        {
            Series = "XI-789236",
            Number = "756752"
        },
        "Leo", 42);
    Employee<Passport<string>, string> ben = new(
        new() { Series = "AS-56757", Number = "234234" },
        "Ben", 32);

    int var1 = 23;
    int var2 = 45;
    Console.WriteLine($"{var1} {var2}");
    Swap<int>(ref var1, ref var2);
    Console.WriteLine($"{var1} {var2}");

    Console.WriteLine($"{leo} <=> {ben}");
    Swap<Employee<Passport<string>, string>>(ref leo, ref ben);
    Console.WriteLine($"{leo} <=> {ben}");



    void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}

