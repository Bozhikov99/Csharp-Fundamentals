using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int songs = int.Parse(Console.ReadLine());
            Song[] playList = new Song[songs];
            for (int i = 0; i < playList.Length; i++)
            {
                string[] command = Console.ReadLine()
                    .Split("_");
                Song song = new Song();
                song.TypeList = command[0];
                song.Name = command[1];
                song.Time = command[2];
                playList[i] = song;
            }
            string listType = Console.ReadLine();
            foreach (Song song in playList)
            {
                if (song.TypeList==listType)
                {
                    Console.WriteLine(song.Name);
                }
                else if (listType=="all")
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
        class Song
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }

    }
}
