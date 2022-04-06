public class Solution {
    public int ThreeSumMulti(int[] arr, int target) {
        double counter = 0;
        
        Array.Sort(arr);
        for(int i = 0; i < arr.Length; i++) {
            int newTarget = target - arr[i];
            int left = i + 1,
                right = arr.Length - 1;
            
            while (left < right) {
                // Console.Write($"[{string.Join(",", arr)}]--");
                // Console.WriteLine($"i[{i}]-j[{left}]-k[{right}]");
                if (arr[left] + arr[right] < newTarget)
                    left++;
                else if(arr[left] + arr[right] > newTarget)
                    right--;
                else if (arr[left] != arr[right]) {
                    int subLeft = 1,
                        subRight = 1;
                    
                    while (left + 1 < right && arr[left] == arr[left + 1]) {
                        subLeft++;
                        left++;
                    }
                    while (right - 1 > left && arr[right] == arr[right - 1]) {
                        subRight++;
                        right--;
                    }
                    
                    counter += subLeft * subRight;
                    counter %= 1000000007;
                    left++;
                    right--;
                } else {
                    counter += (right - left + 1) * (right - left) / 2;
                    counter %= 1000000007;
                    break;
                }
            }
            // Console.WriteLine($"counter={counter}");
        }
        return Convert.ToInt32(counter);
    } 
}