using System;
using System.ComponentModel.DataAnnotations;

namespace DesafioSoftplan.Services.Dtos
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Area { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }
        public string OfficialLanguages { get; set; }
        public string Flag { get; set; }
        public double DemographicDensity { get; set; }
    }
}