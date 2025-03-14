class Array
{
    static void Main(string[] args)
    {
        int[] numsArray = { 2, 4, 6, 7, 3, 4, 5 }; // declaring a array with a elements

        int[] nums2 = new int[10];  //declaring a array with the size and without a elements

        nums2[0] = 1;
        nums2[1] = 2;   //assigning values to the array

        string[] stringArray = new string[10];

        stringArray[2] = "naveen";

        Console.WriteLine(numsArray[3]);
        Console.WriteLine(nums2[1]);
        Console.WriteLine(stringArray[2]);
    }
}
