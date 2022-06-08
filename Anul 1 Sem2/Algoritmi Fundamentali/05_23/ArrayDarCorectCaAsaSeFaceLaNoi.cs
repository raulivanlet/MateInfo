namespace _05_23
{
    internal class ArrayDarCorectCaAsaSeFaceLaNoi
    {
        int[] array;

        public ArrayDarCorectCaAsaSeFaceLaNoi()
        {
            array = new int[0];
        }

        public void Push(int val)
        {
            if (array.Length == 0)
            {
                array = new int[array.Length+1];
                array[0] = val;
            }
            else if(array.Length == 1)
            {
                if (array[0] <= val)
                {
                    int tmp = array[0];
                    array = new int[array.Length+1];
                    array[0] = tmp;
                    array[1] = val;
                }
                else
                {
                    int tmp = array[0];
                    array = new int[array.Length+1];
                    array[0] = val;
                    array[1] = tmp;
                }
            }
            else
            {
                PushSorted(val);
            }
                
        }

        private void PushSorted(int val)
        {
            int i = 0;
            while (i < array.Length)
            {
                if( (val >= i) && (val <= i+1))
                {
                    int[] tmp = new int[array.Length+1];
                    for(int j = 0; j < tmp.Length; j++)
                    {
                        if(j == i + 1)
                        {
                            tmp[j] = val;
                        }
                        else if (j < i)
                        {
                            tmp[j] = array[i];
                        }
                        else
                        {
                            tmp[j] = array[i+1];
                        }
                    }
                    array = new int[array.Length+1];
                    for (int j = 0; j < array.Length; j++)
                    {
                        array[j] = tmp[j];
                    }
                }
                i++;
            }
        }

        public void Print()
        {
            for (int i =0; i < array.Length ; i++)
            {
                System.Console.WriteLine(array[i]);
            }
        }

    }
}