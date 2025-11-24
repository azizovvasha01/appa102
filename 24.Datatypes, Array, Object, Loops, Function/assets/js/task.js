// Task 1
function removeDuplicatesAndCount(arr) {
    let newArr = [];       
    let newLen = 0;         
    let repeatCount = 0;   

   
    for (let i = 0; i < arr.length; i++) {
        let isExists = false;  

        
        for (let j = 0; j < newLen; j++) {
            if (arr[i] === newArr[j]) {
                isExists = true;
                break;
            }
        }

        if (!isExists) {
           
            newArr[newLen] = arr[i];
            newLen++;
        } else {
            
            repeatCount++;
        }
    }

    return {
        tekrarsiz: newArr,
        tekrar_sayi: repeatCount
    };
}


let result = removeDuplicatesAndCount([3, 5, 3, 7, 5, 8, 3]);

console.log("Tekrarsiz array:", result.tekrarsiz);     
console.log("Tekrar sayi:", result.tekrar_sayi);         



// Task 2
function isPalindrome(word) {
    let left = 0;
    let right = word.length - 1;

    while (left < right) {
        if (word[left] !== word[right]) {
            return false; 
        }
        left++;
        right--;
    }

    return true; 
}


console.log(isPalindrome("level")); 
console.log(isPalindrome("salam")); 



// Task 3
function countSmaller(arr, num) {
    let count = 0;

    for (let i = 0; i < arr.length; i++) {
        if (arr[i] < num) {
            count++;
        }
    }

    return count;
}


console.log(countSmaller([5, 2, 8, 1, 7], 6)); 



// Task 4
function checkNumber(n) {
    let sum = 0;

    for (let i = 1; i < n; i++) {
        if (n % i === 0) {
            sum += i;
        }
    }

   
    if (sum > n) {
        return "Abundant";
    } else {
        return "Deficient";
    }
}

console.log(checkNumber(12)); 
console.log(checkNumber(13));


// Task 5
function squareArray(arr) {
    let newArr = [];
    let index = 0;

    for (let i = 0; i < arr.length; i++) {
        newArr[index] = arr[i] * arr[i]; 
        index++;
    }

    return newArr;
}


console.log(squareArray([2, 4, 5])); 


