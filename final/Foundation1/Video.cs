using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public void SetLength(int length)
    {
        _length = length;
    }

    public int GetLength()
    {
        return _length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int CountComments()
    {
        return _comments.Count;
    }

    public void DsiplayComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
 
 
}