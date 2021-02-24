package com.techelevator;

import java.math.BigDecimal;

public class FlowerShopOrder {

    private String bouquetType;
    private int numOfRoses;
    private BigDecimal deliveryFee = new BigDecimal("0.00");
    private BigDecimal subtotal = new BigDecimal("0.00");
    private BigDecimal totalRoseCost = new BigDecimal("0.00");

    private static final BigDecimal SAME_DAY_DELIVERY = new BigDecimal("5.99");
    private static final BigDecimal ROSE_COST = new BigDecimal("2.99");
    private static final BigDecimal STANDARD_BOUQUET = new BigDecimal("19.99");


    public String getBouquetType() {
        return bouquetType;
    }

    public void setBouquetType(String bouquetType) {
        this.bouquetType = bouquetType;
    }

    public int getNumOfRoses() {
        return numOfRoses;
    }

    public void setNumOfRoses(int numOfRoses) {
        this.numOfRoses = numOfRoses;
    }

    public BigDecimal getDeliveryFee() {
        return deliveryFee;
    }

    public void setDeliveryFee(BigDecimal deliveryFee) {
        this.deliveryFee = deliveryFee;
    }

    public BigDecimal getSubtotal() {
        return subtotal;
    }

    public void setSubtotal(BigDecimal subtotal) {
        this.subtotal = subtotal;
    }

    public void setTotalRoseCost(BigDecimal totalRoseCost) {
        this.totalRoseCost = totalRoseCost;
    }

    public BigDecimal getTotalRoseCost() {
        return totalRoseCost;
    }

    public FlowerShopOrder(String bouquetType, int numOfRoses) {
        this.bouquetType = bouquetType;
        this.numOfRoses = numOfRoses;
    }

    public BigDecimal calcSubtotal() {
        if (numOfRoses > 0) {
            for (int i = 1; i <= getNumOfRoses(); i++) {
                totalRoseCost = totalRoseCost.add(ROSE_COST);
            }
            BigDecimal costWithRoses = STANDARD_BOUQUET.add(totalRoseCost);
            setSubtotal(costWithRoses);

        } else {
            setSubtotal(STANDARD_BOUQUET);
        }
        return subtotal;
    }

    public BigDecimal calcDeliveryTotal(boolean sameDayDelivery, String zipCode) {
        int numericZip = Integer.parseInt(zipCode);
        if (numericZip >= 20000 && numericZip <= 29999) {
            setDeliveryFee(new BigDecimal("3.99"));
            if (sameDayDelivery) {
                setDeliveryFee(getDeliveryFee().add(SAME_DAY_DELIVERY));
            }
        } else if (numericZip >= 30000 && numericZip <= 39999) {
            setDeliveryFee(new BigDecimal("6.99"));
            if (sameDayDelivery) {
                setDeliveryFee(getDeliveryFee().add(SAME_DAY_DELIVERY));
            }
        } else if (numericZip >= 10000 && numericZip <= 19999) {
            setDeliveryFee(new BigDecimal("0.00"));
        } else {
            setDeliveryFee(new BigDecimal("19.99"));
        }
        return deliveryFee;
    }


    @Override
    public String toString() {
        return "ORDER - {" + bouquetType + "} - {" + numOfRoses + "} roses - {$" + subtotal + "}";
    }
}
