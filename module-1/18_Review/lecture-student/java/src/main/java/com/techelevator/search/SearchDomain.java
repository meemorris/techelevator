package com.techelevator.search;

import java.nio.file.DirectoryStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.ArrayList;
import java.util.List;

/**
 * The Search Domain is a list of files to be read and indexed by the Search Engine.
 *
 * Folders are NOT recursively searched.
 */
public class SearchDomain {

	private final String folder;
	private final List<String> files;

	/**
	 * Create a Search Domain of a folder
	 *
	 * @param folder
	 * @throws SearchDomainException
	 */
	public SearchDomain(String folder) throws SearchDomainException {
		this.folder = folder;
		this.files = buildDomain();
	}

	public String getFolder() {
		return folder;
	}

	public List<String> getFiles() {
		return files;
	}

	@Override
	public String toString() {
		String result = "";
		for (String file : files) {
			result += file + "\n";
		}
		return result;
	}

	/**
	 * Folders are NOT recursively searched.
	 *
	 * @return
	 * @throws SearchDomainException
	 */
	private List<String> buildDomain() throws SearchDomainException {
		List<String> files = new ArrayList<>();

		Path dir = Path.of(folder);
		try (DirectoryStream<Path> allFilesInDir = Files.newDirectoryStream(dir)) {
			for (Path file: allFilesInDir) {
				files.add(file.toString());
			}
		} catch (Exception e) {
			throw new SearchDomainException(e.getMessage());
		}

		return files;
	}

}
