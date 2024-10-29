namespace Example2_DB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Branch branch = new Branch()
            {
                Name = "Rajvickram",
                Location = "Vellai kovil CDM",
                PhoneNo = 7010986623
            };

            using(var context = new VikramContext())
            {
                context.Add(branch);
                context.SaveChanges();
            }
        }
    }
}