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
            int lastIndex = myString.Length - 1;
            //int firstIndex = 0;

            for (int i = 0 ; i < myString.Length/2; i++) 
            {
                (myString[i], myString[lastIndex]) = (myString[lastIndex], myString[i]);
                lastIndex--;
            }
            Console.WriteLine();
            foreach (char c in myString) {Console.Write(c); }
        }
    }
}