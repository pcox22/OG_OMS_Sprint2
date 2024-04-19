StreamReader productList = new StreamReader("MasterProductList.txt");

List<string> products = new List<string>();
// Contains each line of the product list. Each string in the list represents the entire, unseparated line

List<string[]> formattedProducts = new List<string[]>();
// Contains the separated elements of the Product List. Each index of the List is an array containing the different fields for the data
// The second-hand index accesses the specific data field [Ex, Product ID, On Hand Quantity, etc.]

//Since we have no fixed number of products [technically 300 here], I created a list to dynamically manage incoming products.
List<InventoryItem> inventory = new List<InventoryItem>();

while (!productList.EndOfStream)
{
				products.Add(productList.ReadLine());
}

for (int i = 0; i < products.Count; i++)
{
				formattedProducts.Add(products[i].Split(','));
				// Code below creates a new InventoryItem for each product on the master list and pushes it to an Arraylist
        // Format follows: List[single product's entire data set][individual field]
        // Use of hard-coded files should be fine since there should never be a product that has a different number of data fields [verified by product list; any empty fields are simply null at index]
				inventory.Add(new InventoryItem(Convert.ToInt32(formattedProducts[i][1]), Convert.ToInt32(formattedProducts[i][11]), Convert.ToInt32(formattedProducts[i][14]), formattedProducts[i][6] ,formattedProducts[i][3]));
}

/*
// Check that each inventory item created functions properly using a ToString override for testing
foreach(InventoryItem i in inventory)
{
				Console.WriteLine(i.ToString());
				Console.WriteLine();
}
*/
