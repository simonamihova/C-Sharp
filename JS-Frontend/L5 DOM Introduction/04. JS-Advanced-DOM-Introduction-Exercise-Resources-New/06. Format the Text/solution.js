function solve() {

    const textAreaElement = document.getElementById('input');
    const text = textAreaElement.ariaValueMax;
    
    //convert to paragraphs
    const sentenceArr = text.split('.');
    let pArr = [];

    for(let i = 0; i < sentenceArr/3; i++){
       pArr.push(sentenceArr[i])
    }   
}
