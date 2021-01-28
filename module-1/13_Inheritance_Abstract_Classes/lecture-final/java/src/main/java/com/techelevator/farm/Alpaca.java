package com.techelevator.farm;

import java.math.BigDecimal;

public class Alpaca extends Livestock {

    public Alpaca() {
        super("Alpaca");
    }

    @Override
    public String makeSound() {
        return "Ptoo";
    }

    @Override
    public String getArticle() {
        return "an";
    }

    @Override
    public BigDecimal getPrice() {
        return new BigDecimal("10000.00");
    }
}
