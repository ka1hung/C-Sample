using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = AES.Encrypt("hello word!!", "key");
            Console.WriteLine(data);
            var result = AES.Decrypt(data, "key");
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
