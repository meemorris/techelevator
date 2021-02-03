package com.techelevator;

import java.io.FileOutputStream;
import java.io.IOException;
import java.io.PrintWriter;
import java.nio.file.*;
import java.util.Scanner;

public class Examples {

	private final Scanner userInput = new Scanner(System.in);

    public static void main(String[] args) {
    	Examples examples = new Examples();

//		examples.inspectFilesystem();
//		examples.createDirectory();
//		examples.createOrReplaceFile();
//		examples.addToFile();
	}
	
	private String promptForString(String prompt) {
		System.out.print(prompt);
		return userInput.nextLine();
	}

	private void inspectFilesystem() {
		String input = promptForString("Enter the path of a file or directory >>> ");
		Path path = Path.of(input);

        if (Files.exists(path)) {
            path = path.toAbsolutePath();
			System.out.println(path + " exists.");
			if (Files.isDirectory(path)) {
				System.out.println("Type: Directory");
			} else if (Files.isRegularFile(path)) {
				System.out.println("Type: File");
				try {
                    System.out.println("Size: " + Files.size(path));
                } catch (IOException e) {
				    System.out.println("Couldn't get file size.");
                }
			}
		} else {
			System.out.println("File does not exist.");
		}
    }

    private void createDirectory() {
    	String input = promptForString("Enter the path of a new directory: ");
    	Path newDir = Path.of(input);
    	try {
			Files.createDirectory(newDir);
			System.out.println("Directory created.");
		} catch (FileAlreadyExistsException e) {
    		System.out.println("That directory already exists.");
		} catch (IOException e) { //the other exceptions listed as possible under createDirectory method are most likely children of IOException so it works like a catch all
    		System.out.println("Unable to create directory.");
		}
	}

	private void createOrReplaceFile() {
    	String target = promptForString("Enter the path of the file to create or replace: ");
    	String content = promptForString("Enter content for the file: ");

    	try (PrintWriter writer = new PrintWriter(target);){ //we don't need to create a Path object can pass the path directly to PrintWriter, putting it in try with resources, you won't have to close it
    		writer.println(content); //instead of going out to the screen it goes out to the file
//    		writer.close();
    		System.out.println("File has been created (or replaced).");
		} catch (IOException e) {
    		System.out.println("Couldn't create or replace file.");
		}
	}

	private void addToFile() {
		String target = promptForString("Enter the path of the file to be added to: ");
		String content = promptForString("Enter additional content for the file: ");

		try (FileOutputStream stream = new FileOutputStream(target, true);
			 PrintWriter writer = new PrintWriter(stream)){
			//create first (target is name of file we want to append to, set the second to true, that we want to append)
			//Pass PrintWriter the stream you created rather than the file name. Now you will be adding not overwriting
			writer.println(content);
//			writer.close(); //you need to close both of these
//			stream.close();
			System.out.println("File has been added to.");
		} catch (IOException e) {
			System.out.println("Couldn't append to file.");
		}
	}
}
