namespace BinarySearch1;

internal class OriginalAlgorithm
{
    public static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid;

            else if (arr[mid] < target)
                left = mid + 1;

            else
                right = mid - 1;
        }

        return -1;
    }

}
