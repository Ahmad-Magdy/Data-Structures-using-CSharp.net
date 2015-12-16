     public int BinarySearch(int[] a ,int value)
        {
            int min, max, mid;
            min = a.GetLowerBound(0);
            max = a.GetUpperBound(0);
            while(min<=max)
            {
                mid = (min + max) / 2;
                if (a[mid] == value)
                    return a[mid];
                else if (a[mid] < value)
                    min = mid + 1;
                else
                    max = mid - 1;
            }
            return -1;
        }