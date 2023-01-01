using System;
using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Chicken Noodle Soup";
        
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
        
        Console.WriteLine("Chicken Noodle Soup");
        Console.WriteLine("Press any key to start.");

        Console.ReadKey();

        Console.WriteLine();
        Console.WriteLine("Ingredients:");
        Console.WriteLine("2 tablespoons butter");
        Console.WriteLine("1 chopped onion");
        Console.WriteLine("2 chopped carrots");
        Console.WriteLine("2 chopped celery sticks");
        Console.WriteLine("Heaped tablespoon minced garlic (4 cloves)");
        Console.WriteLine("2 bay leaves");
        Console.WriteLine("3 sprigs fresh thyme");
        Console.WriteLine("1 pound boneless, skinless chicken thighs (4 thighs)");
        Console.WriteLine("8 cups chicken broth");
        Console.WriteLine("5 ounces egg noodles");
        Console.WriteLine("Salt and pepper");
        Console.WriteLine("1/4 cup fresh parsley, finely chopped");
        Console.WriteLine("Water");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue.");

        Console.ReadKey();

        Console.WriteLine();
        Console.WriteLine("Directions:");
        Console.WriteLine("Melt butter in a large pot or Dutch oven over medium heat. Add the onions, carrots, and celery. Cook, stirring every few minutes until the vegetables begin to soften; 5 to 6 minutes.");
        Console.WriteLine();
        Console.WriteLine("Press any key to start this step.");
        
        Console.ReadKey();

        Thread.Sleep(300000);

        Console.WriteLine("Press any key to move on to the next step.");
        
        Console.ReadKey();

        Console.WriteLine();
        Console.WriteLine("Stir in the garlic, bay leaves, and thyme. Cook, while stirring the garlic around the pan, for about 1 minute.");
        Console.WriteLine();
        Console.WriteLine("Press any key to start this step.");

        Console.ReadKey();

        Thread.Sleep(60000);

        Console.WriteLine("Press any key to move on to the next step.");
        
        Console.ReadKey();

        Console.WriteLine();
        Console.WriteLine("Pour in the chicken stock and bring to a low simmer. Taste the soup then adjust the seasoning with salt and pepper. Depending on the stock used, you might need to add 1 or more teaspoons of salt.");
        Console.WriteLine();
        Console.WriteLine("Press any key to start this step.");

        Console.ReadKey();

        Thread.Sleep(1000);

        Console.WriteLine("Press any key to move on to the next step.");

        Console.ReadKey();

        Console.WriteLine();
        Console.WriteLine("Submerge the chicken thighs into the soup so that the broth covers them. Bring the soup back to a low simmer then partially cover the pot with a lid and cook, stirring a few times until the chicken thighs are cooked through; about 20 minutes.");
        Console.WriteLine();
        Console.WriteLine("Press any key to start this step.");

        Console.ReadKey();

        Thread.Sleep(1200000);

        Console.WriteLine("Press any key to move on to the next step.");

        Console.ReadKey();

        Console.WriteLine();
        Console.WriteLine("If, during this time, the broth seems low, add a splash more stock or a bit of water. Turn the heat to medium-low.");
        Console.WriteLine();
        Console.WriteLine("Press any key to start this step.");

        Console.ReadKey();

        Thread.Sleep(1000);

        Console.WriteLine("Press any key to move on to the next step.");

        Console.ReadKey();

        Console.WriteLine();
        Console.WriteLine("Transfer the cooked chicken to a plate. Stir the noodles into the soup and cook until done, 6 minutes.");
        Console.WriteLine();
        Console.WriteLine("Press any key to start this step.");

        Console.ReadKey();

        Thread.Sleep(360000);

        Console.WriteLine("Press any key to move on to the next step.");

        Console.ReadKey();

        Console.WriteLine();
        Console.WriteLine("While the noodles cook, shred the chicken into strips or dice into cubes. Slide the chicken back into the pot and then taste the soup once more for seasoning. Adjust with more salt and pepper, as needed. Stir in the parsley and serve.");
        Console.WriteLine();
        Console.WriteLine("Done!");
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}