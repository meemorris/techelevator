import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Practice {




    public static void main(String[] args) {
        Practice practice = new Practice();
        int[] nums = { 2, 1, 3, 5};
        System.out.println(practice.isValueDouble(nums));
        System.out.println(Arrays.toString(practice.swapEnds(nums)));
        System.out.println(practice.greenTicket(2, 2, 3));
        int[] arr = { 1, 2, 4 };
        System.out.println(practice.start1(nums, arr));
        System.out.println(Arrays.toString(practice.fizzArray3(3, 10)));
        System.out.println(practice.only14(arr));
    }

    public boolean isValueDouble(int[] arr) {
        boolean result = false;
        for (int i = 0; i < arr.length - 1; i++) {
            int comparison = arr[i];
            for (int j = 0; j < arr.length - 1; j++) {
                if (!(j == i)){
                    result = comparison == arr[j + 1];
                }
            }
        }
        return result;
    }

    //Practice question 1
    public int[] swapEnds(int[] arr) {
        int firstValue = 0;
        int lastValue = 0;
        for (int i = 0; i < arr.length; i++) {
            firstValue = arr[0];
            lastValue = arr[arr.length - 1];
        }
        arr[0] = lastValue;
        arr[arr.length - 1] = firstValue;
        return arr;
    }

    //Practice question 2
    public int greenTicket(int a, int b, int c) {
        boolean numbersAreDifferent = a != b && a != c && b != c;
        boolean numbersAreSame = a == b && a == c;
        boolean twoNumAreSame = a == b || a == c || b == c;
        int result = 1;
        if (numbersAreDifferent) {
            result = 0;
        } else if (numbersAreSame) {
            result = 20;
        } else if (twoNumAreSame) {
            result = 10;
        }
        return result;
    }

    //Practice question 3
    public int start1(int[] a, int[] b) {
        int oneCount = 0;

        if (a[0] == 1 && b[0] == 1) {
            oneCount += 2;
        } else if (a[0] == 1 || b[0] == 1) {
            oneCount++;
        }
        return oneCount;
    }

    //Practice question 4
    public Object[] fizzArray3(int start, int end) {
        List<Integer> listToArray = new ArrayList<>();
        for(int i = 0; i < end - start; i++) {
            if (i == 0) {
                listToArray.add(start);
            } else {
                listToArray.add(start + i);
            }
        }
        return listToArray.toArray();
    }

    public boolean only14(int[] nums) {
        int length = 0;
        boolean result = false;
        for (int i = 0; i < nums.length; i++) {
            if (nums[i] == 1 || nums[i] == 4) {
                length++;
            }
        }
        if (length == nums.length - 1) {
            result = true;
        }
        return result;
    }


}
