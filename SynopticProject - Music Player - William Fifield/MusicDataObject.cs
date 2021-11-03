using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynopticProject___Music_Player___William_Fifield
{
    struct MusicDataObject
    {
        /// <summary>
        /// A basic store of strings within the object to allow easy local storage and saving of the music files
        /// </summary>
        /// <param name="fileData"></param>
        /// <param name="pathData"></param>
        public  MusicDataObject(string fileData, string pathData)
        {
            FileData = fileData;
            PathData = pathData;
        }

        public string FileData { get; set; }
        public string PathData { get; set; }


    }
}
