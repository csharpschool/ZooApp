namespace Zoo.Common;

public class Animal
{
    public int Id { get; init; }
    public string AnimalType { get; init; }
    public bool Predator { get; init; }
    public DateTime LastFeed { get; private set; }

    public Animal(int id, string animalType, bool predator) => 
        (Id, AnimalType, Predator) = (id, animalType, predator);

    public void Feed(string food)
    {
        if(LastFeed.Date > DateTime.Now)
        { 
        }
        LastFeed = DateTime.Now;
    }

    public void Pet()
    {
        
    }

}