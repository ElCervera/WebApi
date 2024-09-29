namespace WebApi.Model
{
    public class Comment
    {
        public long Id { get; set; }
        public long ClientId { get; set; }
        public long? OrderId { get; set; }
        public string CommentText { get; set; }
        public int? Rating { get; set; }

        public Client Client { get; set; }
    }
}
