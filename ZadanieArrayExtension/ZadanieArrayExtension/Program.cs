
using ZadanieArrayExtension;

int[] tab = new int[] { 5, 2, 3, 4, 9 };

ArrayExtension.ForEach(tab, (arr, index) => Console.WriteLine(arr[index]));

ArrayExtension.ForEach(tab, (arr, index) => arr[index] = 0);

ArrayExtension.ForEach(tab, (arr, index) => Console.WriteLine(arr[index]));

