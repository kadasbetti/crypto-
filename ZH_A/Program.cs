using System.ComponentModel;

namespace ZH_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("crypto.csv");
            Crypto[] cryptos = new Crypto[lines.Length-1];

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(";");

                cryptos[i - 1] = new Crypto(parts[0], parts[1], float.Parse(parts[2]), float.Parse(parts[3]));
            }



            Console.WriteLine("Tell me a year!");
            string targetYear = Console.ReadLine();
            Console.WriteLine("Tell me a month!");
            string targetMonth = Console.ReadLine();
            List<float> Bitcoin = new List<float>();
            List<float> Ethereum = new List<float>();
            List<float> Tether = new List<float>();
            foreach (Crypto line in cryptos)
            {
                if(line.Date.Substring(0,4) ==targetYear && line.Date.Substring(5,2) == targetMonth)
                {
                    if(line.Name == "Bitcoin")
                    {
                        Bitcoin.Add(line.Close - line.Open);
                    }
                    if (line.Name == "Ethereum")
                    {
                        Ethereum.Add(line.Close - line.Open);
                    }
                    if (line.Name == "Tether")
                    {
                        Tether.Add( line.Close - line.Open);
                    }
                }

            }
            for(int i = 0; i<Bitcoin.Count;i++)
            {
                Console.WriteLine(Bitcoin[i]);
            }
            for (int i = 0; i < Ethereum.Count; i++)
            {
                Console.WriteLine(Ethereum[i]);
            }
            for (int i = 0; i < Tether.Count; i++)
            {
                Console.WriteLine(Tether[i]);
            }



            Console.WriteLine("Tell me a crypo name!");
            string targetName = Console.ReadLine();
            float allOpen = 0;
            float allClose = 0;
            float counter = 0;
            foreach(Crypto line in cryptos)
            {
                if(line.Name == targetName)
                {
                    allOpen += line.Open;
                    allClose += line.Close;
                    counter++;
                }
            }
            Console.WriteLine(allOpen / counter);
            Console.WriteLine(allClose / counter);



            int max = 0;
            string maxName = "";
            foreach (Crypto line in cryptos)
            {
                if ((line.Close - line.Open) / line.Open > max)
                {
                    maxName = line.Name;
                }
            }
            Console.WriteLine(maxName);
            Console.Read();
        }
    }
}