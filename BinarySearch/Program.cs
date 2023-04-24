
int[] arr = new int[40];

for (int i = 0; i < 40; i++)
    arr[i] = i + 1;

int target = 38;
Console.WriteLine($"Array: {string.Join(", ", arr)}");
Console.WriteLine($"Target value: {target}");

int left = 0, right = arr.Length - 1, step = 0;

while (left <= right)
{
    int mid = left + (right - left) / 2;

    Console.WriteLine($"\nStep {++step}:");
    Console.WriteLine($"Left index: {left}");
    Console.WriteLine($"Right index: {right}");
    Console.WriteLine($"Middle index: {mid}");

    if (arr[mid] == target)
    {
        Console.WriteLine($"Target value found at index: {mid}");
        return;
    }
    else if (arr[mid] < target)
    {
        left = mid + 1;
        Console.WriteLine("Target value is greater than middle value.");
    }
    else
    {
        right = mid - 1;
        Console.WriteLine("Target value is less than middle value.");
    }
}

Console.WriteLine("Target value not found in the array.");

Console.ReadKey();