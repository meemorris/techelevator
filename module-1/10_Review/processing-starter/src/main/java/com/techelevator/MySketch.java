package com.techelevator;

import processing.core.PApplet;

public class MySketch extends PApplet {

    @Override
    public void settings() {
        size(640, 480);
    }

    @Override
    public void setup() {
        background(255);
    }

    @Override
    public void draw() { //this draw method is called 60 times per second
        fill(random(255)); //makes every color a different shade of grey
        circle(width / 2.0f, height / 2.0f, 200); //(10, 10, 50) (you could also do circle(random(width), random(height), 50)
        //if you want to get the current position of the mouse : circle(mouseX, mouseY, 50)
    }

}
