package SubArrayWithGivenSum;

import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {
        int n = 5;
        int s = 12;
        int a[] = { 1, 2, 3, 7, 5 };
        ArrayList<Integer> result = subarraySum(a, n, s);

        for (int i = 0; i < result.size(); i++)

            // Printing and display the elements in ArrayList
            System.out.print(result.get(i) + " ");
    }

    static ArrayList<Integer> subarraySum(int[] arr, int n, int s) {
        // ArrayList<Integer> result = new ArrayList<>();

        // for (int i = 0; i < n ; i++) {
        // int x = arr[i];
        // for (int j = i+1; j < n ; j++) {
        // x = x + arr[j];
        // if (s == x) {
        // result.add(i+1);
        // result.add(j+1);
        // return result;
        // }
        // }
        // }
        // result.add(-1);
        // return result;

        ArrayList<Integer> result = new ArrayList<>();
        int currentSum, i, j;

        // Pick a starting point
        for (i = 0; i < n - 1; i++) {
            currentSum = arr[i];

            // try all subarrays starting with 'i'
            for (j = i + 1; j <= n - 1; j++) {
                currentSum = currentSum + arr[j];
                if (currentSum == s) {
                    // int p = j - 1;
                    result.add(i + 1);
                    result.add(j + 1);

                    return result;
                }
            }
        }

        result.add(-1);
        return result;
    }
}
