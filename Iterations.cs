using System;
using System.Collections.Generic;
using System.Linq;
using DotnetIteration.Models;

namespace DotnetIteration
{

    public static class Iteration
    {
        /*
           Welcome to Interation
           Down below you will find instructions for code to write.
           As you write and save your code, you can look in your terminal where you
           ran `dotnet watch test` to see if your code is working. The tests continuously check
           your work each time you save. If a test is failing you have not yet completed that method
           Once you finish a method and have it correct, the test will tell you how
           the next method is working.
        */


        //  
        // 1) Complete the method named `yelling` that takes an list of
        //    words as an argument and returns a new list with all
        //    the words forced to uppercase.
        //
        public static IEnumerable<string> Yelling(List<string> words)
        { 
            var yelled = words.Select(word => word.ToUpper());
            return yelled;
        }


        // 
        // 2) Complete the method named `Double` that takes an list of
        //    numbers as an argument and returns a new list with all
        //    the numbers multiplied by 2.
        // 
        public static IEnumerable<int> Double(List<int> numbers)
        {
            var doubled = numbers.Select(number => number*2);
            return doubled;
        }


        // 
        // 3) Complete the method `StringyIndexes` that takes an list of
        //    strings as an argument and returns a new list with each
        //    string suffixed with " is at index X" where X is the index
        //    of the element.
        // 
        public static IEnumerable<string> StringyIndexes(List<string> data)
        {
            var indexInformation = data.Select((dataItem, indexNumber) =>  $"{dataItem} is at index {indexNumber}");
            return indexInformation;
        }


        // 
        // 4) Complete the method OnlyTheEvenSurvive that accepts an list of
        //    numbers and returns only the elements that are even.
        // 
        public static IEnumerable<int> OnlyTheEvenSurvive(List<int> data)
        {
            

            //P: Taking the list of numbers and returning a new list of numbers that are even. 
            // How to identify if a number is even.
            //
            //E: List :    { 42, 50, 100, 5, -43, 17, 44 }
            //   New List: { 42, 50, 100, 44 }
            //
            //D: A list of int called Data : List<int> data
            //   A list of int called newData: var = newData
            //   % to find the remainder. 4 % 2 = 0
            //
            //A: 
            //  1. Take the list of numbers in data
            var theSurvivingEvens = data.Where((dataItem) => dataItem % 2 == 0);
            //  2. Select a the data item where the int % 2 = 0
            return theSurvivingEvens;
            //  3. return theSurvivingEvens
        }


        // 
        // 5) Complete the method OnlyTheEvenIndexedSurvive that accepts an
        //    list of numbers and returns only the elements at indexes that
        //    are even.
        // 
        public static IEnumerable<int> OnlyTheEvenIndexedSurvive(List<int> data)
        {
            //P: Taking the list of numbers and returning a new list of numbers that are even. 
            // How to identify if a number is even.
            //
            //E: List :    { 42, 50, 100, 5, -43, 17, 44 }
            //   New List: { 42, 50, 100, 44 }
            //
            //D: A list of int called Data : List<int> data
            //   A list of int called newData: var = newData
            //   % to find the remainder. 4 % 2 = 0
            //
            //A: 
            //  1. Take the list of numbers in data
            var theSurvivingEvenIndexes = data.Where((dataItem, index) => index % 2 == 0);
            //  2. Select a the data item where the int % 2 = 0
            return theSurvivingEvenIndexes;
            //  3. return theSurvivingEvens
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
            //P: Taking the list of objects and returning a new list of strings with the name of the movie of that year.
            // How to identify if a number is even.
            //
            //E: List(Object) :     name: "Get Out",
            //                      year: "2017",
            //                      score: 99
            //   New List(string):  name: Get Out
            //
            //D: A list of objects called data : List<Movie> data
            //   A list of strings called newData: List<string> newData
            //   An integer: Movie.Year
            //
            //A: 
            //  1. Take the list of numbers in data
            return data.Where(movie => movie.Year == year && movie.Score > 90).Select(movie => movie.Name);
            //  2. Select a the data item where the Year = year
            //  3. Return the Name of that dataItem
          
            //  3. return theSurvivingEvens
        }


        // 
        // 7) Complete the method EveryoneIsOdd that accepts an list of
        //    numbers and returns true if every element of the list is odd.
        // 
        public static bool EveryoneIsOdd(List<int> data)
        {
            return data.All(number => number%2 == 1); 
        }


        // 
        // 8) Complete the method FindTheNeedle that accepts an list of
        //    strings and returns the one string that contains the word
        //    `needle`.
        // 
        public static string FindTheNeedle(List<string> data)
        {

            var findTheNeedle =  data.Single(dataItem => dataItem.Contains("needle"));
            return findTheNeedle;
           

            //P: Taking the list of strings and returning the one that includes "needle"
            // 
            //
            //E: Input List(string) :  "one", "time", "there was a needle at", "the market"
            //   Output (string): "there was a needle at"                   
            //                      
            //   
            //
            //D: A list of strings called data : "one", "time", "there was a needle at", "the market"
            //   return the string: "there was a needle at"
            //   
            //
            //A: 
            //  1. First take the list of strings called 'data' 
            //  2. Find the item in data that includes the string "needle"
            //  3. return 
            //  4. 
        }


        // 
        // 9) Complete the method FindTheNeedleIndex that accepts an list of
        //    strings and returns the index of the string that contains
        //    the word `needle` inside.
        // 
        public static int FindTheNeedleIndex(List<string> data)
        {
            //P: Taking the list of strings and returning the one that includes "needle." Then find the index of 
            // 
            //
            //E: Input List(string) :  "one", "time", "there was a needle at", "the market"
            //   Output (string): "there was a needle at"                   
            //                      
            //   
            //
            //D: A list of strings called data : "one", "time", "there was a needle at", "the market"
            //   return the string: "there was a needle at"
            //   
            //
            //A: 
            //  1. First take the list of strings called 'data' 
            return data.FindIndex(dataItem => dataItem.Contains("needle"));
            //  2. Find the item in data that includes the string "needle"
            //  3. return 
            //  4. 
        }


        // 
        // 10) Complete the method SomeoneToLove that accepts an list of
        //     strings and returns true if at least one string is exactly
        //     four characters long.
        // 
        public static bool SomeoneToLove(List<string> data)
        {
            return data.Any(dataItem => dataItem.Count() == 4);
        }
    }
}