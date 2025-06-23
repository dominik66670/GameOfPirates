using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfPirates
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    public class RandomOrFromFile
    {
        private readonly List<double> _values;
        private int _index = 0;
        private bool _zPliku;
        private Random _random;
        // Singleton instance
        private static RandomOrFromFile _instance;

        public static RandomOrFromFile Instance => _instance ?? throw new InvalidOperationException("RandomFromFile is not initialized. Call Init(filePath) first.");

        // Init method to load values from file
        public static void Init(string filePath, bool zPliku, int seed,bool czyZSeeda)
        {
            if (_instance != null)
                throw new InvalidOperationException("RandomFromFile is already initialized.");

            _instance = new RandomOrFromFile(filePath, zPliku, seed, czyZSeeda);
        }


        public static void Reset()
        {
            _instance = null;
        }

        // Private constructor — only accessible via Init
        private RandomOrFromFile(string filePath, bool zPliku, int seed,bool czyZSeeda)
        {
            _values = File.ReadAllLines(filePath)
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(line => double.Parse(line, CultureInfo.InvariantCulture))
                .ToList();
            _zPliku = zPliku;

            if (czyZSeeda)
            {
                _random = new Random(seed);
            }
            else
            {
              _random= new Random();
            }

            if (_values.Count == 0)
                throw new InvalidOperationException("Plik nie zawiera żadnych liczb.");
        }

        // Returns next double from [0.0, 1.0) with wrapping
        public double NextDouble()
        {
            if (_zPliku)
            {
                double value = _values[_index];
                _index = (_index + 1) % _values.Count;
                return value;
            }

            else
            {
                return _random.NextDouble();

            }
        }

        // Returns int in range [min, max)
        public int Next(int min, int max)
        {
            if (_zPliku)
            {
                double value = NextDouble();

                return min + (int)(value * (max - min));
            }
            else
            {
                return _random.Next(min, max);
            }
        }
        public List<List<int>> losoweWartosciLudek(int K)
        {
            List<List<int>> losoweWartosci = new List<List<int>>();
            for (int i = 0; i < K; i++)
            {
                List<int> liczbyLosowe = new List<int>() { 0,0,0,0,0,0,0,0,0};
                List<double> liczbyLosoweZPliku = new List<double>();
                for (int j = 0; j < 9; j++)
                {
                    liczbyLosoweZPliku.Add(NextDouble());
                } 
                for (int j = 1;j <= 9; j++)
                {
                    int min_index = liczbyLosoweZPliku.IndexOf(liczbyLosoweZPliku.Min());
                    liczbyLosoweZPliku[min_index] = 10.0;
                    liczbyLosowe[min_index] = j;
                }
                losoweWartosci.Add(liczbyLosowe);
            }
            return losoweWartosci;
        }

        /*public void CzyZpliku(bool zPliku)
        {
            _zPliku = zPliku;
        }

        public void CzyZSeeda(int seed,bool czySeed)
        {
            if (czySeed) { 
                _random = new Random(seed); 
            }

            else { 
                _random= new Random(); 
            }
        }*/
    }

}
