function solve(input){

    const baristaCount = Number(input.shift);
    const team = {};

    //prepare team
    for(let i = 0; i < baristaCount; i++){
        const [name, shift, cofeeTypes] = input[i].split(' ');
        team[name] = {
            shift : shift,
            cofeeTypes : cofeeTypes.split(','),
        }
    }

    //execute command

    let commandLine = input.shift().split(' / ');

    while(commandLine !== 'Closed'){

        let command = commandLine.shift();

        let baristaName = commandLine.shift();
        
        if (command === 'Prepare'){

            let baristaShiftt = commandLine[0];
                


        }else if(command === 'Change Shift'){

        }else if(command === 'Learn'){

        }
    }
}