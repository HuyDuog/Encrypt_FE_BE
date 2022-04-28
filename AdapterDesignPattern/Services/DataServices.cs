using AdapterDesignPattern.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Services
{
    public class DataServices : IDataServices
    {
        private readonly ICommandRepo _iCommandRepo;
        public DataServices(ICommandRepo iCommandRepo)
        {
            _iCommandRepo = iCommandRepo;
        }

        public string Base64toBinary(string data)
        {
            var result = _iCommandRepo.Base64toString(data);
            return _iCommandRepo.ChangetoBinary(result);
        }

        public string Base64toByte(string data)
        {
            var result = _iCommandRepo.Base64toString(data);
            return _iCommandRepo.StringtoByte(result);
        }

        public string Base64toHex(string data)
        {
            var result = _iCommandRepo.Base64toString(data);
            return _iCommandRepo.ChangetoHex(result);
        }

        public string Base64toString(string data)
        {
            return _iCommandRepo.Base64toString(data);

        }

        public string BinarytoBase64(string data)
        {
            var result = _iCommandRepo.BinarytoString(data);
            return _iCommandRepo.ChangetoBase64(result);
        }

        public string BinarytoByte(string data)
        {
            var result = _iCommandRepo.BinarytoString(data);
            return _iCommandRepo.StringtoByte(result);
        }

        public string BinarytoHex(string data)
        {
            var result = _iCommandRepo.BinarytoString(data);
            return _iCommandRepo.ChangetoHex(result);
        }

        public string BinarytoString(string data)
        {
            return _iCommandRepo.BinarytoString(data);
        }

        public string BytetoBase64(string data)
        {
            var result = _iCommandRepo.BytetoString(data);
            return _iCommandRepo.ChangetoBase64(result);
        }

        public string BytetoBinary(string data)
        {
            var result = _iCommandRepo.BytetoString(data);
            return _iCommandRepo.ChangetoBinary(result);
        }

        public string BytetoHex(string data)
        {
            var result = _iCommandRepo.BytetoString(data);
            return _iCommandRepo.ChangetoHex(result);
        }

        public string BytetoString(string data)
        {
            return _iCommandRepo.BytetoString(data);
        }

        public string ChangetoBase64(string data)
        {
            return _iCommandRepo.ChangetoBase64(data);
        }

        public string ChangetoBinary(string data)
        {
            return _iCommandRepo.ChangetoBinary(data);
        }

        public string ChangetoHex(string data)
        {
            return _iCommandRepo.ChangetoHex(data);
        }

        public string ChangetoWords(int data)
        {
            return _iCommandRepo.ChangetoWords(data);
        }

        public string HextoBase64(string data)
        {
            var result = _iCommandRepo.HextoString(data);
            return _iCommandRepo.ChangetoBase64(result);
        }
        public string HextoBinary(string data)
        {
            var result = _iCommandRepo.HextoString(data);
            return _iCommandRepo.ChangetoBinary(result);
        }

        public string HextoByte(string data)
        {
            var result = _iCommandRepo.HextoString(data);
            return _iCommandRepo.StringtoByte(result);
        }

        public string HextoString(string data)
        {
            return _iCommandRepo.HextoString(data);
        }

        public string StringtoByte(string data)
        {
            return _iCommandRepo.StringtoByte(data);
        }
    }
}
