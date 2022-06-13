namespace CSTutorial {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(
                "________________________________________Working with strings_______________________________________________");
            string? name = null;
            do {
                Console.Write("Enter a name: ");
                name = Console.ReadLine();
            } while (name.Equals(""));

            name = char.ToUpper(name[0]) + name.Substring(1);

            string? city = null;

            do {
                Console.Write("Enter a city: ");
                city = Console.ReadLine();
            } while (city.Equals(""));

            city = char.ToUpper(city[0]) + city.Substring(1);


            var age = 0;

            do {
                Console.Write("Enter your age: ");
                age = Convert.ToInt32(Console.ReadLine());
            } while (age < 1);

            Console.WriteLine();
            Console.WriteLine("Hello " + name + " you\'re " + age + " and you are from " + city);

            // Check if a String contains a subString
            Console.WriteLine();
            Console.Write("Enter a text to check if you name contains it: ");
            var check = Console.ReadLine();
            if (name.Contains(check)) {
                Console.WriteLine(name + " does contain \'" + check + "\' it starts at index number " +
                                  name.IndexOf(check));
            }
            else {
                Console.WriteLine(name + " does not contain \'" + check + "\'");
            }

            Console.WriteLine("");
            Console.WriteLine(
                "________________________________________Working with numbers_______________________________________________");

            Console.WriteLine(" 5 / 2 = " + 5 / 2);
            Console.WriteLine(" 5 / 2.0 = " + 5 / 2.0);
            Console.WriteLine(" 5.0 / 2.0 = " + 5.0 / 2);

            Console.WriteLine("");
            Console.Write("Enter a number: ");
            var num = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("printing num++: " + num++ + " after num++: " + num);
            Console.WriteLine("printing ++num: " + ++num + " after ++num: " + num);

            Console.WriteLine("Math.Abs(-20) = " + Math.Abs(-20));
            Console.WriteLine("Math.Pow(3, 2) = " + Math.Pow(3, 2));
            Console.WriteLine("Math.Sqrt(16) = " + Math.Sqrt(16));
            Console.WriteLine("Math.Max(20, 21) = " + Math.Max(20, 21));
            Console.WriteLine("Math.Main(20, 21) = " + Math.Min(20, 21));
            Console.WriteLine();
            Console.WriteLine("Math.Round(4.3) = " + Math.Round(4.3));
            Console.WriteLine("Math.Round(4.7) = " + Math.Round(4.7));

            Console.WriteLine(
                "________________________________________Making a calculator_______________________________________________");

            double num1, num2, result = 0;
            string op;

            Console.Write("Enter a Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            do {
                Console.Write("Enter an operator (+,-,/,*,pow,min,max): ");
                op = Console.ReadLine();
            } while (!(op.Equals("+") || op.Equals("-") || op.Equals("*") || op.Equals("/") || op.Equals("pow") ||
                       op.Equals("min") || op.Equals("max")));

            switch (op) {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "pow":
                    result = Math.Pow(num1, num2);
                    break;
                case "min":
                    result = Math.Min(num1, num2);
                    break;
                case "max":
                    result = Math.Max(num1, num2);
                    break;
            }

            Console.WriteLine(num1 + " " + op + " " + num2 + " = " + result);

            Console.WriteLine(
                "________________________________________Working with 2D arrays_______________________________________________");
            Console.WriteLine();

            displaying2DArray(new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } });
            
            Console.WriteLine(
                "________________________________________Working with objects and classes_______________________________________________");
            Console.WriteLine();

            Console.WriteLine("number of animals: " + Animal.animalCount);
            Animal animal = new Animal();
            Console.WriteLine("number of animals after creating one: " + Animal.animalCount);
            Dog dog = new Dog();
            Console.WriteLine("number of animals after creating a dog: " + Animal.animalCount);
            
            animal.makeSound();
            dog.makeSound();
            
            Console.WriteLine();
            
            animal.sleep();
            dog.sleep();

            // ReadLine is used at the end to prevent the program to close at the end once the code execution is finished in Visual studio
            // Console.ReadLine();
        }

        static void displaying2DArray(int[,] numbers) {
            for (int i = 0; i < numbers.GetLength(0); i++) {
                for (int j = 0; j < numbers.GetLength(1); j++) {
                    Console.Write("Element({0},{1})={2} \t", i, j, numbers[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}