using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204058
{
    public class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser profile1 = new SayaTubeUser("Deva");

            //SayaTubeUser profile2 = new SayaTubeUser("Deva");

            SayaTubeVideo video1 = new SayaTubeVideo("Interstellar");
            video1.IncreasePlayCount(12);
            SayaTubeVideo video2 = new SayaTubeVideo("The Batman");
            video2.IncreasePlayCount(15);
            SayaTubeVideo video3 = new SayaTubeVideo("The Joker");
            video3.IncreasePlayCount(17);
            SayaTubeVideo video4 = new SayaTubeVideo("Pokemon");
            video4.IncreasePlayCount(13);
            SayaTubeVideo video5 = new SayaTubeVideo("The Green Mile");
            video5.IncreasePlayCount(13);
            SayaTubeVideo video6 = new SayaTubeVideo("Spongebob");
            video6.IncreasePlayCount(13);
            SayaTubeVideo video7 = new SayaTubeVideo("The Notebook");
            video7.IncreasePlayCount(13);
            SayaTubeVideo video8 = new SayaTubeVideo("Batman Begins");
            video8.IncreasePlayCount(13);
            SayaTubeVideo video9 = new SayaTubeVideo("Logan");
            video9.IncreasePlayCount(13);
            SayaTubeVideo video10 = new SayaTubeVideo("The Dark Knight");
            video10.IncreasePlayCount(15);

            profile1.addVideo(video1);
            profile1.addVideo(video2);
            profile1.addVideo(video3);
            profile1.addVideo(video4);
            profile1.addVideo(video5);
            profile1.addVideo(video6);
            profile1.addVideo(video7);
            profile1.addVideo(video8);
            profile1.addVideo(video9);
            profile1.addVideo(video10);
            profile1.addVideo(null);
            profile1.printAllvideoplayCount();
        }
    }

    internal class SayaTubeVideo
    {
        int id;
        string title;
        int playCount;

        public SayaTubeVideo(string video)
        {
            Random generate = new Random();
            this.id = generate.Next(0, 100000);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int angka)
        {
            playCount = playCount + angka;
        }

        public int GetPlaycount()
        {
            return playCount;
        }

        public string GetTitle()
        {
            return title;
        }

        public void printVideoDetails()
        {
            Console.WriteLine("title: " + title);
            Console.WriteLine("id: " + id);
            Console.WriteLine("playCount:" + playCount);
        }


    }

    internal class SayaTubeUser
    {
        int id;
        List<SayaTubeVideo> uploadedVideos;
        string Username;

        public SayaTubeUser(string profile)
        {
            Random generate = new Random();
            this.id = generate.Next(0, 100000);
            this.Username = profile;
            uploadedVideos = new List<SayaTubeVideo>();
        }

        public void GetTotalVideoplayCount()
        {
            int dataplayCount = 0;
            foreach (SayaTubeVideo video in uploadedVideos)
            {
                dataplayCount = dataplayCount + video.GetPlaycount();
            }
        }

        public void addVideo(SayaTubeVideo data)
        {
            uploadedVideos.Add(data);
        }


        public void printAllvideoplayCount()
        {

            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("username: " + Username);
                Console.WriteLine("video " + (i + 1) + " judul: " + uploadedVideos[i]);
            }

        }
    }
}

