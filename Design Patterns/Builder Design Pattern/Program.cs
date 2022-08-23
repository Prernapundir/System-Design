using System;

namespace Builder_Design_Pattern
{
    class Phone
    {
        public string Display;
        public string RAM;
        public string Battery;
        public string OperatingSystem;
        public string Camera;
        public bool Microphone;

        public void DisplayPhone()
        {
            Console.WriteLine($"Display : {this.Display} \n" +
                $"RAM : {this.RAM} \n" +
                $"Battery : {this.Battery} \n" +
                $"Operating System : {this.OperatingSystem} \n" +
                $"Camera : {this.Camera} \n" +
                $"Microphone : {this.Microphone} \n");
        }
    }

    // Creating Builder Interface 
    interface IPhoneBuilder
    {
        public void SetDisplay();
        public void SetRAM();
        public void SetBattery();
        public void SetOperatingSystem();
        public void SetCamera();
        public void SetMicrophone();

        public Phone GetPhone();
    }

    // Creating Concrete Builder Class Samsung which implements Builder Interface
    class Samsung : IPhoneBuilder
    {
        readonly Phone phone = new();

        public void SetCamera()
        {
            phone.Camera = "13 MP";
        }

        public void SetBattery()
        {
            phone.Battery = "2400 mAH";
        }

        public void SetDisplay()
        {
            phone.Display = "PLS LCD/720 x 1600 pixels";
        }

        public void SetMicrophone()
        {
            phone.Microphone = true;
        }

        public void SetOperatingSystem()
        {
            phone.OperatingSystem = "Android";
        }

        public void SetRAM()
        {
            phone.RAM = "16 GB";
        }

        public Phone GetPhone()
        {
            return phone;
        }
    }

    //Creating Builder Class IPhone :IPhoneBuilder
    class IPhone : IPhoneBuilder
    {
        readonly Phone phone = new();

        public void SetCamera()
        {
            phone.Camera = "18 MP";
        }

        public void SetBattery()
        {
            phone.Battery = "5000 mAH";
        }

        public void SetDisplay()
        {
            phone.Display = "TFT/320 x 480 pixels";
        }

        public void SetMicrophone()
        {
            phone.Microphone = true;
        }

        public void SetOperatingSystem()
        {
            phone.OperatingSystem = "IOS";
        }

        public void SetRAM()
        {
            phone.RAM = "16 GB";
        }

        public Phone GetPhone()
        {
            return phone;
        }
    }

    // Creating Phone Director
    class PhoneDirector
    {
        private IPhoneBuilder _phoneBuilder;

        public PhoneDirector(IPhoneBuilder phoneBuilder)
        {
            _phoneBuilder = phoneBuilder;
        }

        public Phone BuildPhone()
        {
            _phoneBuilder.SetCamera();
            _phoneBuilder.SetDisplay();
            _phoneBuilder.SetMicrophone();
            _phoneBuilder.SetOperatingSystem();
            _phoneBuilder.SetBattery();
            _phoneBuilder.SetRAM();

            return _phoneBuilder.GetPhone();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            PhoneDirector samsungDirector = new(new Samsung());
            Phone samsung = samsungDirector.BuildPhone();
            samsung.DisplayPhone();

            PhoneDirector iPhoneDirector = new(new IPhone());
            Phone iPhone = iPhoneDirector.BuildPhone();
            iPhone.DisplayPhone();
        }
    }
}
