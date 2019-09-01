namespace Adapter
{
    using System;

    public class Iphone : ILightningPhone
    {
        private bool connected;

        public void ConnectLightning()
        {
            this.connected = true;
            Console.WriteLine("Lightning connected");
        }

        public void Recharge()
        {
            if (this.connected)
            {
                Console.WriteLine("Recharge started");
                Console.WriteLine("Recharge finished");
            }
            else
            {
                Console.WriteLine("Connect Lightning first");
            }
        }
    }
}
