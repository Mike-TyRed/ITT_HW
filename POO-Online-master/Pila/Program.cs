using System;

  public class Stack<T>
{

   readonly int m_Size; 

   int m_StackPointer = 0;

   public T[] m_Items;

   public Stack():this(10)

   {}

   public Stack(int size)

   {
      m_Size = size;

      m_Items = new T[m_Size];
   }

   public void Push(T item)

   {
      if(m_StackPointer >= m_Size) 
        {
            Console.WriteLine("Error StackOverFlow");
        }
        else
        {
      m_Items[m_StackPointer] = item;

      m_StackPointer++;
        }
   }

   public T Pop()
   {
      m_StackPointer--;

      if(m_StackPointer >= 0)
      {
         return m_Items[m_StackPointer];
      }
      else
      {
         m_StackPointer = 0;

         throw new InvalidOperationException("Cannot pop an empty stack");
      }

   }

}

class program
{
    static void Main()
    {
        Stack<string> pila = new Stack<string>();

        pila.Push("2");
        pila.Push("3");
        pila.Push("12");

        foreach(var item in pila.m_Items)
        Console.WriteLine(item);

        Console.WriteLine(pila.Pop());
        Console.WriteLine(pila.Pop());

        foreach(var item in pila.m_Items)
        Console.WriteLine(item);        
    }
}