namespace Cusquinhos.Domain.Models
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime? Modified { get; set; }
        public Guid? ModifiedBy { get; set; }
    }
}