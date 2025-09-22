namespace IndexersGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            MyStringList names = new MyStringList();
            names.Add("Shiro");
            names.Add("Lacy");
            names.Add("Pax");


            Console.WriteLine("My first pet is " + names[0]);
            names[0] = "SHIRO!";
            */

            MyList<string> names = new MyList<string>();
            names.Add("Shiro");
            names.Add("Lacy");
            names.Add("Pax");


            Console.WriteLine("My first pet is " + names[0]);
            names[0] = "SHIRO!";

            MyList<int> nums = new MyList<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);

            for(int i=0; i<nums.Count; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
