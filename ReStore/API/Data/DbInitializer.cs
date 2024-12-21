using API.Entities;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace API.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(StoreContext context, UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new User
                {
                    UserName = "bob",
                    Email = "bob@test.com"
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");

                var admin = new User
                {
                    UserName = "admin",
                    Email = "admin@test.com"
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] {"Member", "Admin"});
            }

            if (context.Products.Any()) return;

            var products = new List<Product>
            {
               new Product
                {
                    Name = "Pokemon Espada",
                    Description =
                        "Prepárate para descubrir Galar en Pokemon Espada, una extensa región con lugares de lo más variado: desde apacibles campos hasta modernas ciudades, pasando por un frondoso bosque y montañas nevadas. Los habitantes y Pokémon colaboran estrechamente para impulsar las industrias de la región. Elige a tu compañero Pokémon para comenzar la aventura, y atrapa, entrena e intercambia Pokémon para crear tu propio equipo y así hacer frente al desafío de los gimnasios. ¡Si perseveras, podrás obtener el título de Campeón!",
                    Price = 45000,
                    PictureURL = "/images/products/Pokémon_Espada.png",
                    Brand = "Nintendo",
                    Type = "Switch",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pokemon Escudo",
                    Description = "Prepárate para descubrir Galar en Pokemon Escudo, una extensa región con lugares de lo más variado: desde apacibles campos hasta modernas ciudades, pasando por un frondoso bosque y montañas nevadas. Los habitantes y Pokémon colaboran estrechamente para impulsar las industrias de la región. Elige a tu compañero Pokémon para comenzar la aventura, y atrapa, entrena e intercambia Pokémon para crear tu propio equipo y así hacer frente al desafío de los gimnasios. ¡Si perseveras, podrás obtener el título de Campeón!",
                    Price = 45000,
                    PictureURL = "/images/products/pokemon_escudo.png",
                    Brand = "Nintendo",
                    Type = "Switch",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pokemon Escarlata",
                    Description =
                        "Atrapa, combate y entrena Pokémon en la región de Paldea, una vasta tierra llena de lagos, cimas montañosas, páramos, poblaciones pequeñas y grandes ciudades. Explora un mundo completamente abierto a tu propio paso y recorre a través de la tierra, el agua y el aire a lomos del Pokémon legendario Koraidon, que puede cambiar de forma en Pokémon Escarlata, o sobre el Pokémon legendario Miraidon, que puede cambiar de forma en Pokémon Violet. Elige entre Sprigatito, Fuecoco o Quaxly para que sea tu primer compañero Pokémon antes de lanzarte en tu aventura a través de Paldea.",
                    Price = 96000,
                    PictureURL = "/images/products/Pokémon_Escarlata.png",
                    Brand = "Nintendo",
                    Type = "Switch",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pokemon Purpura",
                    Description =
                        "Atrapa, combate y entrena Pokémon en la región de Paldea, una vasta tierra llena de lagos, cimas montañosas, páramos, poblaciones pequeñas y grandes ciudades. Explora un mundo completamente abierto a tu propio paso y recorre a través de la tierra, el agua y el aire a lomos del Pokémon legendario Koraidon, que puede cambiar de forma en Pokémon Scarlet, o sobre el Pokémon legendario Miraidon, que puede cambiar de forma en Pokémon Purpura. Elige entre Sprigatito, Fuecoco o Quaxly para que sea tu primer compañero Pokémon antes de lanzarte en tu aventura a través de Paldea.",
                    Price = 96000,
                    PictureURL = "/images/products/pokemon-violet.png",
                    Brand = "Nintendo",
                    Type = "Switch",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Uncharted",
                    Description =
                        "Adéntrate en el peligroso viaje con el que se iniciaron las legendarias aventuras de Nathan Drake. Sal en busca del tesoro perdido de El Dorado con la ayuda de la intrépida periodista Elena Fisher y de Victor 'Sully' Sullivan, el mentor y amigo de Nathan.",
                    Price = 14000,
                    PictureURL = "/images/products/Uncharted.jpg",
                    Brand = "NaugthyDog",
                    Type = "Playstation 3",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Uncharted 2",
                    Description =
                        "Vuelve a ponerte en la piel del cazatesoros Nathan Drake en un relato lleno de situaciones de vida o muerte, ubicaciones exóticas y misiones de rescate heroicas. Descubre los secretos del desafortunado viaje de Marco Polo y el legendario reino de Shambhala en el Himalaya. Te cruzarás con viejos conocidos, además de con adversarios completamente nuevos, con un criminal de guerra fugitivo y letal en sus filas.",
                    Price = 24000,
                    PictureURL = "/images/products/Uncharted_2.jpg",
                    Brand = "NaugthyDog",
                    Type = "Playstation 3",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Uncharted 3",
                    Description =
                        "Parte hacia una aventura en busca de la mítica Atlántida de las arenas con la vuelta de Nathan Drake, el intrépido cazatesoros. Viaja desde las mezquinas calles de Londres hasta la península arábiga supera peligros y derrota a nuevos enemigos para sobrevivir. Vive la tercera entrega de la aclamada saga de aventuras que redefinió el género.",
                    Price = 34000,
                    PictureURL = "/images/products/Uncharted_3.jpg",
                    Brand = "NaugthyDog",
                    Type = "Playstation 3",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Uncharted 4",
                    Description =
                        "Tres años después de los eventos de  UNCHARTED 3: Drake’s Deception, se supone que Nathan Drake se retiró del mundo de los cazafortunas. Sin embargo, el destino no tarda en golpear su puerta cuando su hermano Sam reaparece en busca de ayuda para salvar su propia vida, una aventura demasiado tentadora e irresistible para Drake.",
                    Price = 60000,
                    PictureURL = "/images/products/Uncharted_4.jpg",
                    Brand = "NaugthyDog",
                    Type = "Playstation 4",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Mortal Kombat 9",
                    Description =
                        "El capítulo más nuevo de la icónica franquicia de lucha ya está disponible! Experimenta el torneo más mortífero con todos los combatientes y sus muertes únicas. Los jugadores ingresan al reino para enfrentarse a los Kombatants en Mortal Kombat Komplete Edition, que ofrece todo el contenido descargable (DLC), incluidos los intrépidos guerreros Skarlet, Kenshi y Rain, así como el notorio acosador de sueños Freddy Krueger. Además, el juego ofrece 15 aspectos Klassic Mortal Kombat y tres Klassic Fatalities (Scorpion, Sub-Zero y Reptile).",
                    Price = 15000,
                    PictureURL = "/images/products/Mortal_Kombat_9.jpg",
                    Brand = "NetherRealm Studios",
                    Type = "Xbox360",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Mortal Kombat XL",
                    Description =
                        "¿Quién es el siguiente? Disfruta de la nueva generación de la franquicia de lucha n.º 1. Mortal Kombat X reúne un aspecto cinematográfico y una mecánica de juego nunca vistos. Por primera vez, los jugadores pueden elegir múltiples variantes de cada personaje con impacto tanto en la estrategia como en el estilo de lucha.",
                    Price = 44000,
                    PictureURL = "/images/products/Mortal_Kombat_XL.jpg",
                    Brand = "NetherRealm Studios",
                    Type = "XboxONE",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Mortal Kombat 11 Ultimate",
                    Description =
                        "¡La experiencia definitiva de MK11! Toma el control de los protectores de la Tierra en las dos campañas temporales más aclamadas para impedir que Kronika haga retroceder el tiempo y reinicie la historia. Incluye el elenco kompleto de los 37 kombatientes, incluidos Rain, Mileena y Rambo.",
                    Price = 50000,
                    PictureURL = "/images/products/Mortal_Kombat_11.jpg",
                    Brand = "NetherRealm Studios",
                    Type = "XboxONE",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Mortal Kombat 1",
                    Description =
                        "¡Lo llevamos en la sangre!Descubre un nuevo universo de Mortal Kombat™ creado por Liu Kang, Dios del Fuego. Nuevos orígenesEl nuevo universo de Mortal Kombat 1, reflejo de la visión que tiene Liu Kang, Dios del Fuego, de la perfección, resulta familiar, pero, al mismo tiempo, está radicalmente alterado.",
                    Price = 66000,
                    PictureURL = "/images/products/Mortal_Kmobat_1.jpg",
                    Brand = "NetherRealm Studios",
                    Type = "XboxSeriesX",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Ultra Street Figther 4",
                    Description =
                        "El juego de lucha más grande del mundo ha evolucionado hasta un nuevo nivel con Ultra Street Fighter IV. Siguiendo con la tradición de excelencia de la famosa saga, en esta última entrega se han añadido cinco personajes nuevos y seis fases nuevas que ofrecen muchas más peleas, una mecánica de juego reequilibrada y modos originales.",
                    Price = 6000,
                    PictureURL = "/images/products/Street_Figther_4.jpg",
                    Brand = "Capcom",
                    Type = "Playstation 3",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Street Figther 5",
                    Description =
                        "¡Experimenta la intensidad de la batalla cara a cara en Street Fighter® V! Elige entre 16 personajes icónicos, cada uno con su propia historia personal y desafíos de entrenamiento únicos, y luego lucha contra amigos en línea o sin conexión con una sólida variedad de opciones para cada partida.",
                    Price = 26000,
                    PictureURL = "/images/products/Street_Figther_5.jpg",
                    Brand = "Capcom",
                    Type = "Playstation 4",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Street Figther 6",
                    Description =
                        "Un variado elenco de 18 luchadores Juega con maestros legendarios y nuevos favoritos de los fans como Ryu, Chun-Li, Luke, Jamie, Kimberly y muchos más. En esta última edición verás sus últimos y sorprendentes rediseños, además de sus cinemáticas especiales.",
                    Price = 50000,
                    PictureURL = "/images/products/Street_Fighter_6.jpg",
                    Brand = "Capcom",
                    Type = "Playstation 5",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Sonic Frontiers",
                    Description =
                        "Mundos chocan en la nueva aventura de alta velocidad de Sonic the Hedgehog! En busca de las esmeraldas del Caos perdidas, Sonic queda varado en una antigua isla repleta de criaturas inusuales. Lucha contra hordas de enemigos poderosos mientras exploras un impresionante mundo de acción, aventura y misterio. Acelera a nuevas alturas y experimenta la emoción de la libertad de plataformas de zona abierta y de alta velocidad mientras corres a través de las cinco enormes islas Starfall. Lánzate a la aventura, ejerce el poder de los Antiguos y lucha para detener a estos nuevos enemigos misteriosos. ¡Bienvenidos a la evolución de los juegos de Sonic!",
                    Price = 50000,
                    PictureURL = "/images/products/Sonic_Frontiers.jpg",
                    Brand = "Sega",
                    Type = "Switch",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Sonic Colors",
                    Description = "¡Únete a Sonic en la aventura de alta velocidad de tu vida! El malvado Dr. Eggman ha construido un gigantesco parque de diversiones interestelar repleto de atracciones increíbles y coloridas, pero lo impulsa con una raza alienígena capturada llamada Wisps. Usa la velocidad del rayo de Sonic para liberar a los Wisps y aprende los secretos de sus asombrosos poderes mientras exploras seis mundos coloridos y únicos, cada uno lleno de enemigos peligrosos y obstáculos que superar. Ahora, con impresionantes efectos visuales mejorados, características adicionales, nuevos modos de juego y jugabilidad mejorada, es la experiencia definitiva de Sonic Colors. Sonic será puesto a prueba en este emocionante viaje para liberar a los Wisps, pero con su ayuda y la tuya, ¡es una prueba que pasará con gran éxito!",
                    Price = 34000,
                    PictureURL = "/images/products/Sonic_Colors.jpg",
                    Brand = "Sega",
                    Type = "Switch",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Sonic Forces",
                    Description =
                        "Sonic Forces es el último juego de Sonic the Hedgehog que te permite crear un personaje personalizado con poderosos dispositivos, acelerar a través de paisajes en ruinas como Modern Sonic y catapultar plataformas peligrosas como Classic Sonic.¡Experimenta acción trepidante con estos tres estilos de juego únicos, explora escenarios icónicos y lucha en contenido adicional único con Shadow como personaje jugable!*",
                    Price = 34000,
                    PictureURL = "/images/products/Sonic_Forces.jpg",
                    Brand = "Sega",
                    Type = "Switch",
                    QuantityInStock = 100
                },
            };

            // context.Products.AddRange(products);

             foreach (var product in products)
             {
                 context.Products.Add(product);
             }

             context.SaveChanges();
        }
    }
}