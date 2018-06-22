using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CityInfoContext : DbContext 
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }

        public CityInfoContext(DbContextOptions<CityInfoContext> options) : base(options)
        {
            Database.Migrate(); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(
                new City
                {
                    Id = 1,
                    Name = "Mitla",
                    Description = "Tierra de los muertos"
                },
                new City
                {
                    Id = 2,
                    Name = "Oaxaca de Juárez",
                    Description = "Capital cultural de México"
                });

            modelBuilder.Entity<PointOfInterest>().HasData(
                new PointOfInterest
                {
                    Id = 1,
                    CityId = 1,
                    Name = "Zona Arquelógica",
                    Description = "Ruinas de las civilizaciones Mixteca y Zapoteca que habitaron el lugar."
                },
                new PointOfInterest
                {
                    Id = 2,
                    CityId = 1,
                    Name = "Casa de Fernando",
                    Description = "Antigua hacienda Gonzalez que pertenece a los caciques y terratenientes locales."
                },
                new PointOfInterest
                {
                    Id = 3,
                    CityId = 2,
                    Name = "Zocalo Capitalino",
                    Description = "Tradicional plaza en el corazón de la ciudad, rodeada de bellas calles del centro histórico."
                },
                new PointOfInterest
                {
                    Id = 4,
                    CityId = 2,
                    Name = "Templ de Santo Domingo",
                    Description = "Antiguo templo dominíco famoso por su retablo y altar bañados en oro."
                });
        }
    }
}
