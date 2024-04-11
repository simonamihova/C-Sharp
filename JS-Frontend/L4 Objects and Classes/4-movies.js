function solve(input){

    const movies = [];

    for (line of input){

        const addMovieCommand = 'addMovie';
        const directedByCommand = 'directedBy';
        const onDateCommand = 'onDate';
        if (line.includes(addMovieCommand)){

            const movieName = line.substring(addMovieCommand.length + 1);

            const movie = {
                name : movieName
            };

            movies.push(movie)

        }else if(line.includes(directedByCommand)){

            const[movieName, director] = line.split(` ${directedByCommand} `);
            const movie = movies.find(m => m.name === movieName);

            if(movie){
                movie.director = director;
            }

        }else if(line.includes(onDateCommand)){

            const[movieName, movieDate] = line.split(` ${onDateCommand} `);
            const movie = movies.find(m => m.name === movieName);

            if(movie){
                movie.date = movieDate;
            }

        } 
        
        
    }

    for(const movie of movies){
        if(movie.director && movie.date){

        console.log(JSON.stringify(movie));
        }
    }

}

solve([

    'addMovie Fast and Furious',
    
    'addMovie Godfather',
    
    'Inception directedBy Christopher Nolan',
    
    'Godfather directedBy Francis Ford Coppola',
    
    'Godfather onDate 29.07.2018',
    
    'Fast and Furious onDate 30.07.2018',
    
    'Batman onDate 01.08.2018',
    
    'Fast and Furious directedBy Rob Cohen'
    
    ])