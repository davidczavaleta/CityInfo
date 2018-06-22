using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore(); 

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Oaxaca de Juárez",
                    Description = "Ciudad capital",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1, 
                            Name = "Templo de Santo Domingo", 
                            Description = "Templo famoso por su altar bañado en oro"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2, 
                            Name = "Museo del palacio", 
                            Description = "Museo dedicado a la tecnología, en el zócalo de la capital"
                        }
                    }
                },

                new CityDto()
                {
                    Id  = 2,
                    Name = "Mitla",
                    Description = "Tierra de los muertos", 
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1, 
                            Name ="Zona Arqueológica", 
                            Description ="Zona arqueológica preshipánica desarrollada por la cultura mixteca y zapoteca"
                        }, 
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name ="Iglesia Local", 
                            Description ="Iglesia católica con la particularidad de estar construida sobre las ruinas de un templo prehispánico, mezclando dos culturas y formas de construir"
                        }
                    }
                },

                new CityDto()
                {
                    Id = 3,
                    Name = "Huatulco",
                    Description = "Las mejores bahias", 
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1, 
                            Name ="La entrega", 
                            Description = "Bahía famosa por ser el lugar donde entregaron a Vicente Guerrero"
                        }
                    }
                }
            };
        }
    }
}
