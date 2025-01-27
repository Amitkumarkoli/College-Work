﻿using System;

namespace ConstructorOverload {

  class Car {   
    
    // constructor with no parameter
    Car() {
      Console.WriteLine("Car constructor");
    }
     
    // constructor with one parameter
    Car(string brand) {
      Console.WriteLine("Car constructor with one parameter");
      Console.WriteLine("Brand: " + brand);
    }

    static void Main(string[] args) {

      // call with no parameter
      Car car = new Car();

      Console.WriteLine();

      // call with one parameter 
      Car car2 =  new Car("Bugatti");
     
      Console.ReadLine();
    }
  }
}