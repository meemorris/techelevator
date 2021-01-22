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
        circle(width / 2.0f, height / 2.0f, 200);
    }

}
