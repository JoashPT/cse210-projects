public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void StoreComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int CommentCount()
    {
        return _comments.Count;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public string GetLength()
    {
        return _length.ToString();
    }

    public List<string> GetCommentList()
    {
        List<string> commentStringList = new List<string>();
        foreach (Comment comment in _comments)
        {
            string commentString = $"{comment.GetName()}: {comment.GetText()}";
            commentStringList.Add(commentString);
        }
        return commentStringList;
    }
}