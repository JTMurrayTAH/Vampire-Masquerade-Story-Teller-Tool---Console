using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTM_Generator
{
    internal class Character
    {
        bool IsVampire;
        StringChoice?   NameChoice;
        StringChoice?   LastNameChoice;
        IntChoice?      AgeChoice;
        StringChoice?   MotivationChoice;
        StringChoice?   GoalChoice;
        StringChoice?   PersonalityChoice;
        StringChoice?   AffilationChoice;
        StringChoice?   WealthChoice;
        StringChoice?   CountryChoice;
        IntChoice?      FamilySize;
        IntChoice?      HumanityLvl;
        StringChoice? ClanChoice;

        StringChoice?   JobChoice;

        void ChangeConsoleColour()
        {
            int SelectedOption = new Random().Next(15);
            switch (SelectedOption) 
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

        public void StartGenerate()
        {   
            //Change the colour to try and make it more readable.
            ChangeConsoleColour();
            //Set whether character is a Vampire or not.
            SetMortalStatus();

            //Generate Stats depending on vampire status.
            if (IsVampire)
            {
                GenerateVampireStats();
            }
            else
            {
                GenerateHumanStats();
            }
            //Set Colour back to white.
            Console.ForegroundColor= ConsoleColor.White;
        }

        void SetMortalStatus()
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

        void GenerateVampireStats()
        {
            GenerateName();

            GenerateAge();

            //State if Vampire
            Console.WriteLine("Is Vampire: Yes");

            //Filler
            Console.WriteLine("");
            //Generate persona
            GeneratePersona();

            //Generate Affilation
            GenerateBonds();

            //Generate Attributes.
            GenerateAttributes();

            //Generate Skills
            GenerateSkills();

            //Generate Family Size
            GenerateFamilySize();

            //Generate Country of origin
            GenerateHomeCountry();

            //Generate Wealth Level
            GenerateWealthStatus();

            //End Line
            Console.WriteLine("------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");

        }

        private void GenerateWealthStatus()
        {
            WealthChoice = new StringChoice("Wealth Status", new string[] {"Squander", "Poor", "Average", "Above Average", "Wealthy", "Rich", "Super Rich" });
        }

        private void GenerateHomeCountry()
        {
            CountryChoice = new StringChoice("Country of Origin", new string[]
            {"United Kingdom", "England", "Wales", "Ireland", "Scotland"
            });

            //Filler
            Console.WriteLine("");
        }

        private void GenerateFamilySize()
        {
            FamilySize = new IntChoice("Family Size", 0, 7);
            //Filler
            Console.WriteLine("");
        }



        void GenerateHumanStats()
        {
            GenerateName();

            GenerateAge();

            //State if Vampire
            Console.WriteLine("Is Vampire: No");

            //Filler
            Console.WriteLine("");
            //Generate persona
            GeneratePersona();

            //Generate Affilation
            GenerateBonds();

            GenerateJob();

            //Generate Attributes.
            GenerateAttributes();

            //Generate Skills
            GenerateSkills();

            //Generate Family Size
            GenerateFamilySize();

            //Generate Country of origin
            GenerateHomeCountry();

            //Generate Wealth Level
            GenerateWealthStatus();

            //End Line
            Console.WriteLine("------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        void GenerateBirthdate()
        {
            string BirthdayText;
            int BirthYear = 2024 - AgeChoice.OutcomeChoice;
            int BirthMonth = new Random().Next(12) + 1;
            int BirthDay = 1;

            switch (BirthMonth)
            {
                case 1:
                    BirthDay = new Random().Next(31);
                    break;

                case 2:
                    BirthDay = new Random().Next(28);
                    break;

                case 3:
                    BirthDay = new Random().Next(31);
                    break;

                case 4:
                    BirthDay = new Random().Next(30);
                    break;

                case 5:
                    BirthDay = new Random().Next(31);
                    break;

                case 6:
                    BirthDay = new Random().Next(30);
                    break;

                case 7:
                    BirthDay = new Random().Next(31);
                    break;
                case 8:
                    BirthDay = new Random().Next(31);
                    break;

                case 9:
                    BirthDay = new Random().Next(30);
                    break;
                case 10:
                    BirthDay = new Random().Next(31);
                    break;

                case 11:
                    BirthDay = new Random().Next(30);
                    break;
                case 12:
                    BirthDay = new Random().Next(31);
                    break;

            }
            BirthdayText = $"Year: {BirthYear} | Month: {BirthMonth} | BirthDay: {BirthDay}";
            Console.WriteLine(BirthdayText);
        }

        void GenerateAttributes()
        {
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
                Console.WriteLine("Physical: " + string.Join(", ", Physical));
                Console.WriteLine("Social: " + string.Join(", ", Social));
                Console.WriteLine("Mental: " + string.Join(", ", Mental));
            }
            //Filler
            Console.WriteLine("");
        }

        void GenerateSkills()
        {
            //Vampire Skills
            if (IsVampire)
            {

            }
            else
            {

            }
            //Filler
            Console.WriteLine("");

        }

        void GenerateJob()
        {

            IsAware();

            //Filler
            Console.WriteLine("");
            JobChoice = new StringChoice("Job", new string[] 
            {   
                // Mundane Jobs
                "Taxi Driver", "Bartender", "Receptionist", "Landlord", "Florist",
                "Fitness Trainer", "Chef", "Office Manager", "Journalist", "Security Guard",
                "Call Center Worker", "Retail Store Manager", "Musician", "Freelance Writer", "Plumber",
                    "Housekeeper", "Dog Walker", "Fashion Designer", "Bookstore Clerk", "Childcare Worker",

                // Criminal Jobs
                "Gang Leader", "Weapons Dealer", "Black Market Doctor", "Illegal Street Fighter", "Locksmith for Hire",
                "Corrupt Police Officer", "Money Launderer", "Human Smuggler", "Prostitution Ring Operator", "Bank Robber",
                "Car Thief", "Graffiti Artist", "Illegal Arm Wrestler Organizer", "Rogue Chemist", "Document Forger",
                "Kidnapper", "Contraband Importer", "Nightclub Drug Supplier", "Underground Fight Promoter", "Vandal",

                // Military Jobs
                "Army Officer", "Sniper", "Military Intelligence Analyst", "Special Forces Operative", "Combat Medic",
                "Drone Operator", "Military Police", "Paratrooper", "Explosives Expert", "Weapons Engineer",
                "Private Military Contractor", "Tank Commander", "Helicopter Pilot", "Field Medic", "Artillery Officer",
                "Infantry Soldier", "Air Force Pilot", "Combat Instructor", "Logistics Officer", "Navy Seal",

                // Governmental Jobs
                "Mayor’s Assistant", "Diplomat", "City Council Member", "Customs Officer", "FBI Agent",
                "CIA Operative", "State Governor's Advisor", "Ambassador", "Local Police Detective", "Border Patrol Agent",
                "National Security Advisor", "Public Prosecutor", "Secret Service Agent", "IRS Auditor", "Immigration Officer",
                "Political Lobbyist", "Prison Warden", "Firefighter", "Homeland Security Agent", "Public Relations Officer",

                // Supernatural Jobs
                "Vampire Familiar", "Occult Librarian", "Blood Doll", "Hedge Witch", "Cursed Artifact Collector",
                "Supernatural Fixer", "Werewolf Liaison", "Ghost Whisperer", "Ghoul Handler", "Necromancer’s Assistant",
                "Demonologist", "Occult Shop Owner", "Coven Member", "Psychic Medium", "Arcane Researcher",
                "Relic Hunter", "Mystical Tattoo Artist", "Elder Vampire Bodyguard", "Clan Historian", "Dark Ritual Specialist"
});

            //Filler
            Console.WriteLine("");
        }
        void IsAware()
        {
            int Outcome = new Random().Next(4);
            switch (Outcome)
                {
                case 0:
                Console.WriteLine("Knows nothing of the occult");
                break;
                case 1:
                    Console.WriteLine("Believes in the occult, no proof");
                    break;
                case 2:
                    Console.WriteLine("doesnt believe in it, despite proof.");
                    break;
                case 3:
                    Console.WriteLine("Conspiracy Theroist.");
                    break;
                case 4:
                    Console.WriteLine("Knows the supernatural exist.");
                    break;
            }
        }
    
    
        void GenerateName()
        {
            //Vampire Skills
            if (IsVampire)
            {
//First Name
            NameChoice = new StringChoice("Name", new string[] { 
    // Male Names
    "Dylan", "Aiden", "Kai", "Oliver", "Milo", "Finn",
    "Jasper", "Leo", "Theo", "Ezra", "Lucian", "Sebastian",
    "Victor", "Gabriel", "Vincent", "Adrian", "Silas",
    "Damien", "Alaric", "Julian", "Tristan", "Xander",
    "Roman", "Elijah", "Atticus", "Lorenzo", "Cassius",
    "Raphael", "Dorian", "Mathias", "Orion",

    // Female Names
    "Lila", "Isabella", "Sophie", "Evelyn", "Zara", "Hazel",
    "Ivy", "Aurora", "Scarlett", "Luna", "Elena", "Amara",
    "Seraphina", "Lilith", "Celia", "Violet", "Esme", "Astrid",
    "Selene", "Fiona", "Isolde", "Genevieve", "Ophelia",
    "Anastasia", "Maris", "Rowena", "Vivienne", "Freya",
    "Aria", "Evangeline", "Raven",

    // Gender-neutral Names
    "Riley", "Quinn", "Sage", "Rowan", "River",
    "Emerson", "Morgan", "Phoenix", "Avery", "Arden",
    "Ellis", "Reese", "Jordan", "Harley", "Sloane",
    "Lennon", "Skylar", "Taylor", "Remy", "Sterling",

    // Surnames for flavor (optional use for vampire personas)
    "Montague", "Valentine", "Blackwood", "Ravenwood",
    "Nightingale", "Von Stein", "Hawthorne", "Carrington",
    "Fairchild", "Larkspur", "Sinclair", "Thorne", "Vanderbilt",
    "Rutherford", "Devereux", "Astor", "Winslow", "Baldwin"
});

            //Last Name
            LastNameChoice = new StringChoice("Last name", new string[]
            {// Common Last Names
    "Smith", "Johnson", "Williams", "Brown", "Taylor",
    "Davis", "Anderson", "Moore", "Miller", "Thompson",
    "White", "Clark", "Walker", "Hall", "Young",

    // Noble/Elegant Last Names
    "Montgomery", "Lancaster", "Beaumont", "Harrington", "Ashford",
    "Winchester", "Blackwood", "Whitmore", "Kingsley", "Fitzgerald",
    "Hawthorne", "Van Buren", "Kensington", "Rothschild", "Sterling",

    // Mysterious/Dark Last Names
    "Grimm", "Ravenwood", "Thorne", "Nightshade", "Blackwell",
    "Graves", "Darkmoor", "Sable", "Valentine", "Obsidian",
    "Rook", "Drake", "Vanderbilt", "Craven", "Galloway",
    "Crowley", "Voss", "Sinclair", "Morvant", "Dusk",
    
    // Supernatural/Old World Last Names
    "Dragomir", "Belmont", "Vladislav", "Orlov", "Kane",
    "Valek", "Constantine", "Bathory", "Romanov", "Faust",
    "Devereaux", "Borgia", "Szilagyi", "Lacroix", "Vermillion"
            });
            }

            //Non Vampire
            else
            {
                //First Name
                NameChoice = new StringChoice("Name", new string[] { 
    // Male Names
    "Dylan", "Aiden", "Kai", "Oliver", "Milo", "Finn",
    "Jasper", "Leo", "Theo", "Ezra", "Lucian", "Sebastian",
    "Victor", "Gabriel", "Vincent", "Adrian", "Silas",
    "Damien", "Alaric", "Julian", "Tristan", "Xander",
    "Roman", "Elijah", "Atticus", "Lorenzo", "Cassius",
    "Raphael", "Dorian", "Mathias", "Orion",

    // Female Names
    "Lila", "Isabella", "Sophie", "Evelyn", "Zara", "Hazel",
    "Ivy", "Aurora", "Scarlett", "Luna", "Elena", "Amara",
    "Seraphina", "Lilith", "Celia", "Violet", "Esme", "Astrid",
    "Selene", "Fiona", "Isolde", "Genevieve", "Ophelia",
    "Anastasia", "Maris", "Rowena", "Vivienne", "Freya",
    "Aria", "Evangeline", "Raven",

    // Gender-neutral Names
    "Riley", "Quinn", "Sage", "Rowan", "River",
    "Emerson", "Morgan", "Phoenix", "Avery", "Arden",
    "Ellis", "Reese", "Jordan", "Harley", "Sloane",
    "Lennon", "Skylar", "Taylor", "Remy", "Sterling",

    // Surnames for flavor (optional use for vampire personas)
    "Montague", "Valentine", "Blackwood", "Ravenwood",
    "Nightingale", "Von Stein", "Hawthorne", "Carrington",
    "Fairchild", "Larkspur", "Sinclair", "Thorne", "Vanderbilt",
    "Rutherford", "Devereux", "Astor", "Winslow", "Baldwin"
});

                //Last Name
                LastNameChoice = new StringChoice("Last name", new string[]
                {// Common Last Names
    "Smith", "Johnson", "Williams", "Brown", "Taylor",
    "Davis", "Anderson", "Moore", "Miller", "Thompson",
    "White", "Clark", "Walker", "Hall", "Young",

    // Noble/Elegant Last Names
    "Montgomery", "Lancaster", "Beaumont", "Harrington", "Ashford",
    "Winchester", "Blackwood", "Whitmore", "Kingsley", "Fitzgerald",
    "Hawthorne", "Van Buren", "Kensington", "Rothschild", "Sterling",

    // Mysterious/Dark Last Names
    "Grimm", "Ravenwood", "Thorne", "Nightshade", "Blackwell",
    "Graves", "Darkmoor", "Sable", "Valentine", "Obsidian",
    "Rook", "Drake", "Vanderbilt", "Craven", "Galloway",
    "Crowley", "Voss", "Sinclair", "Morvant", "Dusk",
    
                });
            }
            

            //Filler
            Console.WriteLine("");
        }

        void GenerateAge()
        {
            //Vampire Skills
            if (IsVampire)
            {
            //State Age
            AgeChoice = new IntChoice("Age", 18, 900);

            //State Birthday
            GenerateBirthdate();
            }
            //Non Vampire
            else
            {
                //State Age
                AgeChoice = new IntChoice("Age", 18, 80);

                //State Birthday
                GenerateBirthdate();
            }
            
        }

        void GeneratePersona()
        {
            //Vampire Skills
            if (IsVampire)
            {
                //Humanity
                HumanityLvl = new IntChoice("Humanty", 0, 10);

            //State Motivation : The why
            MotivationChoice = new StringChoice("Motivation", new string[] {
    // Personal Motivations
    "Seek revenge on an old rival",
    "Attain greater personal power",
    "Protect a loved one or mortal family",
    "Rediscover lost humanity",
    "Find meaning in immortality",
    "Indulge in carnal pleasures",
    "Gain acceptance in a higher vampire society",
    "Escape the control of a domineering sire",
    "Endure eternal boredom through indulgence",
    "Rebel against the vampire hierarchy",
    "Attain a position of influence among vampires",
    "Cure vampirism or find redemption",
    "Maintain or restore sanity from a mental affliction",
    "Satisfy an insatiable thirst for blood or knowledge",
    "Manipulate mortals to build a personal empire",

    // Long-term Motivations
    "Discover the secrets of vampire origin",
    "Secure a legacy through generations of vampires",
    "Overthrow the ruling vampire prince or elders",
    "Accumulate ancient vampire artifacts or knowledge",
    "Survive and avoid final death at all costs",
    "Influence the mortal world’s politics or economy",
    "Uncover hidden vampiric conspiracies",
    "Destroy or weaken rival vampire clans",
    "Amass wealth and resources over centuries",
    "Ascend to the role of a Methuselah or ancient vampire",
    "Build a loyal following of fledglings and thralls",
    "Control or manipulate supernatural forces beyond vampires",
    "Ensure dominance over a city or territory",
    "Ensure the survival of one's bloodline or progeny",
    "Outwit or elude ancient enemies, including vampire hunters",

    // Spiritual/Philosophical Motivations
    "Understand the nature of the soul and eternity",
    "Reconcile vampirism with personal religious beliefs",
    "Seek redemption or transcendence beyond vampirism",
    "Challenge or align with the forces of fate",
    "Find the ultimate truth behind existence and the universe",
    "Control or escape from destiny",
    "End a cursed existence with honor or meaning"
});

            //Filler
            Console.WriteLine("");

            //State Goal : The what
            GoalChoice = new StringChoice("Goal", new string[] { 
                // Physical and Political Goals
    "Become the Prince or ruler of a major city",
    "Find and harness an ancient vampire artifact",
    "Uncover and stop a threat to the Masquerade",
    "Seize control of the city's most valuable assets",
    "Build an empire through mortal influence and control",
    "Destroy a rival vampire clan or sect",
    "Topple the current vampire leadership",
    "Manipulate human politics to ensure vampire dominance",

    // Personal Goals
    "Find a cure for vampirism",
    "Restore lost humanity or mortality",
    "Gain mastery over a rare vampire discipline",
    "Uncover the secrets of vampiric origin",
    "Escape the control of my sire or clan",
    "Overcome a personal curse or affliction",
    "Build an immortal legacy in art, science, or philosophy",
    
    // Knowledge and Discovery Goals
    "Discover the truth behind vampire myths",
    "Uncover hidden knowledge from ancient vampire elders",
    "Learn the secrets of immortality beyond vampirism",
    "Collect rare tomes of occult and forbidden knowledge",
    "Find and control supernatural forces beyond vampirism",
    
    // Survival and Protection Goals
    "Secure the future of my bloodline",
    "Outlive my enemies and ensure my eternal survival",
    "Protect my loved ones or progeny from threats",
    "Survive a deadly vampire hunter or ancient foe",
    "Hide my existence from powerful vampire elders",

    // Revenge and Retribution Goals
    "Kill or destroy an ancient rival who wronged me",
    "Avenge the destruction of my clan or bloodline",
    "Hunt down and eliminate a traitor within the vampire court",
    "Exact vengeance on those who betrayed me",

    // Existential and Philosophical Goals
    "Find a way to transcend vampirism",
    "Discover the true meaning behind eternal life",
    "Understand and control the Beast within",
    "End the cycle of violence between vampire factions",
    "Achieve peace or transcendence beyond the undead existence"
});

            //Filler
            Console.WriteLine("");

                

            //The How
            PersonalityChoice = new StringChoice("Personality", new string[]
{
    // Well-Integrated Vampires
    "Modern and cultured, embraces contemporary trends while hiding their true nature",
    "Slick and sophisticated, adept at blending into high society and using charm",
    "Intellectual and articulate, enjoys engaging in discussions about philosophy and art",
    "Charismatic and influential, holds positions of power in mortal organizations",

    // Stereotypical Vampires
    "Classic romantic, embodies the tragic allure of vampirism with a flair for the dramatic",
    "Brooding and mysterious, often seen lurking in the shadows and haunted by their past",
    "Charming seducer, uses charisma and allure to manipulate mortals for personal gain",
    "Old-world aristocrat, maintains traditional values and a disdain for modernity",

    // Normal People (Living Among Mortals)
    "Disguised as an ordinary human, lives a mundane life while hiding their vampiric nature",
    "Everyday worker, holds a regular job to blend in while secretly feeding at night",
    "Socially awkward, struggles to relate to humans but desires connection",
    "Cynical observer, jaded by centuries of existence yet longing for acceptance",

    // Darker Personalities
    "Sadistic and cruel, revels in the suffering of others and thrives on fear",
    "Manipulative puppeteer, enjoys orchestrating events for personal amusement",
    "Twisted philosopher, believes in the superiority of vampirism over humanity",
    "Revenge-driven, consumed by a desire to punish those who wronged them in the past",

    // Extreme Ends of the Spectrum
    "Radical vampire activist, seeks to overthrow the masquerade and expose vampires to the world",
    "Anarchist, believes in chaos and disruption of established vampire hierarchies",
    "Survivalist, obsessed with the idea of outliving all threats, even if it means betrayal",
    "Isolationist, shuns society and lives in solitude, grappling with their monstrous nature",

    // Haunted Personalities
    "Tormented by guilt, constantly reflects on their past and seeks redemption",
    "Obsessed with their own mortality, struggles with the meaning of their undead existence",
    "Emotionally unstable, swings between despair and manic moments of excitement",
    "Haunted by memories of lost loved ones, yearns for a connection that can never be regained"
});

            //Filler
            Console.WriteLine("");
            }
            //Non Vampire
            else
            {

                //Humanity
                HumanityLvl = new IntChoice("Humanty", 0, 10);

                //State Motivation : The why
                MotivationChoice = new StringChoice("Motivation", new string[] {
    // Personal Motivations
    "Protect their family",
    "Achieve personal wealth and comfort",
    "Rise to social prominence or fame",
    "Escape a troubled past",
    "Prove their worth or competence",
    "Seek knowledge or truth",
    "Gain control over their fate",
    "Restore their tarnished reputation",
    
    // Long-Term Motivations
    "Achieve immortality through legacy or fame",
    "Escape societal expectations and live freely",
    "Make the world a better place for future generations",
    "Discover forbidden knowledge or secrets of life",
    "Gain influence over powerful individuals or groups",
    "Change the course of human history",
    "Overcome personal weaknesses or limitations",

    // Darker Motivations
    "Avenge a wrong done to them or loved ones",
    "Gain power over others",
    "Satisfy morbid curiosity about death or the supernatural",
    "Manipulate others to achieve selfish goals",
    "Escape the consequences of past crimes",
    "Prove themselves superior to others"
});

                //Filler
                Console.WriteLine("");

                //State Goal : The what
                GoalChoice = new StringChoice("Goal", new string[] { 
                    // Short-Term Goals
    "Secure a high-paying job or promotion",
    "Clear their name from false accusations",
    "Win the affection of a loved one",
    "Avoid a looming financial crisis",
    "Escape the influence of a criminal organization",

    // Long-Term Goals
    "Build a successful business empire",
    "Ensure their family's safety and legacy",
    "Reveal the truth about a conspiracy",
    "Find a cure for a life-threatening illness",
    "Write a book that will change people's lives",

    // Darker Goals
    "Wipe out a rival or enemy",
    "Ascend to leadership of a criminal organization",
    "Cover up their involvement in a crime",
    "Manipulate others into serving them",
    "Survive a dangerous encounter with the supernatural"
});

                //Filler
                Console.WriteLine("");

                //The How
                PersonalityChoice = new StringChoice("Personality", new string[]
    {
    // Well-Integrated
    "Charming and approachable, easily makes friends",
    "Hardworking and pragmatic, values efficiency",
    "Optimistic and cheerful, always tries to uplift others",
    "Analytical and cautious, prefers logical solutions",

    // Everyday or Normal
    "Down-to-earth, prefers simple pleasures",
    "Shy and reserved, avoids conflict and attention",
    "Kind-hearted, always willing to lend a hand",
    "Ambitious but naive, still learning the harshness of the world",

    // Darker or Extreme
    "Self-serving and manipulative, willing to exploit others",
    "Paranoid and distrusting, constantly watches their back",
    "Violent and quick-tempered, prone to aggressive outbursts",
    "Cunning and strategic, always thinking two steps ahead",
    
    // Haunted Personalities
    "Wracked with guilt over past decisions",
    "Emotionally detached, finds it hard to connect with others",
    "Melancholic, constantly reminiscing about lost opportunities",
    "Plagued by nightmares, barely sleeps due to inner torment"
    });

                //Filler
                Console.WriteLine("");
            }
        }

        void GenerateBonds()
        {
            //Vampire Skills
            if (IsVampire)
            {
                //Clan
                ClanChoice = new StringChoice("Clan Bloodline", new string[]
                    {"Banu Haqim", "Brujah", "Gangrel","Hecata", "Lasombra","Malkavian", "Ministry","Nosferatu", "Ravnos","Toreador", "Tremere","Tzimisce","Ventrue"});

                //Filler
                Console.WriteLine("");
                //For Who
                AffilationChoice = new StringChoice("Affilation", new string[]
            { "Carmillia", "Sabbat", "Anarchist",
            "Carmillia (Self)", "Sabbat (Self)", "Anarchist (Self)",
            "Carmillia (Spy)", "Sabbat (Spy)", "Anarchist (Spy)",
            "Self"});

            //Filler
            Console.WriteLine("");
            }
            //Non Vampire
            else
            {
                AffilationChoice = new StringChoice("Affilation", new string[] 
            {"Vampire Hunter", "Mortal (Unaffiliated)",
            "The Society of Leopold", "The Arcanum", "Mortal (Unaffiliated)",
            "The Church (Anti-Vampire)", "Government Operative", "Mortal (Unaffiliated)",
            "Criminal Organization", "Corporate Insider", "Mortal (Unaffiliated)",
            "Independent", "Secret Society Member", "Supernatural Researcher", "Mortal (Unaffiliated)" });
            }
            
        }
    }
}
