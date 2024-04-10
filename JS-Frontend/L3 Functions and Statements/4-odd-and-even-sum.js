/*You will receive a single number. You have to write a function, that returns the sum of all even and all odd digits from that number.
You will receive a single number. You have to write a function, that returns the sum of all even and all odd digits from that number.*/

function solve(num){
        
    function splitIntToArray(number){

        const intArr = number
            .toString()
            .split('')
            .map(Number);
        return intArr;
    }

    let oddSum = function (arr = []){
        
        let sum = 0;

        for(const number of arr){
            if(number % 2 !== 0){
                sum += number;
            }
        }

        return sum;
    }

    let evenSum = function (arr = []){
        
        let sum = 0;

        for(const number of arr){
            if(number % 2 === 0){
                sum += number;
            }
        }

        return sum;
    }

    console.log(`Odd sum = ${oddSum(splitIntToArray(num))}, Even sum = ${evenSum(splitIntToArray(num))}`)
}

solve(1000435);