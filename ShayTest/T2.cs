using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ShayTest.T1;

namespace ShayTest
{
    public class T2
    {
        public string[] songs { get; set; }

        public T2()
        {

            //initalizing an array of songs
            int sizeOfList = 10;
            songs=new string[sizeOfList];   
            for (int i = 0;i< sizeOfList; i++)
            {

                this.songs[i] = $"song{i + 1}.mp3";

            }
               
           
        }
       
        public string[] Shuffle()
        {
            if (this.songs.Length>1)
            {
                string[] suffuled = new string[this.songs.Length];
                Array.Copy(songs, suffuled, this.songs.Length);

                while (string.Join(',', suffuled) == string.Join(',', this.songs))
                    suffuled = suffuled.Shuffle();

                this.songs = suffuled;  
                return suffuled;
            }

            return songs;
           
        }
    }
}
