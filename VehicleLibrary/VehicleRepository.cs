using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibrary
{
    public class VehicleRepository
    {
        private static List<Vehicle> _vehicles = new List<Vehicle>();
        private static int nextId = 0;
        public List<Vehicle> ListAll()
        {
            return _vehicles;
        }
        public Vehicle GetById(int id)
        {
            return _vehicles.Find(v => v.Id == id);
        }
        public void Add(Vehicle newVehicle)
        {
            newVehicle.Id = nextId++;
            _vehicles.Add(newVehicle);
        }
        public void Edit(Vehicle editVehicle)
        {
            var origVeh = GetById(editVehicle.Id);

            origVeh.Year = editVehicle.Year;
            origVeh.Make = editVehicle.Make;
            origVeh.Model = editVehicle.Model;
        }
        public void Delete(int Id)
        {
            var vehToDelete = GetById(Id);

            _vehicles.Remove(vehToDelete);
        }
    }
}
