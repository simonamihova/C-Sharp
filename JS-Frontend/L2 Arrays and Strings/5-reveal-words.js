function replaceWordByTemplate(words, text = '') {
    let wordsArray = words.split(', ');
    let textArray = text.split(' ');

    let result  =  textArray
        .map(tWord => tWord[0] === '*' ? wordsArray.find(w => w.length === tWord.length) : tWord)
        .join(' ');
    console.log(result);
}

replaceWordByTemplate('great',

'softuni is ***** place for learning new programming languages');