using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanetsAPI.Data
{
    public class PlanetContext : DbContext
    {
        public PlanetContext(DbContextOptions<PlanetContext> options)
            : base(options)
        { }

        public DbSet<Planet> Planets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Planet>().ToTable("Planet");
        }
    }

    public class Planet
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Distance { get; set; }
        [Required]
        public string Mass { get; set; }
        [Required]
        public string Diameter { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Link { get; set; }
    }
}
