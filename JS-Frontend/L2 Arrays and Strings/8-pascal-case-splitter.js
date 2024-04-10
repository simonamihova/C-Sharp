function solve (text){

    const matches = text.matchAll(/[A-Z][a-z]*/g);
    const result = Array.from(matches).map(match => match[0]);
    console.log(result.join(', '));

}

solve('SplitMeIfYouCanHaHaYouCantOrYouCan');