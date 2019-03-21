using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroJam.CaptainBlood
{
    [System.Serializable]
    public class Planet
    {
        public readonly Glossary[] name;
        public readonly Vector2Int coordinates;
        public readonly Glossary race;
        public bool visited;
        public bool destroyed;
        public Alien inhabitant;

        public Planet(Glossary[] _name, Vector2Int _coord, Glossary _race)
        {
            if (_name.Length > 4) throw new PlanetValueException("Planet's name is too long.");
            if (_name[0] != Glossary.Planet) throw new PlanetValueException("Planet's name must begin with PLANET");
            if (_coord.x < 0 || _coord.x > 256 || _coord.y < 0 || _coord.y > 125) throw new PlanetValueException("Planet's coordinates must be between [0,0] and [256,125].");
            if((int)_race < 73 && (int)_race > 88) throw new PlanetValueException("Planet's race is not a race !");

            name = _name;
            coordinates = _coord;
            race = _race;

            inhabitant = new Alien();
        }

        public Planet(Vector2Int _coord, Glossary _race)
        {
            if (_coord.x < 0 || _coord.x > 256 || _coord.y < 0 || _coord.y > 125) throw new PlanetValueException("Planet's coordinates must be between [0,0] and [256,125].");
            if ((int)_race < 73 || (int)_race > 88) throw new PlanetValueException("Planet's race is not a race !");

            name = GenerateName();
            coordinates = _coord;
            race = _race;

            inhabitant = new Alien();

        }


        private Glossary[] GenerateName()
        {
            int length = Random.Range(3, 5);

            Glossary[] result = new Glossary[length];

            Debug.Log(result.Length);

            result[0] = Glossary.Planet;
            result[1] = (Glossary)Random.Range(2, 73);
            result[2] = (Glossary)Random.Range(2, 73);
            if (result.Length > 3) result[3] = (Glossary)Random.Range(113, 121);

            return result;
        }

        public void SetAlien()
        {

        }
    }

    [System.Serializable]
    public class Grid
    {
        public Vector2Int[] coord;
        public Planet[] planets;

        public Grid(int _size)
        {
            coord = new Vector2Int[_size];
            planets = new Planet[_size];
        }

        public Planet Planet(Vector2Int _coord)
        {
            for (int i = 256*_coord.x; i < 256 * _coord.x + 126; i++)
            {
                return planets[i];
            }

            return null;
        }
    }

    public static class Galaxy
    {
        public static Dictionary<Vector2Int, Planet> planets = new Dictionary<Vector2Int, Planet>();
        public static Grid grid;

        public static void Initialize()
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            sw.Start();

            grid = new Grid(256 * 126);

            int index = 0;

            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < 126; y++)
                {
                    planets.Add(new Vector2Int(x, y), new Planet(new Vector2Int(x, y), (Glossary)Random.Range(74, 89)));

                    grid.coord[index] = new Vector2Int(x, y);
                    grid.planets[index] = planets[new Vector2Int(x, y)];

                    index++;
                }
            }

            sw.Stop();

            Debug.Log("Time to Initialize whole Galaxy : "+sw.ElapsedMilliseconds/1000+"s.");
        }
    }

    public class PlanetValueException : System.Exception
    {
        public PlanetValueException(string message) : base (message) { }
    }

    
}
