using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VTM_Generator
{
    #region Enum Setters
    enum VGoal
    {// Revenge
        Revenge_Self,              // Personal revenge for past wrongs
        Revenge_Other,             // Revenge on behalf of others
        Avenge_Clan,               // Avenge the destruction of one's clan or bloodline
        Destroy_Rival,             // Eliminate a rival vampire or organization

        // Power and Influence
        Amass_Wealth,              // Accumulate wealth and material resources
        Become_Prince,             // Ascend to the role of Prince or ruler of a city
        Control_Territory,         // Seize control of a specific territory or domain
        Gain_Political_Influence,  // Manipulate human or vampire politics for personal gain
        Build_Vampiric_Empire,     // Establish an empire through vampire progeny or mortal control
        Overthrow_Vampire_Leader,  // Topple the current vampire hierarchy
        Ascend_Clan_Ranks,         // Climb the ranks within the vampire clan or sect
        Control_Human_Society,     // Manipulate human systems (government, economy) for vampiric dominance

        // Knowledge and Discovery
        Uncover_Vampiric_Origin,   // Discover the true origin of vampires
        Master_Blood_Magic,        // Gain mastery over blood sorcery or rare disciplines
        Discover_Ancient_Artifact, // Find and harness the power of an ancient vampiric artifact
        Uncover_Secret_Ritual,     // Learn hidden vampire rituals or forbidden practices
        Unlock_Immortality_Secret, // Discover secrets to eternal life or transcendence beyond vampirism

        // Personal Redemption or Change
        Restore_Humanity,          // Regain lost humanity or mortality
        Find_Cure_Vampirism,       // Find a cure for vampirism or reverse the transformation
        Escape_Sire_Control,       // Break free from the control or influence of one's sire
        Transcend_Vampirism,       // Achieve spiritual or physical transcendence beyond the vampiric curse

        // Survival and Protection
        Survive_Final_Death,       // Avoid final death at all costs
        Protect_Loved_Ones,        // Ensure the safety of loved ones, be they mortal or vampiric
        Outlive_All_Rivals,        // Survive and outlast all vampiric and human enemies
        Preserve_Bloodline,        // Ensure the survival of one's vampiric progeny or clan

        // Control and Manipulation
        Manipulate_Mortal_Politics, // Use mortals to influence global or local politics
        Control_Supernatural_Entities, // Manipulate or control other supernatural forces (werewolves, mages, etc.)
        Build_Thrall_Army,          // Establish a network of thralls and ghouls for power and influence
        Corrupt_Mortal_Institutions, // Corrupt human institutions (church, government, etc.) for vampiric advantage

        // Spiritual and Philosophical Goals
        Understand_The_Beast,      // Understand and control the Beast within
        Challenge_The_Masquerade,  // Expose the truth of vampires to the mortal world
        Find_Meaning_In_Eternity,  // Discover a philosophical or spiritual truth to eternal existence
        Reconcile_With_Faith,      // Reconcile vampirism with religious or spiritual beliefs
        Achieve_Vampiric_Enlightenment, // Reach a higher state of vampiric or spiritual enlightenment
    }
    enum MundaneHGoal
    {// Revenge
        Revenge_Self,              // Seek revenge for personal wrongs
        Revenge_Other,             // Avenge someone else or a loved one
        Bring_Criminal_Justice,    // Bring a criminal or enemy to justice

        // Wealth and Power
        Amass_Wealth,              // Accumulate material wealth and financial power
        Climb_Social_Ladder,       // Gain social status or climb a societal ladder
        Gain_Political_Power,      // Gain influence in local or national politics
        Build_Corporate_Empire,    // Establish a powerful business or corporate empire
        Achieve_Fame,              // Become famous or renowned in a particular field (entertainment, media)
        Create_Artistic_Legacy,    // Leave behind a legacy of art, literature, or cultural impact

        // Knowledge and Discovery
        Discover_Ancient_Truths,   // Uncover lost or hidden historical knowledge
        Find_Cure,                 // Find a cure for a disease or medical condition (e.g., vampirism, rare illness)
        Solve_Mystery,             // Solve a personal or global mystery (e.g., disappearance, conspiracy)
        Uncover_Conspiracy,        // Unveil a hidden conspiracy, either mortal or supernatural
        Learn_Supernatural_Truth,  // Discover the truth about supernatural forces (vampires, ghosts, etc.)
        Attain_Higher_Education,   // Pursue knowledge or academic achievement
        Create_Scientific_Innovation, // Invent or discover groundbreaking scientific advancements
        Break_Technological_Barrier,  // Push the limits of technology or create new tech

        // Personal Growth and Redemption
        Seek_Redemption,           // Atone for past mistakes or sins
        Restore_Honor,             // Restore personal or family honor
        Find_Purpose,              // Discover personal meaning or purpose in life
        Overcome_Fear,             // Conquer a personal fear or mental block
        Achieve_Spiritual_Enlightenment, // Reach a state of spiritual or philosophical enlightenment
        Improve_Self,              // Personal improvement in skill, discipline, or fitness

        // Survival and Protection
        Protect_Loved_Ones,        // Keep family, friends, or loved ones safe from harm
        Survive_Impending_Doom,    // Survive a natural or supernatural threat (disaster, vampire, war)
        Outlive_Rivals,            // Survive or outlast business or personal rivals
        Build_Safe_Haven,          // Create a place of safety or refuge from threats
        Escape_Danger,             // Flee from imminent danger (e.g., a vampire or criminal organization)
        Ensure_Childrens_Future,  // Secure a safe and prosperous future for one's children
        Hide_Identity,             // Avoid detection or remain hidden from a pursuing force

        // Legacy and Family
        Create_Family_Legacy,      // Build a legacy for future generations
        Establish_Family_Lineage,  // Ensure the continuation of a family name or heritage
        Build_Community,           // Build or lead a community or organization for a greater good
        Make_History,              // Achieve something that will be remembered in the history books
        Ensure_Immortality_Through_Legacy, // Achieve immortality through deeds, accomplishments, or family

        // Moral and Ethical Goals
        Fight_For_Justice,         // Fight for a just cause, protect the innocent
        Stop_Abuse_Of_Power,       // Prevent misuse of power (government, corporate, supernatural)
        Expose_Corruption,         // Uncover and take down corrupt organizations or individuals
        Protect_Environment,       // Safeguard nature or fight against ecological destruction
        Advance_Human_Rights,      // Fight for the rights and dignity of marginalized groups
        Serve_Higher_Good,         // Work towards a greater moral or societal cause
        Uphold_Moral_Code,         // Remain steadfast in personal ethics or beliefs despite challenges

        // Financial and Material Goals
        Secure_Wealth_For_Future,  // Secure financial stability for future generations
        Buy_Luxury_Estates,        // Acquire high-end real estate or luxury properties
        Retire_Rich,               // Gain enough wealth to retire in comfort
        Start_Business,            // Start a personal business or entrepreneurial venture
        Win_Big_Investment,        // Succeed in a major financial investment (stock market, real estate)
        Acquire_Rare_Artifacts,    // Obtain valuable or rare material possessions (art, cars, antiques)

        // Social and Political Goals
        Win_Election,              // Win a political race or election
        Build_Influential_Network, // Establish connections in influential social or political circles
        Create_Grassroots_Movement, // Lead a social or political movement for change
        Influence_Policy,          // Influence government or corporate policy for a personal or greater cause

        // Career and Professional Goals
        Become_Leader,             // Attain leadership position in a company, military, or organization
        Climb_Career_Ladder,       // Climb the ranks in a profession or organization
        Publish_Best_Selling_Novel, // Write and publish a successful book or novel
        Win_Prestigious_Award,     // Earn recognition in a particular field with an award (Nobel, Oscars, etc.)
        Master_Craft,              // Achieve mastery in a specific trade, skill, or profession

        // Entertainment and Leisure
        Travel_The_World,          // Travel to exotic locations around the globe
        Experience_Adventures,     // Seek thrilling experiences and adventures
        Attend_Exclusive_Events,   // Gain access to high-profile parties, galas, or secret events
    }
    enum OcculteHGoal {
        Revenge_Self,
        Revenge_Other,
        Amass_Wealth,
        Discover_Occult_Power,
        Protect_From_Supernatural_Threats,
        Seek_Immortality,
        Ally_With_Supernatural_Beings,
        Destroy_Supernatural_Entities,
        Uncover_Ancient_Secrets,
        Master_Magic,
        Control_Supernatural_Forces,
        Find_Occult_Artifacts,
        Gain_Influence_In_Supernatural_Communities,
        Survive_Against_The_Undead,
        // Survival and Protection
        Protect_Loved_Ones,        // Keep family, friends, or loved ones safe from harm
        Survive_Impending_Doom,    // Survive a natural or supernatural threat (disaster, vampire, war)
        Outlive_Rivals,            // Survive or outlast business or personal rivals
        Build_Safe_Haven,          // Create a place of safety or refuge from threats
        Escape_Danger,             // Flee from imminent danger (e.g., a vampire or criminal organization)
        Ensure_Childrens_Future,  // Secure a safe and prosperous future for one's children
        Hide_Identity           // Avoid detection or remain hidden from a pursuing force

    }
    enum Motive {
        Power,           // Desire to control or dominate
        Revenge,         // To settle a personal score
        Redemption,      // To atone for past actions
        Survival,        // Desire for immortality, survival
        Love,            // To protect someone or something
        Curiosity,       // Desire to uncover secrets or knowledge
        Escape,          // Want to flee from control or danger
        Duty,            // Feel compelled by responsibility or honor
        Greed,           // Desire for wealth or material gain
        Belonging,        // Desire to fit in or gain acceptance
        Power_And_Control,
        Fear_Of_Death,
        Freedom,
        Love_And_Protection,
        Ambition,
        Duty_And_Honor,
        Legacy,
        Pleasure,
        Justice,
        Faith_And_Religion,
        Vengeance,
        Knowledge_And_Mastery,
        Rebellion
    }
    enum VClan
    { // Camarilla Clans
        Brujah,
        Malkavian,
        Nosferatu,
        Toreador,
        Tremere,
        Ventrue,

        // Sabbat Clans
        Lasombra,
        Tzimisce,

        // Independent Clans
        Assamite,
        FollowersOfSet, // Also known as Setites
        Giovanni,
        Ravnos,

        // Anarch Clans (could belong to any sect but have a strong presence in the Anarch Movement)
        Caitiff, // Clanless vampires
    }
    public enum SuperNaturalJob
    {
        OccultInvestigator,
        WitchHunter,
        Demonologist,
        CultLeader,
        MageApprentice
    }
    public enum SkillMethod { JackOfTrades, Balanced, Specalist }
    public enum MortalJob
    {
        Doctor,
        Lawyer,
        Teacher,
        Mechanic,
        Shopkeeper
    }
    enum MortalAge { Young_adult, mature_adult, Senior_Adult, Elderly }
    enum Sect { Carmillia, Sabbat, Anarchist }
    enum Loyalty { Devout, Unloyal, Spy, To_Survive }
    enum Relation { Hostile, Posititve, neutral }
    #endregion
    internal class Char()
    {
        int ConsoleColour;
        string FullName = "";
        string BirthDate = "";
        int Age;
        int Byear = 0;
        VGoal CharVGoal;
        MundaneHGoal CharHGoal;
        OcculteHGoal CharHoccGoal;
        MortalAge CharAge;
        SkillMethod CharSkillType;
        Motive CharMotive;
        Sect VSect;
        MortalJob Mortaljob;
        SuperNaturalJob SuperNaturaljob;
        Loyalty VLoyalty;

        StringChoice? StringChoice;
        IntChoice? IntChoice;
        bool IsVampire;
        bool IsAwareOccult;
        //Character.
        //Name (First, Middle, Last), Title. Done
        //Age, Birthdate. Done
        //Goal Done
        //motivation Done
        //Reaction to assistance
        //reaction to obstacles
        //likes, dislikes
        //Is Vampire? Done
        //When were they embraced (max age) Done
        //Reason for embrace. Done
        //Generation Done
        //Clan Done
        //Affiliation Done
        //Role in affiliation Done
        //Job Done
        //Family size
        //Wealth
        //Country of origin
        //attributes Done
        //skills Done
        //humanity

        public void StartGenerate()
        {
            RandomConsoleColour();
            MortalStatus();
            Name();
            SetAge();
            History();
            Plan();
            affiliation();

            GenerateAttributes();
            GenerateSkills();
            Humanity();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
        }
        void RandomConsoleColour()
        {

            int NewConsoleColour = new Random().Next(14);
            if (NewConsoleColour == ConsoleColour)
            {
                NewConsoleColour = new Random().Next(14);

            }
            ConsoleColour = NewConsoleColour;
            switch (ConsoleColour)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case 10:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case 11:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 12:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case 13:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case 14:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
            }

        }
        void MortalStatus()
        {
            int Outcome = new Random().Next(2);
            if (Outcome == 0)
            {
                IsVampire = true;
            }
            else
            {
                IsVampire = false;
            }
        }


        void Name()
        {
            Console.WriteLine("");
            Console.WriteLine("Name:");

            string FirstName, MiddleName, LastName, Title;
            bool hasMiddleName;
            int Outcome = new Random().Next(0, 1);

            if (Outcome == 0)
            { hasMiddleName = true; } else { hasMiddleName = false; }

            if (IsVampire)
            {
                string[] VampFirstNameArray = new string[] { "Adrian", "Alaric", "Alexandra", "Amelia", "Anastasia", "Anton", "Aria", "Ash", "Astrid", "Avery", "Beatrix", "Briar", "Caleb", "Callista", 
                    "Cassius", "Celeste", "Dante", "Darius", "Delilah", "Dominic", "Eleanor", "Elara", "Elijah", "Emilia", "Evander", "Felix", "Freya", "Gideon", "Hazel", "Helena", "Hugo", "Iris", 
                    "Isabella", "Jasper", "Julian", "Katarina", "Killian", "Leon", "Lilith", "Lorenzo", "Lydia", "Magnus", "Malcolm", "Marceline", "Matthias", "Mirella", "Nathaniel", "Nico", "Octavia", 
                    "Ophelia", "Orion", "Penelope", "Percival", "Quentin", "Raven", "Reina", "Ren", "Rowan", "Salem", "Sasha", "Sebastian", "Seraphina", "Silas", "Soren", "Stella", "Sylvia", "Tatiana", 
                    "Theodore", "Thorne", "Tristan", "Uriah", "Valentina", "Victor", "Violet", "Vivian", "Wesley", "Wilhelmina", "Wren", "Xander", "Yara", "Yvonne", "Zachariah", "Zara", "Zephyr", "Aisling", 
                    "Anwen", "Azrael", "Balthazar", "Bellamy", "Blaise", "Coraline", "Desdemona", "Evangeline", "Lucien", "Oberon", "Selene", "Thalia", "Verity", "Wolfgang", "Zane" };

                string[] VampLastNameArray = new string[] { "Archer", "Ashford", "Axton", "Baines", "Bennett", "Blackwood", "Blake", "Blanchard", "Boucher", "Byrne", "Calder", "Carver", "Castell", "Chambers", 
                    "Crawford", "Cross", "Darcy", "Delacroix", "Donovan", "Doyle", "Draper", "Duval", "Eldridge", "Everly", "Faulkner", "Fletcher", "Frost", "Galloway", "Garnet", "Graves", "Grey", "Hale", "Hart", 
                    "Hawthorne", "Hendrix", "Holloway", "Hunt", "Ingram", "Jasper", "Kane", "Kavanagh", "Kincaid", "Lancaster", "Langley", "Locke", "Lynch", "Mallory", "March", "Margrave", "Monroe", "Morgan", 
                    "Moriarty", "Nightingale", "North", "Osborne", "Payne", "Pryor", "Quincy", "Ravenwood", "Redgrave", "Reed", "Remington", "Roth", "Rowe", "Sinclair", "Stanton", "Sterling", "Stroud", "Sutton", 
                    "Talbot", "Thorne", "Thornton", "Travers", "Valentine", "Vance", "Voss", "Ward", "Wells", "Whitmore", "Wilde", "Winchester", "Wolfe", "Woodrow", "Worthington", "York", "Yates", "Ainsley", 
                    "Beaumont", "Carmichael", "Cavanaugh", "Fairchild", "Kingsley", "Langston", "Montgomery", "Pembroke", "Radcliffe", "Selby", "Tremont", "Vanderbilt", "Wyndham", "Yardley", "Zephyr" };

                string[] VampTitlesArray = new string[] { 
                //Carmillia
                "Prince", "Primogen", "Seneschal", "Keeper of Elysium", "Harpy", "Sheriff", "Scourge", "Justicar", "Archon", "Regent", "Whip", "Ancilla", "Elder", "Neonate", "Chamberlain", "Master of Harpies", 
                    "Warden", "Chancellor", "Lord", "Dame",
                    //Anarchist
                    "Baron", "Emissary", "Enforcer", "Speaker", "Warlord", "Outlaw", "Iconoclast", "Firebrand", "Revolutionary", "Protector", "Councilor", "Provocateur", "Liaison", "Renegade", "Nomad", "Mediator", 
                    "Defender", "Agitator", "Rebel", "Vanguard",
                    //Sabbat
                    "Archbishop", "Cardinal", "Priscus", "Ductus", "Templar", "Paladin", "Inquisitor", "Seraph", "Bishop", "Abbot", "Crusader", "War Priest", "Monomancer", "Confessor", "Flesh Sculptor", "Judge", 
                    "Ravager", "Lore Keeper", "Blood Apostle", "Herald",
                    //clanless
                    "Shade", "Fang", "Raven", "Wraith", "Ghost", "Grim", "Bloodhound", "Jackal", "Shadowblade", "Nightstalker", "Rogue", "Viper", "Whisper", "Wolf", "Scar", "Revenant", "Bones", "Hollow", "Blaze", 
                    "Echo", "Vermin", "Crow", "Harbinger", "Slayer", "Murmur", "Phantom", "Valkyrie", "Frost", "Hunter", "Ash", "Dusk", "Specter", "Gloom", "Hellhound", "Banshee", "Stalker", "Fury", "Bite", "Serpent", 
                    "Void", "Shadewalker", "Nomad", "Silhouette", "Rascal", "Ruin", "Dagger", "Sable", "Abyss", "Midnight", "Reckoner"

                };

                FirstName = VampFirstNameArray[new Random().Next(0, VampFirstNameArray.Length)];
                LastName = VampLastNameArray[new Random().Next(0, VampLastNameArray.Length)];
                Title = VampTitlesArray[new Random().Next(0, VampTitlesArray.Length)];

                if (hasMiddleName == true)
                {
                    string[] VampMiddleNameArray = new string[] { "Alice", "Arthur", "August", "Belle", "Blair", "Cael", "Cassandra", "Cassian", "Celine", "Cyrus", "Dahlia", "Damon", "Dorian", "Edith", "Edwin", 
                        "Elias", "Elise", "Ember", "Emil", "Estelle", "Faye", "Florence", "Galen", "Genevieve", "Giselle", "Grant", "Gwen", "Heath", "Heloise", "Ignatius", "Isidore", "James", "Jane", "Jude", 
                        "Kalliope", "Laurence", "Leander", "Lenore", "Luca", "Maeve", "Marcus", "Marian", "Maxwell", "Nadia", "Naomi", "Nathaniel", "Niamh", "Noelle", "Odette", "Orson", "Paige", "Pearl", 
                        "Peregrine", "Renee", "Rex", "Rose", "Rowena", "Sable", "Samson", "Selena", "Severin", "Shea", "Solomon", "Sullivan", "Sybil", "Tamsin", "Tate", "Thea", "Tristan", "Ulysses", "Una", 
                        "Vera", "Verne", "Viola", "Walter", "Winifred", "Xavier", "Yvonne", "Zachary", "Zenobia", "Alaric", "Aurora", "Bran", "Caius", "Dara", "Emrys", "Fenris", "Gideon", "Isolde", "Lysander", 
                        "Mordecai", "Orion", "Phaedra", "Seren", "Theron", "Valeria", "Wilhelm", "Zara" };

                    MiddleName = VampMiddleNameArray[new Random().Next(0, VampMiddleNameArray.Length)];
                    FullName = FirstName + " " + MiddleName + " " + LastName;
                }
                else
                {
                    FullName = FirstName + " " + LastName;

                }


                Console.WriteLine("Name: " + FullName);
                Console.WriteLine("Title: " + Title);
            }

            //Human
            else
            {
                string[] HumFirstNameArray = new string[] { "Oliver", "Emma", "Liam", "Ava", "Noah", "Sophia", "James", "Isabella", "Ethan", "Mia", "Benjamin", "Charlotte", "Lucas", "Amelia", "Henry", "Harper", 
                    "Alexander", "Evelyn", "William", "Abigail", "Samuel", "Ella", "Jack", "Scarlett", "Daniel", "Grace", "Sebastian", "Lily", "David", "Chloe", "Matthew", "Zoe", "Andrew", "Aria", "Joseph", 
                    "Aurora", "Christopher", "Savannah", "Thomas", "Hannah", "Anthony", "Stella", "Charles", "Violet", "Jonathan", "Ellie", "Nathan", "Hazel", "Gabriel", "Lucy", "Ryan", "Sophie", "Isaac", 
                    "Madeline", "Joshua", "Ruby", "Christian", "Alice", "Adam", "Eleanor", "Dylan", "Eva", "Aaron", "Layla", "Leo", "Willow", "Caleb", "Clara", "Owen", "Ivy", "Lucas", "Isla", "Miles", "Paisley", 
                    "Connor", "Emilia", "Evan", "Natalie", "Adrian", "Julia", "Mason", "Luna", "Ryder", "Sadie", "Brandon", "Piper", "Colin", "Jade", "Kyle", "Aurora", "Jason", "Serena", "Marcus", "Elena", 
                    "Justin", "Maya", "Hunter", "Faith", "Jared", "Morgan", "Bryce", "Rose" };

                string[] HumLastNameArray = new string[] { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez", "Hernandez", "Lopez", "Gonzalez", "Wilson", 
                    "Anderson", "Thomas", "Taylor", "Moore", "Jackson", "Martin", "Lee", "Perez", "Thompson", "White", "Harris", "Sanchez", "Clark", "Ramirez", "Lewis", "Robinson", "Walker", "Young", "Allen", 
                    "King", "Wright", "Scott", "Torres", "Nguyen", "Hill", "Flores", "Green", "Adams", "Nelson", "Baker", "Hall", "Rivera", "Campbell", "Mitchell", "Carter", "Roberts", "Gomez", "Phillips", 
                    "Evans", "Turner", "Diaz", "Parker", "Edwards", "Collins", "Stewart", "Sanchez", "Morris", "Rogers", "Reed", "Cook", "Morgan", "Bell", "Murphy", "Bailey", "Rivera", "Cooper", "Richardson", 
                    "Cox", "Howard", "Ward", "Torres", "Peterson", "Gray", "Ramirez", "James", "Watson", "Brooks", "Kelly", "Sanders", "Price", "Bennett", "Wood", "Barnes", "Ross", "Henderson", "Coleman", 
                    "Jenkins", "Perry", "Powell", "Long" };

                string[] HumTitlesArray = new string[] { 
                    //Non Occult
                    "Red", "Buddy", "Ace", "Smokey", "Duke", "Sunny", "Skipper", "Raven", "Sparky", "Tater", "Champ", "Blue", "Rocky", "Gizmo", "Bear", "Dash", "Flash", 
                    "Tank", "Slim", "Bubba", "Pepper", "Roxie", "Jax", "Doodle", "Penny", "Noodle", "Shorty", "Maverick", "Cuddles", "Chewy", "Squeaky", "Cookie", "Gadget", "Whiskers", "Twinkle", "Rusty", 
                    "Pookie", "Fuzzy", "Sandy", "Spike", "Munchkin", "Biscuit", "Jellybean", "Pumpkin", "Sassy", "Binky", "Daisy", "Ziggy", "Nugget", "Buddy", "Chipper", "Scooter", "Bubbles", "Honey", 
                    "Peanut", "Munchie", "Sugar", "Twix", "Socks", "Sprout", "Gummy", "Teddy", "Pipsqueak", "Waffles", "Zippy", "Sparrow", "Snickers", "Doodles", "Chili", "Twitch", "Cheddar", "Dash", 
                    "Snickerdoodle", "Snickerdoodle", "Bambi", "Muffin", "Scooch", "Flick", "Fawn", "Sizzle", "Dusty", "Flip", "Choco", "Snooze", "Skittles", "Coco", "Nibbles", "Squirt", "Gidget", "Bunny", 
                    "Toffee", "Chipper", "Jasmine", "Wiggles",
                    //Occult
                    "Hex", "Wraith", "Shade", "Raven", "Mystic", "Grim", "Specter", "Luna", "Rune", "Haven", "Witchy", "Gloom", "Oracle", "Nightshade", "Fate", "Chant", "Cinder", "Psyche", "Nocturne", "Fable", 
                    "Veil", "Silhouette", "Eclipse", "Ember", "Ritual", "Frost", "Sorcerer", "Phantom", "Coven", "Banshee", "Fable", "Kismet", "Dusk", "Jinx", "Wraith", "Wendigo", "Soul", "Spirit", "Ash", 
                    "Ritualist", "Wisp", "Sable", "Twilight", "Charmed", "Nimbus", "Necro", "Myst", "Shade", "Hecate", "Oracle", "Cauldron", "Shiver", "Oracle", "Gloom", "Rook", "Poe", "Obsidian", "Hollow", 
                    "Silence", "Charmed", "Witchlight", "Willow", "Runeweaver", "Zephyr", "Crypt", "Murmur", "Maven", "Spellbound", "Mystwalker", "Gloomweaver", "Thorn", "Witchfinder", "Phaedra", "Nox", "Abyss", 
                    "Briar", "Revenant", "Darkling", "Riven", "Hollow", "Demon", "Briar", "Gossamer", "Nightfall", "Fleeting", "Corvid", "Veil", "Serpent", "Cinder", "Echo"
                };

                FirstName = HumFirstNameArray[new Random().Next(0, HumFirstNameArray.Length)];
                LastName = HumLastNameArray[new Random().Next(0, HumLastNameArray.Length)];
                Title = HumTitlesArray[new Random().Next(0, HumTitlesArray.Length)];

                if (hasMiddleName == true)
                {
                    string[] HumMiddleNameArray = new string[] { "James", "Marie", "Elizabeth", "Ann", "Joseph", "Grace", "Michael", "Rose", "William", "Louise", "Lee", "Alyssa", "David", "Nicole", "John", 
                        "Mae", "Christopher", "Lynn", "Anne", "Scott", "Jade", "Matthew", "Diane", "Paul", "Renee", "Thomas", "Jean", "Edward", "Samantha", "Benjamin", "Faith", "Patrick", "Kay", "Anthony", 
                        "Dawn", "Charles", "Nina", "Alexander", "Hope", "Henry", "Iris", "Samuel", "Chloe", "Daniel", "Sophie", "Andrew", "Faye", "Evelyn", "Liam", "Victoria", "Gabriel", "Ella", "Isaac", 
                        "Brielle", "Luke", "Catherine", "Owen", "Ruth", "Jonathan", "Isabelle", "Michael", "Hazel", "Ryan", "Autumn", "Adrian", "Paige", "Jasper", "Brooke", "Derek", "Elena", "Henry", "Ivy", 
                        "Matthew", "Skye", "Julian", "Wren", "Nicholas", "Tessa", "Grant", "Sienna", "Elijah", "Claire", "Marcus", "Delilah", "Vincent", "Giselle", "Aidan", "Serenity", "Leo", "Marilyn", 
                        "Nathan", "Daphne", "Sebastian", "Joy", "Eric", "Miriam", "Colton", "Blythe" };
                    MiddleName = HumMiddleNameArray[new Random().Next(0, HumMiddleNameArray.Length)];
                    FullName = FirstName + " " + MiddleName + " " + LastName;
                }
                else
                {
                    FullName = FirstName + " " + LastName;

                }

                Console.WriteLine("Name: " + FullName);
                Console.WriteLine("Title: " + Title);
            }

        }

        void SetAge()
        {
            Console.WriteLine("");
            Console.WriteLine("Age:");

            int CurrentAge;
            int Outcome = new Random().Next(0, 4); // Include 3 as a possible case value

            if (IsVampire)
            {
                CurrentAge = new Random().Next(20, 9000); // Vampires can be extremely old

                switch (Outcome)
                {
                    case 0:
                        CharAge = MortalAge.Young_adult;
                        break;
                    case 1:
                        CharAge = MortalAge.mature_adult;
                        break;
                    case 2:
                        CharAge = MortalAge.Senior_Adult;
                        break;
                    case 3:
                        CharAge = MortalAge.Elderly;
                        break;
                }
            }
            else
            {
                CurrentAge = new Random().Next(20, 80); // Humans have limited lifespans

                // Fix the conditions to avoid overlaps
                if (CurrentAge < 30)
                {
                    CharAge = MortalAge.Young_adult;
                }
                else if (CurrentAge < 40)
                {
                    CharAge = MortalAge.mature_adult;
                }
                else if (CurrentAge < 60)
                {
                    CharAge = MortalAge.Senior_Adult;
                }
                else
                {
                    CharAge = MortalAge.Elderly;
                }
            }

            int BDay = 0; int BMonth = 0;
            Byear = 2024 - CurrentAge;

            // If Byear is negative, convert to BCE
            string era = "CE";
            if (Byear <= 0)
            {
                Byear = Math.Abs(Byear) + 1; // Convert to positive BCE
                era = "BCE";
            }

            BMonth = new Random().Next(12) + 1;

            switch (BMonth)
            {
                case 1:
                    BDay = new Random().Next(1, 32);
                    break;
                case 2:
                    BDay = new Random().Next(1, 29); // Could add leap year check if needed
                    break;
                case 3:
                    BDay = new Random().Next(1, 32);
                    break;
                case 4:
                    BDay = new Random().Next(1, 31);
                    break;
                case 5:
                    BDay = new Random().Next(1, 32);
                    break;
                case 6:
                    BDay = new Random().Next(1, 31);
                    break;
                case 7:
                    BDay = new Random().Next(1, 32);
                    break;
                case 8:
                    BDay = new Random().Next(1, 32);
                    break;
                case 9:
                    BDay = new Random().Next(1, 31);
                    break;
                case 10:
                    BDay = new Random().Next(1, 32);
                    break;
                case 11:
                    BDay = new Random().Next(1, 31);
                    break;
                case 12:
                    BDay = new Random().Next(1, 32);
                    break;
            }

            BirthDate = $"BirthDay: {BDay} | Month: {BMonth} | Birth Year: {Byear} {era}";

            Age = CurrentAge;

            Console.WriteLine($"Years old: {Age}");
            Console.WriteLine($"General appearance: {CharAge}");
            Console.WriteLine(BirthDate);
        }

        void History()
        {
            //Vampire
            // - When Embraced Done - Reason for embrace Done - Generate Done - Clan Done - relation to sire Done
            if (IsVampire)
            {
                // Common properties
                string EmbraceDate = "";
                Motive EmbracedReason;
                VClan Clan;
                Relation SireRelation;
                Random random = new Random();

                // Reason for Embracing
                Array embracedValues = Enum.GetValues(typeof(Motive));
                EmbracedReason = (Motive)embracedValues.GetValue(random.Next(embracedValues.Length));

                // Clan
                Array clanValues = Enum.GetValues(typeof(VClan));
                Clan = (VClan)clanValues.GetValue(random.Next(clanValues.Length));

                // Sire relation
                Array SireRelationVaues = Enum.GetValues(typeof(Relation));
                SireRelation = (Relation)SireRelationVaues.GetValue(random.Next(SireRelationVaues.Length));

                // Embrace Date Generation
                int embracedAge = 0;
                int day = random.Next(1, 32); // Day range can be 1 to 31 (later adjusted based on the month)
                int month = random.Next(1, 13); // Month range 1 to 12

                // Adjust day based on the month
                if (month == 2) // February
                {
                    day = random.Next(1, 29); // Could be simplified to skip leap years
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11) // 30-day months
                {
                    day = random.Next(1, 31);
                }

                // Based on character age, determine the year they were embraced
                switch (CharAge)
                {
                    case MortalAge.Young_adult:
                        embracedAge = random.Next(18, 28);
                        break;
                    case MortalAge.mature_adult:
                        embracedAge = random.Next(28, 50);
                        break;
                    case MortalAge.Senior_Adult:
                        embracedAge = random.Next(50, 70);
                        break;
                    case MortalAge.Elderly:
                        embracedAge = random.Next(70, 90);
                        break;
                }

                int Generation = random.Next(5, 15);



                int embracedYear = Byear + embracedAge; // Calculate embrace year based on birth year
                EmbraceDate = $"{day}/{month}/{embracedYear}";

                // Output
                Console.WriteLine($"This vampire was embraced on: {EmbraceDate}");
                Console.WriteLine($"They were embraced when they were: {embracedAge} years old");
                Console.WriteLine("");
                Console.WriteLine($"They were embraced by their sire for: {EmbracedReason}");
                Console.WriteLine($"The vampire's sire was a generation: {Generation}");
                Console.WriteLine($"The vampire's relation with their sire is: {SireRelation}");
                Console.WriteLine("");
                Console.WriteLine($"The vampire's generation is: {Generation + 1}");
                Console.WriteLine($"The vampire is of Clan {Clan} Lineage");
                Console.WriteLine("");

            }
            else
            {
                // Human-specific history if needed
            }

        }

        void affiliation()
        {
            Console.WriteLine("");
            Console.WriteLine("Affiliation state:");
            Random random = new Random();
            if (IsVampire)
            {
                // Sect of vamp
                Array SectValues = Enum.GetValues(typeof(Sect));
                VSect = (Sect)SectValues.GetValue(random.Next(SectValues.Length));

                // Sire relation
                Array LoyaltyValues = Enum.GetValues(typeof(Loyalty));
                VLoyalty = (Loyalty)LoyaltyValues.GetValue(random.Next(LoyaltyValues.Length));

                Console.WriteLine($"This vampire claims to be a {VSect}");
                Console.WriteLine($"Their loyalty is: {VLoyalty}");
            }
            //Human
            else
            {
                //Is aware of occult
                if (IsAwareOccult)
                {
                    Array SuperJobValues = Enum.GetValues(typeof(SuperNaturalJob));
                    SuperNaturaljob = (SuperNaturalJob)SuperJobValues.GetValue(random.Next(SuperJobValues.Length));
                    Console.WriteLine($"This Occult mortal job is: {SuperNaturaljob}");
                }
                //Is NOT aware of occult
                else
                {
                    Array MortalJobValues = Enum.GetValues(typeof(MortalJob));
                    Mortaljob = (MortalJob)MortalJobValues.GetValue(random.Next(MortalJobValues.Length));
                    Console.WriteLine($"This Mundane mortals job is: {Mortaljob}");
                }


            }



        }
        void Plan()
        {
            Console.WriteLine("");
            Console.WriteLine("Plan:");

            if (IsVampire)
            {
                // Get all values from the enum
                Array values = Enum.GetValues(typeof(VGoal));

                // Generate a random index within the bounds of the enum values
                Random random = new Random();
                VGoal randomGoal = (VGoal)values.GetValue(random.Next(values.Length));
                CharVGoal = randomGoal;

                //Motive

                // Get all values from the enum
                Array Motivevalues = Enum.GetValues(typeof(Motive));

                // Generate a random index within the bounds of the enum values
                Random Mrandom = new Random();
                Motive MrandomMotive = (Motive)Motivevalues.GetValue(random.Next(Motivevalues.Length));
                CharMotive = MrandomMotive;

                Console.WriteLine($"This vampire's motive is: {CharMotive}");
                Console.WriteLine($"This vampire's goal is: {CharVGoal}");
            }

            else //Human
            {
                int Outcome = new Random().Next(2);
                if (Outcome == 0)
                {
                    IsAwareOccult = true;
                    // Get all values from the enum
                    Array values = Enum.GetValues(typeof(OcculteHGoal));

                    // Generate a random index within the bounds of the enum values
                    Random random = new Random();
                    OcculteHGoal randomGoal = (OcculteHGoal)values.GetValue(random.Next(values.Length));
                    CharHoccGoal = randomGoal;

                    //Motive


                    // Get all values from the enum
                    Array Mvalues = Enum.GetValues(typeof(Motive));

                    // Generate a random index within the bounds of the enum values
                    Random Mrandom = new Random();
                    Motive MrandomMotive = (Motive)Mvalues.GetValue(random.Next(Mvalues.Length));
                    CharMotive = MrandomMotive;

                    Console.WriteLine($"This Human's motive is: {CharMotive}");
                    Console.WriteLine($"This Humans's goal is: {CharHoccGoal}");
                    Console.WriteLine("This human is aware of supernatural forces.");

                }
                else
                {
                    IsAwareOccult = false;
                    // Get all values from the enum
                    Array values = Enum.GetValues(typeof(MundaneHGoal));

                    // Generate a random index within the bounds of the enum values
                    Random random = new Random();
                    MundaneHGoal randomGoal = (MundaneHGoal)values.GetValue(random.Next(values.Length));
                    CharHGoal = randomGoal;

                    //Motive

                    // Get all values from the enum
                    Array Mvalues = Enum.GetValues(typeof(Motive));

                    // Generate a random index within the bounds of the enum values
                    Random Mrandom = new Random();
                    Motive MrandomMotive = (Motive)Mvalues.GetValue(random.Next(Mvalues.Length));
                    CharMotive = MrandomMotive;

                    Console.WriteLine($"This Human's motive is: {CharMotive}");
                    Console.WriteLine($"This Humans's goal is: {CharHGoal}");
                    Console.Write("This human is not aware of supernatural forces.");

                }


            }
        }

        void GenerateAttributes()
        {
            Console.WriteLine("");
            //Vampire Stats
            if (IsVampire)

            {
                // Define the number of each attribute level
                int[] attributePool = { 1, 2, 2, 2, 2, 3, 3, 3, 4 };

                // Shuffle the pool to randomize the distribution
                Random rand = new Random();
                attributePool = attributePool.OrderBy(x => rand.Next()).ToArray();

                // Allocate attributes to Physical, Social, and Mental
                int[] Physical = new int[] { attributePool[0], attributePool[1], attributePool[2] };
                int[] Social = new int[] { attributePool[3], attributePool[4], attributePool[5] };
                int[] Mental = new int[] { attributePool[6], attributePool[7], attributePool[8] };

                // Output the results
                Console.WriteLine("Attributes");
                Console.WriteLine("Physical: " + string.Join(", ", Physical));
                Console.WriteLine("Social: " + string.Join(", ", Social));
                Console.WriteLine("Mental: " + string.Join(", ", Mental));
            }
            //Human Stats
            else
            {
                // Define the number of each attribute level
                int[] attributePool = { 1, 1, 2, 2, 2, 2, 2, 3, 3 };

                // Shuffle the pool to randomize the distribution
                Random rand = new Random();
                attributePool = attributePool.OrderBy(x => rand.Next()).ToArray();

                // Allocate attributes to Physical, Social, and Mental
                int[] Physical = new int[] { attributePool[0], attributePool[1], attributePool[2] };
                int[] Social = new int[] { attributePool[3], attributePool[4], attributePool[5] };
                int[] Mental = new int[] { attributePool[6], attributePool[7], attributePool[8] };

                // Output the results
                Console.WriteLine("Attributes");
                Console.WriteLine("Physical: " + string.Join(", ", Physical));
                Console.WriteLine("Social: " + string.Join(", ", Social));
                Console.WriteLine("Mental: " + string.Join(", ", Mental));
            }
            //Filler
            Console.WriteLine("");
        }

        void GenerateSkills()
        {
            #region Dictionaries
            // Skill dictionaries mapping skill IDs to skill names
            Dictionary<int, string> PhysicalSkillNames = new Dictionary<int, string>()
    {
        { 1, "Athletics" }, { 2, "Brawl" }, { 3, "Craft" }, { 4, "Drive" }, { 5, "Firearms" },
        { 6, "Larceny" }, { 7, "Melee" }, { 8, "Stealth" }, { 9, "Survival" }
    };

            Dictionary<int, string> SocialSkillNames = new Dictionary<int, string>()
    {
        { 1, "Animal Ken" }, { 2, "Etiquette" }, { 3, "Insight" }, { 4, "Intimidation" },
        { 5, "Leadership" }, { 6, "Performance" }, { 7, "Persuasion" }, { 8, "Streetwise" },
        { 9, "Subterfuge" }
    };

            Dictionary<int, string> MentalSkillNames = new Dictionary<int, string>()
    {
        { 1, "Academics" }, { 2, "Awareness" }, { 3, "Finance" }, { 4, "Investigation" },
        { 5, "Medicine" }, { 6, "Occult" }, { 7, "Politics" }, { 8, "Science" }, { 9, "Technology" }
    };
            #endregion
            int[] SkillPool = { 1 };
            int[] PhysicalSkills = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] SocialSkills = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] MentalSkills = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Random random = new Random();
            int outcome = random.Next(1, 4);

            switch (outcome)
            {
                case 1:
                    CharSkillType = SkillMethod.Balanced;
                    SkillPool = new int[] {0,0,0,0,0,0,0,0,0,0,0,0,1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3 };
                    break;
                case 2:
                    CharSkillType = SkillMethod.JackOfTrades;
                    SkillPool = new int[] { 0,0,0,0,0,0,1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3 };
                    break;
                case 3:
                    CharSkillType = SkillMethod.Specalist;//
                    SkillPool = new int[] { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4 };
                    break;
            }

            // Shuffle the skill pool
            SkillPool = SkillPool.OrderBy(x => random.Next()).ToArray();

            if (IsVampire)
            {
                Console.WriteLine("Vampire Skills:");
                PrintSkillCategory("Physical Skills", PhysicalSkills, SkillPool, PhysicalSkillNames);
                PrintSkillCategory("Social Skills", SocialSkills, SkillPool, SocialSkillNames);
                PrintSkillCategory("Mental Skills", MentalSkills, SkillPool, MentalSkillNames);
            }
            else
            {
                Console.WriteLine("Human Skills:");
                PrintSkillCategory("Physical Skills", PhysicalSkills, SkillPool, PhysicalSkillNames);
                PrintSkillCategory("Social Skills", SocialSkills, SkillPool, SocialSkillNames);
                PrintSkillCategory("Mental Skills", MentalSkills, SkillPool, MentalSkillNames);
            }

            Console.WriteLine($"\nThis character is a {CharSkillType}.");
        }
        
        void PrintSkillCategory(string categoryName, int[] skillList, int[] skillPool, Dictionary<int, string> skillNames)
        {
            Console.WriteLine($"\n{categoryName}:");
            for (int i = 0; i < skillList.Length; i++)
            {
                int randomValue = skillPool[i % skillPool.Length];
                string skillName = skillNames[skillList[i]];
                Console.WriteLine($"  {skillName} - Value: {randomValue}");
            }
        }

        void Humanity()
        {
            Console.WriteLine("");
            Console.WriteLine("Humanity:");
            Random random = new Random();
            int Humanity = 7;
            if (IsVampire)
            {
                int[] LiklyHumanity = {2,2,3,3,3,3,3,4,4,4,4,4,4,5,5,5,5,5,5,5,5,6,6,6,6,6,6,6,6,7,7,7,7,7,7,7,7,7,7,7,8,8,8,8,8 };
                Humanity = LiklyHumanity[random.Next(LiklyHumanity.Length)];
            }
            //Human
            else
            {
                int[] LiklyHumanity = { 2, 2, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 8, 8, 8, 8, 8 };
                Humanity = LiklyHumanity[random.Next(LiklyHumanity.Length)];
            }
            Console.WriteLine($"The humanity of this character is {Humanity}");
        }


    }
}
