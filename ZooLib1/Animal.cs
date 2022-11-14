namespace ZooLib1
{
    public class Animal
    {
        public String Navn { get; set; } 
        public String Slags { get; set; }
        public int Alder { get; set; }
        public String Køn { get; set; }


        public Animal()
        {


        }

        public override string ToString()
        {
            return $"{nameof(Navn)}: {Navn}, {nameof(Slags)}: {Slags}, {nameof(Alder)}: {Alder}, {nameof(Køn)}: {Køn}";
        }
    }
}