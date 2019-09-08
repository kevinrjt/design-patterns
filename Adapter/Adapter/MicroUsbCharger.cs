namespace Adapter
{
    public class MicroUsbCharger
    {
        public void RechargeMicroUsbPhone(IMicroUsbPhone phone)
        {
            phone.ConnectMicroUsb();
            phone.Recharge();
        }
    }
}
