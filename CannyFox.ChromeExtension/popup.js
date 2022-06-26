document.addEventListener('DOMContentLoaded', function() {  
    var checkPageButton = document.getElementById('find-button'); 
    checkPageButton.addEventListener('click', function() {  
        chrome.tabs.executeScript({
            code: "window.getSelection().toString();"
          }, function(selection) {
            if(selection[0] == "") alert("rasmdan olib kelish kerak");
            else alert(selection[0]);
          });        
    }, false);  
}, false);  
