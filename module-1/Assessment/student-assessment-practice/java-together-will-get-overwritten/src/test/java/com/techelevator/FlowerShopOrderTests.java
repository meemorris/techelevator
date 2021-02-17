package com.techelevator;

import org.junit.Assert;
import org.junit.Test;

import java.math.BigDecimal;

public class FlowerShopOrderTests {
    @Test
    public void test_subtotal_no_roses()
    {
        FlowerShopOrder myOrder =  new FlowerShopOrder("stuff",0);
        BigDecimal expected = new BigDecimal("19.99");
        Assert.assertEquals(expected,myOrder.getSubTotal());
    }
    @Test
    public void test_subtotal_some_roses()
    {
        FlowerShopOrder myOrder =  new FlowerShopOrder("stuff",4);
        BigDecimal expected = new BigDecimal("31.95");
        Assert.assertEquals(expected,myOrder.getSubTotal());
    }

    @Test
    public void test_zip_starts_with_1_is_freebie() {
        FlowerShopOrder myOrder =  new FlowerShopOrder("stuff",4);
        BigDecimal actual = myOrder.calcDeliveryTotal(false,"10000");
        Assert.assertEquals(BigDecimal.ZERO, actual);

        myOrder =  new FlowerShopOrder("stuff",4);
        actual = myOrder.calcDeliveryTotal(true,"10000");
        Assert.assertEquals(BigDecimal.ZERO, actual);
    }

    /* There should be more tests for the calcDelivery but that can be an exercise for the reader*/
}
