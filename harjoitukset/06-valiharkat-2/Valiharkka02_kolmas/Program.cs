Console.WriteLine("anna kuukausi (1-12): ");
int month = int.Parse(Console.ReadLine());

int days = DateTime.DaysInMonth(2024, month);

Console.WriteLine($"{month} days: {days}");
