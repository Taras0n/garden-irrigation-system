using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO.Ports;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private static SerialPort _serialPort;

        public ApplicationController()
        {
            if (_serialPort == null)
            {
                _serialPort = new SerialPort("COM3", 9600); // Задайте ваш COM порт та швидкість
                _serialPort.Open();
            }
        }

        // Увімкнення
        [HttpPost("turn-on")]
        public IActionResult TurnOn()
        {
            _serialPort.WriteLine("ON");  // Команда
            return Ok(new { status = "Arduino turned ON" });
        }

        // Вимкнення Arduino
        [HttpPost("turn-off")]
        public IActionResult TurnOff()
        {
            _serialPort.WriteLine("OFF");  // Команда
            return Ok(new { status = "Arduino turned OFF" });
        }

        // Закриття порту при зупинці додатку
        ~ApplicationController()
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                _serialPort.Close();
            }
        }

    }
}
