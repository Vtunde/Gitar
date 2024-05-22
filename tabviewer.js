var interval
var scrollSpeed = 1

function autoscroll(){
    window.scrollBy(0,scrollSpeed)
}

function tryAutoscroll(){
    x = document.getElementById("autoscroll").checked;
    if (x){
        // scrollSpeed = document.getElementById("scrollSpeed").value
        console.log(scrollSpeed)
        interval = setInterval(autoscroll, 50)
    }
    else{ clearInterval(interval) }
}

var fontSize = 18
function decreaseFont(){
    fontSize--
    document.getElementById("tab").style.fontSize = fontSize + "px";
}

function increaseFont(){
    fontSize++
    document.getElementById("tab").style.fontSize = fontSize + "px";
}