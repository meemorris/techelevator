package com.techelevator;

import org.junit.Assert;
import org.junit.Test;

import java.math.BigDecimal;

public class FlowerShopOrderTests {

    @Test
    public void calcSubtotal_calculates_standard_bouquet() {
        FlowerShopOrder sut = new FlowerShopOrder("Daisies", 0);

        BigDecimal subtotal = sut.calcSubtotal();
        Assert.assertEquals(new BigDecimal("19.99"), subtotal);
    }

    @Test
    public void calcSubtotal_calculates_standard_bouquet_and_extra_roses() {
        FlowerShopOrder sut = new FlowerShopOrder("Lilies", 24);

        BigDecimal subtotal = sut.calcSubtotal();
        Assert.assertEquals(new BigDecimal("91.75"), subtotal);
    }

    //didn't finish

}
