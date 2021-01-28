package com.techelevator.farm;

import java.math.BigDecimal;

public abstract class Livestock extends FarmAnimal implements Sellable {

    public Livestock(String name) {
        super(name);
    }

    public BigDecimal getPrice() {
        return null;
    }

}
