public class CombinedFilter
{
    public static int[] combinedFilter(int[] xs)
    {
        FizzBuzzFilter.fizzBuzzReplace(xs);
        return DiffFilter.diffs(xs);
    }
}
