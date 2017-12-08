using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoublyLinkedListImpl;
namespace DoublyLinkedListTests
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestAddFirstWhenEmpty()
    {
      var node = new LinkedList<int>();
      node.AddFirst(1);

      Assert.AreEqual(node.Count, 1);
      Assert.AreEqual(node.Head.Value, 1);
      Assert.AreEqual(node.Tail.Value, 1);
      Assert.AreEqual(node.Head.Previous, null);
      Assert.AreEqual(node.Tail.Previous, null);
    }

    [TestMethod]
    public void TestAddFirstToExistingNode()
    {
      var node = new LinkedList<int>();
      node.AddFirst(2);
      node.AddFirst(1);

      Assert.AreEqual(node.Count, 2);
      Assert.AreEqual(node.Head.Value, 1);
      Assert.AreEqual(node.Tail.Value, 2);
      Assert.AreEqual(node.Head.Previous, null);
      Assert.AreEqual(node.Tail.Previous.Value, 1);
    }

    [TestMethod]
    public void TestAddLastWhenEmpty()
    {
      var node = new LinkedList<int>();
      node.AddLast(1);


      Assert.AreEqual(node.Count, 1);
      Assert.AreEqual(node.Head.Value, 1);
      Assert.AreEqual(node.Tail.Value, 1);
      Assert.AreEqual(node.Head.Previous, null);
      Assert.AreEqual(node.Tail.Previous, null);
    }

    [TestMethod]
    public void TestAddLastToExistingNodes()
    {
      var node = new LinkedList<int>();
      node.AddFirst(2);
      node.AddFirst(1);
      node.AddLast(3);

      Assert.AreEqual(node.Count, 3);
      Assert.AreEqual(node.Head.Value, 1);
      Assert.AreEqual(node.Tail.Value, 3);
      Assert.AreEqual(node.Head.Previous, null);
      Assert.AreEqual(node.Tail.Previous.Value, 2);
    }

    [TestMethod]
    public void RemoveFirstWhenThereIsOneNode()
    {
      var node = new LinkedList<int>();
      node.AddFirst(1);

      node.RemoveFirst();

      Assert.AreEqual(node.Count, 0);
      Assert.AreEqual(node.Head, null);
      Assert.AreEqual(node.Tail ,null);
    }

    [TestMethod]
    public void RemoveFirstWhenThereAreMultipleNodes()
    {
      var node = new LinkedList<int>();
      node.AddFirst(3);
      node.AddFirst(2);
      node.AddFirst(1);

      node.RemoveFirst();

      Assert.AreEqual(node.Count, 2);
      Assert.AreEqual(node.Head.Value, 2);
      Assert.AreEqual(node.Tail.Value, 3);
      Assert.AreEqual(node.Tail.Previous.Value, 2);

    }

    [TestMethod]
    public void RemoveFirstMultipleTimes()
    {
      var node = new LinkedList<int>();
      node.AddFirst(5);
      node.AddFirst(4);
      node.AddFirst(3);
      node.AddFirst(2);
      node.AddFirst(1);

      node.RemoveFirst();
      node.RemoveFirst();


      Assert.AreEqual(node.Count, 3);
      Assert.AreEqual(node.Head.Value, 3);
      Assert.AreEqual(node.Tail.Value, 5);
      Assert.AreEqual(node.Tail.Previous.Value, 4);

    }

    [TestMethod]
    public void RemoveLastWhenThereIsOnlyOneNode()
    {
      var node = new LinkedList<int>();
      node.AddFirst(1);

      node.RemoveLast();

      Assert.AreEqual(node.Count, 0);
      Assert.AreEqual(node.Head, null);
      Assert.AreEqual(node.Tail, null);
    }

    [TestMethod]
    public void RemoveLastWhenThereAreMultipleNodes()
    {
      var node = new LinkedList<int>();
      node.AddFirst(5);
      node.AddFirst(4);
      node.AddFirst(3);
      node.AddFirst(2);
      node.AddFirst(1);

      Assert.AreEqual(node.Tail.Value, 5);

      node.RemoveLast();

      Assert.AreEqual(node.Count, 4);
      Assert.AreEqual(node.Head.Value, 1);
      Assert.AreEqual(node.Tail.Value, 4);
      Assert.AreEqual(node.Tail.Previous.Value, 3);
      Assert.AreEqual(node.Tail.Previous.Previous.Value, 2);


    }
    [TestMethod]
    public void RemoveLastMultipleTimes()
    {
      var node = new LinkedList<int>();
      node.AddFirst(5);
      node.AddFirst(4);
      node.AddFirst(3);
      node.AddFirst(2);
      node.AddFirst(1);

      Assert.AreEqual(node.Tail.Value, 5);

      node.RemoveLast();
      Assert.AreEqual(node.Tail.Value, 4);

      node.RemoveLast();
      Assert.AreEqual(node.Tail.Value, 3);


      Assert.AreEqual(node.Count, 3);
      Assert.AreEqual(node.Head.Value, 1);
      Assert.AreEqual(node.Tail.Value, 3);
      Assert.AreEqual(node.Tail.Previous.Value, 2);
      Assert.AreEqual(node.Tail.Previous.Previous.Value, 1);


    }

    [TestMethod]

    public void TestRemoveMethod_RemoveFirstElement_ThereIsOnlyOneElement()
    {
      var node = new LinkedList<int>();

      node.AddLast(5);
      node.Remove(5);

      Assert.AreEqual(node.Count, 0);
      Assert.AreEqual(node.Head, null);
      Assert.AreEqual(node.Tail, null);

    }

    [TestMethod]
    public void TestRemoveMethod_RemoveMiddleNode()
    {
      var node = new LinkedList<int>();

      node.AddFirst(1);
      node.AddLast(2); // removed
      node.AddLast(3);
      node.AddLast(4); // removed
      node.AddLast(5);

      node.Remove(4);

      Assert.AreEqual(node.Count, 4);
      Assert.AreEqual(node.Head.Value, 1);
      Assert.AreEqual(node.Tail.Value, 5);
      Assert.AreEqual(node.Tail.Previous.Value, 3);
      Assert.AreEqual(node.Tail.Previous.Next.Value, 5);

      node.Remove(2);

      Assert.AreEqual(node.Count, 3);
      Assert.AreEqual(node.Head.Value, 1);
      Assert.AreEqual(node.Tail.Value, 5);
      Assert.AreEqual(node.Tail.Previous.Value, 3);
      Assert.AreEqual(node.Tail.Previous.Next.Value, 5);

      Assert.AreEqual(node.Head.Next.Value, 3);
      Assert.AreEqual(node.Head.Next.Previous.Value, 1);







    }



  }
}
