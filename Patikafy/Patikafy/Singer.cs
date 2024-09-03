namespace Patikafy;

public class Singer 
{
    public string Name { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }
    public int Sold { get; set; }

    public override string ToString()
    {
        return Name + " " + Genre + " " + Year + " " + Sold;
    }
}