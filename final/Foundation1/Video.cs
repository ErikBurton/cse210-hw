// Video class to store information about a YouTube video
class Video {
    // Properties for video details
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }

    // List to store comments - (abstraction: encapsulating comments within the Video class)
    private List<Comment> comments = new List<Comment>();

    // Method to add comment to the video  (abstraction: hiding implementation details)
    public void AddComment(string commenterName, string commentText)
    {
        Comment newComment = new Comment
        {
            CommenterName = commenterName,
            CommentText = commentText
        };

        comments.Add(newComment);
    }

    // Method to get the number of comment (abstraction: hiding implementation details)
    public int GetNumberOfComments() 
    {
        return comments.Count;
    }

    // Method to display video information and comments
    public void DisplayVideoInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {LengthInSeconds} seconds");
        Console.WriteLine();
        Console.WriteLine(new string('-', 40));
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        foreach (var comment in comments)
        {
            Console.WriteLine($"Comment by: {comment.CommenterName}: {comment.CommentText}");
        }

        Console.WriteLine();

    }
}

