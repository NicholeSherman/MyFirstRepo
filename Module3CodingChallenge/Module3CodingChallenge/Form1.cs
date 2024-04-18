using System.Reflection;

namespace Module3CodingChallenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Ice Cream Flavor event handler
        private void flavor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Data sources

            // List of description strings
            string[] descriptions = { "Vanilla ice cream is a classic flavor made with fresh vanilla.",
                "Rocky Road is a chocolate-flavored ice cream with nuts and marshmallows.",
                "Strawberry ice cream is made by blending in fresh strawberries",
                "Caramel Collision is vanilla ice cream with ribbons of carmel and carmel filled chocolate candies" };

            // Dictionary of prices
            Dictionary<string, decimal> iceCreamPrices = new Dictionary<string, decimal>
            {
                { "Vanilla", 2.99m },
                { "Rocky Road", 3.59m },
                { "Strawberry", 3.49m },
                {"Caramel Collision", 3.59m }
            };

            // LINQ Query 
            var myLinqQuery = from description in descriptions
                              where description.StartsWith(flavor.Text)
                              select description;

            // Query execution
            foreach (var description in myLinqQuery)
                lblDescription.Text = description;

            // LINQ Query 
            var priceQuery = from price in iceCreamPrices
                             where price.Key == (flavor.Text)
                             select price;

            // Query execution
            foreach (var price in priceQuery)
                lblPrice.Text = "$" + price.Value.ToString();
        }

        // Pet event handler
        private void pet_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Data sources

            // List of description strings
            string[] descriptions =
                { "Angel is our little scaredy cat. She usually can't be seen unless you catch her running to hide.",
                "Apollo is our escape artist. He leaps the tallest fences to explore whatever is on the other side.",
                "Artemis loves to lick. She will whine when you walk in the door because she needs to taste you, right now.",
                "Coco was our crazy little girl. She loved to cuddle...until she was done, then she would bite.",
                "Ginger loves to cuddle, and is 100% the alpha of her species",
                "Hades was the sweetest little guy ever. I miss him swimming out to say hi!",
                "Harry does not have even a single hair on him. He's pretty quiet and likes to sleep on a warm rock",
                "Lydia is our grumpy old lady. She likes to grumble and barks whenever the other pets are having fun.",
                "Momo is our bottomless pit. He will always insist that no one ever feeds him, and it is always time to eat.",
                "Squeaker was our puppy in a smaller animals body. He loved to do tricks and have his ears scratched",
                "Toby ties with Lydia at being grumpy, but he's not old or a lady."

                };

            // Dictionary of pet types
            Dictionary<string, string> petTypes = new Dictionary<string, string>
            {
                { "Angel", "Cat" },
                { "Apollo", "Dog" },
                { "Artemis", "Dog" },
                { "Coco", "Ferret" },
                { "Ginger", "Cat" },
                { "Hades", "Fish" },
                { "Harry", "Lizard" },
                { "Lydia", "Dog" },
                { "Momo", "Cat" },
                { "Squeaker", "Rat" },
                { "Toby", "Cat" }
            };

            // Dictionary of pet breeds/colors
            Dictionary<string, string> petColors = new Dictionary<string, string>
            {
                { "Angel", "Calico" },
                { "Apollo", "Black and White Husky" },
                {"Artemis", "White German Shepherd Great Pyrenees Mix" },
                { "Coco", "Brown" },
                { "Ginger", "Calico" },
                { "Hades", "Black Fan Tailed Beta" },
                { "Harry", "Bearded Dragon" },
                { "Lydia", "German Shepherd Chihuahua mix" },
                { "Momo", "Orange Tabby" },
                { "Squeaker", "Black and White" },
                { "Toby", "Black and Grey Tabby" },
            };

            // LINQ Query for description
            var myLinqQuery = from description in descriptions
                              where description.StartsWith(pet.Text)
                              select description;

            // Query execution for description
            foreach (var description in myLinqQuery)
                lblPetDescription.Text = description;

            // LINQ Query for breed/color
            var colorQuery = from color in petColors
                             where color.Key == (pet.Text)
                             select color;

            // Query execution for breed/color
            foreach (var color in colorQuery)
                lblPetColor.Text = color.Value.ToString();

            // LINQ Query for pet type
            var typeQuery = from type in petTypes
                            where type.Key == (pet.Text)
                            select type;

            // Query execution for pet type
            foreach (var type in typeQuery)
                lblType.Text = type.Value.ToString();
        }

    }
}
