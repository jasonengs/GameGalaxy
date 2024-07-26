using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameGalaxy.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    PlatformId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.PlatformId);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Developer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "date", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_Games_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GamePlatforms",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false),
                    PlatformId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlatforms", x => new { x.GameId, x.PlatformId });
                    table.ForeignKey(
                        name: "FK_GamePlatforms_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamePlatforms_Platforms_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platforms",
                        principalColumn: "PlatformId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Name" },
                values: new object[,]
                {
                    { 1, "Role-Playing (RPG)" },
                    { 2, "Adventure" },
                    { 3, "Shooter" },
                    { 4, "Sport" },
                    { 5, "Racing" },
                    { 6, "Simulator" },
                    { 7, "Fighting" },
                    { 8, "Indie" },
                    { 9, "Puzzle" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "PlatformId", "Name" },
                values: new object[,]
                {
                    { 1, "Microsoft Windows" },
                    { 2, "Playstation 5" },
                    { 3, "Xbox Series X|S" },
                    { 4, "Nintendo Switch" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Description", "Developer", "GenreId", "Image", "Publisher", "Rating", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "Grand Theft Auto V is a vast open world game set in Los Santos, a sprawling sun-soaked metropolis struggling to stay afloat in an era of economic uncertainty and cheap reality TV. The game blends storytelling and gameplay in new ways as players repeatedly jump in and out of the lives of the game’s three lead characters, playing all sides of the game’s interwoven story.", "Rockstar North", 3, "grand_theft_auto_v.webp", "Take-Two Interactive", 97, new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grand Theft Auto V" },
                    { 2, "In an era where machines roam the land and mankind is no longer the dominant species, a young hunter named Aloy embarks on a journey to discover her destiny. Explore a vibrant and lush world inhabited by mysterious mechanized creatures. Embark on a compelling, emotional journey and unravel mysteries of tribal societies, ancient artefacts and enhanced technologies that will determine the fate of this planet and of life itself.", "Guerrilla Games", 1, "horizon_zero_dawn.webp", "Sony Interactive Entertainment", 89, new DateTime(2017, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horizon Zero Dawn" },
                    { 3, "The Legend of Zelda: Breath of the Wild is the first 3D open-world game in the Zelda series. Link can travel anywhere and be equipped with weapons and armor found throughout the world to grant him various bonuses. Unlike many games in the series, Breath of the Wild does not impose a specific order in which quests or dungeons must be completed. While the game still has environmental obstacles such as weather effects, inhospitable lands, or powerful enemies, many of them can be overcome using the right method. A lot of critics ranked Breath of the Wild as one of the best video games of all time.", "Nintendo", 1, "the_legend_of_zelda_breath_of_the_wild.webp", "Nintendo", 97, new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Legend of Zelda: Breath of the Wild" },
                    { 4, "Experience the epic conclusion of the Mishima clan and unravel the reasons behind each step of their ceaseless fight. Powered by Unreal Engine 4, Tekken 7 features stunning story-driven cinematic battles and intense duels that can be enjoyed with friends and rivals alike through innovative fight mechanics.", "Bandai Namco Studios", 7, "tekken_7.webp", "Bandai Namco Entertainment", 82, new DateTime(2017, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tekken 7" },
                    { 5, "Welcome to Hope County, Montana, land of the free and the brave, but also home to a fanatical doomsday cult known as The Project at Eden’s Gate that is threatening the community's freedom. Stand up to the cult’s leader, Joseph Seed and the Heralds, and spark the fires of resistance that will liberate the besieged community. In this expansive world, your limits and creativity will be tested against the biggest and most ruthless baddest enemy Far Cry has ever seen. It’ll be wild and it’ll get weird, but as long as you keep your wits about you, the residents of Hope County can rest assured knowing you’re their beacon of hope.", "Ubisoft Montreal", 3, "far_cry_5.webp", "Ubisoft Entertainment", 81, new DateTime(2018, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Far Cry 5" },
                    { 6, "God of War is the sequel to God of War III as well as a continuation of the canon God of War chronology. Unlike previous installments, this game focuses on Norse mythology and follows an older and more seasoned Kratos and his son Atreus in the years since the third game. It is in this harsh, unforgiving world that he must fight to survive… and teach his son to do the same.", "SUE Santa Monica Studio", 1, "god_of_war.webp", "Sony Interactive Entertainment", 94, new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "God Of War" },
                    { 7, "Starring the world’s most iconic Super Hero, Spider-Man features the acrobatic abilities, improvisation and web-slinging that the wall-crawler is famous for, while also introducing elements never-before-seen in a Spider-Man game. From traversing with parkour and utilizing the environment, to new combat and blockbuster set pieces, it’s Spider-Man unlike any you’ve played before.", "Insomniac Games", 1, "marvel_spider_man_remastered.webp", "Sony Interactive Entertainment", 87, new DateTime(2018, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel's Spider-Man Remastered" },
                    { 8, "Dynamic seasons change everything at the world’s greatest automotive festival. Go it alone or team up with others to explore beautiful and historic Britain in a shared open world. Collect, modify and drive over 450 cars. Race, stunt, create and explore – choose your own path to become a Horizon Superstar.", "Playground Games", 5, "forza_horizon_4.webp", "Xbox Game Studios", 92, new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forza Horizon 4" },
                    { 9, "Red Dead Redemption 2 is the epic tale of outlaw Arthur Morgan and the infamous Van der Linde gang, on the run across America at the dawn of the modern age.", "Rockstar Games", 1, "red_dead_redemption_2.webp", "Take-Two Interactive", 97, new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption 2" },
                    { 10, "Take your Pokémon journey to the Kanto region with your energetic partner, Pikachu, to become a top Pokémon Trainer as you battle other trainers. Use a throwing motion to catch Pokémon in the wild with either one Joy-Con controller or Poké Ball Plus accessory, which will light up, vibrate, and make sounds to bring your adventure to life. Share your adventure with family or friends in 2-player action on one system using a second Joy-Con or Poké Ball Plus (sold separately). You can even connect to the Pokémon GO app using a compatible smartphone to bring over Pokémon originally discovered in the Kanto region! Explore the diverse and vibrant region of Kanto! True-to-size wild Pokémon roam around in the game, so catch them like a real Pokémon Trainer by using motion, timing, and a well-placed Poké Ball. Go on a stroll with your favorite Pokémon in your Poké Ball Plus! Connect your game directly to Pokémon GO to receive Kanto region Pokémon.", "Game Freak", 1, "pokemon_lets_go_pikachu.webp", "The Pokémon Company", 79, new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokémon Let's Go, Pikachu!" },
                    { 11, "Take your Pokémon journey to the Kanto region with your energetic partner, Eevee, to become a top Pokémon Trainer as you battle other trainers. Use a throwing motion to catch Pokémon in the wild with either one Joy-Con controller or Poké Ball Plus accessory, which will light up, vibrate, and make sounds to bring your adventure to life. Share your adventure with family or friends in 2-player action on one system using a second Joy-Con or Poké Ball Plus (sold separately). You can even connect to the Pokémon GO app using a compatible smartphone to bring over Pokémon originally discovered in the Kanto region! Explore the diverse and vibrant region of Kanto! True-to-size wild Pokémon roam around in the game, so catch them like a real Pokémon Trainer by using motion, timing, and a well-placed Poké Ball. Go on a stroll with your favorite Pokémon in your Poké Ball Plus! Connect your game directly to Pokémon GO to receive Kanto region Pokémon.", "Game Freak", 1, "pokemon_lets_go_eevee.webp", "The Pokémon Company", 80, new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokémon Let's Go, Eevee!" },
                    { 12, "Enter a dark and brutal new gameplay experience from the creators of Bloodborne and the Dark Souls series. Sekiro: Shadows Die Twice is an intense, third-person, action-adventure set against the bloody backdrop of 14th-century Japan. Step into the role of a disgraced warrior brought back from the brink of death whose mission is to rescue his master and exact revenge on his arch nemesis. Take Revenge. Restore Your Honor. Kill Ingeniously.", "FromSoftware", 1, "sekiro_shadows_die_twice.webp", "Activision", 90, new DateTime(2019, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sekiro: Shadows Die Twice" },
                    { 13, "Outer Wilds is a critically-acclaimed and award-winning open world mystery about a solar system trapped in an endless time loop. The newest member of the space program in a small village on the planet Timber Hearth, the player navigates a space shuttle and travels across their solar system to get to the bottom of its mysteries by exploring the cosmos and gathering the knowledge hidden within each of the system's planets, left behind by another civilization in the distant past.", "Mobius Digital", 8, "outer_wilds.webp", "Annapurna Interactive", 85, new DateTime(2019, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Outer Wild" },
                    { 14, "Prepare to go dark, Modern Warfare is back! The stakes have never been higher as players take on the role of lethal Tier One operators in a heart-racing saga that will affect the global balance of power. Call of Duty: Modern Warfare engulfs fans in an incredibly raw, gritty, provocative narrative that brings unrivaled intensity and shines a light on the changing nature of modern war. Players will be thrust into an immersive narrative spanning the entire game. Experience the ultimate online playground with classic multiplayer or squad-up and play cooperatively in a collection of elite operations, accessible to all skill levels.", "Infinity Ward", 3, "call_of_duty_modern_warfare.webp", "Activision", 80, new DateTime(2019, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Call of Duty: Modern Warfare" },
                    { 15, "From legendary game creator Hideo Kojima comes an all-new, genre-defying open world action adventure, starring Norman Reedus, Mads Mikkelsen, Léa Seydoux and Lindsay Wagner. In the near future, mysterious explosions have rocked the globe, setting off a series of supernatural events known as the Death Stranding. With otherworldly creatures plaguing the landscape, and mass extinction imminent, it’s up to Sam Porter Bridges to travel across the ravaged wasteland and save humanity from impending annihilation.", "Kojima Productions", 1, "death_stranding_directors_cut.webp", "Sony Interactive Entertainment", 82, new DateTime(2019, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Death Stranding: Director's Cut" },
                    { 16, "Unsheathe your sword and take up your shield! The world of Pokémon expands to include the Galar region in Pokémon Sword and Pokémon Shield!", "Game Freak", 1, "pokemon_sword.webp", "The Pokémon Company", 80, new DateTime(2019, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokémon Sword" },
                    { 17, "Unsheathe your sword and take up your shield! The world of Pokémon expands to include the Galar region in Pokémon Sword and Pokémon Shield!", "Game Freak", 1, "pokemon_shield.webp", "The Pokémon Company", 80, new DateTime(2019, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokémon Shield" },
                    { 18, "Escape to a deserted island and create your own paradise as you explore, create, and customize in Animal Crossing: New Horizons. Your island getaway has a wealth of natural resources that can be used to craft everything from tools to creature comforts. You can hunt down insects at the crack of dawn, decorate your paradise throughout the day, or enjoy sunset on the beach while fishing in the ocean. The time of day and season match real life, so each day on your island is a chance to check in and find new surprises all year round.", "Nintendo", 6, "animal_crossing_new_horizons.webp", "Nintendo", 90, new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animal Crossing: New Horizons" },
                    { 19, "Uncover the hidden wonders of Tsushima in this open-world action adventure. Forge a new path and wage an unconventional war for the freedom of Tsushima. Challenge opponents with your katana, master the bow to eliminate distant threats, develop stealth tactics to ambush enemies in order to win over the mongols.", "Sucker Punch Productions", 1, "ghost_of__tsushima_directors_cut.webp", "Sony Interactive Entertainment", 83, new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ghost of Tsushima: Directors Cut" },
                    { 20, "Microsoft Flight Simulator is the next generation of one of the most beloved simulation franchises. From light planes to wide-body jets, fly highly detailed and stunning aircraft in an incredibly realistic world. Create your flight plan and fly anywhere on the planet. Enjoy flying day or night and face realistic, challenging weather conditions.", "Asobo Studio", 6, "microsoft_flight_simulator.webp", "Xbox Game Studios", 91, new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft Flight Simulator" },
                    { 21, "In Assassin's Creed Valhalla, become Eivor, a legendary Viking raider on a quest for glory. Explore a dynamic and beautiful open world set against the brutal backdrop of England’s Dark Ages. Raid your enemies, grow your settlement, and build your political power in the quest to earn a place among the gods in Valhalla.", "Ubisoft Montreal", 1, "assassins_creed_valhalla.webp", "Ubisoft Entertainment", 80, new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassin's Creed Valhalla" },
                    { 22, "The latest adventure in the Spider-Man universe will build on and expand ‘Marvel’s Spider-Man’ through an all-new story. Players will experience the rise of Miles Morales as he masters new powers to become his own Spider-Man.", "Insomniac Games", 1, "marvel_spider_man_miles_morales.webp", "Sony Interactive Entertainment", 85, new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel's Spider-Man: Miles Morales" },
                    { 23, "Entirely rebuilt from the ground up and masterfully enhanced, Demon's Souls is a remake of the 2009 release that introduces the horrors of a fog-laden, dark fantasy land to a whole new generation of gamers. Those who’ve faced its trials and tribulations before, can once again challenge the darkness in stunning visual quality with incredible performance. The remake features improved graphics and animations, sound and lighting tweaks and a reimagining of many of the visual, musical and mechanical aspects of the original game.", "Bluepoint Games", 1, "demons_souls.webp", "Sony Interactive Entertainment", 92, new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Demon's Soul" },
                    { 24, "The iconic Black Ops series is back with Call of Duty: Black Ops Cold War - the direct sequel to the original and fan-favorite Call of Duty: Black Ops. Black Ops Cold War will drop fans into the depths of the Cold War’s volatile geopolitical battle of the early 1980s. Nothing is ever as it seems in a gripping single-player Campaign, where players will come face-to-face with historical figures and hard truths, as they battle around the globe through iconic locales like East Berlin, Vietnam, Turkey, Soviet KGB headquarters and more. Beyond the Campaign, players will bring a Cold War arsenal of weapons and equipment into the next generation of Multiplayer and Zombies experiences. Welcome to the brink. Welcome to Call of Duty: Black Ops Cold War.", "Treyarch", 3, "call_of_duty_black_ops_cold_war.webp", "Activision", 76, new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Call of Duty: Black Ops Cold War" },
                    { 25, "Cyberpunk 2077 is an open-world, action-adventure story set in Night City, a megalopolis obsessed with power, glamour and body modification. You play as V, a mercenary outlaw going after a one-of-a-kind implant that is the key to immortality. You can customize your character’s cyberware, skillset and playstyle, and explore a vast city where the choices you make shape the story and the world around you.", "CD Projekt RED", 1, "cyberpunk_2077.webp", "CD Projekt", 86, new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyber Punk 2077" },
                    { 26, "Embark on the craziest journey of your life in It Takes Two, a genre-bending platform adventure created purely for co-op. Invite a friend to join for free with Friend’s Pass and work together across a huge variety of gleefully disruptive gameplay challenges. Play as the clashing couple Cody and May, two humans turned into dolls by a magic spell. Together, trapped in a fantastical world where the unpredictable hides around every corner, they are reluctantly challenged with saving their fractured relationship.", "Hazelight Studios", 9, "it_takes_two.webp", "Electronic Arts", 88, new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "It Takes Two" },
                    { 27, "Returnal is a 2021 roguelike third-person shooter video game developed by Housemarque and published by Sony Interactive Entertainment. It follows Selene Vassos, an astronaut who lands on the planet Atropos in search of the mysterious \"White Shadow\" signal and finds herself trapped in a time loop. After crash-landing on a shape-shifting alien planet, Selene finds herself fighting tooth and nail for survival. Every time she’s defeated, the player is forced to restart the journey.", "Housemarque", 3, "returnal.webp", "Sony Interactive Entertainment", 86, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returnal" },
                    { 28, "Resident Evil Village is a first person survival horror and the sequel to Resident Evil 7: Biohazard. The game maintains elements from previous Resident Evil games with players having to scavenge environments for items and manage their resources. However, it adds more action-oriented gameplay, with higher enemy counts and a greater emphasis on combat.", "Capcom", 3, "resident_evil_village.webp", "Capcom", 84, new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil Village" },
                    { 29, "Go dimension-hopping with Ratchet and Clank as they take on an evil emperor from another reality. Jump between action-packed worlds and beyond at mind-blowing speeds, complete with dazzling visuals and an insane arsenal.", "Insomniac Games", 3, "ratchet_and_clank_rift_apart.webp", "Sony Interactive Entertainment", 88, new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ratchet & Clank: Rift Apart" },
                    { 30, "Deathloop transports players to the lawless island of Blackreef in an eternal struggle between two extraordinary assassins. Explore stunning environments and meticulously designed levels in an immersive gameplay experience that lets you approach every situation any way you like. Hunt down targets all over the island in an effort to put an end to the cycle once and for all, and remember, if at first you don’t succeed… die, die again.", "Arkane Studios", 6, "deathloop.webp", "Bethesda Softworks", 88, new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deathloop" },
                    { 31, "Dive into the gritty world of a modern-day guerrilla revolution to liberate a nation from its oppressive dictators. Welcome to Yara, a tropical paradise frozen in time. Far Cry 6 thrusts players into a modern-day guerrilla revolution. As dictator of Yara, Anton Castillo is intent on restoring his nation back to its former glory by any means, with his son, Diego, following in his bloody footsteps. Become a guerrilla fighter and liberate Yara.", "Ubisoft Toronto", 3, "far_cry_6.webp", "Ubisoft Entertainment", 73, new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Far Cry 6" },
                    { 32, "Unpacking is a zen puzzle game about the familiar experience of pulling possessions out of boxes and fitting them into a new home. Part block-fitting puzzle, part home decoration, you are invited to create a satisfying living space while learning clues about the life you’re unpacking. Over the course of eight house moves, you are given a chance to experience a sense of intimacy with a character you never see and a story you’re never told.", "Witch Beam", 9, "unpacking.webp", "Humble Games", 83, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpacking" },
                    { 33, "Your Ultimate Horizon Adventure awaits! Explore the vibrant and ever-evolving open-world landscapes of Mexico with limitless, fun driving action in hundreds of the world’s greatest cars.", "Playground Games", 5, "forza_horizon_5.webp", "Xbox Game Studios", 92, new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forza Horizon 5" },
                    { 34, "Revisit the Sinnoh region and the story of the Pokémon Diamond Version game. Experience the nostalgic story from the Pokémon Diamond Version game in a reimagined adventure, Pokémon Brilliant Diamond, now on the Nintendo Switch system! Adventures in the Pokémon Brilliant Diamond game will take place in the familiar Sinnoh region. Rich in nature and with mighty Mount Coronet at its heart, Sinnoh is a land of many myths passed down through the ages. You’ll choose either Turtwig, Chimchar, or Piplup to be your first partner Pokémon and then set off on your journey to become the Champion of the Pokémon League. Along the way, you’ll be able to encounter the Legendary Pokémon Dialga. Adventure together with the Pokémon that appeared in the Pokémon Diamond Version game. Players of the original games can revisit familiar places and relive familiar scenes, while first time players can enjoy plenty of fun encounters and surprises that the Sinnoh region has to offer. The original story and the scale of the Sinnoh region’s towns and routes have been faithfully reproduced. This remake has also been revitalized with some of the player-friendly features of modern Pokémon games and up-close-and-personal Pokémon battle scenes. Whether you played Pokémon Diamond Version or Pokémon Pearl Version back in the day or you’re encountering these games for the first time, there’s something for everyone to enjoy.", "ILCA", 1, "pokemon_brilliant_diamond.webp", "The Pokémon Company", 73, new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokémon Brilliant Diamond" },
                    { 35, "Revisit the Sinnoh region and the story of the Pokémon Pearl Version game. Experience the nostalgic story from the Pokémon Pearl Version game in a reimagined adventure, Pokémon Shining Pearl, now on the Nintendo Switch system! Adventures in the Pokémon Shining Pearl game will take place in the familiar Sinnoh region. Rich in nature and with mighty Mount Coronet at its heart, Sinnoh is a land of many myths passed down through the ages. You’ll choose either Turtwig, Chimchar, or Piplup to be your first partner Pokémon and then set off on your journey to become the Champion of the Pokémon League. Along the way, you’ll be able to encounter the Legendary Pokémon Palkia. Adventure together with the Pokémon that appeared in the Pokémon Pearl Version game. Players of the original games can revisit familiar places and relive familiar scenes, while first time players can enjoy plenty of fun encounters and surprises that the Sinnoh region has to offer. The original story and the scale of the Sinnoh region’s towns and routes have been faithfully reproduced. This remake has also been revitalized with some of the player-friendly features of modern Pokémon games and up-close-and-personal Pokémon battle scenes. Whether you played Pokémon Diamond Version or Pokémon Pearl Version back in the day or you’re encountering these games for the first time, there’s something for everyone to enjoy.", "ILCA", 1, "pokemon_shining_pearl.webp", "The Pokémon Company", 73, new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokémon Shining Pearl" },
                    { 36, "The Master Chief returns in Halo Infinite – the next chapter of the legendary franchise. When all hope is lost and humanity’s fate hangs in the balance, the Master Chief is ready to confront the most ruthless foe he’s ever faced. Step inside the armor of humanity’s greatest hero to experience an epic adventure and explore the massive scale of the Halo ring.", "343 Industries", 3, "halo_infinite.webp", "Xbox Game Studios", 87, new DateTime(2021, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Halo Infinite" },
                    { 37, "The Pokémon Legends: Arceus game honors past Pokémon games’ core gameplay while infusing new action and RPG elements. You’ll need to catch, survey, and research wild Pokémon in a long-gone era of the Sinnoh region to create and complete the region’s first Pokédex.", "Game Freak", 1, "pokemon_legends_arceus.webp", "The Pokémon Company", 83, new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokémon Legends: Arceus" },
                    { 38, "A third person action game featuring intense hand-to-hand combat, it puts you in control of a young Kung-Fu student on his path of revenge throughout the city.", "Sloclap", 7, "sifu.webp", "Kepler Interactive", 81, new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sifu" },
                    { 39, "Horizon Forbidden West continues Aloy’s story as she moves west to a far-future America to brave a majestic, but dangerous frontier where she’ll face awe-inspiring machines and mysterious new threats.", "Guerrilla Games", 1, "horizon_forbidden_west.webp", "Sony Interactive Entertainment", 88, new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horizon Forbidden West" },
                    { 40, "Elden Ring is a fantasy, action and open world game with RPG elements such as stats, weapons and spells. Rise, Tarnished, and be guided by grace to brandish the power of the Elden Ring and become an Elden Lord in the Lands Between.", "FromSoftware", 1, "elden_ring.webp", "Bandai Namco Entertainment", 96, new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elden Ring" },
                    { 41, "Gran Turismo 7 brings together the very best features of the Real Driving Simulator. Whether you’re a competitive or casual racer, collector, tuner, livery designer or photographer – find your line with a staggering collection of game modes including fan-favorites like GT Campaign, Arcade and Driving School. With the reintroduction of the legendary GT Simulation Mode, buy, tune, race and sell your way through a rewarding solo campaign as you unlock new cars and challenges. And if you love going head-to-head with others, hone your skills and compete in the GT Sport Mode.", "Polyphony Digital", 5, "gran_turismo_7.webp", "Sony Interactive Entertainment", 87, new DateTime(2022, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gran Turismo 7" },
                    { 42, "After strange disappearances hit Tokyo's population, it's up to you to uncover the source and purge the city of a strange, new evil. Armed with your own mysterious spectral abilities, you will face down the occult, unravel conspiracy theories and experience urban legends like never before.", "Tango Gameworks", 2, "ghostwire_tokyo.webp", "Bethesda Softworks", 75, new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ghostwire: Tokyo" },
                    { 43, "Lost, alone, and separated from family, a stray cat must untangle an ancient mystery to escape a long-forgotten cybercity and find the way home.", "BlueTwleve Studio", 8, "stray.webp", "Annapurna Interactive", 83, new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stray" },
                    { 44, "Experience the emotional storytelling and unforgettable characters of Joel and Ellie in The Last of Us, winner of over 200 Game of the Year awards and now rebuilt for PlayStation 5. Enjoy a total overhaul of the original experience, faithfully reproduced but incorporating modernized gameplay, improved controls and expanded accessibility options. Plus, feel immersed with improved effects and enhanced exploration and combat. It also includes the Left Behind story DLC.", "Naughty Dog", 3, "the_last_of_us_part_1.webp", "Sony Interactive Entertainment", 89, new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last of Us Part I" },
                    { 45, "Call of Duty: Modern Warfare II drops players into an unprecedented global conflict that features the return of the iconic Operators of Task Force 141.", "Infinity Ward", 3, "call_of_duty_modern_warfare_ii.webp", "Activision", 75, new DateTime(2022, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Call of Duty: Modern Warfare II" },
                    { 46, "God of War: Ragnarök is the ninth installment in the God of War series and the sequel to 2018's God of War. Continuing with the Norse mythology theme, the game is set in ancient Norway and features series protagonists Kratos, the former Greek God of War, and his young son Atreus. The game kicked off the events of Ragnarök, where Kratos and Atreus must journey to each of the Nine Realms in search of answers as they prepare for the prophesied battle that will end the world.", "SUE Santa Monica Studio", 1, "god_of_war_ragnarok.webp", "Sony Interactive Entertainment", 94, new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "God of War Ragnarök" },
                    { 47, "The Pokémon Scarlet and Pokémon Violet games, the newest chapters in the Pokémon series, are coming to Nintendo Switch later this year. With these new titles, the Pokémon series takes a new evolutionary step, allowing you to explore freely in a richly expressed open world. Various towns blend seamlessly into the wilderness with no borders. You’ll be able to see the Pokémon of this region in the skies, in the seas, in the forests, on the streets—all over! You’ll be able to experience the true joy of the Pokémon series—battling against wild Pokémon in order to catch them—now in an open-world game that players of any age can enjoy.?", "Game Freak", 1, "pokemon_scarlet.webp", "The Pokémon Company", 72, new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokémon Scarlet" },
                    { 48, "Catch, battle, and train Pokémon in the Paldea Region, a vast land filled with lakes, towering peaks, wastelands, small towns, and sprawling cities. Explore a wide-open world at your own pace and traverse land, water, and air by riding on a form-shifting Legendary Pokémon. Choose either Sprigatito, Fuecoco, or Quaxly, to be your first partner Pokémon before setting off on your journey through Paldea.", "Game Freak", 1, "pokemon_violet.webp", "The Pokémon Company", 71, new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokémon Violet" },
                    { 49, "Forspoken follows the journey of Frey, a young New Yorker transported to the beautiful and cruel land of Athia. In search of a way home, Frey must use her newfound magical abilities to traverse sprawling landscapes and battle monstrous creatures.", "Luminous Productions", 1, "forspoken.webp", "Square Enix", 64, new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forspoken" },
                    { 50, "Hogwarts Legacy is an immersive, open-world action RPG set in the world first introduced in the Harry Potter books. Now you can take control of the action and be at the center of your own adventure in the wizarding world. Embark on a journey through familiar and new locations as you explore and discover fantastic beasts, customize your character and craft potions, master spell casting, upgrade talents, and become the wizard you want to be. Discover the feeling of living at Hogwarts as you make allies, battle Dark wizards, and ultimately decide the fate of the wizarding world. Your legacy is what you make of it.", "Avalanche Software", 1, "hogwarts_legacy.webp", "Portkey Games", 84, new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hogwarts Legacy" },
                    { 51, "Resident Evil 4 is a remake of the 2005 original Resident Evil 4 reimagined for 2023 to bring state-of-the-art survival horror. Resident Evil 4 preserves the essence of the original game, while introducing modernized gameplay, a reimagined storyline, and vividly detailed graphics to make this the latest survival horror game where life and death, terror and catharsis intersect.", "Capcom", 3, "resident_evil_4.webp", "Capcom", 93, new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil 4" },
                    { 52, "The Legend of Zelda: Tears of the Kingdom is the sequel to The Legend of Zelda: Breath of the Wild. The setting for Link’s adventure has been expanded to include the skies above the vast lands of Hyrule.", "Nintendo", 1, "the_legend_of_zelda_tears_of_the_kingdom.webp", "Nintendo", 96, new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Legend of Zelda: Tears of the Kingdom" },
                    { 53, "Endless demons to slaughter. Deep customization through Talents, Skill Points, Runes, and Legendary loot. Randomized dungeons contained in a dynamic open world. Survive and conquer darkness—or succumb to the shadows.", "Blizzard Entertainment", 1, "diablo_iv.webp", "Blizzard Entertainment", 86, new DateTime(2023, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diablo IV" },
                    { 54, "An ancient evil has returned to Baldur's Gate, intent on devouring it from the inside out. The fate of Faerun lies in your hands. Alone, you may resist. But together, you can overcome.", "Larian Studios", 1, "baldurs_gate_3.webp", "Larian Studios", 96, new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baldur's Gate 3" },
                    { 55, "EA SPORTS FC 24 is the ultimate football simulation game that lets you play as your favourite stars and teams in the most authentic and immersive way possible. With EA SPORTS FC, you can experience the thrill of the world's biggest competitions, such as the Premier League, UEFA Champions League, UEFA Women's Champions League, La Liga Santander, Bundesliga, Ligue 1, Serie A, CONMEBOL Libertadores, Barclays Women's Super League, NWSL and many more. EA SPORTS FC 24 also features a new brand identity inspired by the triangles that have been part of EA SPORTS football for the past 30 years, from the isometric polygons that make up the game to the chemistry triangles that exist in Ultimate Team to the player indicator across every match. Join the Club and be part of a new Football Club for the future of football we want to build together.", "EA", 4, "ea_sports_fc_24.webp", "EA Sports", 75, new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "EA Sports FC 24" },
                    { 56, "In the ninth century CE, Baghdad is at its height, leading the world in science, art, innovation, and commerce. Amid its bustling urban landscape, a conflicted young orphan with a tragic past must navigate the streets to survive. In Assassin’s Creed Mirage, you are Basim, a cunning street thief with nightmarish visions, seeking answers and justice. After an act of deadly retribution, Basim flees Baghdad and joins an ancient organization – The Hidden Ones. As he learns their mysterious rituals and powerful tenets, he will hone his unique abilities, discover his true nature, and come to understand a new Creed – one that will change his fate in ways he never could have imagined.", "Ubisoft Bordeaux", 1, "assassins_creed_mirage.webp", "Ubisoft Entertainment", 75, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassin's Creed Mirage" },
                    { 57, "Marvel's Spider-Man 2 is the next game in the critically acclaimed Marvel's Spider-Man franchise. Developed by Insomniac Games in collaboration with PlayStation and Marvel Games. Swing, jump and utilize the new Web Wings to travel across Marvel’s New York, quickly switching between Peter Parker and Miles Morales to experience different stories and epic new powers, as the iconic villain Venom threatens to destroy their lives, their city and the ones they love. Quickly swap between both Spider-Men as you explore an expanded Marvel’s New York. Fight against a variety of new and iconic villains, including an original take on the monstrous Venom, the ruthless Kraven the Hunter, the volatile Lizard and many more.", "Insomniac Games", 1, "marvel_spider_man_2.webp", "Sony Interactive Entertainment", 90, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel's Spider-Man 2" },
                    { 58, "Saga Anderson arrives to investigate ritualistic murders in a small town. Alan Wake pens a dark story to shape the reality around him. These two heroes are somehow connected. Can they become the heroes they need to be?", "Remedy Entertainment", 1, "alan_wake_ii.webp", "Epic Games", 89, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alan Wake II" },
                    { 59, "The game brings \"open combat, \" offering players more choices in approaching the single-player missions. Makarov returns as the chief villain of the new campaign. The newly introduced Carry Forward system will let players keep their progression and inventory from Modern Warfare II. Multiplayer fans can expect 16 maps at the launch and at least 12 coming later. Zombies mode will also return and should offer the largest zombie map to date.", "Infinity Ward", 3, "call_of_duty_modern_warfare_iii.webp", "Activision", 56, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Call of Duty: Modern Warfare III" },
                    { 60, "Avatar: Frontiers of Pandora is a first-person, action-adventure game set in the never-before-seen Western Frontier of Pandora. Abducted by the human militaristic corporation known as the RDA, you, a Na’vi, were trained and molded to serve their purpose. Fifteen years later, you are free, but find yourself a stranger in your birthplace. Reconnect with your lost heritage, discover what it truly means to be Na'vi, and join other clans to protect Pandora from the RDA.", "Massive Entertainment", 2, "avatar_frontiers_of_pandora.webp", "Ubisoft Entertainment", 72, new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avatar: Frontiers of Pandora" },
                    { 61, "Dash into a stylish and thrilling action-adventure platformer set in a mythological Persian world where the boundaries of time and space are yours to manipulate. Play as Sargon and evolve from sword-wielding prodigy to extraordinary legend as you master acrobatic combat and unlock new Time Powers and unique super abilities.", "Ubisoft Montpellier", 2, "prince_of_persia_the_lost_crown.webp", "Ubisoft Entertainment", 86, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prince of Persia: The Lost Crown" },
                    { 62, "Palworld is a brand-new, multiplayer, open-world survival crafting game where you can befriend and collect mysterious creatures called \"Pal\" in a vast world! Make your Pals fight, build, farm, and work in factories.", "PocketPair", 1, "palworld.webp", "PocketPair", 0, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Palworld" },
                    { 63, "The Last of Us Part II is an action-adventure game set five years after the events of The Last of Us. The player traverses post-apocalyptic environments such as buildings and forests to advance the story. They can use firearms, improvised weapons, and stealth to defend against hostile humans and cannibalistic creatures infected by a mutated strain of the Cordyceps fungus. The game intermittently switches control between Ellie and Abby, and also briefly Joel in the opening sequence. The nimble nature of the player character introduces platforming elements, allowing the player to jump and climb to traverse environments and gain advantages during combat.", "Naughty Dog", 3, "the_last_of_us_part_2_remastered.webp", "Sony Interactive Entertainment", 90, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last of Us Part II: Remastered" },
                    { 64, "Tekken 8 is the eighth canon release and tenth overall entry in the Tekken series. The game's story features 32 former and new characters, each with their own narrative that contributes to the overall story. Tekken 8 features upgraded fighting elements and systems from its predecessor, it also introduces brand-new mechanics such as the \"Heat\" system and \"Tornado\" hits. Arcade Quest was another addition to their online mode which includes tournaments, arcade features, customizable avatars and specialized currency that is featured throughout the game.", "Bandai Namco Studios", 7, "tekken_8.webp", "Bandai Namco Entertainment", 90, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tekken 8" },
                    { 65, "Rise of the Rōnin is a combat focused open-world action RPG that takes place in Japan at a time of great change. It is the very end of a 300-year long Edo Period, commonly known as “Bakumatsu”. Set in the late 19th century, Japan is facing the darkest of times as it struggles with its oppressive rulers and deadly diseases while western influence permeates as civil war continues to rage between the Tokugawa Shogunate and the Anti-Shogunate factions.", "Team NINJA", 1, "rise_of_the_ronin.webp", "Sony Interactive Entertainment", 76, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rise of the Rōnin" },
                    { 66, "Eve and her comrades land on the surface to reclaim the extinct Earth and cross paths with a survivor named Adam. Eve is then led by Adam to the last surviving city, Xion, where she meets the elder of the town Orcal and is told many stories. In order to serve her mission to save Earth, Eve develops close relationships with the key members of Xion and contributes to rebuilding the city. On a mission to save Earth from the NA:tive, Eve is also faced with helping out the citizens of Xion. Whether you will help the survivors or not, depends purely on your decision as the player.", "SHIFT UP", 1, "stellar_blade.webp", "Sony Interactive Entertainment", 81, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stellar Blade" },
                    { 67, "Black Myth: Wukong is an action RPG rooted in Chinese mythology. You shall set out as the Destined One to venture into the challenges and marvels ahead, to uncover the obscured truth beneath the veil of a glorious legend from the past.", "Game Science", 1, "black_myth_wukong.webp", "Game Science", 0, new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Myth: Wukong" },
                    { 68, "Developed by Treyarch and Raven, Black Ops 6 is a spy action thriller set in the early 90s, a period of transition and upheaval in global politics, characterized by the end of the Cold War and the rise of the United States as a single superpower. With a mind-bending narrative, and unbound by the rules of engagement, this is signature Black Ops. The Black Ops 6 Campaign provides dynamic moment-to-moment gameplay that includes a variety of play spaces with blockbuster set pieces and action-packed moments, high-stakes heists, and cloak-and-dagger spy activity. In a best-in-class Multiplayer experience, players will test their skills across 16 new maps at launch, including 12 core 6v6 maps and 4 Strike maps that can be played 2v2 or 6v6. Black Ops 6 also marks the epic return of Round-Based Zombies, the fan-favorite mode where players will take down hordes of the undead in two brand-new maps at launch. Post-launch, players can look forward to even more exciting maps and groundbreaking experiences dropping into both Multiplayer and Zombies.", "Treyarch", 3, "call_of_duty_black_ops_6.webp", "Activision", 0, new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Call of Duty: Black Ops 6" },
                    { 69, "Experience an epic historical action-adventure story set in feudal Japan! Become a lethal shinobi Assassin and a powerful legendary samurai as you explore a beautiful open world in a time of chaos. Switch seamlessly between two unlikely allies as you discover their common destiny. Master complementary playstyles, create your shinobi league, customize your hideout, and usher in a new era for Japan.", "Ubisoft Québec", 1, "assassins_creed_shadows.webp", "Ubisoft Entertainment", 0, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassin's Creed Shadows" },
                    { 70, "Grand Theft Auto VI heads to the state of Leonida, home to the neon-soaked streets of Vice City and beyond in the biggest, most immersive evolution of the Grand Theft Auto series yet.", "Rockstar Games", 3, "grand_theft_auto_vi.webp", "Take-Two Interactive", 0, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grand Theft Auto VI" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "GameId", "PlatformId", "Price" },
                values: new object[,]
                {
                    { 1, 1, 41.9m },
                    { 1, 2, 30m },
                    { 1, 3, 30m },
                    { 2, 1, 67.9m },
                    { 2, 2, 60.9m },
                    { 3, 4, 79.9m },
                    { 4, 1, 49.9m },
                    { 4, 2, 79.9m },
                    { 4, 3, 64.9m },
                    { 5, 1, 79.9m },
                    { 5, 2, 69.9m },
                    { 5, 3, 69.9m },
                    { 6, 1, 67.9m },
                    { 6, 2, 64.9m },
                    { 7, 1, 79.9m },
                    { 7, 2, 67.9m },
                    { 8, 1, 79.9m },
                    { 8, 3, 74.9m },
                    { 9, 1, 79.9m },
                    { 9, 2, 79.9m },
                    { 9, 3, 79.9m },
                    { 10, 4, 79.9m },
                    { 11, 4, 79.9m },
                    { 12, 1, 84m },
                    { 12, 2, 70.7m },
                    { 12, 3, 64.9m },
                    { 13, 1, 25m },
                    { 13, 2, 35.54m },
                    { 13, 3, 36m },
                    { 13, 4, 36.95m },
                    { 14, 1, 84m },
                    { 14, 2, 86.08m },
                    { 14, 3, 79.4m },
                    { 15, 1, 67.89m },
                    { 15, 2, 69m },
                    { 16, 4, 79.9m },
                    { 17, 4, 79.9m },
                    { 18, 4, 79.9m },
                    { 19, 1, 79.9m },
                    { 19, 2, 97.9m },
                    { 20, 1, 81.9m },
                    { 20, 3, 81.75m },
                    { 21, 1, 79.9m },
                    { 21, 2, 86.49m },
                    { 21, 3, 78.75m },
                    { 22, 1, 67.9m },
                    { 22, 2, 67.9m },
                    { 23, 2, 97.9m },
                    { 24, 1, 84m },
                    { 24, 2, 95.66m },
                    { 24, 3, 93.9m },
                    { 25, 1, 103.99m },
                    { 25, 2, 99.74m },
                    { 25, 3, 119.99m },
                    { 26, 1, 49.9m },
                    { 26, 2, 55.93m },
                    { 26, 3, 54.9m },
                    { 26, 4, 59.95m },
                    { 27, 1, 79.9m },
                    { 27, 2, 97.9m },
                    { 28, 1, 54m },
                    { 28, 2, 55.01m },
                    { 28, 3, 54m },
                    { 29, 1, 79.9m },
                    { 29, 2, 97.9m },
                    { 30, 1, 87m },
                    { 30, 2, 86.49m },
                    { 30, 3, 84.75m },
                    { 31, 1, 79.9m },
                    { 31, 2, 86.38m },
                    { 31, 3, 84.75m },
                    { 32, 1, 18.5m },
                    { 32, 2, 28.42m },
                    { 32, 3, 29.25m },
                    { 32, 4, 28.95m },
                    { 33, 1, 79.9m },
                    { 33, 3, 79.9m },
                    { 34, 4, 79.9m },
                    { 35, 4, 79.9m },
                    { 36, 1, 81.9m },
                    { 36, 3, 81.9m },
                    { 37, 4, 79.9m },
                    { 38, 1, 35.99m },
                    { 38, 2, 55.93m },
                    { 38, 3, 57.75m },
                    { 38, 4, 60m },
                    { 39, 1, 79.9m },
                    { 39, 2, 79.9m },
                    { 40, 1, 119.9m },
                    { 40, 2, 119.9m },
                    { 40, 3, 119.9m },
                    { 41, 2, 97.9m },
                    { 42, 1, 81.3m },
                    { 42, 2, 82.82m },
                    { 42, 3, 80.25m },
                    { 43, 1, 29m },
                    { 43, 2, 42.68m },
                    { 43, 3, 43.5m },
                    { 44, 1, 79.9m },
                    { 44, 2, 97.9m },
                    { 45, 1, 98m },
                    { 45, 2, 95.66m },
                    { 45, 3, 93.9m },
                    { 46, 1, 79.9m },
                    { 46, 2, 97.9m },
                    { 47, 4, 79.9m },
                    { 48, 4, 79.9m },
                    { 49, 1, 97.9m },
                    { 49, 2, 97.9m },
                    { 50, 1, 79.9m },
                    { 50, 2, 101.84m },
                    { 50, 3, 99m },
                    { 50, 4, 89.95m },
                    { 51, 1, 54.1m },
                    { 51, 2, 54.6m },
                    { 51, 3, 54.1m },
                    { 52, 4, 87.9m },
                    { 53, 1, 98m },
                    { 53, 2, 98m },
                    { 53, 3, 98m },
                    { 54, 1, 69m },
                    { 54, 2, 81.39m },
                    { 54, 3, 74.25m },
                    { 55, 1, 84.9m },
                    { 55, 2, 95.78m },
                    { 55, 3, 94.9m },
                    { 55, 4, 89.95m },
                    { 56, 1, 64.9m },
                    { 56, 2, 70.54m },
                    { 56, 3, 69.75m },
                    { 57, 2, 97.9m },
                    { 58, 1, 69.8m },
                    { 58, 2, 85.38m },
                    { 58, 3, 83.76m },
                    { 59, 1, 94m },
                    { 59, 2, 94.87m },
                    { 59, 3, 94m },
                    { 60, 1, 94.9m },
                    { 60, 2, 98.81m },
                    { 60, 3, 98.25m },
                    { 61, 1, 54.9m },
                    { 61, 2, 54.9m },
                    { 61, 3, 54.75m },
                    { 61, 4, 59.95m },
                    { 62, 1, 26m },
                    { 62, 3, 43.5m },
                    { 63, 2, 67.9m },
                    { 64, 1, 97.9m },
                    { 64, 2, 97.89m },
                    { 64, 3, 97.9m },
                    { 65, 2, 97.9m },
                    { 66, 2, 97.9m },
                    { 67, 1, 79.9m },
                    { 67, 2, 81.39m },
                    { 68, 1, 98m },
                    { 68, 2, 98m },
                    { 68, 3, 98m },
                    { 69, 1, 94.9m },
                    { 69, 2, 97.9m },
                    { 69, 3, 98.25m },
                    { 70, 2, 97.9m },
                    { 70, 3, 97.9m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GamePlatforms_PlatformId",
                table: "GamePlatforms",
                column: "PlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_GenreId",
                table: "Games",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GamePlatforms");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Platforms");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
