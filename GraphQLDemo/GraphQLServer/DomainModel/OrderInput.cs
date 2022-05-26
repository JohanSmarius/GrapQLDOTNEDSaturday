namespace GraphQLServer.DomainModel;

public class OrderInput
{
    public int CustomerId { get; set; }
    
    public DateTime OrderTime { get; set; }
}