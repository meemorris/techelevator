package com.techelevator.util;

import java.io.FileOutputStream;
import java.io.PrintWriter;

public class TELog {
    public static void log(String message) {
        try (FileOutputStream stream = new FileOutputStream("logs/search.log", true);
             PrintWriter writer = new PrintWriter(stream)){

            writer.println(message);

        } catch (Exception e) {
            throw new TELogException(e.getMessage());
        }
    }

}