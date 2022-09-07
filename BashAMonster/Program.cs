
Monster monster1 = new Monster();
monster1.namn = "Calle";
monster1.farg = "Blå";
monster1.pals = "Fluffig";
monster1.alder = 5;

Vapen vapen1 = new Vapen();
vapen1.namn = "Spira";
vapen1.vasshet = 5;

System.Console.Write("Vad vill du döpa Monstret till? ");
monster1.namn = Console.ReadLine();
System.Console.WriteLine("Monstret heter " + monster1.namn);
System.Console.WriteLine("Monstret är " + monster1.farg);
System.Console.WriteLine("Monstret är " + monster1.pals);
System.Console.WriteLine("Monstret är " + monster1.alder + " år gammal");
Console.ReadLine();

class Monster {
    public string namn;
    public string farg;
    public string pals;
    public int alder;
}

class Vapen {
    public int vasshet;
    public string namn;
}
