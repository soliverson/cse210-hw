public class Video
{
    public string _author;
    public string _title;
    public int _length;             // in seconds
    public List<Comment> _comments = new List<Comment> ();

    

    public void VideoDisplay()
    {
        Console.WriteLine($"{_title}, {_author}, {_length}");
        // Console.WriteLine($"{_comments.Count()} Comments: ");
        Console.WriteLine($"{NumberOfComments()} Comments: ");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }

    public int NumberOfComments()
    {
        return _comments.Count();
    }
        
}