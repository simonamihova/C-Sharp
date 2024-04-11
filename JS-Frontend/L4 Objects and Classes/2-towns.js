function solve(input){

    const towns = [];

    for(const line of input){

        const [townName, townlatitude, townlongitude] = line.split(' | ');
        const obj = {
            town : townName,
            latitude : parseFloat(townlatitude).toFixed(2),
            longitude : parseFloat(townlongitude).toFixed(2),
        };
        towns.push(obj);
    
    }

    towns.forEach(town => {
        console.log(town);
    });
}

solve(['Sofia | 42.696552 | 23.32601', 'Beijing | 39.913818 | 116.363625']);