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
        // Singleton instance
        private static RandomOrFromFile _instance;

        public static RandomOrFromFile Instance => _instance ?? throw new InvalidOperationException("RandomFromFile is not initialized. Call Init(filePath) first.");

        // Init method to load values from file
        public static void Init(string filePath, bool zPliku)
        {
            if (_instance != null)
                throw new InvalidOperationException("RandomFromFile is already initialized.");

            _instance = new RandomOrFromFile(filePath, zPliku);
        }

        // Private constructor — only accessible via Init
        private RandomOrFromFile(string filePath, bool zPliku)
        {
            _values = File.ReadAllLines(filePath)
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(line => double.Parse(line, CultureInfo.InvariantCulture))
                .ToList();
            _zPliku = zPliku;
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
                Random random = new Random();
                return random.NextDouble();
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
                Random random = new Random();
                return random.Next(min, max);
            }
        }

        public void CzyZpliku(bool zPliku)
        {
            _zPliku = zPliku;
        }
    }

}
