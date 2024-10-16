
using CitasApp.Data.Context;
using CitasApp.Data.Entitites;
using CitasApp.Data.Interfaces;

namespace CitasApp.Data.Repositories
{
    internal class CItasRepository : CitasInterface
    {
        public CItasRepository(CitasContext context) 
        {

        }
        public void AddCitas(Citas cita)
        {
            throw new NotImplementedException();
        }

        public void DeleteCitas(Citas cita)
        {
            throw new NotImplementedException();
        }

        public List<Citas> GetAllCitas()
        {
            throw new NotImplementedException();
        }

        public Citas GetCitas(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCitas(Citas cita)
        {
            throw new NotImplementedException();
        }
    }
}
