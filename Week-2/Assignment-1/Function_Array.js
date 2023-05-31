// I'm practicing the use of try...catch in the code. Please let me know if it is inappropriate, thanks!

function max(numbers) {
// your code here, for-loop method preferred
  try {
    if (numbers.length === 0 || !Array.isArray(numbers)) {
      throw new Error('Array is invalid!');
    }

    const onlyNumberArray = numbers.filter(element => typeof element === 'number');
    if (onlyNumberArray.length === 0) {
      return 'Array is valid but without any number!';
    }

    let max = onlyNumberArray[0];
    onlyNumberArray.forEach(num => {
      if (num > max) {
        max = num;
      }
    });
    return max;
  } catch (error) {
    // Handle other errors
    console.error(error);
  }
}



console.log(max([1, 2, 4, 5])); // should print 5
console.log(max([5, 2, 7, 1, 6])); // should print 7
console.log(max(['string here!']))
console.log(max([]))
console.log(max('hehe, I am not an array'))



function findPosition(numbers, target) {
  // your code here, for-loop method preferred
  try {
    if (!Array.isArray(numbers) || typeof target !== 'number') {
      throw new Error('Invalid input. Expecting an array of numbers and a target number.');
    }

    if (!numbers.includes(target)) {
      return -1;
    }

    for (let i = 0; i < numbers.length; i++) {
      if (numbers[i] === target) {
        return i;
      }
    }
  } catch (error) {
    // try to handle other errors here
    console.error(error);
  }
}

console.log(findPosition([5, 2, 7, 1, 6], 5)); // should print 0
console.log(findPosition([5, 2, 7, 1, 6], 7)); // should print 2
console.log(findPosition([5, 2, 7, 7, 7, 1, 6], 7)); // should print 2 (the first position)
console.log(findPosition([5, 2, 7, 1, 6], 8)); // should print -1
console.log(findPosition('string','another string')); // Invalid input
console.log(findPosition(elfkenw)); // catch other error by console