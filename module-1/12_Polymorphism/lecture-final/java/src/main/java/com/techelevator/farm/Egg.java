package com.techelevator.farm;

import java.math.BigDecimal;

public class Egg implements Sellable {
    @Override
    public BigDecimal getPrice() {
        return new BigDecimal("1.00");
    }

    @Override
    public String getName() {
        return "egg";
    }
}
