using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Repository;
namespace Domain.Service
{
    public class VehicleService : IVehicleService
    {
        
        
        public Car AddPassengerToCar(int numberOfPassengers)
        {
            var people = new List<Person>();

            for (int i = 0; i < numberOfPassengers; i++)
            {
                people.Add(new Person());
            }
            Car car = new Car();
            car.Start(people);
            return car;
        }

        public MotorBike AddPassengerToMotorBike(int numberOfPassengers)
        {
            var people = new List<Person>();

            for (int i = 0; i < numberOfPassengers; i++)
            {
                people.Add(new Person());
            }
            MotorBike motorBike = new MotorBike();
            motorBike.Start(people);
            return motorBike;
        }
        public Coach AddPassengerToCoach(int numberOfPassengers)
        {
            var people = new List<Person>();

            for (int i = 0; i < numberOfPassengers; i++)
            {
                people.Add(new Person());
            }
            Coach coach = new Coach();
            coach.Start(people);
            return coach;
        }
    }
}
