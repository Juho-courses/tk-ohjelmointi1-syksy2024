// • Luo kaksi muuttujaa, joille annat arvoiksi jotkin kokonaisluvut
// • Luo ehtolause, joka tarkistaa onko jompikumpi (tai molemmat) muuttujista 
// arvoltaan 42
// • Jos on, tulosta ’42 löytyi!’
// • Jos ei, tulosta ’42 ei löytynyt!’
// • Testaa ohjelmasi toimintaa vaihtelemalla eri arvoja muuttujille ja 
// suorittamalla ohjelm

int eka = 123;
int toka = 131;

if (eka == 42 || toka == 42)
{
    Console.WriteLine("42 löytyi!");
}
else
{
    Console.WriteLine("42 ei löytynyt!");
}