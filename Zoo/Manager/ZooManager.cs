namespace Zoo.Manager
{
    public class ZooManager : IZoo

    {

        private static List<ZOO> data = new List<ZOO>()
        {
            new ZOO(1,"CopenhagenZoo", "copenhagen", "roskildevej", 1235),
            new ZOO(2,"AalborgZoo", "Aalborg", "Hovedvej", 4321),
            new ZOO(3,"AalborgZoo", "Aalborg", "Hovedvej", 4321)
        };
        public   ZOO Create(ZOO zoo)
        {
            throw new NotImplementedException();
        }

        public List<ZOO> Read()
        {
            throw new NotImplementedException();
        }

        public ZOO Update(int id, ZOO zoo)
        {
            throw new NotImplementedException();
        }

        public ZOO Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ZOO> Read(string navn)
        {
            if (navn is null)
            {
                return new List<ZOO>();
            }
            return data.Where(f => f.navn.ToLower().Contains(navn.ToLower())).ToList();
        }
    }
}
