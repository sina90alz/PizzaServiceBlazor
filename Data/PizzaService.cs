namespace BlazingPizza.Data;

public class PizzaService
{
    public async Task<IList<PizzaDB>> GetPizzasAsync()
    {
        List<PizzaDB> listPizzaDB = new List<PizzaDB>();
        listPizzaDB.Add(new PizzaDB()
        {
            Name = "The Baconatorizor",
            BasePrice = 11.99M,
            Description = "It has EVERY kind of bacon",
            Vegetarian = false,
            Vegan = false
        });
        listPizzaDB.Add(new PizzaDB()
        {
            Name = "Buffalo chicken",
            BasePrice = 12.75M,
            Description = "Spicy chicken, hot sauce, and blue cheese, guaranteed to warm you up",
            Vegetarian = false,
            Vegan = false
        });
        listPizzaDB.Add(new PizzaDB()
        {
            Name = "Veggie Delight",
            BasePrice = 11.5M,
            Description = "It's like salad, but on a pizza",
            Vegetarian = true,
            Vegan = false
        });
        listPizzaDB.Add(new PizzaDB()
        {
            Name = "Margherita",
            BasePrice = 9.99M,
            Description = "Traditional Italian pizza with tomatoes and basil",
            Vegetarian = true,
            Vegan = true
        });
        listPizzaDB.Add(new PizzaDB()
        {
            Name = "Basic Cheese Pizza",
            BasePrice = 11.99M,
            Description = "It's cheesy and delicious. Why wouldn't you want one?",
            Vegetarian = true,
            Vegan = false
        });

        return await Task.FromResult(listPizzaDB);
    }
}