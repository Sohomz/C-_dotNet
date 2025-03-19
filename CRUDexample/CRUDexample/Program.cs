using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CRUDexample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                context.Database.Migrate(); // to add migrations if code changes the schema, DB will also adapt that
            }
            using (var context = new AppDbContext())
            {
                var newItem1 = new Item { Id = 1, Name = "Tea" }; //create new Items, see not adding ID
                var newItem2 = new Item { Id = 2, Name = "Sugar" };
                var newItem3 = new Item { Id = 3, Name = "Milk" };

                context.Items.Add(newItem1); //Add items one by one  to context.Items table
                                             //or use AddRange .AddRange(newItem1,newItem2,newItem3}
                context.Items.Add(newItem2);
                context.Items.Add(newItem3);
                context.SaveChanges(); // TO commit changes

                //Now to show in console
                var allItems = context.Items.ToList();
                Console.WriteLine("All Items");

                foreach (var item in allItems)
                {
                    Console.WriteLine($"ID: {item.Id} Name: {item.Name}");
                }
                //trying to update item1
                var itemToUpdate=context.Items.FirstOrDefault(item=>item.Id == newItem1.Id);
                if (itemToUpdate != null) // if item found with id 1
                {
                    itemToUpdate.Name = "Updated Item 1";
                }
                //Trying to delete an item
                var itemToDelete=context.Items.FirstOrDefault(item=>item.Id==newItem2.Id);
                if (itemToDelete != null) //if item found with id 2
                {
                    context.Items.Remove(itemToDelete);
                }

                context.SaveChanges(); // commit
            }
        }
    }
}
