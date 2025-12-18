using VirtualMuseum.Models;

namespace VirtualMuseum.Services
{
    public class ExhibitService
    {
        private readonly List<Exhibit> _exhibits = new();
        public List<Exhibit> GetAll() => _exhibits;
        public void AddExhibit(Exhibit exhibit)
        {
            _exhibits.Add(exhibit);
        }
    }
}
