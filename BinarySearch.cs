     public int BinarySearch(int[] a ,int value) // take array and and the value will looking for
        {
            int min, max, mid;
            // get the index of first element 
            min = a.GetLowerBound(0);
            // get the index of last element
            max = a.GetUpperBound(0);
            // while min < = max or true 
            while(min<=max)
            {
                /*
                 mid element = (begin + end) /2
                 we talk about indexes not value of the array
                */
                mid = (min + max) / 2;
                //if the middle element is equal to the value what we looking for 
                if (a[mid] == value)
                    return a[mid]; // return its value
                /*
                else if the middle element is less than value we looking for
                start from the middle and add 1
                */
                else if (a[mid] < value)
                    min = mid + 1;
                // else if the middle greater than value keep min and set max = mid-1
                else
                    max = mid - 1;
            }
            //if anything else happened return -1
            return -1;
        }