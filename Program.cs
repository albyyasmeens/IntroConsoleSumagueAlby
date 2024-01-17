using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("1.Edsger W. Dijkstra:");
        Console.WriteLine("Computer science is no more about computers than astronomy is about telescopes.");

        Console.Write("2.Alan Kay:");
        Console.WriteLine("The best way to predict the future is to invent it.");

        Console.Write("3.Grace Hopper:");
        Console.WriteLine("The most damaging phrase in the language is, We’ve always done it this way.");

        Console.Write("4.Terry Pratchett(Discworld):");
        Console.WriteLine("It's not worth doing something unless someone, somewhere, would much rather you weren't doing it.");
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}