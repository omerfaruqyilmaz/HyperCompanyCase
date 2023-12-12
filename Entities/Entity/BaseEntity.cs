namespace HyperCompanyCase.Entities.Entity
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsStatus { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
