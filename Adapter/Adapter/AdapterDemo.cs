namespace Adapter
{
    using System;

    /// <summary>
    /// Example derive from https://en.wikipedia.org/wiki/Adapter_pattern.
    /// </summary>
    public class AdapterDemo
    {
        public static void Main(string[] args)
        {
            Android android = new Android();
            Iphone iphone = new Iphone();

            // We only have MicroUsb changer.
            MicroUsbCharger charger = new MicroUsbCharger();

            Console.WriteLine("Recharging Android with MicroUsb");
            charger.RechargeMicroUsbPhone(android);
            
            Console.WriteLine("Recharging Iphone with MicroUsb");
            charger.RechargeMicroUsbPhone(new LightningToMicroUsbAdapter(iphone));
        }
    }
}
