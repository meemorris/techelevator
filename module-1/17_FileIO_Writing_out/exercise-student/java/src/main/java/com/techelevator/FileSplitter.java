package com.techelevator;

import java.io.*;
import java.nio.file.FileAlreadyExistsException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class FileSplitter {

	public static void main(String[] args) {


		Scanner user = new Scanner(System.in);

		System.out.print("Where is the input file (please include the path to the file)? ");
		String inputFile = user.nextLine();
		Path inputPath = Path.of(inputFile);

		//Getting file name components
		String[] path = inputFile.split("\\\\");
		String containsFileName = path[path.length - 1];
		String[] fileNameComponents = containsFileName.split("\\.");
		String firstPartOfName = fileNameComponents[0];
		String fileType = fileNameComponents[1];

		//Getting directory
		String[] directory = inputFile.split("\\.");
		String dirAndPrefix = directory[0];

		//Getting directory - initial approach :)
//		String delimiter = "/";Syste
//		StringBuilder directoryPrep = new StringBuilder(); //like a mutable string, meant to be added on to
//		for (int i = 0; i < path.length - 1; i++) {
//			directoryPrep.append(path[i]).append(delimiter);
//		}
//		Path directory = Path.of(String.valueOf(directoryPrep)); //inputPath.getParent
//		String prefix = directory.getFileName() + fileNameComponents[0];

		System.out.print("How many lines of text (max) should there be in the split files? ");
		int maxLines = Integer.parseInt(user.nextLine());
		System.out.println("**Cooking it all up**");

		try (Scanner inputScanner = new Scanner(inputPath)) {
			try {
				int sequentialNum = 0;
				while (inputScanner.hasNextLine()) {
					sequentialNum++;
					String fileWithPath = dirAndPrefix + "-" + sequentialNum + "." + fileType;
					String fileName = firstPartOfName + "-" + sequentialNum + "." + fileType;
					PrintWriter filesWriter = new PrintWriter(fileWithPath);
					int counter = 1;
					while (counter <= maxLines) {
						String line = inputScanner.nextLine();
						filesWriter.println(line);
						counter++;
						if (counter > maxLines) {
							System.out.println("Generating " + fileName);
							filesWriter.flush();
						}
					}
					if (!inputScanner.hasNextLine()) {
						filesWriter.close();
					}
				}
			} catch (Exception e) {
				System.out.println("That file already exists.");
			}
		} catch (IOException e) {
			System.out.println("Couldn't read from input file.");
		}


	}

}
