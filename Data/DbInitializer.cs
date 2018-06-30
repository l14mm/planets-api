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
            if (context.Planets.Any())
            {
                return;   // DB has been seeded
            }

            var planets = new Planet[]
            {
                new Planet{Name="Mercury",Image="http://planetary.s3.amazonaws.com/assets/images/thumbnail/20170713_mercury-fb-thumb_t233.jpg",Distance="57.91 million km",Mass="3.285 × 10^23 kg",Diameter="4,880 km",
                Link="https://en.wikipedia.org/wiki/Mercury_(planet)",Description="Mercury is the smallest and innermost planet in the Solar System. Its orbital period around the Sun of 87.97 days is the shortest of all the planets in the Solar System. It is named after the Roman deity Mercury, the messenger of the gods."},
                new Planet{Name="Venus",Image="https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Venus-real_color.jpg/260px-Venus-real_color.jpg",Distance="108.2 million km",Mass="4.867 × 10^24 kg",Diameter="12,104 km",
                Link="https://en.wikipedia.org/wiki/Venus",Description="Venus is the second planet from the Sun, orbiting it every 224.7 Earth days.[12] It has the longest rotation period (243 days) of any planet in the Solar System and rotates in the opposite direction to most other planets (meaning the Sun would rise in the west and set in the east).[13] It does not have any natural satellites. It is named after the Roman goddess of love and beauty. It is the second-brightest natural object in the night sky after the Moon, reaching an apparent magnitude of −4.6 – bright enough to cast shadows at night and, rarely, visible to the naked eye in broad daylight.[14][15] Orbiting within Earth's orbit, Venus is an inferior planet and never appears to venture far from the Sun; its maximum angular distance from the Sun (elongation) is 47.8°."},
                new Planet{Name="Earth",Image="https://3c1703fe8d.site.internapcdn.net/newman/gfx/news/hires/2014/whatpercento.jpg",Distance="149.6 million km",Mass="5.972 × 10^24 kg",Diameter="12,742 km",
                Link="https://en.wikipedia.org/wiki/Earth",Description="Earth is the third planet from the Sun and the only astronomical object known to harbor life. According to radiometric dating and other sources of evidence, Earth formed over 4.5 billion years ago.[24][25][26] Earth's gravity interacts with other objects in space, especially the Sun and the Moon, Earth's only natural satellite. Earth revolves around the Sun in 365.26 days, a period known as an Earth year. During this time, Earth rotates about its axis about 366.26 times."},
                new Planet{Name="Mars",Image="https://s.hswstatic.com/gif/mars-a1.jpg",Distance="227.9 million km",Mass="6.39 × 10^23 kg",Diameter="6,780 km",
                Link="https://en.wikipedia.org/wiki/Mars",Description="Mars is the fourth planet from the Sun and the second-smallest planet in the Solar System after Mercury. In English, Mars carries a name of the Roman god of war, and is often referred to as the 'Red Planet'[14][15] because the reddish iron oxide prevalent on its surface gives it a reddish appearance that is distinctive among the astronomical bodies visible to the naked eye.[16] Mars is a terrestrial planet with a thin atmosphere, having surface features reminiscent both of the impact craters of the Moon and the valleys, deserts, and polar ice caps of Earth."},
                new Planet{Name="Jupiter",Image="https://upload.wikimedia.org/wikipedia/commons/thumb/2/2b/Jupiter_and_its_shrunken_Great_Red_Spot.jpg/330px-Jupiter_and_its_shrunken_Great_Red_Spot.jpg",Distance="778.5 million km",Mass="1.898 × 10^27 kg",Diameter="139,822 km",
                Link="https://en.wikipedia.org/wiki/Jupiter",Description="Jupiter is the fifth planet from the Sun and the largest in the Solar System. It is a giant planet with a mass one-thousandth that of the Sun, but two-and-a-half times that of all the other planets in the Solar System combined. Jupiter and Saturn are gas giants; the other two giant planets, Uranus and Neptune are ice giants. Jupiter has been known to astronomers since antiquity.[13] The Romans named it after their god Jupiter.[14] When viewed from Earth, Jupiter can reach an apparent magnitude of −2.94, bright enough for its reflected light to cast shadows,[15] and making it on average the third-brightest object in the night sky after the Moon and Venus."},
                new Planet{Name="Saturn",Image="https://news.nationalgeographic.com/content/dam/news/2016/12/05/saturn-cassini/01saturn-cassini.jpg",Distance="1.433 billion km",Mass="5.683 × 10^26 kg",Diameter="116,464 km",
                Link="https://en.wikipedia.org/wiki/Saturn",Description="Saturn is the sixth planet from the Sun and the second-largest in the Solar System, after Jupiter. It is a gas giant with an average radius about nine times that of Earth.[10][11] It has only one-eighth the average density of Earth, but with its larger volume Saturn is over 95 times more massive.[12][13][14] Saturn is named after the Roman god of agriculture; its astronomical symbol (♄) represents the god's sickle."},
                new Planet{Name="Uranus",Image="https://upload.wikimedia.org/wikipedia/commons/3/3d/Uranus2.jpg",Distance="2.871 billion km",Mass="8.681 × 10^25 kg",Diameter="50,724 km",
                Link="https://en.wikipedia.org/wiki/Uranus",Description="Uranus is the seventh planet from the Sun. It has the third-largest planetary radius and fourth-largest planetary mass in the Solar System. Uranus is similar in composition to Neptune, and both have different bulk chemical composition from that of the larger gas giants Jupiter and Saturn. For this reason, scientists often classify Uranus and Neptune as 'ice giants' to distinguish them from the gas giants. Uranus's atmosphere is similar to Jupiter's and Saturn's in its primary composition of hydrogen and helium, but it contains more 'ices' such as water, ammonia, and methane, along with traces of other hydrocarbons.[12] It is the coldest planetary atmosphere in the Solar System, with a minimum temperature of 49 K (−224 °C; −371 °F), and has a complex, layered cloud structure with water thought to make up the lowest clouds and methane the uppermost layer of clouds.[12] The interior of Uranus is mainly composed of ices and rock."},
                new Planet{Name="Neptune",Image="https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/Neptune_Full.jpg/275px-Neptune_Full.jpg",Distance="4.495 billion km",Mass="1.024 × 10^26 kg",Diameter="49,244 km",
                Link="https://en.wikipedia.org/wiki/Neptune",Description="Neptune is the eighth and farthest known planet from the Sun in the Solar System. In the Solar System, it is the fourth-largest planet by diameter, the third-most-massive planet, and the densest giant planet. Neptune is 17 times the mass of Earth and is slightly more massive than its near-twin Uranus, which is 15 times the mass of Earth and slightly larger than Neptune.[d] Neptune orbits the Sun once every 164.8 years at an average distance of 30.1 AU (4.5 billion km). It is named after the Roman god of the sea and has the astronomical symbol ♆, a stylised version of the god Neptune's trident."},
            };
            foreach (Planet p in planets)
            {
                context.Planets.Add(p);
            }
            context.SaveChanges();
        }
    }
}
