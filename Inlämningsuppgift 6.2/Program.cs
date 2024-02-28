namespace uppgift_6._2
{
    class program
    {
        static void Main(string[] args)
        {
            int StörstaTal = Störst(1, 2);
            Console.WriteLine(StörstaTal);
        }
        static int Störst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }
            else if (tal2 > tal1)
            {
                return tal2;
            }
            else if (tal1 == tal2)
            {
                return tal1;
            }
        }
    }
}