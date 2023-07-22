namespace QuickSort {
    /* This function takes last element as pivot, places
       the pivot element at its correct position in sorted
        array, and places all smaller (smaller than pivot)
       to left of pivot and all greater elements to right
       of pivot */
    class QuickSorter
    {
        // A utility function to swap two elements


        private static int partition(int[] arr, int low, int high)
        {
            int temp;
            int pivot = arr[high];    // pivot
            int i = (low - 1);  // Index of smaller element

            for (int j = low; j <= high - 1; j++)
            {
                // If current element is smaller than or
                // equal to pivot
                if (arr[j] <= pivot)
                {
                    i++;    // increment index of smaller element
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                }
            }
            temp = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp;
            return (i + 1);
        }

        public static void QuickSort(int[] a)
        {
            QuickSort(a, 0, a.Length - 1);
        }

        /* The main function that implements QuickSort
        arr[] --> Array to be sorted,
        low  --> Starting index,
        high  --> Ending index */
        public static void QuickSort(int[] input, int low, int high)
        {
            int pi;

            if (low < high)
            {
                /* pi is partitioning index, arr[p] is now
                at right place */
                pi = partition(input, low, high);

                // Separately sort elements before
                // partition and after partition
                QuickSort(input, low, pi - 1);
                QuickSort(input, pi + 1, high);
            }
        }
    }
}