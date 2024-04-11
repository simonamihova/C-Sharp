function solve(currentStock, productsOrdered){

    const store = {};//associative array NOT OBJECT

    for(let i = 0; i < currentStock.length; i += 2){

        const product = currentStock[i];
        const quantity = Number(currentStock[i+1]);

        store[product] = quantity;
    }

    for(let i =  0; i < productsOrdered.length; i += 2){

        const product = productsOrdered[i];
        const quantity = Number(productsOrdered[i+1]);

        if(!store[product]){
            store[product] = 0;
        }

        store[product] += quantity;

    }

    for(const product in store){
        console.log(`${product} -> ${store[product]}`);
    }

}

solve([

    'Chips', '5', 'CocaCola', '9', 'Bananas', '14', 'Pasta', '4', 'Beer', '2'
    
    ],
    
    [
    
    'Flour', '44', 'Oil', '12', 'Pasta', '7', 'Tomatoes', '70', 'Bananas', '30'
    
    ]);