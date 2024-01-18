let platno = document.getElementById("platno");
let kontext = platno.getContext("2d");
let stredKruhuX = 100;
let stredKruhuY = 100;
 
platno.onmousemove = function(event) {
    stredKruhuX = event.clientX;
    stredKruhuY = event.clientY;
}
 
function nakresli() {
    kontext.clearRect(0, 0, platno.width, platno.height);
    kontext.beginPath();
    kontext.arc(stredKruhuX, stredKruhuY, 50, 0, 2 * Math.PI);
    kontext.fill();
    kontext.fillRect(300, 300, 100, 100);
    requestAnimationFrame(nakresli);
}
 
nakresli(); 