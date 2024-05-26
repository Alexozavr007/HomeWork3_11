namespace HomeWork3_11_2;
public class CarCollection {
    private List<Car> cars = new List<Car>();

    public void Add(string name, int year) {
        var car = new Car();
        car.Name = name;
        car.Year = year;
        cars.Add(car);
    }
    public Car this[int index] {
        get {
            return cars[index];
        }
    }
    public int Count {
        get {
            return cars.Count; 
        }
    }
    public void Clear() {
        cars.Clear();
    }
}
