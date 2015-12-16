public void SelectionSort(int[] a)
        {
            int min;
            for (int i = 0; i < a.Length - 1; i++)
            {
                min = i; 
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[min] > a[j])
                    {
                        min = j;
                    }
                }
                int holder = a[min];
                a[min] = a[i];
                a[i] = holder;
            }
            Console.WriteLine("After Selection Sort\n==================");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + "  ");
            }
        }