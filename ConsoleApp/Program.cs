// Today, I will learn git & github, so let's see how it goes.

using System.Globalization;

Console.WriteLine("Version 2");
void printArray<T> (T[] array) {
    foreach (T element in array) {
        Console.WriteLine(element);
    }
}

int[] nums = {1, 2, 3, 4, 5};
int[] evenNums = new int[5]; int evenCount = 0;
int[] oddNums = new int[5]; int oddCount = 0;
foreach (int num in nums) {
    if (num % 2 == 0) {
        evenNums[evenCount] = num; evenCount++;
    }
    else {
        oddNums[oddCount] = num; oddCount++;
    }
}

Console.WriteLine("Even numbers:");
printArray(evenNums);
Console.WriteLine("Odd numbers:");
printArray(oddNums);