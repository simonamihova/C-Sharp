/*The input comes as a single number parameter. The bounders are:



· 3-13 (age) – is a child;

· 14-19 (age) – is a teenager;

· 20-65 (age) – is an adult;

· >=66 (age) – is an elder;

· In all other cases print – "out of bounds"*/ 

function ages(num){
    if(num>=0 && num<=2){
        console.log('baby');
    }
    else if(num>2 && num<=13){
        console.log('child');
    }
    else if(num>13 && num<=19){
        console.log('teenager');
    }
    else if(num>19 && num<=65){
        console.log('adult');
    }
    else if(num>65){
        console.log('elder');
    }
    else{
        console.log('out of bounds');
    }
}