package com.techelevator.util;

import java.io.FileOutputStream;
import java.io.PrintWriter;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

public class TELog {
    public static void log(String message) {
        try (FileOutputStream stream = new FileOutputStream("logs/search.log", true);
             PrintWriter writer = new PrintWriter(stream)){

            LocalDateTime timeStamp = LocalDateTime.now(); //this will represent when it was called
            DateTimeFormatter formatter = DateTimeFormatter.ofPattern("M/d/y hh:mm"); //create the format
            writer.println(timeStamp.format(formatter) + " : " + message); //tell my timestamp to use that


        } catch (Exception e) {
            throw new TELogException(e.getMessage() + "occurred while trying to write " + message + " to the log."); //if it gets an exception, it categorizes it as a custom exception and includes the message from whatever that exception was
        }
    }

}