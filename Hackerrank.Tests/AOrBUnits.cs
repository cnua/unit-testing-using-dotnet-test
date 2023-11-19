
using Hackerrank;
#region private::Tests
/*
3 8 2B 9F 58 5 B9 40 5A 2 91 BE A8

"3 8 2B 9F 58 5 B9 40 5A 2 91 BE A8"
*/
namespace Hackerrank.Tests;
public class AorBUnitTest
{
    const string _path=@"../docs/input01.txt";
    [Fact]
    static void AorBBigIntTxtLoader()
    {
        //Arrange
        // string str = "3 AOrB8 2B 9F 58 5 B9 40 5A 2 91 BE A8";
        
        var str = File.OpenText(_path).ReadToEnd();
        int k;
        string a, b, c;
        //Act
        var arr = str.Split('\n');
        int q = Convert.ToInt32(arr[0]);

        for (int qItr = 1; qItr <= arr.Length - 1; qItr += 4)
        {
            k = Convert.ToInt32(arr[qItr]);//arr.Length.Dump();
            a = arr[qItr + 1];
            b = arr[qItr + 2];
            c = arr[qItr + 3];
            Hackerrank.AOrB.aOrB(k, a, b, c);
        }
        //Assert
        Assert.True(1 + 1 == 2);
    }
    [Fact]

    void TestRunPossibleSubSets()
    {
        string actual = AOrB.PossibleSubsets(new char[]{'a','b','c'},3);
        Console.WriteLine(actual);
        Assert.True(actual.Length == 8);
    }
}
#endregion