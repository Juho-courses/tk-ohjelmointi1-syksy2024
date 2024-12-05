// luodaan uusi Address-olio ja tallennetaan se address-nimiseen muuttujaan
Address address = new Address("Satakunnankatu", 23);

// kutsutaan address-muuttujan ChangeAddress-metodia parametreilla nadönas jas 1
address.ChangeAddress("Karjalankatu", 1);

// kutsutaan address-muuttujan Print-metodia
address.Print();

Address a2 = new Address("Annankatu", 6);
a2.Print();


Person p1 = new Person("Jaska", 23);
Console.WriteLine(p1.FirstName);
Console.WriteLine(p1.Age);
p1.SetAddress(address);
p1.Address.Print();
p1.SetAddress(a2);
p1.Address.Print();

int new_age = p1.MakeOlder();

Console.WriteLine(new_age);
Console.WriteLine(p1.Age);