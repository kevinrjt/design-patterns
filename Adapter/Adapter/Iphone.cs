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
                Console.WriteLine("Recharging started");
                Console.WriteLine("Recharging finished");
            }
            else
            {
                Console.WriteLine("Connect Lightning first");
            }
        }
    }
}
