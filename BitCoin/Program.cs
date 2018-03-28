using NBitcoin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCoin
{
    class Program
    {
        static void Main(string[] args)
        {

            Key privateKey = new Key();
            PubKey publicKey = privateKey.PubKey;
            Console.WriteLine(privateKey);
            Console.WriteLine(publicKey);
            Console.WriteLine(publicKey.GetAddress(Network.Main).ToString().Length);
            Console.WriteLine(publicKey.GetAddress(Network.TestNet));
            Console.ReadKey();

        }
    }
}
