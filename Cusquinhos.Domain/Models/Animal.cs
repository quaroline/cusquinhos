using Cusquinhos.Shared.Enums;

namespace Cusquinhos.Domain.Models
{
    public class Animal : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime BirthDate { get; set; }
        public char Gender { get; set; }
        public Breed Breed { get; set; }
        public Species Species { get; set; }
        public Guid NgoId { get; set; }
        public Guid RegisteredBy { get; set; }
    }
}