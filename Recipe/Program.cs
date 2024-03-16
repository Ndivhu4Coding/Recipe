using System;

namespace Recipe
{
    internal class Recipe
    {
        public int NumOfIngredients { get; set; }
        public int NumOfSteps { get; set; }
        public string RecipeName { get; set; }
        public string[] Step;

        public Recipe(int numOfIngredients, int numOfSteps, string recipeName)
        {
            NumOfIngredients = numOfIngredients;
            NumOfSteps = numOfSteps;
            RecipeName = recipeName;
            Step = new string[numOfSteps];
        }

        public void AddSteps()
        {
            for (int i = 0; i < NumOfSteps; i++)
            {
                Console.WriteLine($"Enter step {i + 1}:");
                Step[i] = Console.ReadLine();
            }
        }

        internal class Ingredients
        {
            public string IngredientName;
            public double Quantity;
            public string Measurement;

            public Ingredients(string ingredientName, double quantity, string measurement)
            {
                IngredientName = ingredientName;
                Quantity = quantity;
                Measurement = measurement;
            }

            public void GetIngredientDetails(int numOfIngredients)
            {
                Ingredients[] ingredients = new Ingredients[numOfIngredients];
                for (int i = 0; i < ingredients.Length; i++)
                {
                    Console.WriteLine($"Enter the name of ingredient {i + 1}:");
                    string ingredientName = Console.ReadLine();

                    Console.WriteLine($"Enter the quantity of ingredient {i + 1}:");
                    double quantity = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Enter the unit of measurement for ingredient {i + 1}:");
                    string measurement = Console.ReadLine();

                    ingredients[i] = new Ingredients(ingredientName, quantity, measurement);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the recipe:");
            string recipeName = Console.ReadLine();

            Console.WriteLine("Enter the number of ingredients:");
            int numOfIngredients = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of steps:");
            int numOfSteps = Convert.ToInt32(Console.ReadLine());

            Recipe details = new Recipe(numOfIngredients, numOfSteps, recipeName);
            details.AddSteps();

            Ingredients ingredientsDetails = new Ingredients(null, 0, null);
            ingredientsDetails.GetIngredientDetails(numOfIngredients);
        }
    }
}
