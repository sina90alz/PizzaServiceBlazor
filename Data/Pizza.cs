namespace BlazingPizza.Data;

public class PizzaDB
{
    public int PizzaId { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public decimal BasePrice { get; set; }
    
    public bool Vegetarian { get; set; }
    
    public bool Vegan { get; set; }
}