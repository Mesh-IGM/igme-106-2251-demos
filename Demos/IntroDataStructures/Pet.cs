
namespace IntroDataStructures
{
    // A simple Pet class to use when playing with 
    // array & List based data structures
    class Pet
    {
        private string name;
        private double weight;

        // Default constructor
        public Pet()
        {
        }

        // Parameterized constructor
        public Pet(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
        }
    }
}
