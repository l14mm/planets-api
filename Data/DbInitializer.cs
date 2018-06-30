using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanetsAPI.Data
{
    public class DbInitializer
    {
        public static void Initialize(PlanetContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Planets.Local.Count >= 1)
            {
                return;   // DB has been seeded
            }

            var planets = new Planet[]
            {
                new Planet{Name="Mercury",Image="http://planetary.s3.amazonaws.com/assets/images/thumbnail/20170713_mercury-fb-thumb_t233.jpg",Distance="57.91 million km",Mass="3.285 × 10^23 kg",Diameter="4,880 km"},
                new Planet{Name="Venus",Image="https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Venus-real_color.jpg/260px-Venus-real_color.jpg",Distance="108.2 million km",Mass="4.867 × 10^24 kg",Diameter="12,104 km"},
                new Planet{Name="Earth",Image="https://3c1703fe8d.site.internapcdn.net/newman/gfx/news/hires/2014/whatpercento.jpg",Distance="149.6 million km",Mass="5.972 × 10^24 kg",Diameter="12,742 km"},
                new Planet{Name="Mars",Image="https://s.hswstatic.com/gif/mars-a1.jpg",Distance="227.9 million km",Mass="6.39 × 10^23 kg",Diameter="6,780 km"},
                new Planet{Name="Jupiter",Image="https://upload.wikimedia.org/wikipedia/commons/thumb/2/2b/Jupiter_and_its_shrunken_Great_Red_Spot.jpg/330px-Jupiter_and_its_shrunken_Great_Red_Spot.jpg",Distance="778.5 million km",Mass="1.898 × 10^27 kg",Diameter="139,822 km"},
                new Planet{Name="Saturn",Image="https://news.nationalgeographic.com/content/dam/news/2016/12/05/saturn-cassini/01saturn-cassini.jpg",Distance="1.433 billion km",Mass="5.683 × 10^26 kg",Diameter="116,464 km"},
                new Planet{Name="Uranus",Image="https://upload.wikimedia.org/wikipedia/commons/3/3d/Uranus2.jpg",Distance="2.871 billion km",Mass="8.681 × 10^25 kg",Diameter="50,724 km"},
                new Planet{Name="Neptune",Image="https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/Neptune_Full.jpg/275px-Neptune_Full.jpg",Distance="4.495 billion km",Mass="1.024 × 10^26 kg",Diameter="49,244 km"},
            };
            foreach (Planet p in planets)
            {
                context.Planets.Add(p);
            }
            context.SaveChanges();
        }
    }
}
