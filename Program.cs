using System;

namespace unity3d_multiplayer_gameserver
{
    class Program
    {
        static void Main(string[] args)
        {
            NetManager.StartLoop(8888);
        }
    }
}
