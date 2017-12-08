using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListImpl
{
  public class LinkedList<T> : ICollection<T>
  {

    public LinkedListNode<T> Head { get; private set; }
    public LinkedListNode<T> Tail { get; private set; }

    #region Add

    public void AddFirst(T value)
    {
      AddFirst(new LinkedListNode<T>(value));
    }

    public void AddFirst(LinkedListNode<T> value)
    {
      if(Count == 0)
      {
        Head = value;
        Tail = value;
      }
      else
      {
        var temp = Head;
        Head = value;
        Head.Next = temp;
        temp.Previous = Head;
      }
      Count++;
    }

    public void AddLast(T value)
    {
      AddLast(new LinkedListNode<T>(value));
    }

    public void AddLast(LinkedListNode<T> node)
    {
      if (Count == 0)
      {
        Head = node;
        Tail = node;
      }
      else
      {
        Tail.Next = node;
        node.Previous = Tail;
        Tail = node;
      }
      Count++;
    }

    #endregion

    #region Remove

    public void RemoveFirst()
    {
      if(Count == 1)
      {
        Head = null;
        Tail = null;
      }
      else
      {
        Head = Head.Next;
        Head.Previous = null;
      }
      Count--;
    }

    public void RemoveLast()
    {
      if(Count == 1)
      {
        Head = null;
        Tail = null;
      }
      else
      {
        var previousOfTail = Tail.Previous;
        previousOfTail.Next = null;
        Tail = previousOfTail;
      }
      Count--;
    }

    #endregion

    #region ICollection
    public int Count { get; set; }

    public bool IsReadOnly => throw new NotImplementedException();

    public void Add(T item)
    {
      throw new NotImplementedException();
    }

    public void Clear()
    {
      throw new NotImplementedException();
    }

    public bool Contains(T item)
    {
      throw new NotImplementedException();
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
      throw new NotImplementedException();
    }

    public IEnumerator<T> GetEnumerator()
    {
      throw new NotImplementedException();
    }

    public bool Remove(T value)
    {
      LinkedListNode<T> previous = null;
      var current = Head;
      while (current != null)
      {
        if (current.Value.Equals(value))
        {
          if(previous == null)
          {
            RemoveFirst();
            return true;
          }
          else
          {
            previous.Next = current.Next;
            current.Next.Previous = previous;

            if(current.Next == null)
            {
              Tail = previous;
            }
          }
          Count--;
          return true;
        }

        previous = current;
        current = current.Next;
      }
      return false;
      
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      throw new NotImplementedException();
    }
    #endregion

  }
}
