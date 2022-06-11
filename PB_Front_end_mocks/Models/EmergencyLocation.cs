using PB_Front_end_mocks.Abstracts;

namespace PB_Front_end_mocks.Models
{
    public class EmergencyLocation: Place
    {
        public EmergencyLocation(Guid id, string name, string endereco, string telefone, string tipo) : base(id, name, endereco, telefone, tipo)
        {

        }
    }
}
