using System;

namespace ConstructorOverload {

  class Car {   
    
    // constructor with string and int parameter
    Car(string brand, int price) {

      Console.WriteLine("Brand: " + brand);
      Console.WriteLine("Price: " + price);
    }
    
    // constructor with int and string parameter
    Car(int speed, string color) {
      
      Console.WriteLine("Speed: " + speed + " km/hr");
      Console.WriteLine("Color: " + color);
    }
    static void Main(string[] args) {

      // call constructor  with string and int parameter
      Car car = new Car("Bugatti", 50000);
      
      Console.WriteLine();

      // call constructor with int and string parameter
      Car car2 =new Car(60, "Red");
    
      Console.ReadLine();
    }
  }
}