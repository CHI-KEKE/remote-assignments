function binarySearchPosition(numbers, target) {
    // your code here
    numbers.sort((a,b) => a-b);
    let head = 0;
    let tail = numbers.length -1;
    while(head <= tail)    // run the last loop when head === tail, and exit the loop when head is greater than tail
    {
        let middle = Math.floor((head + tail)/2);

        if(numbers[middle] === target)
        {
            return middle;
        }
        else if(numbers[middle] < target)
        {
            head = middle + 1;   // push the head to right, because the target should be on the right side
        }
        else
        {
            tail = middle -1;   // pull the tail to left, because the target should be on the left side
        }

    }
    return -1;
}



console.log(binarySearchPosition([1, 2, 5, 6, 7], 1)); // should print 0
console.log(binarySearchPosition([1, 2, 5, 6, 7], 6)); // should print 3