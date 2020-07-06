# 02-02 C#\_Iteration

### My solutions:

```csharp

// 1) Complete the method named `yelling` that takes an list of
        //    words as an argument and returns a new list with all
        //    the words forced to uppercase.
        //
        public static IEnumerable<string> Yelling(List<string> words)
        {
            //P: Takes a list of strings called 'words'
            //   Return a new list where those strings are uppercased.
            //
            //
            //E List<string> words = {"hello", "my", "name", "is", "kento"}
            //  List<string> newWords = {"HELLO", "MY", "NAME", "IS", "KENTO"}
            //
            //
            //D Input: List<string> words
            //  Output: List<string> words
            //  .Select .Upper
            //
            //A
            //  1. Take the list<string> words
            //  2. And select all of the strings inside
            //  3. And Uppercase them
            //  4. To finally store them in another list
            return words.Select(word => word.ToUpper());
        }


        //
        // 2) Complete the method named `Double` that takes an list of
        //    numbers as an argument and returns a new list with all
        //    the numbers multiplied by 2.
        //
        public static IEnumerable<int> Double(List<int> numbers)
        {
            //P Take a list of numbers
            //  and multiply each numbers in the list by 2. Then store them in another list.
            //
            //
            //E {1, 2, 3, 4, 5, 6, 7} => {2, 4, 6, 8, 10, 12, 14}
            //
            //
            //D Input: List<int> numbers
            //  Output: List<int> new numbers
            //  .Select
            //  words * 2
            //A 1. Take the list<int> numbers
            //  2. And select all of the elements inside
            //  3. Multiply them by 2
            //  4. Then finally add them to the list
            //
            return numbers.Select(number => number * 2);
        }


        //
        // 3) Complete the method `StringyIndexes` that takes an list of
        //    strings as an argument and returns a new list with each
        //    string suffixed with " is at index X" where X is the index
        //    of the element.
        //
        public static IEnumerable<string> StringyIndexes(List<string> data)
        {
            //P Take the list of strings called data, identify the index of each item
            // return a new list with each items in the string by identifying their index
            // in the format "X is at index Y"
            //
            //E {"hello", "my", "name", "is", "kento"}
            //  "Hello is at index 0", "my is at index 1", "Name is at index 2"
            //
            //
            //D Input: List<string> data
            //  Output: List<string> newData
            //  .Select
            //  $"{dataItem} is at index {indexSelected}
            //A 1. Take the list<string> data
            //  2. select all of the elements inside
            //  3. identify the index of each element
            //  4. return the string in the format: $"{dataItem} is at index {indexSelected}
            //
            return data.Select((dataItem, selectedIndex) => $"{dataItem} is at index {selectedIndex}");
        }


        //
        // 4) Complete the method OnlyTheEvenSurvive that accepts an list of
        //    numbers and returns only the elements that are even.
        //
        public static IEnumerable<int> OnlyTheEvenSurvive(List<int> data)
        {
            //P Take the list of integers called data and identify elements in the list that are even.
            //  Return a list of the numbers that are even.
            //
            //
            //E Before {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}
            //  After {2, 4, 6, 8, 10, 12}
            //
            //
            //D Input List<int> data
            //  Output List<int> newData
            //  data % 2 = 0
            //  .Where
            //A 1. Take the list of numbers
            //  2. Select all of the elements inside
            //  3. Identify elements where the remainder of 2 will equal 0
            //  4. return the list of new integers as a list
            //
            return data.Where(dataItem => dataItem % 2 == 0);
        }


        //
        // 5) Complete the method OnlyTheEvenIndexedSurvive that accepts an
        //    list of numbers and returns only the elements at indexes that
        //    are even.
        //
        public static IEnumerable<int> OnlyTheEvenIndexedSurvive(List<int> data)
        {
            //P Take the list of integers and return elements where its indexes are even.
            //  The remainder of the index should equal to 0.
            //
            //
            //E Before {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}
            //  After { 1, 3, 5, 7, 9, 11}
            //
            //
            //D input List<int> data
            //  output List<int> data
            //  .Where
            //  index % 2 = 0
            //A 1. Take the list<int> data
            //  2. Identify its index
            //  3. Then find the index numbers where its remainder of 2 will equal to 0
            //  4. return a new list that have the indexes where it's remainder of 2 equal to 0.
            //
            return data.Where((dataItem, index) => index % 2 == 0);
        }


        //
        // 6) Complete the method BestMoviesOfTheYear that accepts an list of
        //    movie objects AND a year and returns the names of movies that are
        //    from that year AND have a score more than 90.
        //
        // A movie object looks like this:
        //
        // {
        //   name: "Get Out",
        //   year: "2017",
        //   score: 99
        // }
        //
        public static IEnumerable<string> BestMovieOfTheYear(List<Movie> data, int year)
        {
           //P Take the list of Movies and its year and find the names of the movies of that year who's
            // score is more than 90.
            //
            //
            //E Movie: name - Get Out, year: 2017, score: 99;
            //  Movie: name - Gravity, year: 2017, score 92;
            //
            //
            //D Input: List<Movie> data, int year
            //  Output: List<string> movie.Name, List<string> movie.Year
            //  movie.Score > 90
            //  .Where .Select
            //A 1. Take the list of movies
            //  2. Find the movie of the year given
            //  3. and also Find the movie who's score is over 90
            //  4. return the name of the movie
            //
            return data.Where(movie => movie.Year == year && movie.Score > 90).Select(movie => movie.Name);
        }


        //
        // 7) Complete the method EveryoneIsOdd that accepts an list of
        //    numbers and returns true if every element of the list is odd.
        //
        public static bool EveryoneIsOdd(List<int> data)
        {
            //P Take the list of numbers called data, identify if the elements in the list
            // is odd, if they are return true
            //
            //
            //E True = {1, 3, 5, 7, 9}
            //  False = {1, 3, 4, 5, 7, 9}
            //
            //
            //D input: List<int> data
            //  output: bool EveryoneIsOdd = true
            //  if the element's remainder of 2 == 1
            //  .All
            //A 1. Take the list of numbers
            //  2. identify if they are odd by finding the remainder of 2.
            //  3. If the remainder = 1, return a bool == true
            //
            return data.All(dataItem => dataItem % 2 == 1);
        }


        //
        // 8) Complete the method FindTheNeedle that accepts an list of
        //    strings and returns the one string that contains the word
        //    `needle`.
        //
        public static string FindTheNeedle(List<string> data)
        {
            //P Take a list of string called data, find the element that includes the word "needle"
            // Return the element where that word is included
            //
            //
            //E Before { "one", "time", "there was a needle at", "the market" }
            //  After {"There was a needle at"}
            //
            //
            //D input: List <string> data
            //  output: string that includes "needle"
            //  .contain .Where
            //
            //A 1. Take the list of strings,
            //  2. Find the element that contains the word "needle"
            //  3. return that element.
            //
            return data.Single(dataItem => dataItem.Contains("needle"));
        }


        //
        // 9) Complete the method FindTheNeedleIndex that accepts an list of
        //    strings and returns the index of the string that contains
        //    the word `needle` inside.
        //
        public static int FindTheNeedleIndex(List<string> data)
        {
            //P Take the list of strings, find its index where the word "needle" exists.
            //return the index of that string.
            //
            //
            //E "this", "is alot", "of Information", "but thank god", "I found the needle",
            //
            //
            //
            //D Input: List<string> data
            //  Output: List<string> data[index], int index
            //  .contains .FindIndex
            //
            //A 1. Take the list called data
            //  2. find the element in the list that includes the string "needle"
            //  3. Find the index number of that particular string we pulled up
            //  4. return the index number
            //
            return data.FindIndex(dataItem => dataItem.Contains("needle"));
        }


        //
        // 10) Complete the method SomeoneToLove that accepts an list of
        //     strings and returns true if at least one string is exactly
        //     four characters long.
        //
        public static bool SomeoneToLove(List<string> data)
        {
            //P Take the list of string called data, identify if at least one string
            // is exactly 4 characters long. Return boolean.
            //
            //
            //E Before {"ohooo", "ho", "hohoh, "ohohoo", "ohoo"}
            //  After {"ohoo"} = .Length = 4
            //
            //
            //D Input: List<string> data
            //  Output: bool = true
            //  .Any .Length()
            //
            //A 1. Take the list of string
            //  2. identify if any have exactly 4 characters long
            //  3. return bool
            //
            return data.Any(canAnybodyFindMeSomebodyToLoveByFreddieMercury => canAnybodyFindMeSomebodyToLoveByFreddieMercury.Length == 4);
        }

```

