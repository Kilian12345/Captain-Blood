using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood.Lang
{
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

        public static float Value(this Word _word)
        {
            switch (Words.dictionary[_word])
            {
                case WordNature.Adjective:
                    return Words.adjectives[_word].factor;
                case WordNature.Verb:
                    return Words.verbs[_word].factor;
                case WordNature.Negation:
                    return -1;
                case WordNature.Number:
                    return (float)_word - 111;
                default:
                    return 0;
            }
        }

        public static WordNature Nature(this Word _word)
        {
            return Words.dictionary[_word];
        }

        public static bool Nature(this Word _word,WordNature _nature)
        {
            return _word.Nature() == _nature;
        }

        public static SentenceConstruction Type(this Word _word)
        {
            if (!_word.Nature(WordNature.Verb)) throw new LanguageException("You must use a verb.");

            return Words.verbs[_word].constructions;
        }

        public static bool IsWord(this Word _word)
        {
            WordNature nature = _word.Nature();
            if (nature == WordNature.Ponctuation || nature == WordNature.Expression || nature == WordNature.Negation || nature == WordNature.Number) return false;

            return true;
        }

        public static bool Contains(this Sentence _sentence, Word _word)
        {
            for (int i = 0; i < _sentence.size; i++)
            {
                if (_sentence.words[i] == _word) return true;
            }

            return false;
        }

        public static bool Contains(this Sentence _sentence, Word[] _words)
        {
            int count = 0;

            for (int k = 0; k < _words.Length; k++)
            {
                for (int i = 0; i < _sentence.size; i++)
                {
                    if (_sentence.words[i] == _words[k]) count++;
                }
            }

            return count == _words.Length;
        }

        public static bool Contains(this Sentence _sentence, Word[] _words, bool _validOrder)
        {
            int count = 0;

            if (!_validOrder) return _sentence.Contains(_words);
            else
            {
                for (int k = 0; k < _sentence.size; k++)
                {
                    if (_sentence.words[k] != _words[0]) continue;

                    for (int i = 0; i < _words.Length; i++)
                    {
                        if (_sentence.words[k + i] != _words[i]) break;
                        else
                        {
                            count++;
                        }
                    }

                    if (count == _words.Length) return true;
                    else count = 0;
                }

                return false;
            }
        }
    }

    public class LanguageException : System.Exception
    {
        public LanguageException(string message) : base(message) { }
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
                switch (_sentence.words[i].Nature())
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
                            if (nounsAfterVerb > 1) return SentenceCorrectness.correct;
                            else return SentenceCorrectness.needObject;
                        default:
                            return SentenceCorrectness.needVerb;
                    }
                else return SentenceCorrectness.none;
            }
            else return SentenceCorrectness.none;
        }

        public static SentenceConstruction Construction(this Sentence _sentence)
        {
            WordNature[] structure = new WordNature[_sentence.size];
            Dictionary<WordNature, int> counts = new Dictionary<WordNature, int>();

            int verbIndex = -1;

            for (int i = 0; i < 7; i++)
            {
                counts.Add((WordNature)i, 0);
            }

            for (int i = 0; i < _sentence.size; i++)
            {
                WordNature nature = _sentence.words[i].Nature();

                structure[i] = nature;
                counts[nature]++;
                if (_sentence.words[i].Nature(WordNature.Verb) && verbIndex == -1) verbIndex = i;
            }

            if(counts[WordNature.Noun] == 0 && counts[WordNature.Adjective] == 0)
            {
                if (counts[WordNature.Expression] > 0) return SentenceConstruction.E;
                else return SentenceConstruction.none;
            }
            else if (counts[WordNature.Verb] > 0)
            {
                return _sentence.words[verbIndex].Type();
            }
            else
            {
                return SentenceConstruction.O;
            }
        }

        public static Dictionary<WordFunction, List<Word>> Structure(this Sentence _sentence)
        {
            Dictionary<WordFunction, List<Word>> result = new Dictionary<WordFunction, List<Word>>();

            SentenceConstruction construction = _sentence.Construction();

            result.Add(WordFunction.Subject, new List<Word>());
            result.Add(WordFunction.Action, new List<Word>());
            result.Add(WordFunction.Object, new List<Word>());
            result.Add(WordFunction.Complement, new List<Word>());

            bool verbPassed = false;

            if(construction != SentenceConstruction.E  && construction != SentenceConstruction.O)
            {
                for (int i = 0; i < _sentence.size; i++)
                {
                    Word word = _sentence.words[i];

                    if(word.IsWord())
                    {
                        if(word.Nature(WordNature.Verb) && !verbPassed)
                        {
                            verbPassed = true;
                            result[WordFunction.Action].Add(word);
                        }
                        else if (!verbPassed)
                        {
                            result[WordFunction.Subject].Add(word);
                        }
                        else
                        { 
                            if(result[WordFunction.Action][0].Type() == SentenceConstruction.SVO) result[WordFunction.Object].Add(word);
                            else if (result[WordFunction.Action][0].Type() == SentenceConstruction.SVA) result[WordFunction.Complement].Add(word);
                        }
                    }
                }
            }
            else if (construction == SentenceConstruction.O)
            {

            }

            return result;
        }

        public static float SentenceEsteem(this Sentence _sentence, Alien _alien)
        {
            float result = 0;
            float verb = 0;
            bool negative = false;

            const float gaussianFactorA = 2.5f;
            const float gaussianFactorC = 1.12f;

            for (int i = 0; i < _sentence.size; i++)
            {
                WordNature nature = _sentence.words[i].Nature();
                
                if (nature == WordNature.Noun)
                {
                    Alien.GlossaryValues word = _alien.glossary[_sentence.words[i]];

                    //float weight = -Mathf.Pow(word.iterations, 2) * .05f * word.value + word.value > 0 ? Mathf.Clamp(-Mathf.Pow(word.iterations, 2) * .05f * word.value + word.value, 0, 2) : Mathf.Clamp(-Mathf.Pow(word.iterations, 2) * .05f * word.value + word.value, -2, 0);
                    float weight = Mathf.Pow(gaussianFactorA, -(Mathf.Pow(word.iterations, 2) / (2 * Mathf.Pow(gaussianFactorC, 2)))) * word.value;
                    if (i == 0)
                    {
                        result += weight / 10;
                    }
                    else if(verb == 0 && _sentence.Construction() != SentenceConstruction.O)
                    {
                        if(_sentence.words[i-1].Nature(WordNature.Adjective))
                        {
                            result += weight / 10 * _sentence.words[i - 1].Value();
                        }
                        else
                        {
                            result += weight / 10;
                        }
                    }
                    else
                    {
                        if (_sentence.words[i - 1].Nature(WordNature.Adjective))
                        {
                            result += weight * _sentence.words[i - 1].Value();
                        }
                        else
                        {
                            result += weight;
                        }
                    }

                    word.iterations++;
                }
                else if(nature == WordNature.Verb && verb == 0)
                {
                    verb = _sentence.words[i].Value();
                }
                else if (nature == WordNature.Verb)
                {
                    result += _sentence.words[i].Value() > 0 ? _sentence.words[i].Value() +1 : -1 + _sentence.words[i].Value();
                }
                else if (_sentence.words[i] == Word.Not)
                {
                    negative = true;
                }
            }

            if (verb == 0) verb = 1;

            result *= verb * (negative ? -1 : 1);

            result = result * 8 / _sentence.size;

            return result;
        }

        public static Answer Answer(this Sentence _sentence, Alien _alien)
        {
            Answer result;
            result.sentence = _sentence;
            result.construction = _sentence.Construction();
            result.correctness = _sentence.Correctness();
            result.structure = _sentence.Structure();
            result.esteem = _sentence.SentenceEsteem(_alien);
            result.negative = _sentence.IsNegative();

            return result;
        }

        public static bool IsNegative(this Sentence _sentence)
        {
            return _sentence.Contains(Word.No) || _sentence.Contains(Word.Not);
        }

        public static Sentence ReturnCoordinates(Vector2Int _coord)
        {
            return ReturnCoordinates(_coord.x, _coord.y);
        }

        public static Sentence ReturnCoordinates(int _x, int _y)
        {
            Sentence result = new Sentence();

            result.AddWord(Word.Coord);
            result.AddWord(Word.Equal);
            result.AddWord((Word)(111 + Mathf.FloorToInt(_x / 100)));
            result.AddWord((Word)(111 + Mathf.FloorToInt(_x / 10)- Mathf.FloorToInt(_x / 100)*10));
            result.AddWord((Word)(111 + _x - Mathf.FloorToInt(_x / 10)));
            result.AddWord(Word.OutOf);
            result.AddWord((Word)(111 + Mathf.FloorToInt(_y / 100)));
            result.AddWord((Word)(111 + Mathf.FloorToInt(_y / 10) - Mathf.FloorToInt(_y / 100)*10));
            result.AddWord((Word)(111 + _x - Mathf.FloorToInt(_y / 10)));

            return result;
        }

        public static Word[] ReturnCode(int _code)
        {
            if (_code.ToString().Length > 8 ) throw new LanguageException("The max length is 8 digits.");
            if (_code.ToString().Length == 0) throw new LanguageException("The min length is 1 digit.");

            Word[] result = new Word[_code.ToString().Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i]=(Word)(111+int.Parse(_code.ToString()[i].ToString()));
            }

            return result;
        }

        public static Word[] ReturnCode(string _code)
        {
            if (_code.Length > 8 ) throw new LanguageException("The max length is 8 digits.");
            if (_code.Length == 0) throw new LanguageException("The min length is 1 digit.");

            Word[] result = new Word[_code.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i]=(Word)(111+int.Parse(_code[i].ToString()));
            }

            return result;
        }

        public static Word[] ReturnCode(int _code, bool _use8Digits)
        {
            if(!_use8Digits) return Language.ReturnCode(_code);

            List<Word> result= new List<Word>();
            for (int i = 0; i < 8-_code.ToString().Length; i++)
            {
                result.Add(Word.Zero);
            }

            Word[] tmp = ReturnCode(_code);
            for (int i = 0; i < tmp.Length; i++)
            {
                result.Add(tmp[i]);
            }

            return result.ToArray();
        }

        public static Sentence RandomSentenceSVO()
        {
            Sentence result = new Sentence();

            if (Random.value < .8f) result.AddWord(GetWordOfNature(WordNature.Adjective));
            result.AddWord(Words.nouns[Random.Range(0, Words.nouns.Count)]);
            if (Random.value < .5f) result.AddWord(Word.Not);
            result.AddWord(GetWordOfNature(WordNature.Verb));
            if (Random.value < .8f) result.AddWord(GetWordOfNature(WordNature.Adjective));
            result.AddWord(Words.nouns[Random.Range(0, Words.nouns.Count)]);

            return result;

            Word GetWordOfNature(WordNature _nature)
            {
                Word tmp;

                do
                {
                    tmp = (Word)Random.Range(0, Words.dictionary.Count);
                } while (Words.dictionary[tmp] != _nature);

                return tmp;

            }
        }

        
    }
}
