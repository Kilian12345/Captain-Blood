using System.Collections.Generic;

namespace RetroJam.CaptainBlood.Lang
{
    public enum Word
    {
        none,
        QuestionMark,
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
        Male,
        Female,
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
    public enum WordNature { Ponctuation, Noun, Adjective, Verb, Expression, Negation, Number }
    public enum WordFunction { Subject, Action, Object, Complement}
    public enum VerbType { Intransitive, Transitive, Ditransitive, DoubleTransitive, Copular}
    public enum SentenceConstruction { none, E, O, SV, SVO, SVA, SVOO, SVOC, SVOA }
    public enum SentenceCorrectness { none, correct, needSubject, needObject, needAdverb, needVerb}

public static class WordsFunctions
    {
        public static string ToText(this Word _word)
        {
            switch (_word)
            {
                case Word.none:
                    return "";
                case Word.QuestionMark:
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

    public static class Words
    {
        public static Dictionary<Word, WordNature> dictionary { get; private set; }

        public static Dictionary<Word, Verb> verbs { get; private set; }

        public static Dictionary<Word, Adjective> adjectives { get; private set; }

        public static List<Word> nouns { get; private set; }

        public class Verb
        {
            public VerbType type;
            public int valency;
            public SentenceConstruction constructions;
            public float factor;

            public Verb(VerbType _type, int _valency, SentenceConstruction _constructions, float _factor)
            {
                type = _type;
                valency = _valency;
                constructions = _constructions;
                factor = _factor;
            }
        }

        public class Adjective
        {
            public float factor;

            public Adjective(float _value)
            {
                factor = _value;
            }
        }

        public static void InitializeWords()
        {
            dictionary = new Dictionary<Word, WordNature>();
            verbs = new Dictionary<Word, Verb>();
            adjectives = new Dictionary<Word, Adjective>();
            nouns = new List<Word>();

            for (int i = 1; i < 121; i++)
            {
                switch ((Word)i)
                {
                    case Word.QuestionMark:
                        dictionary.Add((Word)i, WordNature.Ponctuation);
                        break;
                    case Word.Not:
                        dictionary.Add((Word)i, WordNature.Negation);
                        break;
                    case Word.Yes:
                        dictionary.Add((Word)i, WordNature.Expression);
                        break;
                    case Word.No:
                        dictionary.Add((Word)i, WordNature.Expression);
                        break;
                    case Word.Me:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.You:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Howdy:
                        dictionary.Add((Word)i, WordNature.Expression);
                        break;
                    case Word.Bye:
                        dictionary.Add((Word)i, WordNature.Expression);
                        break;
                    case Word.Go:
                        dictionary.Add((Word)i, WordNature.Verb);
                        verbs.Add((Word)i, new Verb(VerbType.Intransitive, 1, SentenceConstruction.SVA, .25f));
                        break;
                    case Word.Want:
                        dictionary.Add((Word)i, WordNature.Verb);
                        verbs.Add((Word)i, new Verb(VerbType.Transitive, 2,  SentenceConstruction.SVO, .25f));
                        break;
                    case Word.Teleport:
                        dictionary.Add((Word)i, WordNature.Verb);
                        verbs.Add((Word)i, new Verb(VerbType.Transitive, 2, SentenceConstruction.SVO, .25f));
                        break;
                    case Word.Give:
                        dictionary.Add((Word)i, WordNature.Verb);
                        verbs.Add((Word)i, new Verb(VerbType.Ditransitive, 3, SentenceConstruction.SVOO, .75f));
                        break;
                    case Word.Like:
                        dictionary.Add((Word)i, WordNature.Verb);
                        verbs.Add((Word)i, new Verb(VerbType.Transitive, 2,  SentenceConstruction.SVO, 1f));
                        break;
                    case Word.Say:
                        dictionary.Add((Word)i, WordNature.Verb);
                        verbs.Add((Word)i, new Verb(VerbType.Transitive, 2,SentenceConstruction.SVOO, .25f));
                        break;
                    case Word.Know:
                        dictionary.Add((Word)i, WordNature.Verb);
                        verbs.Add((Word)i, new Verb(VerbType.Transitive, 2, SentenceConstruction.SVO, .5f));
                        break;
                    case Word.Unknown:
                        dictionary.Add((Word)i, WordNature.Adjective);
                        adjectives.Add((Word)i, new Adjective(.8f));
                        break;
                    case Word.Play:
                        dictionary.Add((Word)i, WordNature.Verb);
                        verbs.Add((Word)i, new Verb(VerbType.Intransitive, 1, SentenceConstruction.SVA, .5f));
                        break;
                    case Word.Search:
                        dictionary.Add((Word)i, WordNature.Verb);
                        verbs.Add((Word)i, new Verb(VerbType.Transitive, 2, SentenceConstruction.SVO, .5f));
                        break;
                    case Word.Race:
                        dictionary.Add((Word)i, WordNature.Verb);
                        verbs.Add((Word)i, new Verb(VerbType.Intransitive, 1, SentenceConstruction.SVO, .25f));
                        break;
                    case Word.Vote:
                        dictionary.Add((Word)i, WordNature.Verb);
                        verbs.Add((Word)i, new Verb(VerbType.Transitive, 2, SentenceConstruction.SVO, .25f));
                        break;
                    case Word.Help:
                        dictionary.Add((Word)i, WordNature.Verb);
                        verbs.Add((Word)i, new Verb(VerbType.Transitive, 2,  SentenceConstruction.SVO, .75f));
                        break;
                    case Word.Disarm:
                        dictionary.Add((Word)i, WordNature.Verb);
                        verbs.Add((Word)i, new Verb(VerbType.Transitive, 2,  SentenceConstruction.SVO, .25f));
                        break;
                    case Word.Laugh:
                        dictionary.Add((Word)i, WordNature.Expression);
                        break;
                    case Word.Sob:
                        dictionary.Add((Word)i, WordNature.Expression);
                        break;
                    case Word.Fear:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Destroy:
                        dictionary.Add((Word)i, WordNature.Verb);
                        verbs.Add((Word)i, new Verb(VerbType.Transitive, 2, SentenceConstruction.SVO, -1f));
                        break;
                    case Word.Free:
                        dictionary.Add((Word)i, WordNature.Adjective);
                        adjectives.Add((Word)i, new Adjective(1.5f));
                        break;
                    case Word.Kill:
                        dictionary.Add((Word)i, WordNature.Verb);
                        verbs.Add((Word)i, new Verb(VerbType.Transitive, 2, SentenceConstruction.SVO, -.75f));
                        break;
                    case Word.Prison:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Prisonner:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Trap:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Danger:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Forbidden:
                        dictionary.Add((Word)i, WordNature.Adjective);
                        adjectives.Add((Word)i, new Adjective(.1f));
                        break;
                    case Word.Radioactivity:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Impossible:
                        dictionary.Add((Word)i, WordNature.Adjective);
                        adjectives.Add((Word)i, new Adjective(.1f));
                        break;
                    case Word.Bounty:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Information:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.NonSense:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.RDV:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Time:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Urgent:
                        dictionary.Add((Word)i, WordNature.Adjective);
                        adjectives.Add((Word)i, new Adjective(.9f));
                        break;
                    case Word.Idea:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Missile:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Code:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Friend:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Ennemy:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Spirit:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Brain:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Warrior:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.President:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Scientist:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Genetic:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Sex:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Reproduction:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Male:
                        dictionary.Add((Word)i, WordNature.Adjective);
                        adjectives.Add((Word)i, new Adjective(1f));
                        break;
                    case Word.Female:
                        dictionary.Add((Word)i, WordNature.Adjective);
                        adjectives.Add((Word)i, new Adjective(1f));
                        break;
                    case Word.Identity:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Pop:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.People:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Different:
                        dictionary.Add((Word)i, WordNature.Adjective);
                        adjectives.Add((Word)i, new Adjective(1f));
                        break;
                    case Word.Small:
                        dictionary.Add((Word)i, WordNature.Adjective);
                        adjectives.Add((Word)i, new Adjective(.5f));
                        break;
                    case Word.Great:
                        dictionary.Add((Word)i, WordNature.Adjective);
                        adjectives.Add((Word)i, new Adjective(1.5f));
                        break;
                    case Word.Strong:
                        dictionary.Add((Word)i, WordNature.Adjective);
                        adjectives.Add((Word)i, new Adjective(1.6f));
                        break;
                    case Word.Bad:
                        dictionary.Add((Word)i, WordNature.Adjective);
                        adjectives.Add((Word)i, new Adjective(.3f));
                        break;
                    case Word.Brave:
                        dictionary.Add((Word)i, WordNature.Adjective);
                        adjectives.Add((Word)i, new Adjective(1.3f));
                        break;
                    case Word.Good:
                        dictionary.Add((Word)i, WordNature.Adjective);
                        adjectives.Add((Word)i, new Adjective(1.4f));
                        break;
                    case Word.Crazy:
                        dictionary.Add((Word)i, WordNature.Adjective);
                        adjectives.Add((Word)i, new Adjective(.4f));
                        break;
                    case Word.Poor:
                        dictionary.Add((Word)i, WordNature.Adjective);
                        adjectives.Add((Word)i, new Adjective(.7f));
                        break;
                    case Word.Insult:
                        dictionary.Add((Word)i, WordNature.Expression);
                        break;
                    case Word.Curse:
                        dictionary.Add((Word)i, WordNature.Expression);
                        break;
                    case Word.Peace:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Dead:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Oorx:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Tromp:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Kingpak:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Robhead:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.CroolisVar:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.CroolisUlv:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Izwal:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Migrax:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Antenna:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Buggol:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Tricephal:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.TubularBrain:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Yukas:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Sinox:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Ondoyante:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Duplicate:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Tuttle:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Morlock:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Yoko:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Maxon:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Blood:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Torka:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Ship:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Contact:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Home:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Planet:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Trauma:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Entrax:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Ondoya:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Kristo:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Rosko:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Corpo:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Ulikan:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.BowBow:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Hour:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Coord:
                        dictionary.Add((Word)i, WordNature.Noun);
                        nouns.Add((Word)i);
                        break;
                    case Word.Equal:
                        dictionary.Add((Word)i, WordNature.Verb);
                        verbs.Add((Word)i, new Verb(VerbType.Transitive, 2,  SentenceConstruction.SVO, .25f));
                        break;
                    case Word.OutOf:
                        dictionary.Add((Word)i, WordNature.Ponctuation);
                        break;
                    case Word.Zero:
                        dictionary.Add((Word)i, WordNature.Number);
                        break;
                    case Word.One:
                        dictionary.Add((Word)i, WordNature.Number);
                        break;
                    case Word.Two:
                        dictionary.Add((Word)i, WordNature.Number);
                        break;
                    case Word.Three:
                        dictionary.Add((Word)i, WordNature.Number);
                        break;
                    case Word.For:
                        dictionary.Add((Word)i, WordNature.Number);
                        break;
                    case Word.Five:
                        dictionary.Add((Word)i, WordNature.Number);
                        break;
                    case Word.Six:
                        dictionary.Add((Word)i, WordNature.Number);
                        break;
                    case Word.Seven:
                        dictionary.Add((Word)i, WordNature.Number);
                        break;
                    case Word.Height:
                        dictionary.Add((Word)i, WordNature.Number);
                        break;
                    case Word.Nine:
                        dictionary.Add((Word)i, WordNature.Number);
                        break;
                }
            }
        }

    }

    public class Lexicon
    {
        public Dictionary<Word, float> glossary;

        public Lexicon()
        {
            for (int i = 0; i < Words.nouns.Count; i++)
            {
                glossary.Add(Words.nouns[i], UnityEngine.Random.value + 1);
            }
        }
    }

    public static class Language
    {

        public static SentenceCorrectness Correctness(this Sentence _sentence)
        {
            int adjCount = 0;
            int nounsCount = 0;
            int verbsCount = 0;
            int expressionsCount = 0;
            int nounsBeforeVerb = 0;
            int nounsAfterVerb = 0;
            int mainVerbIndex = 0;
            bool verbPassed = false;
            Word mainVerb = Word.none;

            for (int i = 0; i < _sentence.size; i++)
            {
                switch (Words.dictionary[_sentence.words[i]])
                {
                    case WordNature.Noun:
                        nounsCount++;
                        if (!verbPassed) nounsBeforeVerb++;
                        else nounsAfterVerb++;
                        break;
                    case WordNature.Verb:
                        if (!verbPassed)
                        {
                            mainVerb = _sentence.words[i];
                            mainVerbIndex = i;
                        }
                        verbPassed = true;
                        verbsCount++;
                        break;
                    case WordNature.Expression:
                        expressionsCount++;
                        break;
                    case WordNature.Adjective:
                        adjCount++;
                        break;
                    default:
                        break;
                }
            }

            if (verbsCount == 0)
            {
                if (nounsCount == 0 && expressionsCount == 0) return SentenceCorrectness.none;
                else if (expressionsCount == 0 && adjCount > 0) return SentenceCorrectness.correct;
                else if (expressionsCount == 0) return SentenceCorrectness.needVerb;
                else return SentenceCorrectness.correct;
            }
            else if (verbsCount == 1 || (verbsCount == 2 && (mainVerb == Word.Want || mainVerb == Word.Like || mainVerb == Word.Know)))
            {
                if (nounsCount == 0) return SentenceCorrectness.none;
                else if (nounsBeforeVerb == 0) return SentenceCorrectness.needSubject;
                else if (nounsBeforeVerb < 3)
                    switch (Words.verbs[_sentence.words[mainVerbIndex]].constructions)
                    {
                        case SentenceConstruction.SVO:
                            if (nounsAfterVerb > 0) return SentenceCorrectness.correct;
                            else return SentenceCorrectness.needObject;
                        case SentenceConstruction.SVA:
                            if (nounsAfterVerb > 0) return SentenceCorrectness.correct;
                            else return SentenceCorrectness.needAdverb;
                        case SentenceConstruction.SVOO:
                            if (nounsAfterVerb > 0) return SentenceCorrectness.correct;
                            else return SentenceCorrectness.needObject;
                        default:
                            return SentenceCorrectness.needVerb;
                    }
                else return SentenceCorrectness.none;
            }
            else return SentenceCorrectness.none;
        }
    }
}
