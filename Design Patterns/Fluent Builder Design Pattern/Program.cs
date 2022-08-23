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

    // Creating Fluent Builder Interface 
    interface IPhoneBuilder
    {
        public IPhoneBuilder SetDisplay();
        public IPhoneBuilder SetRAM();
        public IPhoneBuilder SetBattery();
        public IPhoneBuilder SetOperatingSystem();
        public IPhoneBuilder SetCamera();
        public IPhoneBuilder SetMicrophone();

        public Phone GetPhone();
    }

    // Creating Concrete Fluent Builder Class Samsung which implements Fluent Builder Interface
    class Samsung : IPhoneBuilder
    {
        readonly Phone phone = new();

        public IPhoneBuilder SetCamera()
        {
            phone.Camera = "13 MP";
            return this;
        }

        public IPhoneBuilder SetBattery()
        {
            phone.Battery = "2400 mAH";
            return this;
        }

        public IPhoneBuilder SetDisplay()
        {
            phone.Display = "PLS LCD/720 x 1600 pixels";
            return this;
        }

        public IPhoneBuilder SetMicrophone()
        {
            phone.Microphone = true;
            return this;
        }

        public IPhoneBuilder SetOperatingSystem()
        {
            phone.OperatingSystem = "Android";
            return this;
        }

        public IPhoneBuilder SetRAM()
        {
            phone.RAM = "16 GB";
            return this;
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

        public IPhoneBuilder SetCamera()
        {
            phone.Camera = "18 MP";
            return this; // returning this for chaining the methods 
        }

        public IPhoneBuilder SetBattery()
        {
            phone.Battery = "5000 mAH";
            return this;
        }

        public IPhoneBuilder SetDisplay()
        {
            phone.Display = "TFT/320 x 480 pixels";
            return this;
        }

        public IPhoneBuilder SetMicrophone()
        {
            phone.Microphone = true;
            return this;
        }

        public IPhoneBuilder SetOperatingSystem()
        {
            phone.OperatingSystem = "IOS";
            return this;
        }

        public IPhoneBuilder SetRAM()
        {
            phone.RAM = "16 GB";
            return this;
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
            //method chaining
            _phoneBuilder
                .SetCamera()
                .SetDisplay()
                .SetMicrophone()
                .SetOperatingSystem()
                .SetBattery()
                .SetRAM();

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
