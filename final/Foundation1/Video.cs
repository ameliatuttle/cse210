using System;
using System.Collections.Generic;

namespace Foundation1 
{
    class Video
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int Length { get; private set; }
        public int NumberOfComments => comments.Count;

        private List<Comment> comments;

        public Video(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
            comments = new List<Comment>();
        }

        public void AddComment(string commenterName, string commentText)
        {
            Comment comment = new Comment(commenterName, commentText);
            comments.Add(comment);
        }

        public List<Comment> GetComments()
        {
            return comments;
        }
    }
}