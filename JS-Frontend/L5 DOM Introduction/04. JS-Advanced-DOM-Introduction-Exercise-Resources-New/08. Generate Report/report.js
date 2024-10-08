function generateReport() {

    const thElements = document.querySelectorAll('table thead th');
    const trElements = document.querySelectorAll('table tbody tr');
    const outputElement = document.getElementById('output');

    const columns = Array
        .from(thElements)
        .map(thElement => {
            const checkBoxElement = thElement.querySelector('input[type=checkbox]');
            return {
                name: thElement.textContent.toLowerCase().trim(),
                active: checkBoxElement.checked,
            }
        });

    const reportData = Array
        .from(trElements)
        .map(trElement =>{

           const tdElements = trElement.querySelectorAll('td');

           const returnResult = Array  
                .from(tdElements)
                .filter((tdElement, i) => columns[i].active)
                .reduce((data, tdElement, i) =>{
                    const columnName = columns[i].name;
                    data[columnName] = tdElement.textContent;
   
                    return data;
           }, {})
   
           return returnResult;
        })
       
    outputElement.value = JSON.stringify(reportData, null, 2);
}