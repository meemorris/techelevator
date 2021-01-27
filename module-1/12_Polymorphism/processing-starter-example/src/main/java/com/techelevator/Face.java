package com.techelevator;

import processing.core.PApplet;

public class Face {

    private float centerX;
    private float centerY;

    public Face(float centerX, float centerY) {
        this.centerX = centerX;
        this.centerY = centerY;
    }

    public float getCenterX() {
        return centerX;
    }

    public float getCenterY() {
        return centerX;
    }

    public void draw(PApplet sketch) {
        sketch.circle(centerX, centerY, 200); //(10, 10, 50) (you could also do circle(random(width), random(height), 50)
        //if you want to get the current position of the mouse : circle(mouseX, mouseY, 50)
        sketch.ellipse(centerX - 30, centerY - 40, 20, 40);
        sketch.ellipse(centerX + 30, centerY - 40, 20, 40);
        sketch.curve(centerX - 70, centerY - 130, centerX - 50, centerY + 30, centerX + 50, centerY + 30, centerX + 70, centerY - 130);
    }
    }

