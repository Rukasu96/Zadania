
using ZadanieArrayExtension;

int[] tab = new int[] { 5, 2, 3, 4, 9 };

ArrayExtension.ForEach(tab, 4, (arr, index) => Console.WriteLine(arr[index]));

ArrayExtension.ForEach(tab, 4, (arr, index) => arr[index] = 0);

ArrayExtension.ForEach(tab, 4, (arr, index) => Console.WriteLine(arr[index]));

