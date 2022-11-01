using CarLotSimulator;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
//TODO

//Create a seperate class file called Car-  DONE
//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable-DONE
//Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()-DONE
//The methods should take one string parameter: the respective noise property-DONE

var carOne = new Car(2021, "Ford", "Mustang", "vrooom", "bippity beep", true);
Console.WriteLine($"The number of cars in the Lot is : {CarLot.numberOfCars}");

var carTwo = new Car(2000, "Chevy", "Impala", "spitter spatter", "wonk", true);
Console.WriteLine($"The number of cars in the Lot is : {CarLot.numberOfCars}");

var carThree = new Car(2022, "GMC", "Yukon", "hmmmmm", "beep", true);
Console.WriteLine($"The number of cars in the Lot is : {CarLot.numberOfCars}");

//Now that the Car class is created we can instanciate 3 new cars
//Set the properties for each of the cars
//Call each of the methods for each car
//carOne.MakeEngineNoise(carOne.EngineNoise);
//carTwo.MakeEngineNoise(carTwo.EngineNoise);
//carThree.MakeEngineNoise(carThree.EngineNoise);

{
    //Console.WriteLine($"{carOne.Year} {carOne.Make} {carOne.Model} {carOne.EngineNoise} {carOne.HonkNoise}");
}
   

