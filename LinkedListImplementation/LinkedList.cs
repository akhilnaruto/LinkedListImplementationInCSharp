using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementation
{
  public class LinkedList<T> : ICollection<T>
  {
    public LinkedListNode<T> Head { get; private set; }
    public LinkedListNode<T> Tail { get; private set; }

    #region Add

    public void AddLast(T value)
    {
      AddLast(new LinkedListNode<T>(value));
    }


    public void AddLast(LinkedListNode<T> value)
    {
      if(Count == 0)
      {
        Head = value;
        Tail = value;
      }
      else
      {
        Tail.Next = value;
        Tail = value;
      }
      Count ++;
    }

    public void AddFirst(T value)
    {
      AddFirst(new LinkedListNode<T>(value));
    }

    public void AddFirst(LinkedListNode<T> value)
    {
      if (Count == 0)
      {
        Head = value;
        Tail = value;
      }
      else
      {
        var temp = Head;
        Head = value;
        Head.Next = temp;
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
      }
      Count--;
    }
    public void RemoveLast()
    {
      if (Count == 1)
      {
        Head = null;
        Tail = null;
      }
      else
      {
        var current = Head;
        while(current.Next != Tail)
        {
          current = current.Next;
        }
        current.Next = null;
        Tail = current;
      }
      Count--;
    }

    #endregion



    #region ICollection

    public int Count { get; private set; }

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

    public bool Remove(T item)
    {
      var current = Head;
      LinkedListNode<T> previous = null;
      while(current != null)
      {
        if (current.Value.Equals(item))
        {
           if(previous == null)
          {
            RemoveFirst();
          }
          else
          {
            previous.Next = current.Next;
            if(current.Next == null)
            {
              Tail = previous; 
            }
            Count--;
          }
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
