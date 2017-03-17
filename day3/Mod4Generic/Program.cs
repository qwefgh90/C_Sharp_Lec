using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Generic
{
    class Stack<T>
    {
        private T[] s;
        private int top;
        private int size;
        public Stack(int size)
        {
            s = new T[size];
            top = -1;
            this.size = size;
        }
        public void push(T v){
            if (top + 1 == size)
                throw new Exception("스택 자료구조의 길이를 초과하였습니다.");
            s[++top] = v;
        }
        public T pop()
        {
            if(top == -1)
                throw new Exception("스택이 비었습니다.");
                
            return s[top--];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s1 = new Stack<int>(5);
            s1.push(1);
            s1.push(2);
            s1.push(3);
            s1.push(4);
            Console.WriteLine(s1.pop());
            Console.WriteLine(s1.pop());
            Console.WriteLine(s1.pop());
            Console.WriteLine(s1.pop());
        }
    }
}
