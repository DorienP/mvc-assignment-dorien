namespace mvc_assignment_dorien.Models
{
    public class CustomerOrder
    {
        public int Id { get; set; }
        public System.DateTime OrderDate { get; set; }
        public string Description { get; set; }
        public decimal Total  { get; set; }
    }
}