namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 4; //int refactor
            var response = answer < 9 ? $"{answer} is less than nine." : $"{answer} is greater than or equal to nine."; //string refactor with ternary changes.
            Console.WriteLine(response);
        }
    }
}
