using CodeWars;

namespace TestProject
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [DataRow(-1L, 1L)]
        [DataRow(0L, 0L)]
        [DataRow(10L, 1L)]
        [DataRow(16L, 7L)]
        [DataRow(942L, 6L)]
        [DataRow(999999999999L, 9L)]
        [DataRow(493193L, 2L)]
        public void TestDigitalRoot(long n, long expected)
        {
            int actual = MathematicalOperations.DigitalRoot(n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(-1, false)]
        [DataRow(0, true)]
        [DataRow(3, false)]
        [DataRow(4, true)]
        [DataRow(25, true)]
        public void TestIsSquare(int n, bool expected)
        {
            bool result = MathematicalOperations.IsSquare(n);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(new int[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }, 5)]
        [DataRow(new int[] { 7 }, 7)]
        [DataRow(new int[] { 1, 1, 2 }, 2)]
        [DataRow(new int[] { 0, 1, 0, 1, 0 }, 0)]
        [DataRow(new int[] { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 }, 4)]
        public void TestFindIt(int[] numbers, int expected)
        {
            int result = CollectionsOperations.Find_it(numbers);
            Assert.IsTrue(result == expected);
        }

        [TestMethod]
        [DataRow("din", "(((")]
        [DataRow("recede", "()()()")]
        [DataRow("Success", ")())())")]
        [DataRow("(( @", "))((")]
        public void TestDuplicateEncode(string w, string expected)
        {
            string result = CollectionsOperations.DuplicateEncode(w);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(1, 0)]
        [DataRow(12, 4)]
        [DataRow(16, 4)]
        [DataRow(71, 9)]
        public void TestShortestStepsToNum(int n, int expected)
        {
            int result = MathematicalOperations.ShortestStepsToNum(n);
            Assert.IsTrue(result == expected);
        }

        [TestMethod]
        [DataRow("iiisdoso", new int[] {8, 64 })]
        [DataRow("iiisdosodddddiso", new int[] { 8, 64, 3600 })]
        public void TestIntepreteInstructions(string w, int[] expected)
        {
            int[] actual = MathematicalOperations.IntepreteInstructions(w);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}