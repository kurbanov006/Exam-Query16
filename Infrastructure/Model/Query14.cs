public class Query14
{
    public int TicketId { get; set; }
    public int UserId { get; set; }
    public string IssueType { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Status { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public DateTime ResolvedAt { get; set; }
}
