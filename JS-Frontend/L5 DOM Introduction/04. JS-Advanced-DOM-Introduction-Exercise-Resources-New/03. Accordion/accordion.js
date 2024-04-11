function toggle() {

    const buttonElement = document.getElementsByClassName("button")[0];
    const buttonText = buttonElement.textContent;

    const divElement = document.getElementById('extra');

    if(buttonText === 'More'){

        divElement.style.display = 'block';
        buttonElement.textContent = 'Less';

    }else{

        divElement.style.display = 'none';
        buttonElement.textContent = 'More';
    }


}