using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprRosreestrMfc
    {
        public Guid Id { get; set; }
        public string DeclarantName { get; set; }
        public string Kladr { get; set; }
        public string PostalCode { get; set; }
        public string Region { get; set; }
        public string District { get; set; }
        public string DistrictType { get; set; }
        public string City { get; set; }
        public string CityType { get; set; }
        public string UrbanDistrict { get; set; }
        public string UrbanDistrictType { get; set; }
        public string SovietVillage { get; set; }
        public string SovietVillageType { get; set; }
        public string Locality { get; set; }
        public string LocalityType { get; set; }
        public string Street { get; set; }
        public string StreetType { get; set; }
        public string Level1 { get; set; }
        public string Level1Type { get; set; }
        public string Level2 { get; set; }
        public string Level2Type { get; set; }
        public string Level3 { get; set; }
        public string Level3Type { get; set; }
        public string Apartment { get; set; }
        public string ApartmentType { get; set; }
        public string Other { get; set; }
        public string Note { get; set; }
        public string Commentt { get; set; }
        public string DeclarantKind { get; set; }
    }
}
