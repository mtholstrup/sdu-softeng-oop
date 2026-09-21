int[] numbers = {4, 2, 3, 0, -2, -7, 7, -8, -4};
int largestNegative = 0;

foreach(int num in numbers) {
    if (num < largestNegative) {
        largestNegative = num;
    }
}

if (largestNegative == 0) {
    Console.WriteLine("There are no negative numbers in this array");
} else {
    Console.WriteLine("The largest negative value is: "+largestNegative);
}