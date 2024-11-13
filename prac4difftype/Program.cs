using System;

namespace ConstructorOverload {

  class Car {   
    
    // constructor with string parameter
    Car(string brand) {
      Console.WriteLine("Brand: " + brand);
    }

    // constructor  with int parameter
    Car(int price) {
      Console.WriteLine("Price: " + price);
    }

    static void Main(string[] args) {

      // call constructor  with string parameter
      Car car = new Car("Lamborghini");
      
      Console.WriteLine();

      // call constructor  with int parameter
      Car car2 =new Car(50000);
    
      Console.ReadLine();
    }
  }
}