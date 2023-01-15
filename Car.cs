﻿using Microsoft.VisualBasic;
using System;
namespace ParquimetroProjetoFinal
{
    public class Car
    {
        private string brand;
        private string licensePlate;
        private int parkingTime;

        public Car(string brand, string licensePlate, int parkingTime)
        {
            this.brand = brand;
            this.licensePlate = licensePlate;
            this.parkingTime = parkingTime;
        }

        public string Brand { get => brand; set => brand = value; }
        public string LicensePlate { get => licensePlate; set => licensePlate = value; }
        public int ParkingTime { get => parkingTime; set => parkingTime = value; }

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

        public static string returnRandomLicense()
        {

            int lengthLetter = 4;
            int lengthNumber = 2;

            // creating a StringBuilder object()
            //StringBuilder str_build = new StringBuilder();
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


            //return licensePlateList;
            string licensePlate = randomLicense[0] + randomLicense[1] +"-"+ randomLicense[4] + randomLicense[5] +"-"+ randomLicense[2] + randomLicense[3];

            return licensePlate;

        }
    
        
	}
}
