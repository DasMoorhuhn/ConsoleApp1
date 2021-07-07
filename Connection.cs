using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace UDP
{
	class Connection
	{
		byte[] sendbuf;
		string ipAddr;
		int port;
		IPAddress broadcast;
		IPEndPoint ep;
		Socket s;

		public Connection(string _ip, int _port)
		{
			this.ipAddr = _ip;
			this.port = _port;
			this.s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
			this.broadcast = IPAddress.Parse(this.ipAddr);
			this.ep = new IPEndPoint(broadcast, this.port);
		}

		public void sendPackage(string message)
		{
			this.sendbuf = Encoding.ASCII.GetBytes(message);
			s.SendTo(sendbuf, ep);
		}
	}
}
