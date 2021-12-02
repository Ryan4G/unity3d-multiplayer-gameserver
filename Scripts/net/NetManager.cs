using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
public class NetManager
{
    public static Socket listenfd;

    public static Dictionary<Socket, ClientState> clients = new Dictionary<Socket, ClientState>();

    static List<Socket> checkRead = new List<Socket>();
}
