namespace Charakterguide
{
class Norecruit
{
    public int Age;
    public string Birthday; //?
    public string Height;

    public string Starterclass;

    public string Starterweapon; // kann vllt raus

    public string Clan; //muss evtll doch raus



        public Norecruit(int age, string birthday, string height) // Constructor
        {
        Age = age;
        Birthday = birthday;
        Height = height;
    }

    static void Main(string[] args)
    {
        // name auch noch?
        Norecruit Peter = new Norecruit(16, "01.01", "163 cm");

        Norecruit Tialla = new Norecruit(16, "02.02", "165 cm"); 

        Norecruit Ultand = new Norecruit(23, "28.04", "170 cm");

        Norecruit Bertrand = new Norecruit(28, "28.04", "180 cm");

        Norecruit Gaitz = new Norecruit(23, "28.04", "170 cm");

        Norecruit Fabio = new Norecruit(25, "28.04", "190 cm");

        Norecruit Orchel = new Norecruit(23, "28.04", "170 cm");

        Norecruit Bonaventure = new Norecruit(23, "28.04", "170 cm");

        Norecruit Tobias = new Norecruit(23, "28.04", "170 cm");

        Norecruit Talimun = new Norecruit(23, "28.04", "180 cm");

        Norecruit Buccar = new Norecruit(23, "28.04", "170 cm");

        Norecruit Anatolia = new Norecruit(23, "28.04", "170 cm");

        Norecruit ShaLan = new Norecruit(23, "28.04", "170 cm");

        Norecruit Centurio = new Norecruit(23, "28.04", "180 cm");




            //kommt wieder weg
        Console.WriteLine(Peter.Age);
        Console.WriteLine(Tialla.Birthday);
        Console.WriteLine(Ultand.Height);
    }
}
}