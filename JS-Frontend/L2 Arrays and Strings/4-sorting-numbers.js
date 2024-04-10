function customSort(arr) {
    // Sort the array in ascending order
    arr.sort((a, b) => a - b);

    // Create a new array to store the sorted elements in the required pattern
    const result = [];
    let left = 0;
    let right = arr.length - 1;

    while (left <= right) {
        if (left !== right) {
            // Push the smaller number
            result.push(arr[left]);
            // Push the larger number
            result.push(arr[right]);
        } else {
            // Push the remaining single element
            result.push(arr[left]);
        }
        left++;
        right--;
    }

    return result;
}

customSort([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]);