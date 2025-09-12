namespace Grocery.Core.Models
{
    public class GroceryListItem : Model
    {
        public int GroceryListId { get; set; }  //Changed to a (auto) property 

        public int ProductId { get; set; }   //Changed to a (auto) property 

        public int Amount { get; set; }

        public GroceryListItem(int id, int groceryListId, int productId, int amount) : base(id, "")
        {
            //Values assigned to the properties

            Id = id;
            GroceryListId = groceryListId;
            ProductId = productId;
            Amount = amount;

        }

        public Product Product { get; set; } = new(0, "None", 0);
    }
}
