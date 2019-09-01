namespace Adapter
{
    using System;

    public class LightningToMicroUsbAdapter : IMicroUsbPhone
    {
        private readonly ILightningPhone lightningPhone;

        public LightningToMicroUsbAdapter(ILightningPhone lightningPhone)
        {
            this.lightningPhone = lightningPhone;
        }

        public void ConnectMicroUsb()
        {
            Console.WriteLine("MicroUsb connected");
            this.lightningPhone.ConnectLightning();
        }

        public void Recharge()
        {
            this.lightningPhone.Recharge();
        }
    }
}
