using System;
using System.Collections.Generic;


namespace collections_practice
{
    class Program
    {
        static void Main(string[] args)
        {
        // ---------------------------------------THREE BASIC ARRAYS----------------------------------------------
        
        //---------------------------Array 1-------------------------------
            int[] numbers = new int[10];
            for (var i = 0; i<numbers.Length; i++) {
                
                Console.WriteLine(numbers[i] = i);
            }


         //--------------------------Array 2-------------------------------
            string[] names = new string[] 
            { 
                "Tim", "Martin", "Nikki", "Sara" 
            };

            foreach (string name in names) {
                
                Console.WriteLine($"{name}");
            }
        

         //--------------------------Array 3----------------------------------
            bool[] boolyz = new bool[10];
            for (int i = 0; i < boolyz.Length; i++) {
                if (i%2 == 0) {
                    Console.WriteLine("True");
                }
                else {
                    Console.WriteLine("False");
                }
            }
        



        


        //---------------------------------------------LIST OF FLAVORS----------------------------------------
            //C1 - Instantiate List of Ice Cream Flavors named flavors
            List<string> flavors = new List<string>()
            {
                "Mint Chocolate Chip",
                "Java Mocha Chip", 
                "Rocky Road", 
                "French Vanilla", 
                "Banana Split"
            };


            //C2 - Output length (List_name.count) of flavors List (total count of ice cream flavors)
            Console.WriteLine($"Currently serving {flavors.Count} ice cream flavors.");


            //C3 - Output third flavor in List, then remove value
            Console.WriteLine($"The third flavor in the list is {flavors[2]}.");
            flavors.RemoveAt(2);


            //C4 - Output length (List_name.count) of flavors List (total count should be 1 less now)
            Console.WriteLine($"Currently serving {flavors.Count} ice cream flavors.");








        //---------------------------------------------USER INFO DICTIONARY----------------------------------------
            //C1 - Create Dictionary to store string keys and string values
            Dictionary<string, string> userInfo = new Dictionary<string, string>();


            //C2 - Add Key/Value Pairs to Dictionary (Keys - names, Values - ice cream flavors)
            foreach(var name in names)
                userInfo.Add(name, null);

            // For each name key, select a random flavor from the flavor list above and store it as the value
            Random rand = new Random();
            foreach(var name in names)
                userInfo[name] = (flavors[rand.Next(flavors.Count)]);

            // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach(var kp in userInfo)
                Console.WriteLine($"{kp.Key}: {kp.Value}");
        }
    }
}