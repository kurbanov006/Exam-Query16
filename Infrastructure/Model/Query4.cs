public class Query4
{
    public int Userid { get; set; }
    public string FullName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phonenumber { get; set; } = null!;
    public string Address { get; set; } = null!;
    public int Counts { get; set; }
}

// select u.userid, u.firstname || ' ' || u.lastname as fullname, 
// u.email, u.phonenumber, u.address, count(o.orderid) as counts
// from users u
// join orders o on u.userid = o.userid
// group by u.userid
// having  count(o.orderid) > 5
