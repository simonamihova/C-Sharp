//ex.1
function multiplyByTwo(a){
    console.log(a*2);
}
//multiplyByTwo(10);

//ex. 2
function printStudentInfo(name, age, avgGrade){
    console.log(`Name: ${name}, Age: ${age}, Grade: ${avgGrade.toFixed(2)}`);
}
//printStudentInfo('Pesho', 20, 5.567890);

//ex.3
function checkGrade(num){
    if(num >= 5.50){
        console.log('Excellent');
    }
    else{
        console.log('Not excellent');
    }
}

//checkGrade(5);
//checkGrade(5.80);

//ex.4
function printMonth(num){
    switch (num){
        case 1:
            console.log('January');
            break;
        case 2:
            console.log('February');
            break;
        case 3:
            console.log('March');
            break;
        case 4:
            console.log('April');
            break;
        case 5:
            console.log('May');
            break;
        case 6:
            console.log('June');
            break;
        case 7:
            console.log('July');
            break;
        case 8:
            console.log('August');
            break;
        case 9:
            console.log('September');
            break;
        case 10:
            console.log('October');
            break;
        case 11:
            console.log('November');
            break;
        case 12:
            console.log('December');
            break;
        default:
            console.log('Error');
            break;

    }

}

//printMonth(5);
//printMonth(30);


//ex.5
//  '+', '-', '*', '/', '%', '**'

function calc(a, b, operator){
    switch(operator){
        case '+':
            console.log(a+b);
            break;
        case '-':
            console.log(a-b);
            break;
        case '*':
            console.log(a*b);
            break;
        case '/':
            console.log(a/b);
            break;
        case '%':
            console.log(a%b);
            break;
        case '**':
            console.log(a**b);
            break;
        default:
            console.log('Error');
            break;
    }
}

//calc(2,5,'*');

//ex.6