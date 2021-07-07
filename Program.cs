using System;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace UDP
{

  class Program
  {
    static void Main(string[] args)
    {
      Connection connection = new Connection("192.168.178.51", 9999);
      connection.sendPackage("CMD;A001;LED_01;OFF");
    }
  }
}