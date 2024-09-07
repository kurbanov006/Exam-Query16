public class Query3
{
    public int Ticketid { get; set; }
    public int Userid { get; set; }
    public string Issuetype { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Status { get; set; } = null!;
    public DateTime Createdat { get; set; }
    public DateTime Resolvedat { get; set; }
}

// select ticketid, userid, issuetype, description, status, createdat, resolvedat
// from supporttickets
// where status = 'Open'