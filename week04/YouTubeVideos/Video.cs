



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

    public Video()
    {
        
    }


    public void AddComment(Comment comment)
    {
        _comments.Add(comment);

    }

    public int CountComments()
    {
        return _comments.Count();
    }
    
    public string GetVideoContent()
    {
        string content = $"{_title} ({_length}mins long)\n[{_author}] --- {CountComments()} comments";
        foreach (Comment comment in _comments)
        {
            content += comment.GetCommentContent();
        }

        return content;
    }





}    