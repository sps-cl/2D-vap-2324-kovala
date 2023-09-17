let bird = getImage("obrázky/bird.png") ;
let gameBackground = getImage("obrázky/background.png");
let birdX = canvasWidth / 4;
let birdY = canvasHeight / 2;

let birdSpeed = 0;

let spacePressed = false;

let wallSpeed = -3;

let wallX = 1200;
let wallY = 0;
let wallWidth = 210;
let gapY = canvasHeight / 2;
let gapHeight = 100;

function resetWall(){
    wallX = canvasWidth;
    walY = 0;
    wallWidth = 210;
    gapY = canvasHeight / 2;
    gapHeight = 100;
}

function drawWall() {
    fill(0, 255, 0);
    rect(wallX, wallY, wallWidth, gapY - gapHeight);
    rect(wallX, gapY + gapHeight, wallWidth, canvasHeight - gapY - gapHeight)
}

setup = function () {
    createCanvas(1200, 700);
}

draw = function() {
    image(gameBackground, 0, 0, canvasWidth, canvasHeight);
    rotatedImage(bird, birdX, birdY, birdSpeed * 15);
    drawWall();

    if (isKeyPressed(" ")) {
        if (spacePressed < 21) {
            birdSpeed = -3;
        }
        spacePressed++;
    } else {
        spacePressed = 0;
    }
    birdSpeed += 0.1;
    birdY += birdSpeed;
    wallX += wallSpeed;

    if (birdSpeed > 3)
        birdSpeed = 3;
}
