namespace RetroJam.CaptainBlood
{
    public enum Glossary
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
    public enum WordNature { Ponctuation, Noun, Adjective, Verb }

    public static class WordsFunctions
    {
        public static string ToText(this Glossary _word)
        {
            switch (_word)
            {
                case Glossary.none:
                    return "";
                case Glossary.QuestionMArk:
                    return "?";
                case Glossary.Not:
                    return "NOT";
                case Glossary.Yes:
                    return "YES";
                case Glossary.No:
                    return "NO";
                case Glossary.Me:
                    return "ME";
                case Glossary.You:
                    return "YOU";
                case Glossary.Howdy:
                    return "HOWDY";
                case Glossary.Bye:
                    return "BYE";
                case Glossary.Go:
                    return "GO";
                case Glossary.Want:
                    return "WANT";
                case Glossary.Teleport:
                    return "TELEPORT";
                case Glossary.Give:
                    return "GIVE";
                case Glossary.Like:
                    return "LIKE";
                case Glossary.Say:
                    return "SAY";
                case Glossary.Know:
                    return "KNOW";
                case Glossary.Unknown:
                    return "UNKNOWN";
                case Glossary.Play:
                    return "PLAY";
                case Glossary.Search:
                    return "SEARCH";
                case Glossary.Race:
                    return "RACE";
                case Glossary.Vote:
                    return "VOTE";
                case Glossary.Help:
                    return "HELP";
                case Glossary.Disarm:
                    return "DISARM";
                case Glossary.Laugh:
                    return "( LAUGH )";
                case Glossary.Sob:
                    return "SOB";
                case Glossary.Fear:
                    return "FEAR";
                case Glossary.Destroy:
                    return "DESTROY";
                case Glossary.Free:
                    return "FREE";
                case Glossary.Kill:
                    return "KILL";
                case Glossary.Prison:
                    return "PRISON";
                case Glossary.Prisonner:
                    return "PRISONNER";
                case Glossary.Trap:
                    return "TRAP";
                case Glossary.Danger:
                    return "DANGER";
                case Glossary.Forbidden:
                    return "FORBIDDEN";
                case Glossary.Radioactivity:
                    return "RADIOACTIVITY";
                case Glossary.Impossible:
                    return "IMPOSSIBLE";
                case Glossary.Bounty:
                    return "BOUNTY";
                case Glossary.Information:
                    return "INFORMATION";
                case Glossary.NonSense:
                    return "NONSENSE";
                case Glossary.RDV:
                    return "RENDEZ-VOUS";
                case Glossary.Time:
                    return "TIME";
                case Glossary.Urgent:
                    return "URGENT";
                case Glossary.Idea:
                    return "IDEA";
                case Glossary.Missile:
                    return "MISSILE";
                case Glossary.Code:
                    return "CODE";
                case Glossary.Friend:
                    return "FRIEND";
                case Glossary.Ennemy:
                    return "ENNEMY";
                case Glossary.Spirit:
                    return "SPIRIT";
                case Glossary.Brain:
                    return "BRAIN";
                case Glossary.Warrior:
                    return "WARRIOR";
                case Glossary.President:
                    return "PRESIDENT";
                case Glossary.Scientist:
                    return "SCIENTIST";
                case Glossary.Genetic:
                    return "GENETIC";
                case Glossary.Sex:
                    return "SEX";
                case Glossary.Reproduction:
                    return "REPRODUCTION";
                case Glossary.Male:
                    return "MALE";
                case Glossary.Female:
                    return "FEMALE";
                case Glossary.Identity:
                    return "IDENTITY";
                case Glossary.Pop:
                    return "POP";
                case Glossary.People:
                    return "PEOPLE";
                case Glossary.Different:
                    return "DIFFERENT";
                case Glossary.Small:
                    return "SMALL";
                case Glossary.Great:
                    return "GREAT";
                case Glossary.Strong:
                    return "STRONG";
                case Glossary.Bad:
                    return "BAD";
                case Glossary.Brave:
                    return "BRAVE";
                case Glossary.Good:
                    return "GOOD";
                case Glossary.Crazy:
                    return "CRAZY";
                case Glossary.Poor:
                    return "POOR";
                case Glossary.Insult:
                    return "( INSULT )";
                case Glossary.Curse:
                    return "( CURSE )";
                case Glossary.Peace:
                    return "PEACE";
                case Glossary.Dead:
                    return "DEAD";
                case Glossary.Oorx:
                    return "OORX";
                case Glossary.Tromp:
                    return "TROMP";
                case Glossary.Kingpak:
                    return "KINGPAK";
                case Glossary.Robhead:
                    return "ROBHEAD";
                case Glossary.CroolisVar:
                    return "CROOLIS-VAR";
                case Glossary.CroolisUlv:
                    return "CROOLIS-ULV";
                case Glossary.Izwal:
                    return "IZWAL";
                case Glossary.Migrax:
                    return "MIGRAX";
                case Glossary.Antenna:
                    return "ANTENNA";
                case Glossary.Buggol:
                    return "BUGGOL";
                case Glossary.Tricephal:
                    return "TRICEPHAL";
                case Glossary.TubularBrain:
                    return "TUBULAR-BRAIN";
                case Glossary.Yukas:
                    return "YUKAS";
                case Glossary.Sinox:
                    return "SINOX";
                case Glossary.Ondoyante:
                    return "ONDOYANTE";
                case Glossary.Duplicate:
                    return "DUPLICATE";
                case Glossary.Tuttle:
                    return "TUTTLE";
                case Glossary.Morlock:
                    return "MORLOCK";
                case Glossary.Yoko:
                    return "YOKO";
                case Glossary.Maxon:
                    return "MAXON";
                case Glossary.Blood:
                    return "BLOOD";
                case Glossary.Torka:
                    return "TORKA";
                case Glossary.Ship:
                    return "SHIP";
                case Glossary.Contact:
                    return "CONTACT";
                case Glossary.Home:
                    return "HOME";
                case Glossary.Planet:
                    return "PLANET";
                case Glossary.Trauma:
                    return "TRAUMA";
                case Glossary.Entrax:
                    return "ENTRAX";
                case Glossary.Ondoya:
                    return "ONDOYA";
                case Glossary.Kristo:
                    return "KRISTO";
                case Glossary.Rosko:
                    return "ROSKO";
                case Glossary.Corpo:
                    return "CORPO";
                case Glossary.Ulikan:
                    return "ULIKAN";
                case Glossary.BowBow:
                    return "BOW-BOW";
                case Glossary.Hour:
                    return "HOUR";
                case Glossary.Coord:
                    return "COORDINATE";
                case Glossary.Equal:
                    return "=";
                case Glossary.OutOf:
                    return "/";
                case Glossary.Zero:
                    return "0";
                case Glossary.One:
                    return "1";
                case Glossary.Two:
                    return "2";
                case Glossary.Three:
                    return "3";
                case Glossary.For:
                    return "4";
                case Glossary.Five:
                    return "5";
                case Glossary.Six:
                    return "6";
                case Glossary.Seven:
                    return "7";
                case Glossary.Height:
                    return "8";
                case Glossary.Nine:
                    return "9";
                default:
                    return "";
            }
        }
    }

    [System.Serializable]
    public class Word
    {
        public Glossary word;
        public WordNature nature;

        public Word(Glossary _word, WordNature _nature)
        {
            word = _word;
            nature = _nature;
        }

        public Word(int _word, int _nature)
        {
            word = (Glossary)_word;
            nature = (WordNature)_nature;
        }
    }

    public static class Language
    {

    }
}
