namespace Zoo.Manager
{
    public interface IZoo
    {
        public ZOO Create(ZOO zoo);
        public List<ZOO> Read();

        public ZOO Update(int id, ZOO zoo);
        public ZOO Delete(int id);

        public List<ZOO> Read(String navn);

    }

 
}
