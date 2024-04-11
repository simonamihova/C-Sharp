function solve() {

  const textElement = document.getElementById('text');
  const namingElement = document.getElementById('naming-convention');
  const resultElement = document.getElementById('result');

  const text = textElement.value;
  const naming = namingElement.value;


  const convertToPascal =  (text) => text.split(' ')
      .map(word => word[0].toUpperCase + word.slice(1).toLowerCase())
      .join('');

  const convertor = {
    'Pascal Case' : convertToPascal,
    'Camel Case' : convertToPascal(text).charAt(0).toLowerCase() + convertToPascal(text).slice(1),
  }


  if(!convertor[naming]){

      resultElement.textContent = 'Error!';
      return;
  }

  resultElement.textContent = convertor[naming](text);
}