using System.Collections.Generic;
using System.Linq;

namespace VR_Vacation.DataAccess
{
    public class VacationInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<VacationContext>
    {
        protected override void Seed(VacationContext context)
        {
            var destinations = new List<Destination>
            {
                new Destination
                {
                    Name = "Iceland",
                    Description = "Nordic island country in the North Atlantic." +
                    "The capital and largest city is Reykjavík, with Reykjavík and the surrounding areas in " +
                    "the southwest of the country being home to over two-thirds of the population. Iceland is " +
                    "volcanically and geologically active. The interior consists of a plateau characterised by " +
                    "sand and lava fields, mountains, and glaciers, and many glacial rivers flow to the sea " +
                    "through the lowlands. Iceland is warmed by the Gulf Stream and has a temperate climate, " +
                    "despite a high latitude just outside the Arctic Circle. Its high latitude and marine influence" +
                    " keep summers chilly, with most of the archipelago having a tundra climate",
                    ImagePath = "https://42j2u214fxk4e2pss1rw1xf1-wpengine.netdna-ssl.com/wp-content/uploads/2018/03/IcelandTravel-akranes-768x512.jpg"
                },
                new Destination
                {
                    Name = "Tahiti" ,
                    Description = "Tahiti is the largest island in the Windward group of French Polynesia. " +
                                  "The island is located in the archipelago of the Society Islands in the central " +
                                  "Southern Pacific Ocean, and is divided into two parts: the bigger, northwestern part," +
                                  " Tahiti Nui, and the smaller, southeastern part, Tahiti Iti. The island was formed from " +
                                  "volcanic activity and is high and mountainous with surrounding coral reefs.The population " +
                                  "is 189,517 inhabitants(2017 census), making it the most populous island of French Polynesia " +
                                  "and accounting for 68.7 % of its total population.",
                    ImagePath = "https://www.tahitilegends.com/images/territories/tahiti.jpg"
                }
            };

            destinations.ForEach(d => context.Destinations.Add(d));
            context.SaveChanges();

            var packages = new List<Package>
            {
                new Package
                {
                    Name = "Glorious Glaciers and Northern Lights", Description =
                        "Winter in Iceland is hard to beat for magical landscape. From icy lava fields to " +
                        "partially frozen waterfalls, Iceland is stunningly beautiful in its winter clothing. Spouting geysers, soaring waterfalls, black sand beaches," +
                        " ice lagoons and the chance to search for the Northern Lights are some of the many natural wonders you can expect on the Glorious Glaciers and " +
                        "Northern Lights road trip.",
                    Price = 2300.00,
                    ImagePath =
                        "https://42j2u214fxk4e2pss1rw1xf1-wpengine.netdna-ssl.com/wp-content/uploads/2018/07/Jokuls%C3%A1rlon-768x510.jpg",
                    Destination = destinations.FirstOrDefault(x => x.Id == 1)
                },
                new Package
                {
                    Name = "Nature’s Treasures and Northern Lights", Description =
                        "Experience West Iceland’s rich history and mystical landscape on the great Nature’s" +
                        " Treasures and Northern Lights guided tour.",
                    Price = 2000.00,
                    ImagePath =
                        "https://42j2u214fxk4e2pss1rw1xf1-wpengine.netdna-ssl.com/wp-content/uploads/2018/03/glacial-lagoon-and-south-shore-4-768x513.jpg",
                    Destination = destinations.FirstOrDefault(x => x.Id == 1)
                },
                new Package
                {
                    Name = "Reykjavik and Golden Circle Road Trip", Description =
                        "Looking for a budget friendly short getaway in Iceland? This great value tour" +
                        " will allow you to explore the two most popular areas in Iceland – Reykjavík the capital of Iceland and the famous Golden Circle in just" +
                        " 4 days.",
                    Price = 1500.00,
                    ImagePath =
                        "https://42j2u214fxk4e2pss1rw1xf1-wpengine.netdna-ssl.com/wp-content/uploads/2018/04/golden-circle-and-glacier-10-768x509.jpg",
                    Destination = destinations.FirstOrDefault(x => x.Id == 1)
                },
                new Package
                {
                    Name = "Dive & Cruise in Fakarava", Description =
                        "Cruising aboard the Aqua Tiki II is perfect for divers (and non-divers) who wish to enjoy" +
                        " preserved and secluded atolls.",
                    Price = 1700.00,
                    ImagePath =
                        "https://www.telegraph.co.uk/content/dam/Travel/leadAssets/32/70/tahiti-bora_3270899a.jpg?imwidth=450",
                    Destination = destinations.FirstOrDefault(x => x.Id == 2)
                },
                new Package
                {
                    Name = "Bora Bora and Taha'a",
                    Description =
                        "This 9-day island escape takes you to premium resorts on the islands of Bora Bora and Taha'a.",
                    Price = 1800.00,
                    ImagePath = "https://lonelyplanetwpnews.imgix.net/2018/02/GettyRF_177387658-e1518014145130.jpg",
                    Destination = destinations.FirstOrDefault(x => x.Id == 2)
                },
                new Package
                {
                    Name = "Island Hopper",
                    Description =
                        "This 12-day vacation takes you to Moorea, Bora Bora, and Tahiti in the islands of French Polynesia.",
                    Price = 2300.00, ImagePath = "https://www.tahitilegends.com/images/about_us.jpg",
                    Destination = destinations.FirstOrDefault(x => x.Id == 2)
                }
            };

            packages.ForEach(p => context.Packages.Add(p));
            context.SaveChanges();

            var experiences = new List<Experience>
            {
                new Experience
                {
                    Name = "Borgarfjordur hike", Description = "Head to scenic Borgarfjordur via the Hvalfjordur tunnel. " +
                     "If you don’t want to take the tunnel, you can take the scenic coastal road instead (adds additional 17 " +
                     "km/10 miles to trip). Drive through the town of Borgarnes where you can learn about the first Viking settlers" +
                     " in the area at the popular Settlement Museum. Visit Deildartunguhver, Europe’s most powerful hot spring, as well" +
                     " as two beautiful waterfalls, Hraunfossar (the Lava Falls) and Barnafoss (the Children´s Falls).  Near Deildartunguhver" +
                     " you can indulge in hot spring relaxation at the new Krauma natural geothermal spa.",
                    Price = 220.00, ImagePath = "https://42j2u214fxk4e2pss1rw1xf1-wpengine.netdna-ssl.com/wp-content/uploads/2018/03/Skogafoss-15-768x606.jpg", Package = packages.FirstOrDefault(x => x.Id == 1)
                },
                new Experience
                {
                    Name = "Waterfalls, Black sand beaches, Stone Arches", Description = "'Travel along the south coast, one of Iceland’s main" +
                    " farming areas. You will see many farms and shaggy herds of Icelandic horses as you head along the Ring Road. See the " +
                    "magnificent waterfall Skogarfoss, site of hidden treasure. Nearby is Skogar Folk Museum, well known throughout Iceland for" +
                    " being the best of its kind with a collection of mementos from this region’s past housed in beautifully-preserved old turf-" +
                    "roofed buildings.'",
                    Price = 150.00, ImagePath = "https://42j2u214fxk4e2pss1rw1xf1-wpengine.netdna-ssl.com/wp-content/uploads/2018/03/Seljalandsdoss-768x513.jpg", Package = packages.FirstOrDefault(x => x.Id == 1)
                },
                new Experience
                {
                    Name = "Vatnajokull National Park", Description = "Visit the park‘s majestic Skaftafell area, which is located between " +
                     "two glaciers and offers several winter hiking possibilities. Continue to Jokulsarlon Glacial Lagoon, where blue, white, " +
                     "turquoise and black-streaked icebergs shift and dance. The mystical lagoon is enormous and has been the backdrop for many" +
                     " major feature films and programs, including Game of Thrones. It is a special place for photographers who enjoy the " +
                     "challenge of catching the icebergs in just the right light conditions. Don’t forget to keep an eye out for seals resting amid the glaciers.",
                    Price = 200.00, ImagePath = "https://42j2u214fxk4e2pss1rw1xf1-wpengine.netdna-ssl.com/wp-content/uploads/2018/07/vik-768x512.jpg", Package = packages.FirstOrDefault(x => x.Id == 1)
                },
                new Experience
                {
                    Name = "'Stykkisholmur - Snaefellsnes '", Description = "Here you´ll embark on an adventurous sail in Breidafjordur Bay " +
                    "(UNESCO nominee) to encounter thousands of tiny islands and experience “Viking Sushi,” a sampling of sea scallops, urchin, " +
                    "and crab drawn onto the boat straight from the pristine Icelandic waters.",
                    Price = 180.00, ImagePath = "https://42j2u214fxk4e2pss1rw1xf1-wpengine.netdna-ssl.com/wp-content/uploads/2018/07/Reynisdrangar-3-768x513.jpg", Package = packages.FirstOrDefault(x => x.Id == 2)
                },
                new Experience
                {
                    Name = "'Thingvellir National Park'", Description = "Iceland’s Golden Circle showcases a trio of celebrated natural " +
                     "attractions, including the dramatic Gullfoss waterfall and the geothermal fields of Geysir Hot Spring Area,  alive with" +
                     " boiling mud pits, steam vents, and exploding geysers.",
                    Price = 210.00, ImagePath = "https://42j2u214fxk4e2pss1rw1xf1-wpengine.netdna-ssl.com/wp-content/uploads/2018/04/Shutterstock-myvatn-768x512.jpg",  Package = packages.FirstOrDefault(x => x.Id == 2)
                },
                new Experience
                {
                    Name = "'Reykholt - Borgarnes'", Description = "Discover first-hand the colourful capital of Reykjavik with a short " +
                      "sightseeing tour.  Catch the city’s energetic vibe when you glimpse stunning Harpa Concert Hall and enjoy the fascinating" +
                      " architectural design of Hallgrimskirkja church.  You’ll also visit the fascinating Aurora Northern Lights Centre for an" +
                      " exciting and informative presentation on the Northern Lights.",
                    Price = 1590.00, ImagePath = "https://42j2u214fxk4e2pss1rw1xf1-wpengine.netdna-ssl.com/wp-content/uploads/2018/04/Shutterstock-Siglufjordur-768x507.jpg", Package = packages.FirstOrDefault(x => x.Id == 2)
                },
                new Experience
                {
                    Name = "Laugarvatn Geothermal Area", Description = "Today you’ll drive north out of Reykjavík, via the small suburbian town" +
                      " Mosfellsbaer and drive to Thingvellir National Park, a UNESCO Heritage Site. Thingvellir National Park is of great " +
                      "ecological, geological and historical interest. The park itself is situated in a stunning volcanic landscape of mountains" +
                      " and lava flows, on the border of Iceland’s largest lake. Surrounding the lake are impressive faults and gorges that are" +
                      " considered among the world’s finest examples of the results of tectonic movements. It is the area where the tectonic" +
                      " plates of Europe and America meet, and one can literally see the ridge between the continents. This is also the former" +
                      " site of the oldest parliament in Europe, Althingi. It was founded in Thingvellir in 930 and there most of the greatest" +
                      " moments of Icelandic history took place over a period of 750 years. In the 18th century a major earthquake took place" +
                      " at this location, after which the parliament was transferred to Reykjavík.",
                    Price = 130.00, ImagePath = "https://42j2u214fxk4e2pss1rw1xf1-wpengine.netdna-ssl.com/wp-content/uploads/2018/07/Jokuls%C3%A1rlon-768x510.jpg",  Package = packages.FirstOrDefault(x => x.Id == 3)
                },                new Experience
                {
                    Name = "Gullfoss, Geysir and Reykjavik", Description = "Continue your tour to the beautiful Gullfoss and Geysir region. " +
                      "The first stop of the day will be at Geysir hot spring area. It is a colorful geothermal field in a 3 km2 (1.2 mi2) " +
                      "area where hot springs and geysers are abundant. The Geysir spouting spring is the world’s largest geyser—its name is " +
                      "the generic term for this strange phenomenon. Geysir, believed to have formed in the thirteenth century, has a bowl 18 m" +
                      " (59 ft) in diameter with a 20 m deep chamber below. Its eruptions are majestic and since the big earthquakes in 2000 it " +
                      "has erupted several times. A smaller, adjacent hot spouting spring, Strokkur, is a popular attraction, erupting regularly " +
                      "at intervals of five to ten minutes. The whole area contains a variety of hot springs and bubbling pools.",
                    Price = 170.00, ImagePath = "https://42j2u214fxk4e2pss1rw1xf1-wpengine.netdna-ssl.com/wp-content/uploads/2018/02/file-700-768x512.jpg",  Package = packages.FirstOrDefault(x => x.Id == 3)
                },
                new Experience
                {
                    Name = "Tahiti Dolphin Watch Tour", Description = "Who never dreamt approching a dolphin ? TOPDIVE allows you to make your wish a reality.﻿ " +
                     "Throughout the year, come to approach and watch dolphins playing near the passes of Tahiti. Live for a few moment with these magnificent " +
                     "and friendly mammal that just waiting to amaze you.",
                    Price = 150.00, ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSJLqH9wP2ReFoSRBqO1mMDjLoX1br3TAYK-35hr2tsIwRVQHxM",  Package = packages.FirstOrDefault(x => x.Id == 4)
                },
                new Experience
                {
                    Name = "Tahiti Whales Watching", Description = "Every year, from August to October, Polynesian waters welcome many humpback whales" +
                                                                   " (Megaptera novaeangliae) coming to mate and give birth before returning to the South pole.",
                    Price = 185.00, ImagePath = "https://2.img-dpreview.com/files/p/TS600x450~sample_galleries/0409644564/0995333892.jpg", Package = packages.FirstOrDefault(x => x.Id == 4)
                },
                new Experience
                {
                    Name = "Jet ski lagoon tour in Tahiti", Description = "The pleasure of cruising on the beautiful lagoon of Tahiti with its shades of blue." +
                    " An unforgettable experience with different stops at points of interest on the lagoon: East and West coast , the aquarium, the observation of " +
                    "dolphins, the port of Papeete, Motu Martin (islet), of course, stops to take a dip...",
                    Price = 190.00, ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRbD0sHRWY6PBuaBn8lkYi7tiq-xdnGEKba_lmXLaUwWWIScJr5",  Package = packages.FirstOrDefault(x => x.Id == 4)
                },
                new Experience
                {
                    Name = "Tahiti 4WD Safari", Description = "4WD Excursion - 130 kms including 60 kms of track, a full or half day in the heart of Tahiti island," +
                      " the visit of the crater will bring you back in the past. Water collecting, several waterfalls where you can swim, archeologic spots, tropical flora," +
                      " basaltic rocks, river ford, several stops will be done and the polynesian guides will be happy to talk about their island and tell you stories about " +
                      "Tahitian legends. Breathless experience guarantee !",
                    Price = 155.00, ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTK8--gaiKz7Ulnprls064coDPtCu3pr_-GUI1xk6QlFnlOyKC_",  Package = packages.FirstOrDefault(x => x.Id == 5)
                },
                new Experience
                {
                    Name = "Tahiti circle island Tour", Description = "Discover highlight points of Tahiti, her History and culture during this half day guided tour﻿. " +
                    "Discover Tahiti with this circle island tour (4hrs) that will let you visit its main attractions. You will discover the authenticity and the cultural" +
                    " richness or this island. ",
                    Price = 215.00, ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRHLDbmi9GoWIK1NCfu9ENIATyr9jafZne1MCzb3Lq7bpdbRPiV", Package = packages.FirstOrDefault(x => x.Id == 5)
                },
                new Experience
                {
                    Name = "Scuba diving in Tahiti", Description = "5 stars Padi diving center based at the InterContinental Tahiti Resort (Aqualung center)." +
                     " They propose you 7/7 days the discovery of the ocean floor of Tahiti island! Diving with sharks, turtles and flotsam.... From leisure " +
                     "diving to specialised trainings, TOPDIVE will insure you great comfort, security and services.",
                    Price = 180.00, ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRHLDbmi9GoWIK1NCfu9ENIATyr9jafZne1MCzb3Lq7bpdbRPiV",  Package = packages.FirstOrDefault(x => x.Id == 5)
                },
                new Experience
                {
                    Name = "Big Game Fishing", Description = "For all passionate fishermen, experience an intense fishing daytrip aboard a very comfortable " +
                                                             "boat specially equipped for all kinds of fishing technics : trolling, casting…",
                    Price = 190.00, ImagePath = "https://tahiti-tours.com/wp-content/uploads/sites/4/2018/02/billabong-tahiti-3.jpg", Package = packages.FirstOrDefault(x => x.Id == 6)
                },
                new Experience
                {
                    Name = "Exotic Tahiti", Description = "Spend 3 days exploring French Polynesia’s most famous island. An included half day tour takes you to " +
                    "James Norman Hall Museum, Tahara’a view point, Arahoho Blow Hole, Vaipahi Gardens, the Mara’a Fern Grottoes and the museum of Tahiti and Her " +
                    "Islands. Spend your free time snorkeling the island’s reefs, relaxing on the beach or exploring this fascinating Pacific culture",
                    Price = 350.00, ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNb3tjEzn9t1ggIcuTrFYbDouU1pMhC5_XEvxxQNDABBNbPcZm", Package = packages.FirstOrDefault(x => x.Id == 6)
                },
                new Experience
                {
                    Name = "Papeete: Le Meridien Tahiti", Description = "Located 10 minutes from the airport and 15 minutes from downtown, this completely" +
                     " renovated 41/2 star resort offers 138 rooms and suites as well as 12 polynesian styled overwater bungalows.",
                    Price = 330.00, ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS7MnKFUnoYpceBt-CSDi689vMNELwf6kTvMNyqP983YY_dJ2s", Package = packages.FirstOrDefault(x => x.Id == 6)
                }

            };

            experiences.ForEach(e => context.Experiences.Add(e));
            context.SaveChanges();

            var users = new List<User>
            {
                new User
                {
                    Username = "test",Password = "test",Firstname = "Tester",Lastname = "Testersson",
                    EmailAddress = "test@test.com", PhoneNumber = "111-111", Address = "Test",
                }
            };

            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();

            var orders = new List<Order>
            {
                new Order
                {
                    Total = 2600.00, UserId = 1
                }
            };

            orders.ForEach(o => context.Orders.Add(o));
            context.SaveChanges();
        }
    }
}