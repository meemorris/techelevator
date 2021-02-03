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

		//examples.inspectFilesystem();
		//examples.createDirectory();
		//examples.createOrReplaceFile();
		examples.addToFile();
	}
	
	private String promptForString(String prompt) {
		System.out.print(prompt);
		return userInput.nextLine();
	}

	private void inspectFilesystem() {
		String input = promptForString("Enter the path of a file or directory >>> ");
		Path path = Path.of(input);

        if (Files.exists(path)) {
            Path absolutePath = path.toAbsolutePath();
			System.out.println(absolutePath + " exists.");
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
		} catch (IOException e) {
    		System.out.println("Unable to create directory.");
		}
	}

	private void createOrReplaceFile() {
    	String target = promptForString("Enter the path of the file to create or replace: ");
    	String content = promptForString("Enter content for the file: ");

    	try (PrintWriter writer = new PrintWriter(target)) {
    		writer.println(content);
    		//writer.close();
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

			writer.println(content);
			System.out.println("File has been added to.");
		} catch (IOException e) {
			System.out.println("Couldn't append to file.");
		}
	}
}
