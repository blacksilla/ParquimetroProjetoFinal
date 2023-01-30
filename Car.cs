using Microsoft.VisualBasic;
using System;
namespace ParquimetroProjetoFinal
{
    public class Car
    {
        private string brand;
        private string licensePlate;
        private double parkingTime;

        public Car(string brand, string licensePlate, double parkingTime)
        {
            this.brand = brand;
            this.licensePlate = licensePlate;
            this.parkingTime = parkingTime;
        }

        public string Brand { get => brand; set => brand = value; }
        public string LicensePlate { get => licensePlate; set => licensePlate = value; }
        public double ParkingTime { get => parkingTime; set => parkingTime = value; }


        //retorna uma marca de carro random
        public static string randomCarBrand()
        {
            List<string> carBrand = new List<string>();

            carBrand.Add("Audi");
            carBrand.Add("BMW");
            carBrand.Add("Bugatti");
            carBrand.Add("Chevrolet");
            carBrand.Add("Ferrari");
            carBrand.Add("Fiat");
            carBrand.Add("Ford");
            carBrand.Add("Honda");
            carBrand.Add("Jaguar");
            carBrand.Add("Lamborghini");
            carBrand.Add("Land Rover");
            carBrand.Add("Lexus");
            carBrand.Add("McLaren");
            carBrand.Add("Mercedes-Benz");
            carBrand.Add("Nissan");
            carBrand.Add("Porsche");
            carBrand.Add("Rolls Royce");
            carBrand.Add("Tesla");
            carBrand.Add("Toyota");
            carBrand.Add("Volkswagen");
            carBrand.Add("Volvo");

            return carBrand[MathHelper.returnRandomInt(0, carBrand.Count - 1,1)];
            
        }

        //retorna uma matricula random
        public static string returnRandomLicense()
        {

            int lengthLetter = 4;
            int lengthNumber = 2;

            Random random = new Random();
            Random randomInt = new Random();


            List<string> randomLicense = new List<string>();


            for (int i = 0; i < lengthLetter; i++)
            {

                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                randomLicense.Add(Convert.ToString(Convert.ToChar(shift + 65)));

            }

            for (int i = lengthLetter; i < lengthNumber + lengthLetter; i++)
            {
                string INT = Convert.ToString(randomInt.Next(9));
                randomLicense.Add(INT);

            }

            List<string> licensePlateList = new List<string>();
            licensePlateList.Add(randomLicense[0]);
            licensePlateList.Add(randomLicense[1]);
            licensePlateList.Add(randomLicense[4]);
            licensePlateList.Add(randomLicense[5]);
            licensePlateList.Add(randomLicense[2]);
            licensePlateList.Add(randomLicense[3]);


            //formato da matricula
            string licensePlate = randomLicense[0] + randomLicense[1] +"-"+ randomLicense[4] + randomLicense[5] +"-"+ randomLicense[2] + randomLicense[3];

            return licensePlate;

        }

        //retorna lista de objetos carro para cada lugar ocupado , int numberOfCars é o numero de ocupados em cada zona
        public static List<Car> returnParkedCars(int numberOfCars)
        {
            List<Car> cars = new List<Car>();


            for (int i = 0; i < numberOfCars; i++)
            {
                cars.Add(new Car(Car.randomCarBrand(), Car.returnRandomLicense(), MathHelper.returnRandomInt(10, 480, 1)));
                
                
            }

            return cars;
        }
    
        
	}
}

