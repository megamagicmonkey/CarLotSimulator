using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instantiate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car


            CarLot theYard = new CarLot();
            Car car1 = new Car();
            theYard.carList.Add(car1);

            Car car2 = new Car(2012, "Nissan", "Altima", "patterpatterpatter", "durr", true);
            theYard.carList.Add(car2);

            Car car3 = new Car() { Year = 1930, Make = "Ford", Model = "Model-T", HonkNoise = "Beep!", EngineNoise = "chuggachuggachugga", IsDriveable = false };
            theYard.carList.Add(car3);

            theYard.carList[0].MakeEngineNoise(car1.EngineNoise);
            theYard.carList[0].MakeHonkNoise(car1.HonkNoise);
            theYard.carList[1].MakeEngineNoise(car2.EngineNoise);
            theYard.carList[1].MakeHonkNoise(car2.HonkNoise);
            theYard.carList[2].MakeEngineNoise(car3.EngineNoise);
            theYard.carList[2].MakeHonkNoise(car3.HonkNoise);




            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instantiate a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
