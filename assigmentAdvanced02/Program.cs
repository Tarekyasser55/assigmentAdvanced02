using System.Collections;
using System.ComponentModel;

namespace assigmentAdvanced02
{
    internal class Program
    {
        //q3
        public static void reverse(ref Queue q)
        {
            Stack stack = new Stack();
            
            while (q.Count > 0)
                stack.Push(q.Dequeue());

            while (stack.Count > 0)
                q.Enqueue(stack.Pop());

        }
        //q4
        public static bool balances(char[] input,Stack stack)
        {
            foreach (char ch in input)
            {
                if (ch == '(' ||ch=='{'||ch=='[')
                    stack.Push(ch);
                else if (ch == ')'||ch=='}'||ch==']' )
                {
                    if (stack.Count == 0)
                        return false;
                    stack.Pop();
                }
            }
            return stack.Count == 0;
        }
static void Main(string[] args)
        {

            #region q1
            //int[] arr = new int[3];
            //int[] Queries = new int[3];
            //for(int i=0; i<arr.Length;i++)
            //{
            //    Console.Write($"Enter the values nubmer{i+1}:");
            //    arr[i] = int.Parse(Console.ReadLine()!);
            //    Console.Write($"Enter the values queries{i + 1}:");
            //    Queries[i] = int.Parse(Console.ReadLine()!);
            //}
            //int num = 0;
            //foreach(int x in Queries )
            //{
            //    int count = 0;
            //    foreach (int number in arr)
            //    {
            //        if (number > x)
            //            count++;
            //    }
            //    Console.WriteLine($"the number number{++num }={count}");
            //}
            #endregion
            #region q2
            //int n = 5;
            //int foun=1;
            //int[] arr = { 1, 3, 2, 3, 1 };
            //for(int i=0;i<(n/2);i++)
            //{


            //    if (arr[i] != arr[arr.Length - i - 1])
            //        foun = 0;
            //}
            //if (foun==1)
            //    Console.WriteLine("yes");
            //else
            //    Console.WriteLine("no");

            #endregion
            #region q3
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //reverse(ref queue );
            //foreach (int i in queue)
            //    Console.WriteLine(i);
            #endregion
            #region q4
            //char[] input = { '[', '(', ')', ']', '{', '}'};
            //Stack stack = new Stack();
            //bool s = balances(input, stack);
            //if (s)
            //    Console.WriteLine("bsalanced");
            //else
            //    Console.WriteLine("not balance");

            #endregion
            #region q5
            //int[] arr = { 1, 2, 3, 3, 5, 2 };
            //int[] arr2 = arr.Distinct().ToArray();
            //foreach (int i in arr2)
            //    Console.WriteLine(i);
            #endregion
            #region q6
            //List<int> list = new List<int> { 1, 2, 3, 4, 5, 6 };
            //List<int> list2 = new List<int>();
            //foreach (int i in list)
            //{
            //    if (i % 2 == 1)
            //        continue;
            //    list2.Add(i);
            //}
            //foreach (int j in list2)
            //    Console.WriteLine(j);
            #endregion
            #region q7
            //Queue<Object> queue = new Queue<object>();
            //queue.Enqueue("tarek");
            //queue.Enqueue(1);
            //queue.Enqueue(2.25);
            #endregion
            #region q9
            //int[] arr1 = { 1, 2, 3, 4, 4, 4 };
            //int[] arr2 = { 1, 0, 4, 4 };
            //Dictionary<int, int> tarek = new Dictionary<int, int>();
            //List<int> list = new List<int>();
            //foreach(int num in arr1)
            //{
            //    if (!tarek.ContainsKey(num))
            //        tarek[num] = 0;
            //    ++tarek[num];
            //}
            //foreach(int num in arr2)
            //{
            //    if (tarek.ContainsKey(num) && tarek[num] > 0)//
            //        list.Add(num);

            //}
            //foreach (int num in list)
            //    Console.WriteLine(num);
            #endregion
            #region q10
            //List<int> list = new List<int> { 1, 2, 3, 7, 9 };
            //int target = 12;
            //bool found = false;
            //for(int i=0;i<list.Count;i++)
            //{
            //    int sum = 0;
            //    for(int j=i;j<list.Count;j++)
            //    {
            //        sum += list[j];
            //        if (sum == target)
            //        {

            //            found = true;
            //            break;
            //        }
            //    }

            //}
            //if (found)
            //    Console.WriteLine("yes found");
            //else
            //{
            //    Console.WriteLine("no found");
            //}
            #endregion
           

        }
    }
}
