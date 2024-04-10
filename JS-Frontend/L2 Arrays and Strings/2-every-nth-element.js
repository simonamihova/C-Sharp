function printEl(arr, num){
    let currentIndex = 0;
    let tempArr = [];
    for(let i = 0; i < arr.length; i+=num){
        tempArr.push(arr[currentIndex]);
        currentIndex += num;
    }  
    return tempArr;
}

printEl(['5','20','31','4','20'],2);