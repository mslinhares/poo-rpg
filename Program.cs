using poo.src.Entities.HeroTypes;
       
Knight arus = new Knight("Arus", 4," knight");
Ninja wedke = new Ninja("Wedke",4,"Ninja");
Wizard jenica = new Wizard("Jenica", 42, "Wizard","White");
Wizard topapa = new Wizard("Topapa",12,"Wizard","Black");

System.Console.WriteLine(arus.ToString());
System.Console.WriteLine(arus.Attack());
System.Console.WriteLine(arus.Attack(2));
System.Console.WriteLine(arus.Attack(4));
System.Console.WriteLine();
System.Console.WriteLine(jenica.ToString());
System.Console.WriteLine(jenica.Attack());
System.Console.WriteLine(jenica.Attack(2));
System.Console.WriteLine(jenica.Attack(15));
System.Console.WriteLine();
System.Console.WriteLine(topapa.ToString());
System.Console.WriteLine(topapa.Attack());
System.Console.WriteLine(topapa.Attack(1));
System.Console.WriteLine(topapa.Attack(8));
System.Console.WriteLine();
System.Console.WriteLine(wedke.ToString());
System.Console.WriteLine(wedke.Attack());
System.Console.WriteLine(wedke.Attack(3));
System.Console.WriteLine(wedke.Attack(10));
System.Console.WriteLine();
