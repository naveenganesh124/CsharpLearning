class Strings
{
    static void Main(string[] args)
    {
        Console.WriteLine("Naveen Ganesh");
        Console.WriteLine("Naveen \nGanesh"); //  `\n` for prin ting the ganesh in nextline
        Console.WriteLine("Naveen\"ganesh"); //  `/`for printing  double quotes 

        //concatition
        String pharse = "naveen ganesh " + "is cool";
        Console.WriteLine(pharse);

        Console.WriteLine(pharse.Length); //for finding the lenght of the string pharse.
        Console.WriteLine(pharse.ToUpper()); // for changing the all the character in the string to upper case;
        Console.WriteLine(pharse.ToLower()); // for changing the all the character in the string to Lower case;


        Console.WriteLine(pharse.Contains("cool")); // to check is that word are there in the pharse or not

        Console.WriteLine(pharse[0]); // to find the character at O th index in pharse string

        Console.WriteLine(pharse.IndexOf("ganesh"));  //it will give you the first occurance of the indexof character which you gave.

        Console.WriteLine(pharse.Substring(7,6)); //substring(index need to start, number of character need to take),
                                                   //it will cut the string from the given string
    }
}
