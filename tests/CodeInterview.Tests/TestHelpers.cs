using System;
using System.Collections.Generic;
using System.Text;

namespace CodeInterview.Tests
{
    public static class TestHelpers
    {
        /// <summary>
        /// Asserts that two sequences contain equal elements in the same order.
        /// </summary>
        /// <remarks>Throws an assertion exception if the sequences differ in length or contain unequal
        /// elements at any position.</remarks>
        /// <typeparam name="T">The type of elements in the sequences being compared.</typeparam>
        /// <param name="expected">The sequence containing the expected elements and order.</param>
        /// <param name="actual">The sequence containing the actual elements and order to compare against the expected sequence.</param>
        public static void AssertSequenceEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual)
        {
            CollectionAssert.AreEqual(expected.ToArray(), actual.ToArray());
        }

        /// <summary>
        /// Asserts that two collections contain the same set of elements, regardless of order.
        /// </summary>
        /// <remarks>This assertion treats the collections as sets and ignores element order. The
        /// comparison uses the default equality comparer for type T.</remarks>
        /// <typeparam name="T">The type of elements in the collections being compared.</typeparam>
        /// <param name="expected">The collection containing the expected set of elements.</param>
        /// <param name="actual">The collection containing the actual set of elements to compare against the expected set.</param>
        public static void AssertSetEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual)
        {
            var expectedOrdered = expected.OrderBy(x => x).ToArray();
            var actualOrdered = actual.OrderBy(x => x).ToArray();
            CollectionAssert.AreEqual(expectedOrdered, actualOrdered);
        }

        /// <summary>
        /// Asserts that two collections of integer sets are equal, regardless of the order of elements within each set
        /// or the order of the sets themselves.
        /// </summary>
        /// <remarks>This assertion treats each inner collection as a set, ignoring the order of elements
        /// within sets and the order of sets in the outer collection. The assertion fails if the sets or their contents
        /// do not match exactly.</remarks>
        /// <param name="expected">The collection of expected integer sets to compare against. Each inner collection represents a set whose
        /// elements are expected to match those in the corresponding set of the actual collection.</param>
        /// <param name="actual">The collection of actual integer sets to compare. Each inner collection represents a set whose elements are
        /// compared to those in the expected collection.</param>
        public static void AssertNestedSetEqual(IEnumerable<IEnumerable<int>> expected, IEnumerable<IEnumerable<int>> actual)
        {
            string Normalize(IEnumerable<int> item) => string.Join(",", item.OrderBy(x => x));

            var expectedNormalized = expected.Select(Normalize).OrderBy(x => x).ToArray();
            var actualNormalized = actual.Select(Normalize).OrderBy(x => x).ToArray();

            CollectionAssert.AreEqual(expectedNormalized, actualNormalized);
        }

        /// <summary>
        /// Asserts that two collections of string sets are equal, regardless of the order of elements within each set
        /// or the order of the sets themselves.
        /// </summary>
        /// <remarks>This assertion treats each inner collection as a set, ignoring the order of elements
        /// within sets and the order of sets in the outer collection. The assertion fails if the sets or their contents
        /// do not match exactly.</remarks>
        /// <param name="expected">The collection of expected string sets to compare against. Each inner collection represents a set whose
        /// elements are expected to match those in the corresponding set of the actual collection.</param>
        /// <param name="actual">The collection of actual string sets to compare. Each inner collection represents a set whose elements are
        /// compared to those in the expected collection.</param>
        public static void AssertNestedSetEqual(IEnumerable<IEnumerable<string>> expected, IEnumerable<IEnumerable<string>> actual, string seperatorString = "<<<Sep>>>")
        {
            string Normalize(IEnumerable<string> item) => string.Join(seperatorString, item.OrderBy(x => x));

            var expectedNormalized = expected.Select(Normalize).OrderBy(x => x).ToArray();
            var actualNormalized = actual.Select(Normalize).OrderBy(x => x).ToArray();

            CollectionAssert.AreEqual(expectedNormalized, actualNormalized);
        }
    }
}
