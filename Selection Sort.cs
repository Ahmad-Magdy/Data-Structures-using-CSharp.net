public void SelectionSort(int[] a)
        {
            int min;
            //first loop , from zero to n-1 , n = number of elements
            for (int i = 0; i < a.Length - 1; i++)
            {
                min = i;  //set min = i to save this index for replace 
                //second loop start from i+1 to the last element
                for (int j = i + 1; j < a.Length; j++)
                {
                    //if the element with index min greater than element with index of j which changes
                    if (a[min] > a[j])
                    {
                        //set min item , min  = j which less than
                        min = j;
                    }
                }
                //swap after loop
                int holder = a[min];
                a[min] = a[i];
                a[i] = holder;
            }
            //Print Output
            Console.WriteLine("After Selection Sort\n==================");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + "  ");
            }
        }