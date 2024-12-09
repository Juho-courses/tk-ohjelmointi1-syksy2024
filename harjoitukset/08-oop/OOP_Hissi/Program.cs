Elevator elevator = new Elevator(5);
elevator.Start(3);
elevator.Start(5);
elevator.Start(-1);
elevator.Start(6);
elevator.Start(1);

class Elevator
{

    private int min_floor = 1;
    public int FloorCount { get; private set; }
    public int CurrentFloor { get; private set; }
    public bool IsMoving { get; private set; }

    public Elevator(int floorCount)
    {
        FloorCount = floorCount;
        IsMoving = false;
        CurrentFloor = 1;
    }

    public void Start(int targetFloor)
    {
        if (targetFloor == CurrentFloor)
        {
            Console.WriteLine("Already at the target floor");
            return;
        }

        if (targetFloor > FloorCount || targetFloor < min_floor)
        {
            Console.WriteLine("Invalid floor");
            return;
        }
        int direction = 1;
        if (targetFloor < CurrentFloor)
        {
            direction = -1;
        }

        while (true)
        {
            CurrentFloor += direction;
            PrintLocation();
            if (CurrentFloor == targetFloor)
            {
                Console.WriteLine($"Target floor {targetFloor} reached!");
                break;
            }
        }
    }

    public void PrintLocation()
    {
        string str = "";
        for (int i = min_floor; i <= FloorCount; i++)
        {
            if (i == CurrentFloor)
            {
                str += "[";
            }
            str += $"{i}";
            if (i == CurrentFloor)
            {
                str += "]";
            }

            if (i != FloorCount) { str += " "; }
        }
        Console.WriteLine(str);
    }
}