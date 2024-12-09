Phone p1 = new Phone("Iphone");
Console.WriteLine(p1.Model);
p1.Call("12312313");
p1.EndCall();
p1.Call("lkjlkajsda");
p1.EndCall();

class Phone(string model)
{
    public string Model { get; private set; } = model;
    public string Number { get; private set; }
    public bool CallOnGoing { get; private set; } = false;


    public void Call(string number)
    {
        if (CallOnGoing)
        {
            Console.WriteLine($"Call already on going {number}");
            return;
        }

        Number = number;
        CallOnGoing = true;
        Console.WriteLine($"Calling number {Number}");
    }

    public void EndCall()
    {
        if (!CallOnGoing)
        {
            Console.WriteLine("No call to hang up.");
            return;
        }

        CallOnGoing = false;
        Console.WriteLine("Hanging up");
        Number = "";
    }

}