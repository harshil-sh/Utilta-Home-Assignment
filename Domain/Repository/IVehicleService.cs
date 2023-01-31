using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IVehicleService
    {
        public Car AddPassengerToCar(int numberOfPassengers);
        public MotorBike AddPassengerToMotorBike(int numberOfPassengers);
        public Coach AddPassengerToCoach(int numberOfPassengers);

    }
}
