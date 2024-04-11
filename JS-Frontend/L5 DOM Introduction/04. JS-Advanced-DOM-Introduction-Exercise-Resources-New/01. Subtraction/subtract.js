function subtract() {

    const firstNumberElement = document.getElementById('firstNumber');
    const secondNumberElemet = document.getElementById('secondNumber');
    const resultElemet = document.getElementById('result');

    const firstElement = Number(firstNumberElement.value);
    const secondElement = Number(secondNumberElemet.value);
    const subtractionResult = firstElement - secondElement;

    resultElemet.textContent = subtractionResult;


}