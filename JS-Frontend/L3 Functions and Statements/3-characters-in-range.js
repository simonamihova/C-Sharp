function solve(start, end){
    
    let tempArr = [start, end];
    tempArr = tempArr.sort();
    function getElementsBetween(start, end){

        let charArr = [];

        for(let i = start.charCodeAt(0)+1; i < end.charCodeAt(0); i++){
            charArr.push(String.fromCharCode(i));
        }

        return charArr;
    }

    console.log(getElementsBetween(tempArr[0], tempArr[1]).join(' '));
}