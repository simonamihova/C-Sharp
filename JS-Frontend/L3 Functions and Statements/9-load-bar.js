function solve(number){

    let loadBar = ['.','.','.','.','.','.','.','.','.','.'];

    let divideByTen =  num => num/10;
    
    function load(num, arr){
        for(let i = 0; i < num; i++){
            arr[i] = '%';
        }
    }

    function isFull(num){
        if(divideByTen(num) === 10){
            return true;
        }
        return false;
    }

    loadbar = load(divideByTen(number), loadBar);

    console.log(`${number}% [${loadBar.join('')}]`);

    if(isFull(divideByTen(number))){
        console.log('100% Complete!');
    }
    else{
        console.log('Still loading...');
    }


}

solve(30);