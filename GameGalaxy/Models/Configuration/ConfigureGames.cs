using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameGalaxy.Models
{
    internal class ConfigureGames : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> entity)
        {
            // Configure the Priamry key for the Game entity
            entity.HasKey(g => g.GameId);
            // Set ReleaseDate columns as Data type
            entity.Property(r => r.ReleaseDate).HasColumnType("date");
            entity.HasData(
                    new Game
                    {
                        GameId = 1,
                        Title = "Grand Theft Auto V",
                        Description = "Grand Theft Auto V is a vast open world game set in Los Santos, a sprawling sun-soaked metropolis struggling to stay afloat in an era of economic uncertainty and cheap reality TV. The game blends storytelling and gameplay in new ways as players repeatedly jump in and out of the lives of the game’s three lead characters, playing all sides of the game’s interwoven story.",
                        Developer = "Rockstar North",
                        Publisher = "Take-Two Interactive",
                        GenreId = 3,
                        ReleaseDate = new DateTime(2013, 9, 17),
                        Rating = 97,
                        Image = "grand_theft_auto_v.webp"
                    },
                    new Game
                    {
                        GameId = 2,
                        Title = "Horizon Zero Dawn",
                        Description = "In an era where machines roam the land and mankind is no longer the dominant species, a young hunter named Aloy embarks on a journey to discover her destiny. Explore a vibrant and lush world inhabited by mysterious mechanized creatures. Embark on a compelling, emotional journey and unravel mysteries of tribal societies, ancient artefacts and enhanced technologies that will determine the fate of this planet and of life itself.",
                        Developer = "Guerrilla Games",
                        Publisher = "Sony Interactive Entertainment",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2017, 2, 28),
                        Rating = 89,
                        Image = "horizon_zero_dawn.webp"
                    },
                    new Game
                    {
                        GameId = 3,
                        Title = "The Legend of Zelda: Breath of the Wild",
                        Description = "The Legend of Zelda: Breath of the Wild is the first 3D open-world game in the Zelda series. Link can travel anywhere and be equipped with weapons and armor found throughout the world to grant him various bonuses. Unlike many games in the series, Breath of the Wild does not impose a specific order in which quests or dungeons must be completed. While the game still has environmental obstacles such as weather effects, inhospitable lands, or powerful enemies, many of them can be overcome using the right method. A lot of critics ranked Breath of the Wild as one of the best video games of all time.",
                        Developer = "Nintendo",
                        Publisher = "Nintendo",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2017, 3, 3),
                        Rating = 97,
                        Image = "the_legend_of_zelda_breath_of_the_wild.webp"
                    },
                    new Game
                    {
                        GameId = 4,
                        Title = "Tekken 7",
                        Description = "Experience the epic conclusion of the Mishima clan and unravel the reasons behind each step of their ceaseless fight. Powered by Unreal Engine 4, Tekken 7 features stunning story-driven cinematic battles and intense duels that can be enjoyed with friends and rivals alike through innovative fight mechanics.",
                        Developer = "Bandai Namco Studios",
                        Publisher = "Bandai Namco Entertainment",
                        GenreId = 7,
                        ReleaseDate = new DateTime(2017, 6, 2),
                        Rating = 82,
                        Image = "tekken_7.webp"
                    },
                    new Game
                    {
                        GameId = 5,
                        Title = "Far Cry 5",
                        Description = "Welcome to Hope County, Montana, land of the free and the brave, but also home to a fanatical doomsday cult known as The Project at Eden’s Gate that is threatening the community's freedom. Stand up to the cult’s leader, Joseph Seed and the Heralds, and spark the fires of resistance that will liberate the besieged community. In this expansive world, your limits and creativity will be tested against the biggest and most ruthless baddest enemy Far Cry has ever seen. It’ll be wild and it’ll get weird, but as long as you keep your wits about you, the residents of Hope County can rest assured knowing you’re their beacon of hope.",
                        Developer = "Ubisoft Montreal",
                        Publisher = "Ubisoft Entertainment",
                        GenreId = 3,
                        ReleaseDate = new DateTime(2018, 3, 26),
                        Rating = 81,
                        Image = "far_cry_5.webp"
                    },
                    new Game
                    {
                        GameId = 6,
                        Title = "God Of War",
                        Description = "God of War is the sequel to God of War III as well as a continuation of the canon God of War chronology. Unlike previous installments, this game focuses on Norse mythology and follows an older and more seasoned Kratos and his son Atreus in the years since the third game. It is in this harsh, unforgiving world that he must fight to survive… and teach his son to do the same.",
                        Developer = "SUE Santa Monica Studio",
                        Publisher = "Sony Interactive Entertainment",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2018, 4, 20),
                        Rating = 94,
                        Image = "god_of_war.webp"
                    },
                    new Game
                    {
                        GameId = 7,
                        Title = "Marvel's Spider-Man Remastered",
                        Description = "Starring the world’s most iconic Super Hero, Spider-Man features the acrobatic abilities, improvisation and web-slinging that the wall-crawler is famous for, while also introducing elements never-before-seen in a Spider-Man game. From traversing with parkour and utilizing the environment, to new combat and blockbuster set pieces, it’s Spider-Man unlike any you’ve played before.",
                        Developer = "Insomniac Games",
                        Publisher = "Sony Interactive Entertainment",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2018, 9, 7),
                        Rating = 87,
                        Image = "marvel_spider_man_remastered.webp"
                    },
                    new Game
                    {
                        GameId = 8,
                        Title = "Forza Horizon 4",
                        Description = "Dynamic seasons change everything at the world’s greatest automotive festival. Go it alone or team up with others to explore beautiful and historic Britain in a shared open world. Collect, modify and drive over 450 cars. Race, stunt, create and explore – choose your own path to become a Horizon Superstar.",
                        Developer = "Playground Games",
                        Publisher = "Xbox Game Studios",
                        GenreId = 5,
                        ReleaseDate = new DateTime(2018, 10, 2),
                        Rating = 92,
                        Image = "forza_horizon_4.webp"
                    },
                    new Game
                    {
                        GameId = 9,
                        Title = "Red Dead Redemption 2",
                        Description = "Red Dead Redemption 2 is the epic tale of outlaw Arthur Morgan and the infamous Van der Linde gang, on the run across America at the dawn of the modern age.",
                        Developer = "Rockstar Games",
                        Publisher = "Take-Two Interactive",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2018, 10, 26),
                        Rating = 97,
                        Image = "red_dead_redemption_2.webp"
                    },
                    new Game
                    {
                        GameId = 10,
                        Title = "Pokémon Let's Go, Pikachu!",
                        Description = "Take your Pokémon journey to the Kanto region with your energetic partner, Pikachu, to become a top Pokémon Trainer as you battle other trainers. Use a throwing motion to catch Pokémon in the wild with either one Joy-Con controller or Poké Ball Plus accessory, which will light up, vibrate, and make sounds to bring your adventure to life. Share your adventure with family or friends in 2-player action on one system using a second Joy-Con or Poké Ball Plus (sold separately). You can even connect to the Pokémon GO app using a compatible smartphone to bring over Pokémon originally discovered in the Kanto region! Explore the diverse and vibrant region of Kanto! True-to-size wild Pokémon roam around in the game, so catch them like a real Pokémon Trainer by using motion, timing, and a well-placed Poké Ball. Go on a stroll with your favorite Pokémon in your Poké Ball Plus! Connect your game directly to Pokémon GO to receive Kanto region Pokémon.",
                        Developer = "Game Freak",
                        Publisher = "The Pokémon Company",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2018, 11, 16),
                        Rating = 79,
                        Image = "pokemon_lets_go_pikachu.webp"
                    },
                    new Game
                    {
                        GameId = 11,
                        Title = "Pokémon Let's Go, Eevee!",
                        Description = "Take your Pokémon journey to the Kanto region with your energetic partner, Eevee, to become a top Pokémon Trainer as you battle other trainers. Use a throwing motion to catch Pokémon in the wild with either one Joy-Con controller or Poké Ball Plus accessory, which will light up, vibrate, and make sounds to bring your adventure to life. Share your adventure with family or friends in 2-player action on one system using a second Joy-Con or Poké Ball Plus (sold separately). You can even connect to the Pokémon GO app using a compatible smartphone to bring over Pokémon originally discovered in the Kanto region! Explore the diverse and vibrant region of Kanto! True-to-size wild Pokémon roam around in the game, so catch them like a real Pokémon Trainer by using motion, timing, and a well-placed Poké Ball. Go on a stroll with your favorite Pokémon in your Poké Ball Plus! Connect your game directly to Pokémon GO to receive Kanto region Pokémon.",
                        Developer = "Game Freak",
                        Publisher = "The Pokémon Company",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2018, 11, 16),
                        Rating = 80,
                        Image = "pokemon_lets_go_eevee.webp"
                    },
                    new Game
                    {
                        GameId = 12,
                        Title = "Sekiro: Shadows Die Twice",
                        Description = "Enter a dark and brutal new gameplay experience from the creators of Bloodborne and the Dark Souls series. Sekiro: Shadows Die Twice is an intense, third-person, action-adventure set against the bloody backdrop of 14th-century Japan. Step into the role of a disgraced warrior brought back from the brink of death whose mission is to rescue his master and exact revenge on his arch nemesis. Take Revenge. Restore Your Honor. Kill Ingeniously.",
                        Developer = "FromSoftware",
                        Publisher = "Activision",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2019, 3, 22),
                        Rating = 90,
                        Image = "sekiro_shadows_die_twice.webp"
                    },
                    new Game
                    {
                        GameId = 13,
                        Title = "Outer Wild",
                        Description = "Outer Wilds is a critically-acclaimed and award-winning open world mystery about a solar system trapped in an endless time loop. The newest member of the space program in a small village on the planet Timber Hearth, the player navigates a space shuttle and travels across their solar system to get to the bottom of its mysteries by exploring the cosmos and gathering the knowledge hidden within each of the system's planets, left behind by another civilization in the distant past.",
                        Developer = "Mobius Digital",
                        Publisher = "Annapurna Interactive",
                        GenreId = 8,
                        ReleaseDate = new DateTime(2019, 5, 29),
                        Rating = 85,
                        Image = "outer_wilds.webp"
                    },
                    new Game
                    {
                        GameId = 14,
                        Title = "Call of Duty: Modern Warfare",
                        Description = "Prepare to go dark, Modern Warfare is back! The stakes have never been higher as players take on the role of lethal Tier One operators in a heart-racing saga that will affect the global balance of power. Call of Duty: Modern Warfare engulfs fans in an incredibly raw, gritty, provocative narrative that brings unrivaled intensity and shines a light on the changing nature of modern war. Players will be thrust into an immersive narrative spanning the entire game. Experience the ultimate online playground with classic multiplayer or squad-up and play cooperatively in a collection of elite operations, accessible to all skill levels.",
                        Developer = "Infinity Ward",
                        Publisher = "Activision",
                        GenreId = 3,
                        ReleaseDate = new DateTime(2019, 10, 25),
                        Rating = 80,
                        Image = "call_of_duty_modern_warfare.webp"
                    },
                    new Game
                    {
                        GameId = 15,
                        Title = "Death Stranding: Director's Cut",
                        Description = "From legendary game creator Hideo Kojima comes an all-new, genre-defying open world action adventure, starring Norman Reedus, Mads Mikkelsen, Léa Seydoux and Lindsay Wagner. In the near future, mysterious explosions have rocked the globe, setting off a series of supernatural events known as the Death Stranding. With otherworldly creatures plaguing the landscape, and mass extinction imminent, it’s up to Sam Porter Bridges to travel across the ravaged wasteland and save humanity from impending annihilation.",
                        Developer = "Kojima Productions",
                        Publisher = "Sony Interactive Entertainment",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2019, 11, 8),
                        Rating = 82,
                        Image = "death_stranding_directors_cut.webp"
                    },
                    new Game
                    {
                        GameId = 16,
                        Title = "Pokémon Sword",
                        Description = "Unsheathe your sword and take up your shield! The world of Pokémon expands to include the Galar region in Pokémon Sword and Pokémon Shield!",
                        Developer = "Game Freak",
                        Publisher = "The Pokémon Company",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2019, 11, 15),
                        Rating = 80,
                        Image = "pokemon_sword.webp"
                    },
                    new Game
                    {
                        GameId = 17,
                        Title = "Pokémon Shield",
                        Description = "Unsheathe your sword and take up your shield! The world of Pokémon expands to include the Galar region in Pokémon Sword and Pokémon Shield!",
                        Developer = "Game Freak",
                        Publisher = "The Pokémon Company",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2019, 11, 15),
                        Rating = 80,
                        Image = "pokemon_shield.webp"
                    },
                    new Game
                    {
                        GameId = 18,
                        Title = "Animal Crossing: New Horizons",
                        Description = "Escape to a deserted island and create your own paradise as you explore, create, and customize in Animal Crossing: New Horizons. Your island getaway has a wealth of natural resources that can be used to craft everything from tools to creature comforts. You can hunt down insects at the crack of dawn, decorate your paradise throughout the day, or enjoy sunset on the beach while fishing in the ocean. The time of day and season match real life, so each day on your island is a chance to check in and find new surprises all year round.",
                        Developer = "Nintendo",
                        Publisher = "Nintendo",
                        GenreId = 6,
                        ReleaseDate = new DateTime(2020, 3, 20),
                        Rating = 90,
                        Image = "animal_crossing_new_horizons.webp"
                    },
                    new Game
                    {
                        GameId = 19,
                        Title = "Ghost of Tsushima: Directors Cut",
                        Description = "Uncover the hidden wonders of Tsushima in this open-world action adventure. Forge a new path and wage an unconventional war for the freedom of Tsushima. Challenge opponents with your katana, master the bow to eliminate distant threats, develop stealth tactics to ambush enemies in order to win over the mongols.",
                        Developer = "Sucker Punch Productions",
                        Publisher = "Sony Interactive Entertainment",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2020, 7, 17),
                        Rating = 83,
                        Image = "ghost_of__tsushima_directors_cut.webp"
                    },
                    new Game
                    {
                        GameId = 20,
                        Title = "Microsoft Flight Simulator",
                        Description = "Microsoft Flight Simulator is the next generation of one of the most beloved simulation franchises. From light planes to wide-body jets, fly highly detailed and stunning aircraft in an incredibly realistic world. Create your flight plan and fly anywhere on the planet. Enjoy flying day or night and face realistic, challenging weather conditions.",
                        Developer = "Asobo Studio",
                        Publisher = "Xbox Game Studios",
                        GenreId = 6,
                        ReleaseDate = new DateTime(2020, 8, 17),
                        Rating = 91,
                        Image = "microsoft_flight_simulator.webp"
                    },
                    new Game
                    {
                        GameId = 21,
                        Title = "Assassin's Creed Valhalla",
                        Description = "In Assassin's Creed Valhalla, become Eivor, a legendary Viking raider on a quest for glory. Explore a dynamic and beautiful open world set against the brutal backdrop of England’s Dark Ages. Raid your enemies, grow your settlement, and build your political power in the quest to earn a place among the gods in Valhalla.",
                        Developer = "Ubisoft Montreal",
                        Publisher = "Ubisoft Entertainment",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2020, 11, 10),
                        Rating = 80,
                        Image = "assassins_creed_valhalla.webp"
                    },
                    new Game
                    {
                        GameId = 22,
                        Title = "Marvel's Spider-Man: Miles Morales",
                        Description = "The latest adventure in the Spider-Man universe will build on and expand ‘Marvel’s Spider-Man’ through an all-new story. Players will experience the rise of Miles Morales as he masters new powers to become his own Spider-Man.",
                        Developer = "Insomniac Games",
                        Publisher = "Sony Interactive Entertainment",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2020, 11, 12),
                        Rating = 85,
                        Image = "marvel_spider_man_miles_morales.webp"
                    },
                    new Game
                    {
                        GameId = 23,
                        Title = "Demon's Soul",
                        Description = "Entirely rebuilt from the ground up and masterfully enhanced, Demon's Souls is a remake of the 2009 release that introduces the horrors of a fog-laden, dark fantasy land to a whole new generation of gamers. Those who’ve faced its trials and tribulations before, can once again challenge the darkness in stunning visual quality with incredible performance. The remake features improved graphics and animations, sound and lighting tweaks and a reimagining of many of the visual, musical and mechanical aspects of the original game.",
                        Developer = "Bluepoint Games",
                        Publisher = "Sony Interactive Entertainment",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2020, 11, 12),
                        Rating = 92,
                        Image = "demons_souls.webp"
                    },
                    new Game
                    {
                        GameId = 24,
                        Title = "Call of Duty: Black Ops Cold War",
                        Description = "The iconic Black Ops series is back with Call of Duty: Black Ops Cold War - the direct sequel to the original and fan-favorite Call of Duty: Black Ops. Black Ops Cold War will drop fans into the depths of the Cold War’s volatile geopolitical battle of the early 1980s. Nothing is ever as it seems in a gripping single-player Campaign, where players will come face-to-face with historical figures and hard truths, as they battle around the globe through iconic locales like East Berlin, Vietnam, Turkey, Soviet KGB headquarters and more. Beyond the Campaign, players will bring a Cold War arsenal of weapons and equipment into the next generation of Multiplayer and Zombies experiences. Welcome to the brink. Welcome to Call of Duty: Black Ops Cold War.",
                        Developer = "Treyarch",
                        Publisher = "Activision",
                        GenreId = 3,
                        ReleaseDate = new DateTime(2020, 11, 13),
                        Rating = 76,
                        Image = "call_of_duty_black_ops_cold_war.webp"
                    },
                    new Game
                    {
                        GameId = 25,
                        Title = "Cyber Punk 2077",
                        Description = "Cyberpunk 2077 is an open-world, action-adventure story set in Night City, a megalopolis obsessed with power, glamour and body modification. You play as V, a mercenary outlaw going after a one-of-a-kind implant that is the key to immortality. You can customize your character’s cyberware, skillset and playstyle, and explore a vast city where the choices you make shape the story and the world around you.",
                        Developer = "CD Projekt RED",
                        Publisher = "CD Projekt",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2020, 12, 10),
                        Rating = 86,
                        Image = "cyberpunk_2077.webp"
                    },
                    new Game
                    {
                        GameId = 26,
                        Title = "It Takes Two",
                        Description = "Embark on the craziest journey of your life in It Takes Two, a genre-bending platform adventure created purely for co-op. Invite a friend to join for free with Friend’s Pass and work together across a huge variety of gleefully disruptive gameplay challenges. Play as the clashing couple Cody and May, two humans turned into dolls by a magic spell. Together, trapped in a fantastical world where the unpredictable hides around every corner, they are reluctantly challenged with saving their fractured relationship.",
                        Developer = "Hazelight Studios",
                        Publisher = "Electronic Arts",
                        GenreId = 9,
                        ReleaseDate = new DateTime(2021, 3, 26),
                        Rating = 88,
                        Image = "it_takes_two.webp"
                    },
                    new Game
                    {
                        GameId = 27,
                        Title = "Returnal",
                        Description = "Returnal is a 2021 roguelike third-person shooter video game developed by Housemarque and published by Sony Interactive Entertainment. It follows Selene Vassos, an astronaut who lands on the planet Atropos in search of the mysterious \"White Shadow\" signal and finds herself trapped in a time loop. After crash-landing on a shape-shifting alien planet, Selene finds herself fighting tooth and nail for survival. Every time she’s defeated, the player is forced to restart the journey.",
                        Developer = "Housemarque",
                        Publisher = "Sony Interactive Entertainment",
                        GenreId = 3,
                        ReleaseDate = new DateTime(2021, 4, 30),
                        Rating = 86,
                        Image = "returnal.webp"
                    },
                    new Game
                    {
                        GameId = 28,
                        Title = "Resident Evil Village",
                        Description = "Resident Evil Village is a first person survival horror and the sequel to Resident Evil 7: Biohazard. The game maintains elements from previous Resident Evil games with players having to scavenge environments for items and manage their resources. However, it adds more action-oriented gameplay, with higher enemy counts and a greater emphasis on combat.",
                        Developer = "Capcom",
                        Publisher = "Capcom",
                        GenreId = 3,
                        ReleaseDate = new DateTime(2021, 5, 7),
                        Rating = 84,
                        Image = "resident_evil_village.webp"
                    },
                    new Game
                    {
                        GameId = 29,
                        Title = "Ratchet & Clank: Rift Apart",
                        Description = "Go dimension-hopping with Ratchet and Clank as they take on an evil emperor from another reality. Jump between action-packed worlds and beyond at mind-blowing speeds, complete with dazzling visuals and an insane arsenal.",
                        Developer = "Insomniac Games",
                        Publisher = "Sony Interactive Entertainment",
                        GenreId = 3,
                        ReleaseDate = new DateTime(2021, 6, 11),
                        Rating = 88,
                        Image = "ratchet_and_clank_rift_apart.webp"
                    },
                    new Game
                    {
                        GameId = 30,
                        Title = "Deathloop",
                        Description = "Deathloop transports players to the lawless island of Blackreef in an eternal struggle between two extraordinary assassins. Explore stunning environments and meticulously designed levels in an immersive gameplay experience that lets you approach every situation any way you like. Hunt down targets all over the island in an effort to put an end to the cycle once and for all, and remember, if at first you don’t succeed… die, die again.",
                        Developer = "Arkane Studios",
                        Publisher = "Bethesda Softworks",
                        GenreId = 6,
                        ReleaseDate = new DateTime(2021, 9, 14),
                        Rating = 88,
                        Image = "deathloop.webp"
                    },
                    new Game
                    {
                        GameId = 31,
                        Title = "Far Cry 6",
                        Description = "Dive into the gritty world of a modern-day guerrilla revolution to liberate a nation from its oppressive dictators. Welcome to Yara, a tropical paradise frozen in time. Far Cry 6 thrusts players into a modern-day guerrilla revolution. As dictator of Yara, Anton Castillo is intent on restoring his nation back to its former glory by any means, with his son, Diego, following in his bloody footsteps. Become a guerrilla fighter and liberate Yara.",
                        Developer = "Ubisoft Toronto",
                        Publisher = "Ubisoft Entertainment",
                        GenreId = 3,
                        ReleaseDate = new DateTime(2021, 10, 7),
                        Rating = 73,
                        Image = "far_cry_6.webp"
                    },
                    new Game
                    {
                        GameId = 32,
                        Title = "Unpacking",
                        Description = "Unpacking is a zen puzzle game about the familiar experience of pulling possessions out of boxes and fitting them into a new home. Part block-fitting puzzle, part home decoration, you are invited to create a satisfying living space while learning clues about the life you’re unpacking. Over the course of eight house moves, you are given a chance to experience a sense of intimacy with a character you never see and a story you’re never told.",
                        Developer = "Witch Beam",
                        Publisher = "Humble Games",
                        GenreId = 9,
                        ReleaseDate = new DateTime(2021, 11, 2),
                        Rating = 83,
                        Image = "unpacking.webp"
                    },
                    new Game
                    {
                        GameId = 33,
                        Title = "Forza Horizon 5",
                        Description = "Your Ultimate Horizon Adventure awaits! Explore the vibrant and ever-evolving open-world landscapes of Mexico with limitless, fun driving action in hundreds of the world’s greatest cars.",
                        Developer = "Playground Games",
                        Publisher = "Xbox Game Studios",
                        GenreId = 5,
                        ReleaseDate = new DateTime(2021, 11, 9),
                        Rating = 92,
                        Image = "forza_horizon_5.webp"
                    },
                    new Game
                    {
                        GameId = 34,
                        Title = "Pokémon Brilliant Diamond",
                        Description = "Revisit the Sinnoh region and the story of the Pokémon Diamond Version game. Experience the nostalgic story from the Pokémon Diamond Version game in a reimagined adventure, Pokémon Brilliant Diamond, now on the Nintendo Switch system! Adventures in the Pokémon Brilliant Diamond game will take place in the familiar Sinnoh region. Rich in nature and with mighty Mount Coronet at its heart, Sinnoh is a land of many myths passed down through the ages. You’ll choose either Turtwig, Chimchar, or Piplup to be your first partner Pokémon and then set off on your journey to become the Champion of the Pokémon League. Along the way, you’ll be able to encounter the Legendary Pokémon Dialga. Adventure together with the Pokémon that appeared in the Pokémon Diamond Version game. Players of the original games can revisit familiar places and relive familiar scenes, while first time players can enjoy plenty of fun encounters and surprises that the Sinnoh region has to offer. The original story and the scale of the Sinnoh region’s towns and routes have been faithfully reproduced. This remake has also been revitalized with some of the player-friendly features of modern Pokémon games and up-close-and-personal Pokémon battle scenes. Whether you played Pokémon Diamond Version or Pokémon Pearl Version back in the day or you’re encountering these games for the first time, there’s something for everyone to enjoy.",
                        Developer = "ILCA",
                        Publisher = "The Pokémon Company",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2021, 11, 19),
                        Rating = 73,
                        Image = "pokemon_brilliant_diamond.webp"
                    },
                    new Game
                    {
                        GameId = 35,
                        Title = "Pokémon Shining Pearl",
                        Description = "Revisit the Sinnoh region and the story of the Pokémon Pearl Version game. Experience the nostalgic story from the Pokémon Pearl Version game in a reimagined adventure, Pokémon Shining Pearl, now on the Nintendo Switch system! Adventures in the Pokémon Shining Pearl game will take place in the familiar Sinnoh region. Rich in nature and with mighty Mount Coronet at its heart, Sinnoh is a land of many myths passed down through the ages. You’ll choose either Turtwig, Chimchar, or Piplup to be your first partner Pokémon and then set off on your journey to become the Champion of the Pokémon League. Along the way, you’ll be able to encounter the Legendary Pokémon Palkia. Adventure together with the Pokémon that appeared in the Pokémon Pearl Version game. Players of the original games can revisit familiar places and relive familiar scenes, while first time players can enjoy plenty of fun encounters and surprises that the Sinnoh region has to offer. The original story and the scale of the Sinnoh region’s towns and routes have been faithfully reproduced. This remake has also been revitalized with some of the player-friendly features of modern Pokémon games and up-close-and-personal Pokémon battle scenes. Whether you played Pokémon Diamond Version or Pokémon Pearl Version back in the day or you’re encountering these games for the first time, there’s something for everyone to enjoy.",
                        Developer = "ILCA",
                        Publisher = "The Pokémon Company",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2021, 11, 19),
                        Rating = 73,
                        Image = "pokemon_shining_pearl.webp"
                    },
                    new Game
                    {
                        GameId = 36,
                        Title = "Halo Infinite",
                        Description = "The Master Chief returns in Halo Infinite – the next chapter of the legendary franchise. When all hope is lost and humanity’s fate hangs in the balance, the Master Chief is ready to confront the most ruthless foe he’s ever faced. Step inside the armor of humanity’s greatest hero to experience an epic adventure and explore the massive scale of the Halo ring.",
                        Developer = "343 Industries",
                        Publisher = "Xbox Game Studios",
                        GenreId = 3,
                        ReleaseDate = new DateTime(2021, 12, 8),
                        Rating = 87,
                        Image = "halo_infinite.webp"
                    },
                    new Game
                    {
                        GameId = 37,
                        Title = "Pokémon Legends: Arceus",
                        Description = "The Pokémon Legends: Arceus game honors past Pokémon games’ core gameplay while infusing new action and RPG elements. You’ll need to catch, survey, and research wild Pokémon in a long-gone era of the Sinnoh region to create and complete the region’s first Pokédex.",
                        Developer = "Game Freak",
                        Publisher = "The Pokémon Company",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2022, 1, 28),
                        Rating = 83,
                        Image = "pokemon_legends_arceus.webp"
                    },
                    new Game
                    {
                        GameId = 38,
                        Title = "Sifu",
                        Description = "A third person action game featuring intense hand-to-hand combat, it puts you in control of a young Kung-Fu student on his path of revenge throughout the city.",
                        Developer = "Sloclap",
                        Publisher = "Kepler Interactive",
                        GenreId = 7,
                        ReleaseDate = new DateTime(2022, 2, 8),
                        Rating = 81,
                        Image = "sifu.webp"
                    },
                    new Game
                    {
                        GameId = 39,
                        Title = "Horizon Forbidden West",
                        Description = "Horizon Forbidden West continues Aloy’s story as she moves west to a far-future America to brave a majestic, but dangerous frontier where she’ll face awe-inspiring machines and mysterious new threats.",
                        Developer = "Guerrilla Games",
                        Publisher = "Sony Interactive Entertainment",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2022, 2, 18),
                        Rating = 88,
                        Image = "horizon_forbidden_west.webp"
                    },
                    new Game
                    {
                        GameId = 40,
                        Title = "Elden Ring",
                        Description = "Elden Ring is a fantasy, action and open world game with RPG elements such as stats, weapons and spells. Rise, Tarnished, and be guided by grace to brandish the power of the Elden Ring and become an Elden Lord in the Lands Between.",
                        Developer = "FromSoftware",
                        Publisher = "Bandai Namco Entertainment",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2022, 2, 25),
                        Rating = 96,
                        Image = "elden_ring.webp"
                    },
                    new Game
                    {
                        GameId = 41,
                        Title = "Gran Turismo 7",
                        Description = "Gran Turismo 7 brings together the very best features of the Real Driving Simulator. Whether you’re a competitive or casual racer, collector, tuner, livery designer or photographer – find your line with a staggering collection of game modes including fan-favorites like GT Campaign, Arcade and Driving School. With the reintroduction of the legendary GT Simulation Mode, buy, tune, race and sell your way through a rewarding solo campaign as you unlock new cars and challenges. And if you love going head-to-head with others, hone your skills and compete in the GT Sport Mode.",
                        Developer = "Polyphony Digital",
                        Publisher = "Sony Interactive Entertainment",
                        GenreId = 5,
                        ReleaseDate = new DateTime(2022, 3, 4),
                        Rating = 87,
                        Image = "gran_turismo_7.webp"
                    },
                    new Game
                    {
                        GameId = 42,
                        Title = "Ghostwire: Tokyo",
                        Description = "After strange disappearances hit Tokyo's population, it's up to you to uncover the source and purge the city of a strange, new evil. Armed with your own mysterious spectral abilities, you will face down the occult, unravel conspiracy theories and experience urban legends like never before.",
                        Developer = "Tango Gameworks",
                        Publisher = "Bethesda Softworks",
                        GenreId = 2,
                        ReleaseDate = new DateTime(2022, 3, 25),
                        Rating = 75,
                        Image = "ghostwire_tokyo.webp"
                    },
                    new Game
                    {
                        GameId = 43,
                        Title = "Stray",
                        Description = "Lost, alone, and separated from family, a stray cat must untangle an ancient mystery to escape a long-forgotten cybercity and find the way home.",
                        Developer = "BlueTwleve Studio",
                        Publisher = "Annapurna Interactive",
                        GenreId = 8,
                        ReleaseDate = new DateTime(2022, 7, 19),
                        Rating = 83,
                        Image = "stray.webp"
                    },
                    new Game
                    {
                        GameId = 44,
                        Title = "The Last of Us Part I",
                        Description = "Experience the emotional storytelling and unforgettable characters of Joel and Ellie in The Last of Us, winner of over 200 Game of the Year awards and now rebuilt for PlayStation 5. Enjoy a total overhaul of the original experience, faithfully reproduced but incorporating modernized gameplay, improved controls and expanded accessibility options. Plus, feel immersed with improved effects and enhanced exploration and combat. It also includes the Left Behind story DLC.",
                        Developer = "Naughty Dog",
                        Publisher = "Sony Interactive Entertainment",
                        GenreId = 3,
                        ReleaseDate = new DateTime(2022, 9, 2),
                        Rating = 89,
                        Image = "the_last_of_us_part_1.webp"
                    },
                    new Game
                    {
                        GameId = 45,
                        Title = "Call of Duty: Modern Warfare II",
                        Description = "Call of Duty: Modern Warfare II drops players into an unprecedented global conflict that features the return of the iconic Operators of Task Force 141.",
                        Developer = "Infinity Ward",
                        Publisher = "Activision",
                        GenreId = 3,
                        ReleaseDate = new DateTime(2022, 10, 28),
                        Rating = 75,
                        Image = "call_of_duty_modern_warfare_ii.webp"
                    },
                    new Game
                    {
                        GameId = 46,
                        Title = "God of War Ragnarök",
                        Description = "God of War: Ragnarök is the ninth installment in the God of War series and the sequel to 2018's God of War. Continuing with the Norse mythology theme, the game is set in ancient Norway and features series protagonists Kratos, the former Greek God of War, and his young son Atreus. The game kicked off the events of Ragnarök, where Kratos and Atreus must journey to each of the Nine Realms in search of answers as they prepare for the prophesied battle that will end the world.",
                        Developer = "SUE Santa Monica Studio",
                        Publisher = "Sony Interactive Entertainment",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2022, 11, 9),
                        Rating = 94,
                        Image = "god_of_war_ragnarok.webp"
                    },
                    new Game
                    {
                        GameId = 47,
                        Title = "Pokémon Scarlet",
                        Description = "The Pokémon Scarlet and Pokémon Violet games, the newest chapters in the Pokémon series, are coming to Nintendo Switch later this year. With these new titles, the Pokémon series takes a new evolutionary step, allowing you to explore freely in a richly expressed open world. Various towns blend seamlessly into the wilderness with no borders. You’ll be able to see the Pokémon of this region in the skies, in the seas, in the forests, on the streets—all over! You’ll be able to experience the true joy of the Pokémon series—battling against wild Pokémon in order to catch them—now in an open-world game that players of any age can enjoy.?",
                        Developer = "Game Freak",
                        Publisher = "The Pokémon Company",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2022, 11, 18),
                        Rating = 72,
                        Image = "pokemon_scarlet.webp"
                    },
                    new Game
                    {
                        GameId = 48,
                        Title = "Pokémon Violet",
                        Description = "Catch, battle, and train Pokémon in the Paldea Region, a vast land filled with lakes, towering peaks, wastelands, small towns, and sprawling cities. Explore a wide-open world at your own pace and traverse land, water, and air by riding on a form-shifting Legendary Pokémon. Choose either Sprigatito, Fuecoco, or Quaxly, to be your first partner Pokémon before setting off on your journey through Paldea.",
                        Developer = "Game Freak",
                        Publisher = "The Pokémon Company",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2022, 11, 18),
                        Rating = 71,
                        Image = "pokemon_violet.webp"
                    },
                    new Game
                    {
                        GameId = 49,
                        Title = "Forspoken",
                        Description = "Forspoken follows the journey of Frey, a young New Yorker transported to the beautiful and cruel land of Athia. In search of a way home, Frey must use her newfound magical abilities to traverse sprawling landscapes and battle monstrous creatures.",
                        Developer = "Luminous Productions",
                        Publisher = "Square Enix",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2023, 1, 24),
                        Rating = 64,
                        Image = "forspoken.webp"
                    },
                    new Game
                    {
                        GameId = 50,
                        Title = "Hogwarts Legacy",
                        Description = "Hogwarts Legacy is an immersive, open-world action RPG set in the world first introduced in the Harry Potter books. Now you can take control of the action and be at the center of your own adventure in the wizarding world. Embark on a journey through familiar and new locations as you explore and discover fantastic beasts, customize your character and craft potions, master spell casting, upgrade talents, and become the wizard you want to be. Discover the feeling of living at Hogwarts as you make allies, battle Dark wizards, and ultimately decide the fate of the wizarding world. Your legacy is what you make of it.",
                        Developer = "Avalanche Software",
                        Publisher = "Portkey Games",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2023, 2, 10),
                        Rating = 84,
                        Image = "hogwarts_legacy.webp"
                    },
                    new Game
                    {
                        GameId = 51,
                        Title = "Resident Evil 4",
                        Description = "Resident Evil 4 is a remake of the 2005 original Resident Evil 4 reimagined for 2023 to bring state-of-the-art survival horror. Resident Evil 4 preserves the essence of the original game, while introducing modernized gameplay, a reimagined storyline, and vividly detailed graphics to make this the latest survival horror game where life and death, terror and catharsis intersect.",
                        Developer = "Capcom",
                        Publisher = "Capcom",
                        GenreId = 3,
                        ReleaseDate = new DateTime(2023, 3, 24),
                        Rating = 93,
                        Image = "resident_evil_4.webp"
                    },
                    new Game
                    {
                        GameId = 52,
                        Title = "The Legend of Zelda: Tears of the Kingdom",
                        Description = "The Legend of Zelda: Tears of the Kingdom is the sequel to The Legend of Zelda: Breath of the Wild. The setting for Link’s adventure has been expanded to include the skies above the vast lands of Hyrule.",
                        Developer = "Nintendo",
                        Publisher = "Nintendo",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2023, 5, 12),
                        Rating = 96,
                        Image = "the_legend_of_zelda_tears_of_the_kingdom.webp"
                    },
                    new Game
                    {
                        GameId = 53,
                        Title = "Diablo IV",
                        Description = "Endless demons to slaughter. Deep customization through Talents, Skill Points, Runes, and Legendary loot. Randomized dungeons contained in a dynamic open world. Survive and conquer darkness—or succumb to the shadows.",
                        Developer = "Blizzard Entertainment",
                        Publisher = "Blizzard Entertainment",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2023, 6, 6),
                        Rating = 86,
                        Image = "diablo_iv.webp"
                    },
                    new Game
                    {
                        GameId = 54,
                        Title = "Baldur's Gate 3",
                        Description = "An ancient evil has returned to Baldur's Gate, intent on devouring it from the inside out. The fate of Faerun lies in your hands. Alone, you may resist. But together, you can overcome.",
                        Developer = "Larian Studios",
                        Publisher = "Larian Studios",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2023, 8, 3),
                        Rating = 96,
                        Image = "baldurs_gate_3.webp"
                    },
                    new Game
                    {
                        GameId = 55,
                        Title = "EA Sports FC 24",
                        Description = "EA SPORTS FC 24 is the ultimate football simulation game that lets you play as your favourite stars and teams in the most authentic and immersive way possible. With EA SPORTS FC, you can experience the thrill of the world's biggest competitions, such as the Premier League, UEFA Champions League, UEFA Women's Champions League, La Liga Santander, Bundesliga, Ligue 1, Serie A, CONMEBOL Libertadores, Barclays Women's Super League, NWSL and many more. EA SPORTS FC 24 also features a new brand identity inspired by the triangles that have been part of EA SPORTS football for the past 30 years, from the isometric polygons that make up the game to the chemistry triangles that exist in Ultimate Team to the player indicator across every match. Join the Club and be part of a new Football Club for the future of football we want to build together.",
                        Developer = "EA",
                        Publisher = "EA Sports",
                        GenreId = 4,
                        ReleaseDate = new DateTime(2023, 9, 29),
                        Rating = 75,
                        Image = "ea_sports_fc_24.webp"
                    },
                    new Game
                    {
                        GameId = 56,
                        Title = "Assassin's Creed Mirage",
                        Description = "In the ninth century CE, Baghdad is at its height, leading the world in science, art, innovation, and commerce. Amid its bustling urban landscape, a conflicted young orphan with a tragic past must navigate the streets to survive. In Assassin’s Creed Mirage, you are Basim, a cunning street thief with nightmarish visions, seeking answers and justice. After an act of deadly retribution, Basim flees Baghdad and joins an ancient organization – The Hidden Ones. As he learns their mysterious rituals and powerful tenets, he will hone his unique abilities, discover his true nature, and come to understand a new Creed – one that will change his fate in ways he never could have imagined.",
                        Developer = "Ubisoft Bordeaux",
                        Publisher = "Ubisoft Entertainment",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2023, 10, 5),
                        Rating = 75,
                        Image = "assassins_creed_mirage.webp"
                    },
                    new Game
                    {
                        GameId = 57,
                        Title = "Marvel's Spider-Man 2",
                        Description = "Marvel's Spider-Man 2 is the next game in the critically acclaimed Marvel's Spider-Man franchise. Developed by Insomniac Games in collaboration with PlayStation and Marvel Games. Swing, jump and utilize the new Web Wings to travel across Marvel’s New York, quickly switching between Peter Parker and Miles Morales to experience different stories and epic new powers, as the iconic villain Venom threatens to destroy their lives, their city and the ones they love. Quickly swap between both Spider-Men as you explore an expanded Marvel’s New York. Fight against a variety of new and iconic villains, including an original take on the monstrous Venom, the ruthless Kraven the Hunter, the volatile Lizard and many more.",
                        Developer = "Insomniac Games",
                        Publisher = "Sony Interactive Entertainment",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2023, 10, 20),
                        Rating = 90,
                        Image = "marvel_spider_man_2.webp"
                    },
                    new Game
                    {
                        GameId = 58,
                        Title = "Alan Wake II",
                        Description = "Saga Anderson arrives to investigate ritualistic murders in a small town. Alan Wake pens a dark story to shape the reality around him. These two heroes are somehow connected. Can they become the heroes they need to be?",
                        Developer = "Remedy Entertainment",
                        Publisher = "Epic Games",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2023, 10, 27),
                        Rating = 89,
                        Image = "alan_wake_ii.webp"
                    },
                    new Game
                    {
                        GameId = 59,
                        Title = "Call of Duty: Modern Warfare III",
                        Description = "The game brings \"open combat, \" offering players more choices in approaching the single-player missions. Makarov returns as the chief villain of the new campaign. The newly introduced Carry Forward system will let players keep their progression and inventory from Modern Warfare II. Multiplayer fans can expect 16 maps at the launch and at least 12 coming later. Zombies mode will also return and should offer the largest zombie map to date.",
                        Developer = "Infinity Ward",
                        Publisher = "Activision",
                        GenreId = 3,
                        ReleaseDate = new DateTime(2023, 11, 10),
                        Rating = 56,
                        Image = "call_of_duty_modern_warfare_iii.webp"
                    },
                    new Game
                    {
                        GameId = 60,
                        Title = "Avatar: Frontiers of Pandora",
                        Description = "Avatar: Frontiers of Pandora is a first-person, action-adventure game set in the never-before-seen Western Frontier of Pandora. Abducted by the human militaristic corporation known as the RDA, you, a Na’vi, were trained and molded to serve their purpose. Fifteen years later, you are free, but find yourself a stranger in your birthplace. Reconnect with your lost heritage, discover what it truly means to be Na'vi, and join other clans to protect Pandora from the RDA.",
                        Developer = "Massive Entertainment",
                        Publisher = "Ubisoft Entertainment",
                        GenreId = 2,
                        ReleaseDate = new DateTime(2023, 12, 7),
                        Rating = 72,
                        Image = "avatar_frontiers_of_pandora.webp"
                    },
                    new Game
                    {
                        GameId = 61,
                        Title = "Prince of Persia: The Lost Crown",
                        Description = "Dash into a stylish and thrilling action-adventure platformer set in a mythological Persian world where the boundaries of time and space are yours to manipulate. Play as Sargon and evolve from sword-wielding prodigy to extraordinary legend as you master acrobatic combat and unlock new Time Powers and unique super abilities.",
                        Developer = "Ubisoft Montpellier",
                        Publisher = "Ubisoft Entertainment",
                        GenreId = 2,
                        ReleaseDate = new DateTime(2024, 1, 18),
                        Rating = 86,
                        Image = "prince_of_persia_the_lost_crown.webp"
                    },
                    new Game
                    {
                        GameId = 62,
                        Title = "Palworld",
                        Description = "Palworld is a brand-new, multiplayer, open-world survival crafting game where you can befriend and collect mysterious creatures called \"Pal\" in a vast world! Make your Pals fight, build, farm, and work in factories.",
                        Developer = "PocketPair",
                        Publisher = "PocketPair",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2024, 1, 19),
                        Rating = 0,
                        Image = "palworld.webp"
                    },
                    new Game
                    {
                        GameId = 63,
                        Title = "The Last of Us Part II: Remastered",
                        Description = "The Last of Us Part II is an action-adventure game set five years after the events of The Last of Us. The player traverses post-apocalyptic environments such as buildings and forests to advance the story. They can use firearms, improvised weapons, and stealth to defend against hostile humans and cannibalistic creatures infected by a mutated strain of the Cordyceps fungus. The game intermittently switches control between Ellie and Abby, and also briefly Joel in the opening sequence. The nimble nature of the player character introduces platforming elements, allowing the player to jump and climb to traverse environments and gain advantages during combat.",
                        Developer = "Naughty Dog",
                        Publisher = "Sony Interactive Entertainment",
                        GenreId = 3,
                        ReleaseDate = new DateTime(2024, 1, 19),
                        Rating = 90,
                        Image = "the_last_of_us_part_2_remastered.webp"
                    },
                    new Game
                    {
                        GameId = 64,
                        Title = "Tekken 8",
                        Description = "Tekken 8 is the eighth canon release and tenth overall entry in the Tekken series. The game's story features 32 former and new characters, each with their own narrative that contributes to the overall story. Tekken 8 features upgraded fighting elements and systems from its predecessor, it also introduces brand-new mechanics such as the \"Heat\" system and \"Tornado\" hits. Arcade Quest was another addition to their online mode which includes tournaments, arcade features, customizable avatars and specialized currency that is featured throughout the game.",
                        Developer = "Bandai Namco Studios",
                        Publisher = "Bandai Namco Entertainment",
                        GenreId = 7,
                        ReleaseDate = new DateTime(2024, 1, 26),
                        Rating = 90,
                        Image = "tekken_8.webp"
                    },
                    new Game
                    {
                        GameId = 65,
                        Title = "Rise of the Rōnin",
                        Description = "Rise of the Rōnin is a combat focused open-world action RPG that takes place in Japan at a time of great change. It is the very end of a 300-year long Edo Period, commonly known as “Bakumatsu”. Set in the late 19th century, Japan is facing the darkest of times as it struggles with its oppressive rulers and deadly diseases while western influence permeates as civil war continues to rage between the Tokugawa Shogunate and the Anti-Shogunate factions.",
                        Developer = "Team NINJA",
                        Publisher = "Sony Interactive Entertainment",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2024, 3, 22),
                        Rating = 76,
                        Image = "rise_of_the_ronin.webp"
                    },
                    new Game
                    {
                        GameId = 66,
                        Title = "Stellar Blade",
                        Description = "Eve and her comrades land on the surface to reclaim the extinct Earth and cross paths with a survivor named Adam. Eve is then led by Adam to the last surviving city, Xion, where she meets the elder of the town Orcal and is told many stories. In order to serve her mission to save Earth, Eve develops close relationships with the key members of Xion and contributes to rebuilding the city. On a mission to save Earth from the NA:tive, Eve is also faced with helping out the citizens of Xion. Whether you will help the survivors or not, depends purely on your decision as the player.",
                        Developer = "SHIFT UP",
                        Publisher = "Sony Interactive Entertainment",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2024, 4, 26),
                        Rating = 81,
                        Image = "stellar_blade.webp"
                    },
                    new Game
                    {
                        GameId = 67,
                        Title = "Black Myth: Wukong",
                        Description = "Black Myth: Wukong is an action RPG rooted in Chinese mythology. You shall set out as the Destined One to venture into the challenges and marvels ahead, to uncover the obscured truth beneath the veil of a glorious legend from the past.",
                        Developer = "Game Science",
                        Publisher = "Game Science",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2024, 8, 20),
                        Rating = 0,
                        Image = "black_myth_wukong.webp"
                    },
                    new Game
                    {
                        GameId = 68,
                        Title = "Call of Duty: Black Ops 6",
                        Description = "Developed by Treyarch and Raven, Black Ops 6 is a spy action thriller set in the early 90s, a period of transition and upheaval in global politics, characterized by the end of the Cold War and the rise of the United States as a single superpower. With a mind-bending narrative, and unbound by the rules of engagement, this is signature Black Ops. The Black Ops 6 Campaign provides dynamic moment-to-moment gameplay that includes a variety of play spaces with blockbuster set pieces and action-packed moments, high-stakes heists, and cloak-and-dagger spy activity. In a best-in-class Multiplayer experience, players will test their skills across 16 new maps at launch, including 12 core 6v6 maps and 4 Strike maps that can be played 2v2 or 6v6. Black Ops 6 also marks the epic return of Round-Based Zombies, the fan-favorite mode where players will take down hordes of the undead in two brand-new maps at launch. Post-launch, players can look forward to even more exciting maps and groundbreaking experiences dropping into both Multiplayer and Zombies.",
                        Developer = "Treyarch",
                        Publisher = "Activision",
                        GenreId = 3,
                        ReleaseDate = new DateTime(2024, 10, 25),
                        Rating = 0,
                        Image = "call_of_duty_black_ops_6.webp"
                    },
                    new Game
                    {
                        GameId = 69,
                        Title = "Assassin's Creed Shadows",
                        Description = "Experience an epic historical action-adventure story set in feudal Japan! Become a lethal shinobi Assassin and a powerful legendary samurai as you explore a beautiful open world in a time of chaos. Switch seamlessly between two unlikely allies as you discover their common destiny. Master complementary playstyles, create your shinobi league, customize your hideout, and usher in a new era for Japan.",
                        Developer = "Ubisoft Québec",
                        Publisher = "Ubisoft Entertainment",
                        GenreId = 1,
                        ReleaseDate = new DateTime(2024, 11, 15),
                        Rating = 0,
                        Image = "assassins_creed_shadows.webp"
                    },
                    new Game
                    {
                        GameId = 70,
                        Title = "Grand Theft Auto VI",
                        Description = "Grand Theft Auto VI heads to the state of Leonida, home to the neon-soaked streets of Vice City and beyond in the biggest, most immersive evolution of the Grand Theft Auto series yet.",
                        Developer = "Rockstar Games",
                        Publisher = "Take-Two Interactive",
                        GenreId = 3,
                        ReleaseDate = new DateTime(2025, 12, 31),
                        Rating = 0,
                        Image = "grand_theft_auto_vi.webp"
                    }
                );
        }
    }
}
