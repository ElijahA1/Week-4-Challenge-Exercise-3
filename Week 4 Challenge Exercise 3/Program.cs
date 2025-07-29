namespace Week_4_Challenge_Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] myString = [ 'h', 'e', 'l', 'l', 'o' ];
            reverseString(myString);
        }
        static void reverseString(char[] myString) 
        {
            int counter = 0;

            for (int i = myString.Length -1 ; i > myString.Length/2; i--) 
            {
                char first = myString[counter];
                char last = myString[i];
                myString[i] = first;
                myString[counter] = last;

                counter++;
            }
            Console.WriteLine();
            foreach (char c in myString) {Console.Write(c); }
        }
    }
}