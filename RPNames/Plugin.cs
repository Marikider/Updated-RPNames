﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNames
{
    using System;
    using System.Collections.Generic;
    using Exiled.API.Features;
    using MEC;
    using Player = Exiled.Events.Handlers.Player;

    public class Plugin : Exiled.API.Features.Plugin<Config>
    {
        public override string Name { get; } = "Rp Names";
        public override string Author { get; } = "Babyboucher20 updated by Mariki";
        public override Version Version { get; } = new Version(1, 7, 0);
        public override Version RequiredExiledVersion { get; } = new Version(5, 0, 0);
        public override string Prefix { get; } = "RP Names";

        public EventHandlers.EventHandlers PlayerHandlers;

        public List<string> NickNames = new List<string> { "If you see this something went wrong", "Uh oh" };
        public override void OnEnabled()
        {
            if (Config.HumanNames.Count == 0)
            {
                NickNames = new List<string> { "Hyde", "Hood", "Hull", "Hogan", "Hitchens", "Higgins", "Hodder", "Huxx", "Hester", "King", "Kubiak", "Koker", "Kerrigan", "Kumara", "Knox", "Koufax", "Keagan", "Kestrel", "Future", "Fitzpatrick", "Fontana", "Fenner", "Furyk", "Finch", "Fullbright", "Fassbinder", "Flood", "Fong", "E.Gold", "Fleetwood", "Fugger", "Frost", "Fsik", "Fawcett", "Fishman", "Freeze", "Fissolo", "Foley", "Fairchild", "Freeman", "Decker", "Dobermann", "Dunlop", "Dumont", "Dandridge", "Diamond", "Cyrus", "Craggs", "Crisper", "Cotheran", "Curry", "Conard", "Cutler", "Coggins", "Cates", "Crisp", "Curio", "Murray", "Morrison", "McKay", "Merchant", "Murillo", "Mooney", "Murdock", "Matisse", "Massey", "McGee", "Minter", "Munson", "Oswald", "Ortega", "Ogle", "Orr", "Ogden", "Onassis", "Olson", "Ollenrenshaw", "Silver", "Small", "Stoneking", "Sweeney", "Surrett", "Swiatek", "Sloane", "Stapleton", "Seibert", "Stroud", "Strode", "Stockton", "Bright", "Miller", "Simarded", "Tombstone", "Cimmerian", "Conwell", "Clef", "Gears", "Kiryu", "Heiden", "Lloyd", "Marlowe", "Sorts", "Xyank", "Anborough", "LaFerrier", "Iceberg", "Kondraki", "Eskobar", "Anderson", "Ambrose", "Baudin", "Belitrov", "Chao", "Blackwood", "Fitzroy", "Silberescher", "Aktus", "Diaghilev", "Winchell", "Winters", "Walsh", "Whalen", "Watson", "Wooster", "Woodson", "Winthrop", "Wall", "Wight", "Webb", "Woodard", "Wixx", "Wong", "Whesker", "Wolfenstein", "Winchester", "Wire", "Wolf", "Wheeler", "Warrick", "Walcott", "Wilde", "Wexler", "Wells", "Weeks", "Wainright", "Wallace", "Weaver", "Wagner", "Wadd", "Withers", "Whitby", "Woodland", "Woody", "Warren", "Race", "Rooney", "Russo", "Rude", "Roland", "Reader", "Renshaw", "Rossi", "Riddle", "Ripa", "Richter", "Rosenberg", "Romo", "Ramirez", "Reagan", "Rainwater", "Romirez", "Riker", "Riggs", "Redman", "Reinhart", "Redgrave", "Rafferty", "Rigby", "Roman", "Reece", "Abawi", "Allard", "Adara", "Abbott", "Acampora", "Ackerman", "Ackroyd", "Abbington", "Axworthy", "Ainge", "Abernathy", "Atkinson", "Abner", "Abella", "Agholor", "Allred", "Asola", "Abrams", "Acker", "Abrell", "Acuff", "Archer", "Asterio", "Adair", "Albright", "Adelson", "Atwood", "Aguillar", "Adler", "Arrowood", "Arora", "Tray", "R.Tey", "A.Clef", "Amathor", "Jesus", "Joker", "Lemon", "Boucher", "Git", "Brook", "Broke", "Brown", "Smith", "Reed", "Freeman", "Guzman", "Simpson", "Gordan", "Silva", "Munoz", "Boyd", "Black", "Green", "Gray", "Purple", "Orange", "Apple", "Grapeseed", "Stone", "Meyer", "Schmidt", "Daniels", "Graza", "Soto", "Fox", "Hart", "Knight", "Night", "Cunningham", "Elliott", "Duncan", "Hudson", "Carroll", "Hoffman", "Pena", "Lawrence", "Chapman", "Rios", "Nunez", "Burke", "Maldonado", "Lawson", "O'brien", "Bishop", "Vega", "Le", "Bowman", "Davidson", "Brewer", "Newman", "Walsh", "Douglas", "Avila", "Bates", "Caldwell", "Lambert", "Neal", "Sutton", "Norris", "Rhodes", "Parks", "Vaughn", "Leon", "Horton", "Miles", "Warner", "Mann", "Zimmerman", "Dawson", "Lara", "Love", "Erickson", "Bladwin", "Salinas", "Ochoa", "Lin", "Liu", "Paul", "Ramsey", "Francis", "O'connor", "Pacheco", "Swanson", "Rivas", "Fitzgrald", "Gill", "Curry", "Mcgee", "Doyle", "Walton", "Brady", "Newton", "Goodman", "Roman", "Webster", "Fischer", "Potter", "Montoya", "Delacruz", "Adkins", "Reese", "Burgess", "Harmon", "Todd", "Wu", "Montoya", "Cannon", "Mack", "Tate", "Sherman", "Hubbard", "Hodges", "Zhang", "Zhang", "Wolf", "Valencia", "Saunders", "Franco", "Rowe", "Gallagher", "Farmer", "Hammond", "Townsend", "Hampton", "Wise", "Ingram", "Gallegos", "Clarke", "Barton", "Schroeder", "Maxwell", "Logan", "Norman", "Camacho", "Persons", "Colon", "Frank", "Glover", "Osborne", "Buchanan", "Casey", "Patton", "Ibarra", "Ball", "Tyler", "Suarez", "Bowers", "Orozco", "Salas", "Cobb", "Andrade", "Bauer", "Conner", "Moody", "Escobar", "Mcguire", "Pope", "McBride", "McCormick", "Lindsey", "Norton", "Kramer", "Sparks", "Flynn", "Yates", "Hogan", "Marsh", "Macias", "Villanueva", "Zamora", "Pratt", "Stokes", "Owen", "Ballard", "Lang", "Brock", "Villarreal", "Charles", "Drake", "Barrera", "Cain", "Patrick", "Pineda", "Burnett", "Mercado", "Santana", "Mercado", "Shepherd", "Bautista", "Ali", "Shaffer", "Lamb", "Trevino", "McKenzie", "Hess" ,"Beil", "Olsen", "Cochran", "Morton", "Nash", "Wilkins", "Peterson", "Briggs", "Shah", "Roth", "Nicholson", "Holloway", "Lozano", "Gambeno", "Flowers", "Rangel", "Hoover", "Short", "Mora", "Arias", "Valenzuela", "Bryan", "Meyers", "weilss", "Underwood", "Bass", "Summers", "Houston", "Carson", "Morrow", "Clayton", "Whitaker", "Decker", "Yoder", "Collier", "Zuniga", "Carey", "Wilcox","Clayton", "Whitaker", "Melendez", "Poole", "Roberson", "Larsen", "Conley", "Davenport", "Copeland", "Massey", "Lam", "Huff", "Rocha", "Cameron", "Jefferson", "Hood", "Monroe", "Anthony", "Pittman", "Huynh", "Randall", "Singleton", "Kirk", "Combs", "Mathis", "Christian", "Skinner", "Bradford", "Richard", "Galvan", "Wall", "Boone", "Kirby", "Wilkinson", "Bridges", "Bruce", "Atkinson", "Velez", "Meza", "Roy", "Vincent", "York", "Hodge", "Villa", "Abbott", "Allison", "Tapia", "Gates", "Chase", "Sosa", "Sweeney", "Farrell", "Wyatt", "Horn", "Dalton", "Barron", "Phelps", "Yu", "Dickerson", "Heath", "Foley", "Atkins", "Mathews", "Bonilla", "Acevedo", "Benitez", "Zavala", "Hensley", "Glenn", "Cisneros", "Harrel", "Shields", "Rubio", "Huffman", "Choi", "Boyer", "Garrison"};
            }
            else
            {
                NickNames = Config.HumanNames;
            }
            PlayerHandlers = new EventHandlers.EventHandlers(this);

            Player.ChangingRole +=  PlayerHandlers.OnPlayerChangeRole;
            Player.Died += PlayerHandlers.OnPlayerDeath;


            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Player.ChangingRole -= PlayerHandlers.OnPlayerChangeRole;
            Player.Died -= PlayerHandlers.OnPlayerDeath;

            base.OnDisabled();
        }
    }
}
