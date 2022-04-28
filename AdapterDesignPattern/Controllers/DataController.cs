using AdapterDesignPattern.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        private readonly IDataServices _services;
        public DataController(IDataServices services)
        {
            _services = services;
        }
        [HttpPost]
        [Route("ChangetoBase64")]
        public ActionResult ChangetoBase64(string data)
        {
            var p = _services.ChangetoBase64(data);
            return Ok(p);
        }
        [HttpPost]
        [Route("ChangetoHex")]
        public ActionResult ChangetoHex(string data)
        {
            var p = _services.ChangetoHex(data);
            return Ok(p);
        }
        [HttpPost]
        [Route("ChangetoBinary")]
        public ActionResult ChangetoBinary(string data)
        {
            var p = _services.ChangetoBinary(data);
            return Ok(p);
        }
        [HttpPost]
        [Route("ChangetoWords")]
        public ActionResult ChangetoWords(int data)
        {
            var p = _services.ChangetoWords(data);
            return Ok(p);
        }
        [HttpPost]
        [Route("BinarytoString")]
        public ActionResult BinarytoString(string  data)
        {
            var p = _services.BinarytoString(data);
            return Ok(p);
        }
        [HttpPost]
        [Route("Base64toString")]
        public ActionResult Base64toString(string data)
        {
            var p = _services.Base64toString(data);
            return Ok(p);
        }
        [HttpPost]
        [Route("StringtoByte")]
        public ActionResult StringtoByte(string data)
        {
            var p = _services.StringtoByte(data);
            return Ok(p);
        }
        [HttpPost]
        [Route("BytetoString")]
        public ActionResult BytetoString(string data)
        {
            var p = _services.BytetoString(data);
            return Ok(p);
        }
        [HttpPost]
        [Route("HextoString")]
        public ActionResult HextoString(string data)
        {
            var p = _services.HextoString(data);
            return Ok(p);
        }
        [HttpPost]
        [Route("Base64toHex")]
        public ActionResult Base64toHex(string data)
        {
            var p = _services.Base64toHex(data);
            return Ok(p);
        }
        [HttpPost]
        [Route("Base64toBinary")]
        public ActionResult Base64toBinary(string data)
        {
            var p = _services.Base64toBinary(data);
            return Ok(p);
        }
        [HttpPost]
        [Route("Base64toByte")]
        public ActionResult Base64toByte(string data)
        {
            var p = _services.Base64toByte(data);
            return Ok(p);
        }
        [HttpPost]
        [Route("BinarytoBase64")]
        public ActionResult BinarytoBase64(string data)
        {
            var p = _services.BinarytoBase64(data);
            return Ok(p);
        }
        [HttpPost]
        [Route("BinarytoByte")]
        public ActionResult BinarytoByte(string data)
        {
            var p = _services.BinarytoByte(data);
            return Ok(p);
        }
        [HttpPost]
        [Route("BinarytoHex")]
        public ActionResult BinarytoHex(string data)
        {
            var p = _services.BinarytoHex(data);
            return Ok(p);
        }
        [HttpPost]
        [Route("BytetoBase64")]
        public ActionResult BytetoBase64(string data)
        {
            var p = _services.BytetoBase64(data);
            return Ok(p);
        }
        [HttpPost]
        [Route("BytetoBinary")]
        public ActionResult BytetoBinary(string data)
        {
            var p = _services.BytetoBinary(data);
            return Ok(p);
        }
        [HttpPost]
        [Route("BytetoHex")]
        public ActionResult BytetoHex(string data)
        {
            var p = _services.BytetoHex(data);
            return Ok(p);
        }
        [HttpPost]
        [Route("HextoBase64")]
        public ActionResult HextoBase64(string data)
        {
            var p = _services.HextoBase64(data);
            return Ok(p);
        }
        [HttpPost]
        [Route("HextoBinary")]
        public ActionResult HextoBinary(string data)
        {
            var p = _services.HextoBinary(data);
            return Ok(p);
        }
        [HttpPost]
        [Route("HextoByte")]
        public ActionResult HextoByte(string data)
        {
            var p = _services.HextoByte(data);
            return Ok(p);
        }
    }
}
