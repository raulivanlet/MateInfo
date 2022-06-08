using System.Collections.Generic;

namespace _05_23
{
    public class Arrai
    {
        List<int> array;
        public Arrai()
        {
            array = new List<int>();
        }

        public void Push(int val)
        {
            array.Add(val);
            array.Sort();
        }

        private void Sort()
        {
            for (int i = 0; i < array.Count; i++)
            {
                if ( (i <= array.Count) && (array[i] >= array[i + 1]) )
                {
                    int tmp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = tmp;
                }

            }
        }

        public void Print()
        {
            for (int i = 0; i < array.Count; i++)
            {
                System.Console.WriteLine(array[i]);
            }
        }

    }
}