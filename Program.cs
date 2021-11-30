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
            int[] numArray1;
            numArray1 = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            foreach (int num in numArray1) {
                
                Console.WriteLine(numArray1[num]);
            }


         //--------------------------Array 2-------------------------------
            string[] nameArray2 = new string[] { "Tim", "Martin", "Nikki", "Sara" };
            foreach (string name in nameArray2) {
                
                Console.WriteLine($"{name}");
            }
        

         //--------------------------Array 3----------------------------------
            int[] numArray3;
            numArray3 = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            for (int i=0; i< numArray3.Length; i++) {
                if (i%2 == 0) {
                    Console.WriteLine("True");
                }
                else {
                    Console.WriteLine("False");
                }
            }
        



        


        //---------------------------------------------LIST OF FLAVORS----------------------------------------
            //C1 - Instantiate List of Ice Cream Flavors named flavors
            List<string> flavors = new List<string>();

            flavors.Add("Mint Chocolate Chip");
            flavors.Add("Java Mocha Chip");
            flavors.Add ("Rocky Road");
            flavors.Add("French Vanilla");
            flavors.Add ("Banana Split");


            //C2 - Output length (List_name.count) of flavors List (total count of ice cream flavors)
            Console.WriteLine($"Currently serving {flavors.Count} ice cream flavors.");


            //C3 - Output third flavor in List, then remove value
            Console.WriteLine($"The third flavor in the list is {flavors[2]}.");
            flavors.Remove("Rocky Road");


            //C4 - Output length (List_name.count) of flavors List (total count should be 1 less now)
            Console.WriteLine($"Currently serving {flavors.Count} ice cream flavors.");








        //---------------------------------------------USER INFO DICTIONARY----------------------------------------
            //C1 - Create Dictionary to store string keys and string values
            Dictionary<string, string> userInfo = new Dictionary<string, string>();


            //C2 - Add Key/Value Pairs to Dictionary (Keys - names, Values - ice cream flavors)
            userInfo.Add("Tim", "Java Mocha Chip");
            userInfo.Add("Martin", "French Vanilla");
            userInfo.Add("Nikki", "Mint Chocolate Chip");
            userInfo.Add("Sara", "Banana Split");


            //C3 - Loop through dictionary and print out each user's name and their associated ice cream flavor
            foreach (var entry in userInfo) {
                
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}