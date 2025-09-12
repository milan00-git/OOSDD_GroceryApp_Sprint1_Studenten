namespace Grocery.Core.Models
{
    public class GroceryListItem : Model
    {
        public int GroceryListId    //Changed to a property
        {
            get { return GroceryListId; }

            set { GroceryListItem = value; }
        } 

        public int ProductId    //Changed to a property 
        {
            get { return ProductId; }

            set { ProductId = value; }
        }

        public int Amount   //Property format changed
        {
            get { return Amount; }

            set { Amount = value; }
        }

        public int Id   //Property added
        {
            get { return Id; }

            set { Id = value; }
        }

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
