using System;

namespace unity3d_multiplayer_gameserver
{
    class Program
    {
        static void Main(string[] args)
        {
            MsgMove msgMove = new MsgMove();
            msgMove.x = 100;
            msgMove.y = 2;
            msgMove.z = 3;

            byte[] bytes = MsgBase.Encode(msgMove);
            Console.WriteLine(System.Text.Encoding.UTF8.GetString(bytes));
        }
    }
}
