function search() {

   const townListElement = document.getElementById('towns');
   const searchElement = document.getElementById('searchText');
   const resultElement = document.getElementById('result');
   const searchText = searchElement.value;

   let matchCount = 0;

   const towns = Array.from(townListElement.children);

   for(const town of towns){
      if(town.textContent.toLowerCase().includes(searchText.toLowerCase())){
         town.style.textDecoration = 'underline';
         town.style.fontWeight = 'bold';

         matchCount++;
      }
   }

   resultElement.textContent = `${matchCount} matches found`

}
