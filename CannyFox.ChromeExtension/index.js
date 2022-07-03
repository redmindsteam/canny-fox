async function getapi() {

    let response = await fetch("https://canny-fox-api.herokuapp.com/api/Tests");
    
    // Storing data in form of JSON
    let data = await response.json();

    console.log(data);

}
getapi();