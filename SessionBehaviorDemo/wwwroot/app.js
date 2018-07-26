function listSession() {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState === 4 && this.status === 200) {
            document.getElementById("sessionListResponse").innerHTML = this.responseText;
        }
    };
    xhttp.open("GET", "/Session/List", true);
    xhttp.send();
}

function loadShort() {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState === 4 && this.status === 200) {
            document.getElementById("shortCallResponse").innerHTML = this.responseText;
        }
    };
    xhttp.open("GET", "/Session/Short", true);
    xhttp.send();
}

function loadLong() {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState === 4 && this.status === 200) {
            document.getElementById("longCallResponse").innerHTML = this.responseText;
            listSession();
        }
    };
    xhttp.open("GET", "/Session/Long", true);
    xhttp.send();
}

setTimeout(loadShort, 1000);
loadLong();