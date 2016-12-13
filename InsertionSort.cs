static int[] InsertionSort(int[] arr)
{
    //Holder vars
    int value, j;
    //Loop from one to end of the array , assume first element [0] already sorted
    for (int i = 1; i < arr.Length; i++)
    {
        //carry the value of element we in, on the array
        value = arr[i];
        //carry the position before the element we in to compare
        j = i - 1;
        //loop to the elemnts before this element and check we not goto further of the end of array, check the value before greater than
        while (j >= 0 && arr[j] > value)
        {
            //Copy the value of the array of j to array of j+1
            arr[j + 1] = arr[j];
            // dicrease j value
            j--;
        }
        //set value to value
        arr[j + 1] = value;
    }
    //return sorted one
    return arr;
}