# Assignment Overview

Learning programming takes practice and the best practice is repetition. This
exercise will allow you time to work on the basics of .NET and how to apply that
logic to solving problems.

## Objectives

After completing this assignment, you should be able to:

- Demonstrate understanding of iteration/enumeration

## Instructions

1. Fork [this repository](https://github.com/suncoast-devs/net-iteration) to
   your own account.
2. Change into your projects directory:
3. Clone your repository:
   `git clone https://github.com/YOUR_NAME_HERE/net-iteration`
4. Change into your project's directory: `cd net-iteration`
5. Install the dependencies: `dotnet restore`
6. Open in your editor: `code .`
7. Start the test runner: `dotnet watch test`
8. Open `Iterations.cs` and work on functions until the test passes. Once you
   are done with a test you can move to the next one by removing the
   `(Skip = "Remove to run test")` from the `Fact` attribute. There are a total
   of 10 questions.
9. Commit and push your work to GitHub.
10. Turn in the URL to your GitHub repo.

## Explorer Mode

- All tests passing
- No linter warnings
- Turn in the homework using the URL to your repository on GitHub.

## Additional Resources

Reference the documentation to find what kind of helpful functions
might already be in C#.

- [String Functions](https://www.c-sharpcorner.com/blogs/some-string-functions-of-c-sharp).
- [Official LINQ](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/)
