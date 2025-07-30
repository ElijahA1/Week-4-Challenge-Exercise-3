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
            int firstIndex = 0;

            for (int i = myString.Length -1 ; i > myString.Length/2; i--) 
            {
                (myString[i], myString[firstIndex]) = (myString[firstIndex], myString[i]);
                firstIndex++;
            }
            Console.WriteLine();
            foreach (char c in myString) {Console.Write(c); }
        }
    }
}