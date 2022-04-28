
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterDesignPattern.DAO
{
    public interface ICommandRepo
    {
        public string ChangetoBase64(string data);
        public string ChangetoHex(string data);
        public string HextoString(string data);
        public string ChangetoBinary(string data);
        public string ChangetoWords(int data);
        public string BinarytoString(string data);
        public string Base64toString(string data);
        public string StringtoByte(string data);
        public string BytetoString(string data);
    }
}
