# Selection Sort Explained 

* A Selection Sort scans an array for the lowest value, then puts it into the furthest left position. 
* For example, if this is the array [8,4,23,42,16,15], the selection sort method will scan position zero, which in this case is 8, to see if there is a lower value than 8. 
* If and when it finds that lower value, it moves it into position 0, so that the array now reads as [4,8,23,42,16,15]
* The algorithm then instructs to hold that position zero, move on to position 1, which is now number 8, and check that value through the length of the array. So now, the array still reads as: [4,8,23,42,16,15]

## Pseudocode
SelectionSort(int[] arr)
    DECLARE n <-- arr.Length;
    FOR i = 0; i to n - 1  
        DECLARE min <-- i;
        FOR j = i + 1 to n
            if (arr[j] < arr[min])
                min <-- j;

        DECLARE temp <-- arr[min];
        arr[min] <-- arr[i];
        arr[i] <-- temp;

## Trace [8,4,23,42,16,15]

selectionSort(int arr[], int n) 
{ 
    int i, j, min; 
  
    for (i = 0; i < n-1; i++) 
    { 
        min = i; 
        for (j = i+1; j < n; j++) 
          if (arr[j] < arr[min]) 
            min = j; 
  
        temp = arr[min]; 
        arr[min] = arr[i];
        arr[i] = temp;
    } 
} 

