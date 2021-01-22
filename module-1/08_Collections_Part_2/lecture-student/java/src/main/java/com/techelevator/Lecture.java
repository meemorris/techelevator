package com.techelevator;

import java.util.*;

public class Lecture {

    //1. removeDuplicates([1,2,1,1,2,1,2]) -> [1,2] or [2,1]
    public List<Integer> removeDuplicates(List<Integer> input) {
        Set<Integer> noDuplicates = new HashSet<>(input); //creates a new Set & passes in all items from input
        List<Integer> output = new ArrayList<>(noDuplicates); //creates a new List & passes in all items from your set list
        return output;
    }

    //2. musicalGroupNames() -> {2="duo",3="trio",4="quartet"}
    public Map<Integer,String> musicalGroupNames() {
        Map<Integer,String> musicGroups = new HashMap<>(); //create map
        musicGroups.put(2, "duo"); //populate the map
        musicGroups.put(3, "trio");
        musicGroups.put(4, "quartet");

        return musicGroups;
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
        Map<Integer,String> groups = musicalGroupNames(); //creates a map that calls this method from #1
        String result = instrument + " "; //start creating the result string with the instrument name and a space
        if (groups.containsKey(count)) { //check if the map contains a key for the specified count given (#of musicians)
            //if containsKey is false, the return value would be null
            result = result + groups.get(count); //if there is a special group name, concatenate it onto the result
        } else {
            result = result + "group";//otherwise, just concatenate the word group onto the result
        }
        return result;
    }
/*
    String groupName = groups.get(Count);
    if (groupName == null) {
        groupName = "group";
    }
    result = result + groupName;
    return result;

    --- you can check to see if you get the keyword or you can specify each option you might get like directly above
 */

    //5. totalCents({"nickel","quarter","penny","penny"}) -> 32 //since we don't know how many things are in the map we will call, we need a loop
    public int totalCents(String[] coins) {
        Map<String,Integer> values = coinValues(); //calling the method that includes the map from earlier
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
        Map<String,Integer> validate = coinValues(); //creates a copy of this map from the method coinValues
        String result = "invalid";
        if (validate.containsKey(coin)) { //don't go to a loop too quickly with a map, usually you're just pulling values out of a map
            result = "valid";
        }
        return result;
    }

    //7. stateNames({"Ohio"="Columbus","Kentucky"="Frankfort","Indiana"="Indianapolis"})
    //             -> ["Ohio","Kentucky","Indianapolis"]
    public List<String> stateNames(Map<String,String> capitals) {
        Set<String> stateSet = capitals.keySet(); //calling keySet will give me the set of all the keys from that map. Created a set because keys are a set.
        List<String> result = new ArrayList<>(stateSet); //Created a list and set its contents to be equal to the set we just created
        return result;
    }

    //8. availableColors({"red"=true,"blue"=false,"green"=true,"yellow"=true,"gray"=false})
    //                  -> ["red","green","yellow"]
    public List<String> availableColors(Map<String,Boolean> availability) {
        List<String> colors = new ArrayList<>();

        Set<Map.Entry<String,Boolean>> allEntries = availability.entrySet(); //Map.Entry is an interface like map or set or list, but it only represents a single key value pair.
        //one map entry represents a single key value pair

        //We don't actually need this variable above: can write it in one line of the for loop
        //for (Map.Entry<String,Boolean> entry : availability.entrySet())

        for (Map.Entry<String,Boolean> entry : allEntries) {
            if (entry.getValue() == true) { //if it's value is true
                colors.add(entry.getKey()); //then add its key into this list of strings called colors
            }
        }

        return colors;
    }

    /*
    Each map entry is a single key value pair.
     */

    //9. addBonus({"Player 1"=5000,"Player 2"=2500,"Player 3"=4500}, 500)
    //         -> {"Player 1"=5500,"Player 2"=3000,"Player 3"=5000}
    public void addBonus(Map<String,Integer> scores, int bonus) { //if return type is void, that is big indicator it wants you to change the map that was given (since you can't return anything)
        for (Map.Entry<String,Integer> entry : scores.entrySet()) {
            String playerName = entry.getKey(); //how you access the key
            int score = entry.getValue(); //how you access the value
            score += bonus;
            entry.setValue(score); //this updates the score that is associated with that particular player
            //so you get and you set
            // you could also put scores.put(playerName, score);
        }
    }

    //10. Modify and return the given map as follows: for this problem the map may or may not contain the
    //    "a" and "b" keys. If both keys are present, append their 2 string values together and store the
    //    result under the key "ab".
    //    mapAB({"a": "Hi", "b": "There"}) → {"a": "Hi", "ab": "HiThere", "b": "There"}
    //    mapAB({"a": "Hi"}) → {"a": "Hi"}
    //    mapAB({"b": "There"}) → {"b": "There"}

    public Map<String, String> mapAB(Map<String,String> input) {

        if(input.containsKey("a") && input.containsKey("b")) { //use this to check to make sure the map has these values
            String combinedValue = input.get("a") + input.get("b"); //use the key and then the output will be the value
            input.put("ab", combinedValue); //when you do a put you have to say what key you're putting this value under and the value you want to associate with that
        }

        return input;
    }

}
