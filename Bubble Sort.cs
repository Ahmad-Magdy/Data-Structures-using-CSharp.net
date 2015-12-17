  public void BubbleSort(int[] a) 
        {
            //first loop, repeat n-1 times
            for (int i = 0; i < a.Length - 1; i++)
            {
                //second loop, repeat n-1 times but must begin from 0 to n-1
                for (int j = 0; j < a.Length - 1; j++)
                {
                    //if the element of index j greater than next item 
                    if (a[j] > a[j + 1])
                    {
                        //swap 
                        int holder = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = holder;
                    }
                }
            }
            //print output after sorting 
            Console.WriteLine("After Bubble sort \n =================");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }