document.addEventListener('DOMContentLoaded', function() {  
    var checkPageButton = document.getElementById('find-button'); 
    checkPageButton.addEventListener('click', function() {  
        chrome.tabs.executeScript({
            code: "window.getSelection().toString();"
          }, function(selection) {
            if(selection[0] == "") alert("rasmdan olib kelish kerak");
            else {
              console.log("salom");
              getapi();
              showResultToBrowser(selection[0]);
            }
          });        
    }, false);  
}, false);  

async function findByQuestion(search) {
  let response = await fetch("https://canny-fox-api.herokuapp.com/api/Search/");
  let data = await response.json();
  alert(data);
}

function showResultToBrowser(result) {
  // Get the snackbar DIV
  var snackbar = document.getElementById("snackbar");

  // Add the "show" class to DIV
  snackbar.className = "show";

  // After 3 seconds, remove the show class from DIV
  setTimeout(function(){ snackbar.className = snackbar.className.replace("show", ""); }, 3000);
}