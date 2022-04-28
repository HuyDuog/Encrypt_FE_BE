using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Services
{
    public interface IDataServices
    {
        public string ChangetoBase64(string data);
        public string ChangetoHex(string data);
        public string ChangetoBinary(string data);
        public string ChangetoWords(int data);
        public string BinarytoString(string data);
        public string Base64toString(string data);
        public string StringtoByte(string data);
        public string BytetoString(string data);
        public string HextoString(string data);
        public string Base64toHex(string data);
        public string Base64toBinary(string data);
        public string Base64toByte(string data);
        public string HextoBase64(string data);
        public string HextoBinary(string data);
        public string HextoByte(string data);
        public string BinarytoBase64(string data);
        public string BinarytoHex(string data);
        public string BinarytoByte(string data);
        public string BytetoHex(string data);
        public string BytetoBase64(string data);
        public string BytetoBinary(string data);

    }
}
