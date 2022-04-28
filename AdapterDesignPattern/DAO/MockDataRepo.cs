
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.DAO
{
    public class MockDataRepo : ICommandRepo
    {
        public string Base64toString(string data)
        {
            var value = System.Convert.FromBase64String(data);
            return Encoding.UTF8.GetString(value);
        }

        public string BinarytoString(string data)
        {
          
                List<Byte> byteList = new List<Byte>();

                for (int i = 0; i < data.Length; i += 8)
                {
                    byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
                }
                return Encoding.ASCII.GetString(byteList.ToArray());
           
        }

        public string ChangetoBase64(string data)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(data);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public string ChangetoBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        public string ChangetoHex(string data)
        {
            MD5 mh = MD5.Create();
            byte[] byt = System.Text.Encoding.UTF8.GetBytes(data);
            byte[] hash = mh.ComputeHash(byt);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }

        public string ChangetoWords(int data)
        {
            if (data == 0)
                return "zero";

            if (data < 0)
                return "minus " + ChangetoWords(Math.Abs(data));

            string words = "";

            if ((data / 1000000) > 0)
            {
                words += ChangetoWords(data / 1000000) + " million ";
                data %= 1000000;
            }

            if ((data / 1000) > 0)
            {
                words += ChangetoWords(data / 1000) + " thousand ";
                data %= 1000;
            }

            if ((data / 100) > 0)
            {
                words += ChangetoWords(data / 100) + " hundred ";
                data %= 100;
            }

            if (data > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (data < 20)
                    words += unitsMap[data];
                else
                {
                    words += tensMap[data / 10];
                    if ((data % 10) > 0)
                        words += "-" + unitsMap[data % 10];
                }
            }

            return words;
        }

        public string StringtoByte(string data)
        {
            byte[] barr = Encoding.UTF8.GetBytes(data);
            string result = "";
            for (int i = 0; i<barr.Length;i++)
            {
                result = result + barr[i].ToString();
                if(i<barr.Length -1)
                {
                    result = result + "-";
                }    
            }    
            return result;
        }
        public string BytetoString(string data)
        {
            string[] text = data.Split("-");
            List<byte> result = new List<byte>();
            for (int i = 0; i < text.Length; i++)
            {
                result.Add((byte)int.Parse(text[i].ToString()));
            }
            return Encoding.ASCII.GetString(result.ToArray());
        }

        public string HextoString(string data)
        {
            byte[] result = Enumerable.Range(0, data.Length)
                      .Where(x => x % 2 == 0)
                      .Select(x => Convert.ToByte(data.Substring(x, 2), 16))
                      .ToArray();
            return System.Text.Encoding.UTF8.GetString(result);
        }
    }
}
