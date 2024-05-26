using HomeWork3_11_2;

var cars = new CarCollection();
cars.Add("BMW", 32);
cars.Add("Fiat", 22);

for (int i = 0; i < cars.Count; i++) {
    Console.WriteLine($"{cars[i].Name} {cars[i].Year}");
}
