package com.techelevator;

import java.util.*;

public class Lecture {

    //1. removeDuplicates([1,2,1,1,2,1,2]) -> [1,2] or [2,1]
    public List<Integer> removeDuplicates(List<Integer> input) {
        Set<Integer> noDuplicates = new HashSet<>(input);
        List<Integer> output = new ArrayList<>(noDuplicates);
        return output;
    }

    //2. musicalGroupNames() -> {2="duo",3="trio",4="quartet"}
    public Map<Integer,String> musicalGroupNames() {
        Map<Integer,String> groupNames = new HashMap<>();
        groupNames.put(2, "duo");
        groupNames.put(3, "trio");
        groupNames.put(4, "quartet");
        return groupNames;
    }

    //3. coinValues() -> {"penny"=1,"nickel"=5,"dime"=10,"quarter"=25}
    public Map<String,Integer> coinValues() {
        Map<String,Integer> coins = new HashMap<>();
        coins.put("penny", 1);
        coins.put("nickel", 5);
        coins.put("dime", 10);
        coins.put("quarter", 25);
        return coins;
    }

    //4. describeGroup(3, "violin") -> "violin trio"
    //   describeGroup(0, "trumpet") -> "trumpet group"
    public String describeGroup(int count, String instrument) {
        Map<Integer,String> groups = musicalGroupNames(); //get the map we created above
        String result = instrument + " "; //start creating the result string with the instrument name and a space
        /*
        if (groups.containsKey(count)) { //check if the map contains a key for the specified number of musicians
            result = result + groups.get(count); //if there is a special group name concatenate it onto the result
        } else {
            result = result + "group";     //otherwise, just concatenate the word "group" onto the result
        }
        */
        String groupName = groups.get(count);
        if (groupName == null) {
            groupName = "group";
        }
        result = result + groupName;
        return result;
    }

    //5. totalCents({"nickel","quarter","penny","penny"}) -> 32
    public int totalCents(String[] coins) {
        Map<String,Integer> values = coinValues();
        int total = 0;
        for (String coin : coins) {
            int value = values.get(coin);
            total += value;
        }
        return total;
    }

    //6. validCoin("dime") -> "valid"
    //   validCoin("token") -> "invalid"
    public String validCoin(String coin) {
        Map<String,Integer> validate = coinValues();
        String result = "invalid";
        if (validate.containsKey(coin)) {
            result = "valid";
        }
        return result;
    }

    //7. stateNames({"Ohio"="Columbus","Kentucky"="Frankfort","Indiana"="Indianapolis"})
    //             -> ["Ohio","Kentucky","Indianapolis"]
    public List<String> stateNames(Map<String,String> capitals) {
        Set<String> stateSet = capitals.keySet();
        List<String> result = new ArrayList<>(stateSet);
        return result;
    }

    //8. availableColors({"red"=true,"blue"=false,"green"=true,"yellow"=true,"gray"=false})
    //                  -> ["red","green","yellow"]
    public List<String> availableColors(Map<String,Boolean> availability) {
        List<String> colors = new ArrayList<>();
        for (Map.Entry<String,Boolean> entry : availability.entrySet()) {
            if (entry.getValue() == true) {
                colors.add(entry.getKey());
            }
        }
        return colors;
    }

    //9. addBonus({"Player 1"=5000,"Player 2"=2500,"Player 3"=4500}, 500)
    //         -> {"Player 1"=5500,"Player 2"=3000,"Player 3"=5000}
    public void addBonus(Map<String,Integer> scores, int bonus) {
        for (Map.Entry<String,Integer> entry : scores.entrySet()) {
            String playerName = entry.getKey(); //this is available but not used
            int score = entry.getValue();
            score += bonus;
            entry.setValue(score); //or scores.put(playerName, score);
        }
    }

    //10. Modify and return the given map as follows: for this problem the map may or may not contain the
    //    "a" and "b" keys. If both keys are present, append their 2 string values together and store the
    //    result under the key "ab".
    //    mapAB({"a": "Hi", "b": "There"}) → {"a": "Hi", "ab": "HiThere", "b": "There"}
    //    mapAB({"a": "Hi"}) → {"a": "Hi"}
    //    mapAB({"b": "There"}) → {"b": "There"}

    public Map<String, String> mapAB(Map<String,String> input) {
        if (input.containsKey("a") && input.containsKey("b")) {
            String combinedValue = input.get("a") + input.get("b");
            input.put("ab", combinedValue);
        }
        return input;
    }

}
