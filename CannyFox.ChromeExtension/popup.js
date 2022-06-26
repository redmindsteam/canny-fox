document.addEventListener('DOMContentLoaded', function() {  
    var checkPageButton = document.getElementById('checkPage'); 
    alert("salom"); 
    checkPageButton.addEventListener('click', function() {  
        chrome.tabs.getSelected(null, function(tab) {  
            d = document;  
            window.open('https://www.google.com/search?q=mindflow', 'blank');  
        });
        alert("bosildi"); 
    }, false);  
}, false);  
