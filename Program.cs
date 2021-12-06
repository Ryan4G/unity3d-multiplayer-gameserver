using System;

namespace unity3d_multiplayer_gameserver
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!DBManager.Connect("game", "127.0.0.1", 3306, "root", "123456"))
            {
                return;
            }

            NetManager.StartLoop(8888);
        }
    }
}
