using Example1.Data;
using Example1.Models;

namespace Example1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Branch branch = new Branch()
            {
                Id = 1,
                Name = "Palani Selvi Rajvickram",
                Location = "7/72 Vellaipranthan Kovil St Chidambaram",
                PhoneNo = 7010986623
            };

            using(var context = new ApplicationDbContext())
            {
                // Adding One Values to the Database without using any Queries :
                //context.Branch.Add(branch);
                //context.SaveChanges();
                //Console.WriteLine("Recore Created");



                // Fetch the Value in Database :
                //var branchs = context.Branch.ToList();


                //// For Each to Get all the values Same Like Fetch Method :
                //foreach(var Branch in branchs) {
                //    Console.WriteLine($"Name : {Branch.Name},Location : {Branch.Location},Phone No : {Branch.PhoneNo}");
                //}

                //Console.ReadKey();



                // Single Record value Taking :
                //var b = context.Branch.Where(x => x.Id == 1).FirstOrDefault();




                // Update the Record Value in the Database Without using SQL Queries :
                //context.Branch.Update(branch);
                //context.SaveChanges();



                // Delete the Value without using SQL Queries :
                //context.Branch.Remove(branch);
                //context.SaveChanges();

            }
        }
    }
}