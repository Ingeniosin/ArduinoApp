using System.IO.Ports;

namespace App20220513_3.Services; 

public class ArduinoService {

   public SerialPort Port;

   public ArduinoService() {
      Port = new SerialPort();
      Port.PortName = "COM3";
      Port.BaudRate = 9600;
      Port.Open();
   }

   public void Encender() {
      Port.Write("A");
   }

   public void Apagar() {
      Port.Write("B");
   }
   
}