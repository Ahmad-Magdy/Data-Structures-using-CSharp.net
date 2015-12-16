  public void BubbleSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int holder = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = holder;
                    }
                }
            }
            Console.WriteLine("After Bubble sort \n =================");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }