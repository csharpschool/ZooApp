using System.Collections;
using Zoo.Common;

namespace Zoo.Data;

public class AnimalData
{
    Animal[] Animals { get; init; } = new[] {
        new Animal("Lion", true),
        new Animal("Giraffe", false),
        new Animal("Quagga", false),
        new Animal("Tiger", true)
    };

    public AnimalData()
    {
            
    }

    public IEnumerable<Animal> GetAnimals(bool isPreadator) {
        foreach (var animal in Animals)
            if(animal.Predator.Equals(isPreadator))
                yield return animal;
    }
}
