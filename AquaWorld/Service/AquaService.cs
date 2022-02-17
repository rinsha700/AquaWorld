using AquaWorld.Data;
using AquaWorld.Models;
using AquaWorld.Service.Interface;

namespace AquaWorld.Service
{
    public class AquaService : IAquaService
    {
        AquaDbContext aquaDbContext;
        public AquaService(AquaDbContext aquaDbContext)
        {
            this.aquaDbContext = aquaDbContext;
        }
        public Aqua Add(Aqua newAqua)
        {

            aquaDbContext.Add(newAqua);
            aquaDbContext.SaveChanges();
            return newAqua;
        }

        public Aqua Delete(Aqua newAqua, int id)
        {
            throw new NotImplementedException();
        }

        public Aqua Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Aqua> GetAll()
        {
            throw new NotImplementedException();
        }

        public Aqua Update(Aqua newAqua, int id)
        {
            throw new NotImplementedException();
        }
    }
}
