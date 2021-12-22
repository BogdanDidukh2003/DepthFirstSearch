using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace DepthFirstSearchTests
{
    public class Tests
    {
        private static Graph<int>[] DepthFirstSearchGraphs =
        {
            new Graph<int>(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, new[]
            {
                Tuple.Create(1, 2), Tuple.Create(1, 3),
                Tuple.Create(2, 4), Tuple.Create(3, 5), Tuple.Create(3, 6),
                Tuple.Create(4, 7), Tuple.Create(5, 7), Tuple.Create(5, 8),
                Tuple.Create(5, 6), Tuple.Create(8, 9), Tuple.Create(9, 10)
            })
        };

        private static List<int>[] DepthFirstSearchResultLists =
        {
            new List<int>(new [] { 1, 3, 6, 5, 8, 9, 10, 7, 4, 2})
        };

        [Test]
        public void Test1([ValueSource(nameof(DepthFirstSearchGraphs))] Graph<int> graph, 
                          [ValueSource(nameof(DepthFirstSearchResultLists))] List<int> expectedList)
        {
            var algorithms = new Algorithms();

            List<int> result = algorithms.DFS(graph, 1);
            Assert.AreEqual(expectedList, result);
        }
    }
}