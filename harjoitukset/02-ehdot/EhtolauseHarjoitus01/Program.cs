// Luo muuttujat joihin tallennat ikäsi ja etunimesi
// • Luo ehtolause joka tarkistaa, että nimi ja ikä ovat samat kuin
// muuttujien arvot
// • Jos lause totta, tulosta 'moi <nimi>!'. (‘<nimi>' on muuttujan arvo)
// • Jos lause ei ole totta, tulosta 'henkilö ei tunnistettu'

int age = 21;
string name = "Jaska";

if (name == "Juho" && age == 21)
{
    Console.WriteLine("moi " + name + "!");
}
else
{
    Console.WriteLine("henkilö ei tunnistettu");
}