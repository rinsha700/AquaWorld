using AquaWorld.Models;

namespace AquaWorld.Service.Interface
{
    public interface IAquaService
    {
        public Aqua Add(Aqua newAqua);
        public List<Aqua> GetAll();
        public Aqua Get(int id);
        public Aqua Update(Aqua newAqua,int id);
        public Aqua Delete(Aqua newAqua, int id);


    }
}
