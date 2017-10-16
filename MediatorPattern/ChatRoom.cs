using System;

namespace MediatorPattern
{
    public class ChatRoom
    {
        public static void ShowMessage(User user, string message)
        {
            Console.WriteLine(DateTime.Now + " [ "+user.name+" ] : "+message);
        }
    }
}
