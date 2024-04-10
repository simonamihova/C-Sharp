function solve(num1, num2, num3){

    let tempMin = num1;

    function getSmallestNum(a, b, c){
       
        if(b < tempMin){
            tempMin = b; 
        }

        if( c < tempMin){
            tempMin = c;
        }

        return tempMin;
    }

    return getSmallestNum(num1, num2, num3);

}

console.log(solve(5,77,3));