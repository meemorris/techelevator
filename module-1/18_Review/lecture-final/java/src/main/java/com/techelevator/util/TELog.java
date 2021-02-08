package com.techelevator.util;

import java.io.FileOutputStream;
import java.io.PrintWriter;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

public class TELog {
    public static void log(String message) {
        try (FileOutputStream stream = new FileOutputStream("logs/search.log", true);
             PrintWriter writer = new PrintWriter(stream)){

            LocalDateTime timestamp = LocalDateTime.now();
            DateTimeFormatter formatter = DateTimeFormatter.ofPattern("M/d/y hh:mm");
            writer.println(timestamp.format(formatter) + " : " + message);

        } catch (Exception e) {
            throw new TELogException(e.getMessage() + "occurred while trying to write " + message + " to the log.");
        }
    }

}