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
        //fill(random(255)); //makes every color a different shade of grey
       // Face myFace = new Face(width / 2.0f, height / 2.0f);

        //you can do background(255); if you want it to clear it and just look like the face is moving around
//        Face myFace = new Face(mouseX, mouseY);
//        myFace.draw(this);
        Face myFace = new MustacheFace(mouseX, mouseY);
        myFace.draw(this);

//        for (int i = 10; i < 400; i += 10) {
//            Face face2 = new Face(i, i);
//            face2.draw(this);
//        }




    }
}
