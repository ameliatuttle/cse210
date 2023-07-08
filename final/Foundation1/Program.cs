using System;
using System.Collections.Generic;

namespace Foundation1
{class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Video 1 Title", "Author 1", 120);
        video1.AddComment("Commenter 1", "Comment 1 Text");
        video1.AddComment("Commenter 2", "Comment 2 Text");
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Video 2 Title", "Author 2", 180);
        video2.AddComment("Commenter 3", "Comment 3 Text");
        video2.AddComment("Commenter 4", "Comment 4 Text");
        video2.AddComment("Commenter 5", "Comment 5 Text");
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Video 3 Title", "Author 3", 240);
        video3.AddComment("Commenter 6", "Comment 6 Text");
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("Video 4 Title", "Author 4", 300);
        video4.AddComment("Commenter 7", "Comment 7 Text");
        video4.AddComment("Commenter 8", "Comment 8 Text");
        video4.AddComment("Commenter 9", "Comment 9 Text");
        video4.AddComment("Commenter 10", "Comment 10 Text");
        videos.Add(video4);

        // Display video details
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of comments: " + video.NumberOfComments);

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine("Commenter: " + comment.CommenterName);
                Console.WriteLine("Comment: " + comment.Text);
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
}