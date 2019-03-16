namespace RetroJam.CaptainBlood
{
    public enum Word
    {
        none,
        QuestionMArk,
        Not,
        Yes,
        No,
        Me,
        You,
        Howdy,
        Bye,
        Go,
        Want,
        Teleport,
        Give,
        Like,
        Say,
        Know,
        Unknown,
        Play,
        Search,
        Race,
        Vote,
        Help,
        Disarm,
        Laugh,
        Sob,
        Fear,
        Destroy,
        Free,
        Kill,
        Prison,
        Prisonner,
        Trap,
        Danger,
        Forbidden,
        Radioactivity,
        Impossible,
        Bounty,
        Information,
        NonSense,
        RDV,
        Time,
        Urgent,
        Idea,
        Missile,
        Code,
        Friend,
        Ennemy,
        Spirit,
        Brain,
        Warrior,
        President,
        Scientist,
        Genetic,
        Sex,
        Reproduction,
        Male, Female,
        Identity,
        Pop,
        People,
        Different,
        Small,
        Great,
        Strong,
        Bad,
        Brave,
        Good,
        Crazy,
        Poor,
        Insult,
        Curse,
        Peace,
        Dead,
        Oorx,
        Tromp,
        Kingpak,
        Robhead,
        CroolisVar,
        CroolisUlv,
        Izwal,
        Migrax,
        Antenna,
        Buggol,
        Tricephal,
        TubularBrain,
        Yukas,
        Sinox,
        Ondoyante,
        Duplicate,
        Tuttle,
        Morlock,
        Yoko,
        Maxon,
        Blood,
        Torka,
        Ship,
        Contact,
        Home,
        Planet,
        Trauma,
        Entrax,
        Ondoya,
        Kristo,
        Rosko,
        Corpo,
        Ulikan,
        BowBow,
        Hour,
        Coord,
        Equal,
        OutOf,
        Zero,
        One,
        Two,
        Three,
        For,
        Five,
        Six,
        Seven,
        Height,
        Nine
    }

    public static class WordsFunctions
    {
        public static string ToText(this Word _word)
        {
            switch (_word)
            {
                case Word.none:
                    return "";
                case Word.QuestionMArk:
                    return "?";
                case Word.Not:
                    return "NOT";
                case Word.Yes:
                    return "YES";
                case Word.No:
                    return "NO";
                case Word.Me:
                    return "ME";
                case Word.You:
                    return "YOU";
                case Word.Howdy:
                    return "HOWDY";
                case Word.Bye:
                    return "BYE";
                case Word.Go:
                    return "GO";
                case Word.Want:
                    return "WANT";
                case Word.Teleport:
                    return "TELEPORT";
                case Word.Give:
                    return "GIVE";
                case Word.Like:
                    return "LIKE";
                case Word.Say:
                    return "SAY";
                case Word.Know:
                    return "KNOW";
                case Word.Unknown:
                    return "UNKNOWN";
                case Word.Play:
                    return "PLAY";
                case Word.Search:
                    return "SEARCH";
                case Word.Race:
                    return "RACE";
                case Word.Vote:
                    return "VOTE";
                case Word.Help:
                    return "HELP";
                case Word.Disarm:
                    return "DISARM";
                case Word.Laugh:
                    return "( LAUGH )";
                case Word.Sob:
                    return "SOB";
                case Word.Fear:
                    return "FEAR";
                case Word.Destroy:
                    return "DESTROY";
                case Word.Free:
                    return "FREE";
                case Word.Kill:
                    return "KILL";
                case Word.Prison:
                    return "PRISON";
                case Word.Prisonner:
                    return "PRISONNER";
                case Word.Trap:
                    return "TRAP";
                case Word.Danger:
                    return "DANGER";
                case Word.Forbidden:
                    return "FORBIDDEN";
                case Word.Radioactivity:
                    return "RADIOACTIVITY";
                case Word.Impossible:
                    return "IMPOSSIBLE";
                case Word.Bounty:
                    return "BOUNTY";
                case Word.Information:
                    return "INFORMATION";
                case Word.NonSense:
                    return "NONSENSE";
                case Word.RDV:
                    return "RENDEZ-VOUS";
                case Word.Time:
                    return "TIME";
                case Word.Urgent:
                    return "URGENT";
                case Word.Idea:
                    return "IDEA";
                case Word.Missile:
                    return "MISSILE";
                case Word.Code:
                    return "CODE";
                case Word.Friend:
                    return "FRIEND";
                case Word.Ennemy:
                    return "ENNEMY";
                case Word.Spirit:
                    return "SPIRIT";
                case Word.Brain:
                    return "BRAIN";
                case Word.Warrior:
                    return "WARRIOR";
                case Word.President:
                    return "PRESIDENT";
                case Word.Scientist:
                    return "SCIENTIST";
                case Word.Genetic:
                    return "GENETIC";
                case Word.Sex:
                    return "SEX";
                case Word.Reproduction:
                    return "REPRODUCTION";
                case Word.Male:
                    return "MALE";
                case Word.Female:
                    return "FEMALE";
                case Word.Identity:
                    return "IDENTITY";
                case Word.Pop:
                    return "POP";
                case Word.People:
                    return "PEOPLE";
                case Word.Different:
                    return "DIFFERENT";
                case Word.Small:
                    return "SMALL";
                case Word.Great:
                    return "GREAT";
                case Word.Strong:
                    return "STRONG";
                case Word.Bad:
                    return "BAD";
                case Word.Brave:
                    return "BRAVE";
                case Word.Good:
                    return "GOOD";
                case Word.Crazy:
                    return "CRAZY";
                case Word.Poor:
                    return "POOR";
                case Word.Insult:
                    return "( INSULT )";
                case Word.Curse:
                    return "( CURSE )";
                case Word.Peace:
                    return "PEACE";
                case Word.Dead:
                    return "DEAD";
                case Word.Oorx:
                    return "OORX";
                case Word.Tromp:
                    return "TROMP";
                case Word.Kingpak:
                    return "KINGPAK";
                case Word.Robhead:
                    return "ROBHEAD";
                case Word.CroolisVar:
                    return "CROOLIS-VAR";
                case Word.CroolisUlv:
                    return "CROOLIS-ULV";
                case Word.Izwal:
                    return "IZWAL";
                case Word.Migrax:
                    return "MIGRAX";
                case Word.Antenna:
                    return "ANTENNA";
                case Word.Buggol:
                    return "BUGGOL";
                case Word.Tricephal:
                    return "TRICEPHAL";
                case Word.TubularBrain:
                    return "TUBULAR-BRAIN";
                case Word.Yukas:
                    return "YUKAS";
                case Word.Sinox:
                    return "SINOX";
                case Word.Ondoyante:
                    return "ONDOYANTE";
                case Word.Duplicate:
                    return "DUPLICATE";
                case Word.Tuttle:
                    return "TUTTLE";
                case Word.Morlock:
                    return "MORLOCK";
                case Word.Yoko:
                    return "YOKO";
                case Word.Maxon:
                    return "MAXON";
                case Word.Blood:
                    return "BLOOD";
                case Word.Torka:
                    return "TORKA";
                case Word.Ship:
                    return "SHIP";
                case Word.Contact:
                    return "CONTACT";
                case Word.Home:
                    return "HOME";
                case Word.Planet:
                    return "PLANET";
                case Word.Trauma:
                    return "TRAUMA";
                case Word.Entrax:
                    return "ENTRAX";
                case Word.Ondoya:
                    return "ONDOYA";
                case Word.Kristo:
                    return "KRISTO";
                case Word.Rosko:
                    return "ROSKO";
                case Word.Corpo:
                    return "CORPO";
                case Word.Ulikan:
                    return "ULIKAN";
                case Word.BowBow:
                    return "BOW-BOW";
                case Word.Hour:
                    return "HOUR";
                case Word.Coord:
                    return "COORDINATE";
                case Word.Equal:
                    return "=";
                case Word.OutOf:
                    return "/";
                case Word.Zero:
                    return "0";
                case Word.One:
                    return "1";
                case Word.Two:
                    return "2";
                case Word.Three:
                    return "3";
                case Word.For:
                    return "4";
                case Word.Five:
                    return "5";
                case Word.Six:
                    return "6";
                case Word.Seven:
                    return "7";
                case Word.Height:
                    return "8";
                case Word.Nine:
                    return "9";
                default:
                    return "";
            }
        }
    }
}
