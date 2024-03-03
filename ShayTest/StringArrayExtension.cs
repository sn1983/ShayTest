using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShayTest
{
    public static class StringArrayExtension
    {

        public static string[] Shuffle(this string[] songs)
        {
            Random rand = new Random();
            for (int i = songs.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                string tmp = songs[j];
                songs[j] = songs[i];
                songs[i] = tmp;
            }
            return songs;
        }
    }
}
