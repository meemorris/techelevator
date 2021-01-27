package com.techelevator;

import processing.core.PApplet;

public class MustacheFace extends Face {


    public MustacheFace(float centerX, float centerY) {
        super(centerX, centerY);
    }

    @Override
    public void draw(PApplet sketch) {
        super.draw(sketch);
        float centerX = getCenterX();
        float centerY = getCenterY();
        sketch.strokeWeight(10);
        sketch.line(centerX - 50, centerY + 10, centerX + 50, centerY + 10);
        sketch.strokeWeight(1);
    }
}
