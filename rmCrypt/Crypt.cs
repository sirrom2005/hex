using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rmCrypt
{
    public class Crypt
    {
        private string key;

        public Crypt(string key)
        {
            this.key = key;
        }

        public string EnCode(string value)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(value);
            string hex = BitConverter.ToString(bytes);
            return hex.Replace("-","::0x");
        }

        public string DeCode(string value)
        {
            string output = "";
            value = value.Replace("::0x", "-");
            int len = value.Length;

            int[] _byte = new int[len];
            byte[] data = new byte[len];

            int i = 0;
            foreach(string x in value.Split('-')) {
                int b = Convert.ToInt32(x, 16);
                output = output + Char.ConvertFromUtf32(b);
                i++;
            }

            return output;
        }
    }
}
