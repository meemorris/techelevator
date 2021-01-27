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
    public void draw() {
        background(255);
        Face myFace = new MustacheFace( mouseX, mouseY);
        myFace.draw(this);

//        for (int i = 10; i < 400; i += 10) {
//            Face face2 = new Face(i, i);
//            face2.draw(this);
//
//        }

    }

}
