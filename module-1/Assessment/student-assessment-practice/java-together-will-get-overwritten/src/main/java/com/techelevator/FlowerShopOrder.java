package com.techelevator;

import java.math.BigDecimal;
import java.util.BitSet;

public class FlowerShopOrder {

    private String bouquetType;
    private int numRoses;
    private BigDecimal subTotal;

    public String getBouquetType(){
        return bouquetType;
    }

    public int getNumRoses(){
        return numRoses;
    }

    public BigDecimal getSubTotal(){
        subTotal = new BigDecimal("19.99");
        for(int i=0; i<numRoses;i++){
            subTotal = subTotal.add(new BigDecimal("2.99"));
        }
        return subTotal;
    }

    public FlowerShopOrder(String bouquetType, int numRoses){
        this.bouquetType = bouquetType;
        this.numRoses = numRoses;
    }

    /*
    The delivery fee is $3.99 if the zip code falls between 20000 and 29999 (+$5.99 for same-day delivery).
    The delivery fee is $6.99 if the zip code falls between 30000 and 39999 (+$5.99 for same-day delivery).
    The delivery fee is waived ($0.00) if the zip code falls between 10000 and 19999.
    All other zip codes cost $19.99 (same-day delivery is not an option).
     */
    public BigDecimal calcDeliveryTotal(boolean isSameDay,String zip){
        BigDecimal deliverFee = new BigDecimal("0");
        int intZip = 0;
        try {
            intZip = Integer.parseInt(zip);
        }
        catch (Exception e){
            return BigDecimal.ZERO;
        }
        if (intZip>=20000 && intZip <=29999){
            deliverFee = new BigDecimal("3.99");
            if (isSameDay){
                deliverFee = deliverFee.add(new BigDecimal("5.99"));
            }
        }
        else if (30000<= intZip && intZip <=39999){
            deliverFee = new BigDecimal("6.99");
            if (isSameDay){
                deliverFee = deliverFee.add(new BigDecimal("5.99"));
            }
        }
        else if (10000<= intZip && intZip <=19999) {
            deliverFee = BigDecimal.ZERO;

        }
        else {
            deliverFee = new BigDecimal("19.99");
        }
        return deliverFee;
    }

    @Override
    public String toString() {
        //ORDER - {bouquet type} - {number of roses} roses - {subtotal}"
        //i have to call getSubTotal because the subTotal is zero until after that's called
        return "ORDER - "+bouquetType+" - "+numRoses+" roses - "+ getSubTotal();
    }

}
