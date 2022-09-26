using namaLaptop;

namespace TugasPBO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Processor processor1 = new Processor("Intel", "CoreI5");
            Processor processor2 = new Processor("AMD", "Ryzen");
            Processor processor3 = new Processor("Intel", "CoreI7");

            Vga Vga1 = new Vga("Nvdia");
            Vga Vga2 = new Vga("AMD");

            Vivobook laptop1 = new Vivobook("Asus", "Vivobook", Vga1, processor1);
            Laptop laptop2 = new Laptop("Lenovo", "IdeaPad", Vga2, processor2);
            Predator predator1 = new Predator("Acer", "Predator", Vga2, processor3);
            ACER acer = new Predator("Acer", "Predator", Vga2, processor3);

            //soal no.1
            laptop2.LaptopDimatikan();
            laptop2.LaptopDinyalakan();

            //soal no.2
            laptop1.Ngoding();

            ////soal no.3
            Console.WriteLine("Merk Vga: " + laptop1.vga.merk + "\n" + "Merk processor: " + laptop1.processor.merk + "\n" + "Tipe processor: " + laptop1.processor.tipe);

            ////soal no.4
            predator1.BermainGame();

            ////soal no.5
            //acer.BermainGame();
        }
    }
    
}

class Processor
{
    public string merk;
    public string tipe;
    public Processor(string merk, string tipe)
    {
        this.merk = merk;
        this.tipe = tipe;
    }
}

namespace namaProcessor
{
    class Intel : Processor
    {
        public Intel(string merk, string tipe) : base(merk, tipe)
        {
            merk = "Intel";
        }
    }
    class CoreI3 : Intel
    {
        public CoreI3(string merk, string tipe) : base(merk, tipe)
        {
            tipe = "CoreI3";
        }
    }
    class CoreI5 : Intel
    {
        public CoreI5(string merk, string tipe) : base(merk, tipe)
        {
            tipe = "CoreI5";
        }
    }
    class CoreI7 : Intel
    {
        public CoreI7(string merk, string tipe) : base(merk, tipe)
        {
            tipe = "CoreI7";
        }
    }

    class AMD : Processor
    {
        public AMD(string merk, string tipe) : base(merk, tipe)
        {
            merk = "AMD";
        }
    }
    class Ryzen : AMD
    {
        public Ryzen(string merk, string tipe) : base(merk, tipe)
        {
            tipe = "RYZEN";
        }
    }
    class Athlon : AMD
    {
        public Athlon(string merk, string tipe) : base(merk, tipe)
        {
            tipe = "ATHLON";
        }
    }
}

class Laptop
{
    public string merk;
    public string tipe;
    public Vga vga;
    public Processor processor;
    public Laptop(string merk, string tipe, Vga vga, Processor processor)
    {
        this.merk = merk;
        this.tipe = tipe;
        this.vga = vga;
        this.processor = processor;
    }
    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} menyala");
    }
    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} mati");
    }
}
namespace namaLaptop
{
    class ASUS : Laptop
    {
        public ASUS(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            merk = "ASUS";
        }
    }
    class ROG : ASUS
    {
        public ROG(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            tipe = "ROG";
        }
    }
    class Vivobook : ASUS
    {
        public Vivobook(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }
    class ACER : Laptop
    {
        public ACER(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            merk = "ACER";
        }
    }
    class Swift : ACER
    {
        public Swift(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            tipe = "Swift";
        }
    }
    class Predator : ACER
    {
        public Predator(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {this.merk} {this.tipe} sedang memainkan game");
        }
    }
    class Lenovo : Laptop
    {
        public Lenovo(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            merk = "Lenovo";
        }
    }
    class IdeaPad : Lenovo
    {
        public IdeaPad(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            tipe = "IdeaPad";
        }
    }
    class Legion : Lenovo
    {
        public Legion(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            tipe = "Legion";
        }
    }
}

class Vga
{
    public string merk;
    public Vga(string merk)
    {
        this.merk = merk;
    }
}
namespace namaVga
{
    class Nvidia : Vga
    {
        public Nvidia(string merk) : base(merk)
        {
            merk = "Nvidia";
        }
    }
    class AMD : Vga
    {
        public AMD(string merk) : base(merk)
        {
            merk = "AMD";
        }
    }
}