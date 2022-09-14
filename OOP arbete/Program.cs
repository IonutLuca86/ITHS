// See https://aka.ms/new-console-template for more information


car minBil = new car();
minBil.color = "blue";
//Console.WriteLine("Bilens färg är: " + minBil.color);
//Console.WriteLine("Bilens namn är: " + minBil.name);
//Console.WriteLine("Bilens maxhastighet är: " + minBil.MaxHastighet);

minBil.tellAboutCar("Harriet");


class car
{
    public string color = "red";
    public string name = "Bettan";
    public string description = "Det här är en trevlig bil";
    public int MaxHastighet = 240;

    public void tellAboutCar(string name)
    {
        Console.WriteLine("Namnet som skickas in är: " + name);
        Console.WriteLine("Namnet som bilen har är: " + this.name);
    }
    
}
