namespace Task1;
class Program
{
    static void Main()
    {
        var animal1 = new Animal(100, 4, 0.5, "Кіт");
        var animal2 = new Animal(80, 5, 1.5, "Лев");
        var plant1 = new Plant(50, 2, 0.5, "Дуб");
        var microorganism1 = new Microorganism(10, 1, 0.01, "Бактерія");

        var ecosystem = new Ecosystem();
        ecosystem.AddOrganism(animal1);
        ecosystem.AddOrganism(animal2);
        ecosystem.AddOrganism(plant1);
        ecosystem.AddOrganism(microorganism1);

        ecosystem.Interact();
    }
}
