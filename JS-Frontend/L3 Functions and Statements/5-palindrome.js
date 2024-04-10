function solve(arr){

    function isPalindrome(number){
        const forward = number.toString();
        const backward = forward.split('').reverse().join('');
        if(forward === backward){
            return true;
        }

        return false;
    }

    for(let num of arr){

        if(isPalindrome(num)){
            console.log('true');
        }
        else{
            console.log('false');
        }
    }

}