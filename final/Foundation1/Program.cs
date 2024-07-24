using System;

class Program
{
    static void Main(string[] args)
    {
        //Create Video Objects
        Video video1 = new Video("LIWAY70", "Piwdeipei", 501);
        Video video2 = new Video("YLYW38", "Jillsepticear", 476);
        Video video3 = new Video("FFXX part 27", "Davider", 1433);

        //Create Comment Objects for video1
        Comment comment1_1 = new Comment("Alph Oreo", "Very funny video, lmao");
        Comment comment1_2 = new Comment("Beth Ai", "What the dog doing? 3:44");
        Comment comment1_3 = new Comment("Gimmo Mel", "My video is better than Piwdeipei!!!");
        
        //Add Comment Objects to video1
        video1.StoreComment(comment1_1);
        video1.StoreComment(comment1_2);
        video1.StoreComment(comment1_3);

        //Create Comment Objects for video2
        Comment comment2_1 = new Comment("Dela Tela", "Nevery seen Jill laugh this much before 6:55");
        Comment comment2_2 = new Comment("Epson Lee", "When collab with Piwds???");
        Comment comment2_3 = new Comment("Z1t", "Nice transition 2:29");

        //Add Comment Objects to video1
        video2.StoreComment(comment2_1);
        video2.StoreComment(comment2_2);
        video2.StoreComment(comment2_3);

        //Create Comment Objects for video3
        Comment comment3_1 = new Comment("10+4", "Such luck 22:31");
        Comment comment3_2 = new Comment("Da Lamb", "LMAO 15:15");
        Comment comment3_3 = new Comment("Micro Onion", "Nowaying HAHAHHAHAHA 13:07");
        Comment comment3_4 = new Comment("Amego", "Hoping for you to play WAW again... (T^T)");

        //Add Comment Objects to video1
        video3.StoreComment(comment3_1);
        video3.StoreComment(comment3_2);
        video3.StoreComment(comment3_3);
        video3.StoreComment(comment3_4);

        //Display video1 attributes
        Console.WriteLine($"\nTitle: {video1.GetTitle()}");
        Console.WriteLine($"Author: {video1.GetAuthor()}");
        Console.WriteLine($"Duration: {video1.GetLength()} seconds");
        Console.WriteLine($"\n{video1.CommentCount()} comments");

        List<string> allComments1 = video1.GetCommentList();
        foreach (string comments in allComments1)
        {
            Console.WriteLine(comments);
        }

        //Display video2 attributes
        Console.WriteLine($"\nTitle: {video2.GetTitle()}");
        Console.WriteLine($"Author: {video2.GetAuthor()}");
        Console.WriteLine($"Duration: {video2.GetLength()} seconds");
        Console.WriteLine($"\n{video2.CommentCount()} comments");

        List<string> allComments2 = video2.GetCommentList();
        foreach (string comments in allComments2)
        {
            Console.WriteLine(comments);
        }

        //Display video3 attributes
        Console.WriteLine($"\nTitle: {video3.GetTitle()}");
        Console.WriteLine($"Author: {video3.GetAuthor()}");
        Console.WriteLine($"Duration: {video3.GetLength()} seconds");
        Console.WriteLine($"\n{video3.CommentCount()} comments");

        List<string> allComments3 = video3.GetCommentList();
        foreach (string comments in allComments3)
        {
            Console.WriteLine(comments);
        }
    }
}