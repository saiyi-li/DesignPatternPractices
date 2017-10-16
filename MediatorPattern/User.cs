namespace MediatorPattern
{
    public class User
    {
        public string name { get; set; }

        public User(string name)
        {
            this.name = name;
        }

        public void SendMessage(string message)
        {
            ChatRoom.ShowMessage(this, message);
        }
    }
}
