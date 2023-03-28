namespace Gitis1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World! again");
            Console.WriteLine("Commit 4");
            Console.WriteLine("Commit 5");
            Console.WriteLine("Mastercommit !");
            Console.WriteLine("Feature 2 branch gjorde en ändring. Klockan 11:55.");
            Console.WriteLine("Feature 2 branch gjorde en ändring. Klockan 11:56.");
            Console.WriteLine("Feature 2 branch gjorde en ändring. Klockan 11:58.");
        }

        static void SomeWork()
        {
            Console.WriteLine("Lade till lite kod från Feature 2 branchen. ");
        }

        static void SomeWork2()
        {
            Console.WriteLine("Added by MergeBranch 12:10");
            Console.WriteLine("Added by MergeBranch C2");
            Console.WriteLine("Added by MergeBranch C3");
        }
    }
}