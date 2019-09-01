namespace Adapter
{
    using System;

    /// <summary>
    /// Example from https://en.wikipedia.org/wiki/Adapter_pattern.
    /// </summary>
    public class AdapterDemo
    {
        public static void RechargeMicroUsbPhone(IMicroUsbPhone phone)
        {
            phone.ConnectMicroUsb();
            phone.Recharge();
        }

        public static void RechargeLightningPhone(ILightningPhone phone)
        {
            phone.ConnectLightning();
            phone.Recharge();
        }

        public static void Main(string[] args)
        {
            Android android = new Android();
            Iphone iPhone = new Iphone();

            Console.WriteLine("Recharging android with MicroUsb");
            RechargeMicroUsbPhone(android);

            Console.WriteLine("Recharging iPhone with Lightning");
            RechargeLightningPhone(iPhone);

            Console.WriteLine("Recharging iPhone with MicroUsb");
            RechargeMicroUsbPhone(new LightningToMicroUsbAdapter(iPhone));
        }
    }
}
