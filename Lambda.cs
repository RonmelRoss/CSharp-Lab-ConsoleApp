using System;

namespace Lambda
{
    class Lambdas
    {
        public void Run() {
            Console.WriteLine("Hello Lambda!");

            #region LAMBDA EXPRESSION

            Func<int, int> square = x => x * x;
            Console.WriteLine(square(Convert.ToInt32("3")));
            Console.WriteLine(square(5));

            // Use implicitly-typed lambda expression.
            // ... Assign it to a Func instance.
            Func<int, int> func1 = x => x + 1;

            // Use lambda expression with statement body.
            Func<int, int> func2 = x => { return x + 1; };

            // Use formal parameters with expression body.
            Func<int, int> func3 = (int x) => x + 1;

            // Use parameters with a statement body.
            Func<int, int> func4 = (int x) => { return x + 1; };

            // Use multiple parameters.
            Func<int, int, int> func5 = (x, y) => x * y;

            // Use no parameters in a lambda expression.
            //Receives no parameters and returns no value.
            //It matches void methods with no parameters
            Action func6 = () => Console.WriteLine();

            // Use delegate method expression.
            //Delegate keyword denotes anonymous function
            //Similar to func4
            Func<int, int> func7 = delegate (int x) { return x + 1; };

            // Use delegate expression with no parameter list.
            Func<int> func8 = delegate { return 1 + 1; };

            // Invoke each of the lambda expressions and delegates we created.
            // ... The methods above are executed.
            //Console.WriteLine(func1.Invoke(1)+"\n");
            //Console.WriteLine(func2.Invoke(1));
            //Console.WriteLine(func3.Invoke(1));
            Console.WriteLine("Value of func4: " + func4.Invoke(1));
            //Console.WriteLine(func5.Invoke(2, 2));
            //func6.Invoke();
            Console.WriteLine("Value of func7: " + func7.Invoke(1));
            //Console.WriteLine(func8.Invoke());
            Console.WriteLine("This value uses lambda expression: "+func1(1));
            #endregion

            #region PREDICATE
            //a function type that always returns a bool value
            Predicate<int> predicate = value => value == 5;
            Console.WriteLine(predicate.Invoke(4));
            Console.WriteLine(predicate(3));
            Console.WriteLine(predicate.Invoke(5));
            Console.WriteLine(predicate(5));
            #endregion

            #region LAMBDA ARRAYS
            Console.WriteLine("\n\nThis block returns data from Lambda arrays:");
            //Create an array of lambdas
            var lookup = new Func<int, int>[]
            {
                a => a+100,
                a => a+200,
                a => a+300
            };

            //Call the lambdas in the lookup table and print the result
            for (int i = 0; i < 10; i++)
            {
                int result = lookup[i % 3](i);
                Console.WriteLine(result);
            }
            #endregion
        }
    }
}
