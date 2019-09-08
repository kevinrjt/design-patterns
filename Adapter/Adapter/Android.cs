namespace Adapter
{
    using System;

    public class Android : IMicroUsbPhone
    {
        private bool connected;

        public void ConnectMicroUsb()
        {
            this.connected = true;
            Console.WriteLine("MicroUsb connected");
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
                Console.WriteLine("Connect MicroUsb first");
            }
        }
    }
}
