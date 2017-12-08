using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListImplementation;

namespace LinkedListTests
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestAddFirstMethod()
    {
      var node = new LinkedList<int>();
      node.AddFirst(6);
      node.AddFirst(5);
      Assert.AreEqual(2, node.Count);
      Assert.AreEqual(5, node.Head.Value);
      Assert.AreEqual(6, node.Tail.Value);
    }

    [TestMethod]

    public void TestAddLastMethod()
    {
      var node = new LinkedList<int>();
      node.AddLast(5);
      node.AddLast(6);
      Assert.AreEqual(2, node.Count);
      Assert.AreEqual(5, node.Head.Value);
      Assert.AreEqual(6, node.Tail.Value);

    }

    [TestMethod]
    public void RemoveLastNodeWhenThereIsOnlyOneNode()
    {
      var node = new LinkedList<int>();
      node.AddFirst(5);
      node.RemoveLast();
      Assert.AreEqual(null, node.Head);
      Assert.AreEqual(null, node.Tail);
      Assert.AreEqual(0, node.Count);
    }

    [TestMethod]
    public void RemoveLastNodeWhenThereAreMultiples()
    {
      var node = new LinkedList<int>();
      node.AddFirst(1);
      node.AddLast(2);
      node.AddLast(3);
      node.AddLast(4);
      node.AddLast(5);

      node.RemoveLast();
      Assert.AreEqual(node.Tail.Value, 4);
      Assert.AreEqual(node.Count, 4);
    }

    [TestMethod]
    public void RemoveFirstWhenAreMultipleNodes()
    {
      var node = new LinkedList<int>();
      node.AddFirst(1);
      node.AddLast(2);
      node.AddLast(3);
      node.AddLast(4);
      node.AddLast(5);

      node.RemoveFirst();

      Assert.AreEqual(node.Count, 4);
      Assert.AreEqual(node.Head.Value, 2);
      Assert.AreEqual(node.Tail.Value, 5);
    }

    [TestMethod]
    public void RemoveFirstWhenThereisOnlyOneNode()
    {
      var node = new LinkedList<int>();
      node.AddFirst(5);

      node.RemoveFirst();
      Assert.AreEqual(null, node.Head);
      Assert.AreEqual(null, node.Tail);
      Assert.AreEqual(0, node.Count);

      var node1 = new LinkedList<int>();
      node1.AddLast(5);

      node1.RemoveFirst();
      Assert.AreEqual(null, node1.Head);
      Assert.AreEqual(null, node1.Tail);
      Assert.AreEqual(0, node1.Count);

    }

    [TestMethod]
    public void TestContainsMethod()
    {
      var node = new LinkedList<int>();
      node.Add(1);
      node.Add(78);
      node.Add(11);
      node.Add(19);

      Assert.AreEqual(true, node.Contains(11));
      Assert.AreEqual(false, node.Contains(21));

    }

    [TestMethod]
    public void RemoveMiddleElementInList()
    {
      var node = new LinkedList<int>();
      node.AddFirst(1);
      node.AddLast(2);
      node.AddLast(3);
      node.AddLast(4);
      node.AddLast(5);

      node.Remove(3);

      Assert.AreEqual(node.Count, 4);
      Assert.AreEqual(node.Tail.Value, 5);
      Assert.AreEqual(node.Head.Value, 1);
    }

    [TestMethod]
    public void TestRemoveMethod_RemoveLastElement()
    {
      var node = new LinkedList<int>();
      node.AddFirst(1);
      node.AddLast(2);

      node.Remove(2);

      Assert.AreEqual(node.Count, 1);
      Assert.AreEqual(node.Tail.Value, 1);
      Assert.AreEqual(node.Head.Value, 1);
    }

    [TestMethod]
    public void TestRemoveMethod_RemoveFirstElement()
    {
      var node = new LinkedList<int>();
      node.AddFirst(1);
      node.AddLast(2);

      node.Remove(1);

      Assert.AreEqual(node.Count, 1);
      Assert.AreEqual(node.Tail.Value, 2);
      Assert.AreEqual(node.Head.Value, 2);
    }
  }
}
