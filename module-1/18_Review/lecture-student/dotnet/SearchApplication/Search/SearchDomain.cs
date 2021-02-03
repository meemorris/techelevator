using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SearchApplication.Search
{
    /// <summary>
    /// The Search Domain is a list of files to be read and indexed by the Search Engine.
    /// Folders are NOT recursively searched.
    /// </summary>
    public class SearchDomain
    {
        public string Folder { get; }
        public IList<string> Files { get; }

		/// <summary>
		/// Create a Search Domain of a folder
		/// </summary>
		/// <param name="folder">Path of folder to index</param>
        public SearchDomain(string folder)
        {
            Folder = folder;
            Files = BuildDomain();
        }

        private IList<string> BuildDomain()
        {
            IList<string> files = new List<string>();
            // Step Three: Complete the BuildDomain method



            return files;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string file in Files)
            {
                sb.Append(file);
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
