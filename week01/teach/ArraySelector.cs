public static class ArraySelector
{
    public static void Run()
    {
        var list1 = new[] { 1, 2, 3, 4, 5 };
        var list2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(list1, list2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}

        var list3 = new[] { 'A', 'A', 'A', 'A', 'A'};
        var list4 = new[] { 'B', 'B', 'B', 'B', 'B'};
        select = new[] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2};
        var charResult = ListSelector(list3, list4, select);
        Console.WriteLine("<char[]>{" + string.Join(", ", charResult) + "}"); // <char[]>{A, B, A, B, A, B, A, B, A, B}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        var result = new int[select.Length];
        var list1Index = 0;
        var list2Index = 0;
        for (var i = 0; i < select.Length; i++)
        {
            if (select[i] == 1)
                result[i] = list1[list1Index++];
            else
                result[i] = list2[list2Index++];
        }

        return result;
    }

    private static char[] ListSelector(char[] list1, char[] list2, int[] select)
    {
        var result = new char[select.Length];
        var list1Index = 0;
        var list2Index = 0;
        for (var i = 0; i < select.Length; i++)
        {
            result[i] = select[i] == 1 ? list1[list1Index++] : list2[list2Index++];
        }

        return result;
    }
}