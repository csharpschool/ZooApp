using System.Collections;
using Zoo.Common;

namespace Zoo.Data;

public class AnimalData
{
    Animal[] Animals { get; init; } = new[] {
        new Animal(1, "Lion", true),
        new Animal(2, "Giraffe", false),
        new Animal(3, "Quagga", false),
        new Animal(4, "Tiger", true)
    };

    public AnimalData()
    {
            
    }

    public IEnumerable<Animal> GetAnimals(bool isPreadator) {
        foreach (var animal in Animals)
            if(animal.Predator.Equals(isPreadator))
                yield return animal;
    }

    public void FeedAnimal(int id)
    {
        var animal = Animals.SingleOrDefault(a => a.Id == id);
        if (animal is null) return;
        animal.Feed("Apple");
    }
    public void PetAnimal(int id)
    {
        var animal = Animals.SingleOrDefault(a => a.Id == id);
        if (animal is null) return;
        animal.Pet();
    }

}
