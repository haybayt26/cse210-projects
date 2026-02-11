



public class Comment
{
    private string _commentDate;
    private string _commenter;
    private string _commentText;


    
    public Comment(string date, string person, string text)
    {
        _commentDate = date;
        _commenter = person;
        _commentText = text;
    }

    public Comment()
    {
        
    }

    public string GetCommentContent()
    {
        return $"\n\t{_commenter}: {_commentDate}\n\t{_commentText}\n";
    }

}