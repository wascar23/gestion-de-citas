
using CitasApp.Data.Entitites;
namespace CitasApp.Data.Interfaces
{
    internal interface CitasInterface
    {
        void AddCitas(Citas cita);
        void DeleteCitas(Citas cita);
        void UpdateCitas(Citas cita);
        Citas GetCitas(int id);
        List<Citas> GetAllCitas();
    }
}
