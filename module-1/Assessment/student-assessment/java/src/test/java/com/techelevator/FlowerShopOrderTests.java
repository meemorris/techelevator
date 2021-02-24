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

    @Test
    public void calcDeliveryTotal_calculates_delivery_for_20000_to_29999() {
        FlowerShopOrder sut = new FlowerShopOrder("Lilies", 24);

        BigDecimal deliveryFee = sut.calcDeliveryTotal(false, "25000");

        Assert.assertEquals(new BigDecimal("3.99"), deliveryFee);
    }

    @Test
    public void calcDeliveryTotal_calculates_delivery_for_20000_to_29999_same_day_delivery() {
        FlowerShopOrder sut = new FlowerShopOrder("Lilies", 24);

        BigDecimal deliveryFee = sut.calcDeliveryTotal(true, "25000");

        Assert.assertEquals(new BigDecimal("9.98"), deliveryFee);
    }

    @Test
    public void calcDeliveryTotal_calculates_delivery_for_30000_to_39999() {
        FlowerShopOrder sut = new FlowerShopOrder("Lilies", 24);

        BigDecimal deliveryFee = sut.calcDeliveryTotal(false, "35000");

        Assert.assertEquals(new BigDecimal("6.99"), deliveryFee);
    }

    @Test
    public void calcDeliveryTotal_calculates_delivery_for_30000_to_39999_same_day_delivery() {
        FlowerShopOrder sut = new FlowerShopOrder("Lilies", 24);

        BigDecimal deliveryFee = sut.calcDeliveryTotal(true, "35000");

        Assert.assertEquals(new BigDecimal("12.98"), deliveryFee);
    }

    @Test
    public void calcDeliveryTotal_calculates_delivery_for_10000_to_19999() {
        FlowerShopOrder sut = new FlowerShopOrder("Lilies", 24);

        BigDecimal deliveryFee = sut.calcDeliveryTotal(false, "15000");

        Assert.assertEquals(new BigDecimal("0.00"), deliveryFee);
    }

    @Test
    public void calcDeliveryTotal_calculates_zip_codes_below_ranges() {
        FlowerShopOrder sut = new FlowerShopOrder("Lilies", 24);

        BigDecimal deliveryFee = sut.calcDeliveryTotal(false, "5000");

        Assert.assertEquals(new BigDecimal("19.99"), deliveryFee);
    }

    @Test
    public void calcDeliveryTotal_calculates_zip_codes_above_ranges() {
        FlowerShopOrder sut = new FlowerShopOrder("Lilies", 24);

        BigDecimal deliveryFee = sut.calcDeliveryTotal(false, "40000");

        Assert.assertEquals(new BigDecimal("19.99"), deliveryFee);
    }


}
