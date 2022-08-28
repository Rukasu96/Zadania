
using ParkingSamochody;

Parking parking = new Parking();
Car car1 = new Car("Audi", "A1", "DB335");
Car car2 = new Car("Jeep", "Wrangler", "DW321");
Car car3 = new Car("BMW", "X5", "WPR244");
Car car4 = new Car("Honda", "Civic", "SCI103");
Car car5 = new Car("Mazda", "CX30", "SWD6W2");
Car car6 = new Car("Nissan", "Juke", "KR505");
Car car7 = new Car("Ford", "Fiesta", "PO97F");
Car car8 = new Car("Suzuki", "Swift", "WPR12L");

parking.AddCar(car2, 'B');

Console.WriteLine(parking);