using PB_Front_end_mocks.Models;

namespace PB_Front_end_mocks.Mocks_statics
{
    public static class PlaceStatic
    {
        public static Location Park1 = new Location(new Guid("800a4abb-db1a-44d8-9e78-2e7b8d7d6575"), "Parque 1", "Endereço do parque 1", "Telefone do Parque 1", "Park");
        public static Location Hotel1 = new Location(new Guid("422583ed-4bc9-4e31-8dd0-049ba98a223b"), "Hotel 1", "Endereço do Hotel 1", "Telefone do Hotel 1", "Hotel");
        public static Location Restaurant1 = new Location(new Guid("22d3070d-943a-4988-85aa-ab8a2a786489"), "Restaurant 1", "Endereço do Restaurant 1", "Telefone do Restaurant 1", "Restaurant");
        public static Location Event1 = new Location(new Guid("10b7640a-71fe-46be-b28b-eeed99468dac"), "Event 1", "Endereço do Event 1", "Telefone do Event 1", "Event");
        public static Location Pub1 = new Location(new Guid("3ae80fd4-bea1-4585-b5c5-10239b1895cc"), "Pub 1", "Endereço do Pub 1", "Telefone do Pub 1", "Pub");
        public static Location Subway1 = new Location(new Guid("12d03aa3-1ae0-4b66-b77f-a4d3bf07d041"), "Subway 1", "Endereço do Subway 1", "Telefone do Subway 1", "Subway");
        public static Location Mall1 = new Location(new Guid("aebb8e54-61fc-48d4-879f-99cd05a54520"), "Mall 1", "Endereço do Mall 1", "Telefone do Mall 1", "Mall");
        public static Location Drugstore1 = new Location(new Guid("f1bf1e25-b4f4-45a8-b002-c9e72117a4d8"), "Drugstore 1", "Endereço do Drugstore 1", "Telefone do Drugstore 1", "Drugstore");
        public static Location Airport1 = new Location(new Guid("28e10d25-2c59-473c-a488-c613c22c911f"), "Airport 1", "Endereço do Airport 1", "Telefone do Airport 1", "Airport");

        public static EmergencyLocation Hospital1 = new EmergencyLocation(new Guid("c9160a54-9413-4e49-b8cf-bc05193614d1"), "Hospital 1", "Endereço do Hospital 1", "Telefone do Hospital 1", "Hospital");
        public static EmergencyLocation PD1 = new EmergencyLocation(new Guid("e10aa35a-d046-4f0e-95c6-ae8bc1bf7e9e"), "PD 1", "Endereço do PD 1", "Telefone do PD 1", "PD");
        public static EmergencyLocation Firemen1 = new EmergencyLocation(new Guid("ccdcec19-aa4c-4f00-bddb-b6345f6f0151"), "Firemen 1", "Endereço do Firemen 1", "Telefone do Firemen 1", "Firemen");


        public static List<Location> GetAllLocations()
        {
            List<Location> locations = new List<Location>();
            locations.Add(Park1);
            locations.Add(Hotel1);
            locations.Add(Restaurant1);
            locations.Add(Event1);
            locations.Add(Pub1);
            locations.Add(Subway1);
            locations.Add(Mall1);
            locations.Add(Drugstore1);
            locations.Add(Airport1);
            return locations;
        }

        public static List<EmergencyLocation> GetAllEmergencyLocations()
        {
            List<EmergencyLocation> emergencyLocations = new List<EmergencyLocation>();
            emergencyLocations.Add(Hospital1);
            emergencyLocations.Add(PD1);
            emergencyLocations.Add(Firemen1);
            return emergencyLocations; 
        }

        public static Location GetLocationById(Guid id)
        {
            return GetAllLocations().FirstOrDefault(x => x.Id == id);
        }

        public static EmergencyLocation GetEmergencyLocationById(Guid id)
        {
            return GetAllEmergencyLocations().FirstOrDefault(x => x.Id == id);
        }
    }
}
