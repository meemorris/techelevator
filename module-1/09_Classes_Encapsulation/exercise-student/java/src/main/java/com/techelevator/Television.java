package com.techelevator;

public class Television {
    private boolean on = false;
    private int currentChannel = 3;
    private int currentVolume = 2;

    public boolean isOn() {
        return on;
    }

    public int getCurrentChannel() {
        return currentChannel;
    }

    public int getCurrentVolume() {
        return currentVolume;
    }

    public void turnOff() {
        on = false;
    }

    public void turnOn() {
        on = true;
        currentChannel = 3;
        currentVolume = 2;
    }

    public void changeChannel(int newChannel) {
        if (on && newChannel >= 3 && newChannel <= 18) {
            currentChannel = newChannel;
        }
    }

    public void channelUp() {
        if (on && currentChannel < 18) {
            currentChannel++;
        } else if (on && currentChannel >= 18) {
            currentChannel = 3;
        }
    }

    public void channelDown() {
        if (on && currentChannel > 3) {
            currentChannel--;
        } else if (on && currentChannel == 3) {
            currentChannel = 18;
        }
    }


    public void raiseVolume() {
        if (on && currentVolume < 10) {
            currentVolume++;
        }
    }

    public void lowerVolume() {
        if (on && currentVolume > 0) {
            currentVolume--;
        }
    }


}

