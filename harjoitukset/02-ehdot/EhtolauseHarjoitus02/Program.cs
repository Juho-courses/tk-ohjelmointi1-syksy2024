// Luo muuttuja, joka pitää tiedon moottorin tilasta
// • Moottori voi olla joko käynnissä tai ei käynnissä
// • Luo muuttuja, joka sisältää tiedon lämpötilasta
// • Luo ehtolause, joka tarkastelee lämpötilaa
// • Jos lämpötila yli 30, käynnistä moottori (muuta muuttujan arvoa)
// • Luo toinen ehtolause, joka tarkastelee moottorin tilaa
// • Jos moottori käynnissä, tulosta 'motor is running'
// • Jos moottori ei käy, tulosta 'motor not runnin

bool isRunning = false;
int temperature = 31;

if (temperature > 30)
{
    isRunning = true;
}

if (isRunning)
{
    Console.WriteLine("motor is running");
}
else
{
    Console.WriteLine("motor not running");
}