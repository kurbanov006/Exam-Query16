using Npgsql;
using Dapper;




public class ServiceQuery
{
    #region GetQuery1
    public IEnumerable<Query1> GetQuery1()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringText))
            {
                connection.Open();

                return connection.Query<Query1>(SqlCommand.Query1);
            }
        }
        catch (NpgsqlException ex)
        {
            System.Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }
    #endregion

    #region GetQuery2
    public IEnumerable<Query2> GetQuery2()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringText))
            {
                connection.Open();

                return connection.Query<Query2>(SqlCommand.Query2);
            }
        }
        catch (NpgsqlException ex)
        {
            System.Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }
    #endregion

    #region GetQuery3
    public IEnumerable<Query3> GetQuery3()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringText))
            {
                connection.Open();

                return connection.Query<Query3>(SqlCommand.Query3);
            }
        }
        catch (NpgsqlException ex)
        {
            System.Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }
    #endregion

    #region Query4
    public IEnumerable<Query4> GetQuery4()
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringText))
        {
            connection.Open();

            return connection.Query<Query4>(SqlCommand.Query4);
        }
    }
    #endregion

    #region Query5
    public IEnumerable<Query5> GetQuery5()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringText))
            {
                connection.Open();

                return connection.Query<Query5>(SqlCommand.Query5);
            }
        }
        catch (NpgsqlException ex)
        {
            System.Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }
    #endregion

    #region Query6
    public IEnumerable<Query6> GetQuery6()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringText))
            {
                connection.Open();

                return connection.Query<Query6>(SqlCommand.Query6);
            }
        }
        catch (NpgsqlException ex)
        {
            System.Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }
    #endregion

    #region Query7

    #endregion



    #region Query8
    public IEnumerable<Query8> GetQuery8()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.Query8))
            {
                connection.Open();

                return connection.Query<Query8>(SqlCommand.Query8);
            }
        }
        catch (NpgsqlException ex)
        {
            System.Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }
    #endregion

    #region Query9
    public IEnumerable<Query9> GetQuery9()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringText))
            {
                connection.Open();

                return connection.Query<Query9>(SqlCommand.Query9);
            }
        }
        catch (NpgsqlException ex)
        {
            System.Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }
    #endregion

    #region Query10
    public IEnumerable<Query10> GetQuery10()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringText))
            {
                connection.Open();

                return connection.Query<Query10>(SqlCommand.Query10);
            }
        }
        catch (NpgsqlException ex)
        {
            System.Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }
    #endregion

    #region Query11
    public IEnumerable<Query11> GetQuery11()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringText))
            {
                connection.Open();

                return connection.Query<Query11>(SqlCommand.Query11);
            }
        }
        catch (NpgsqlException ex)
        {
            System.Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }
    #endregion


    #region Query12
    public IEnumerable<Query12> GetQuery12()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringText))
            {
                connection.Open();

                return connection.Query<Query12>(SqlCommand.Query12);
            }
        }
        catch (NpgsqlException ex)
        {
            System.Console.WriteLine($"Error: {ex.Message}");
            throw;
        }

    }
    #endregion


    #region Query13
    public Query13? GetQuery13()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringText))
            {
                connection.Open();

                return connection.QueryFirstOrDefault<Query13>(SqlCommand.Query13);
            }
        }
        catch (NpgsqlException ex)
        {
            System.Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }
    #endregion

    #region Query14
    public IEnumerable<Query14> GetQuery14()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringText))
            {
                connection.Open();

                return connection.Query<Query14>(SqlCommand.Query14);
            }
        }
        catch (NpgsqlException ex)
        {
            System.Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }
    #endregion

    #region Query15
    public IEnumerable<Query15> GetQuery15()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringText))
            {
                connection.Open();

                return connection.Query<Query15>(SqlCommand.Query15);
            }
        }
        catch (NpgsqlException ex)
        {
            System.Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }
    #endregion

    #region Query16
    public IEnumerable<Query16> GetQuery16()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommand.StringText))
            {
                connection.Open();

                return connection.Query<Query16>(SqlCommand.Query16);
            }
        }
        catch (NpgsqlException ex)
        {
            System.Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }
    #endregion


}


file class SqlCommand
{
    public const string StringText = "Server=localhost; Port=5432; Database=examquery_db; User Id=postgres; Password=12345";

    public const string Query1 = @"select u.userid, u.firstname || ' ' || u.lastname as fullname,
                                u.email, u.phonenumber, u.address, u.dateofbirth,
                                o.orderid, o.orderdate, o.status, sum(o.totalamount) as summtotal
                                from users u
                                join orders o on u.userid = o.userid
                                group by u.userid, o.orderid";
    public const string Query2 = @"select p.productid, p.productname, p.description, p.price,
                                r.reviewid, r.userid, r.rating, r.comment, r.createdat
                                from products p
                                join reviews r on p.productid = r.productid
                                order by r.createdat
                                ";

    public const string Query3 = @"select ticketid, userid, issuetype, description, status, createdat, resolvedat
                                            from supporttickets
                                            where status = 'Open'";


    public const string Query4 = @"select u.userid, u.firstname || ' ' || u.lastname as fullname, 
                            u.email, u.phonenumber, u.address, count(o.orderid) as counts
                            from users u
                            join orders o on u.userid = o.userid
                            group by u.userid
                            having  count(o.orderid) > 5 
                            ";
    public const string Query5 = @"select productname, sum(price) as summ
                                    from products
                                    group by productname
                            ";
    public const string Query6 = @"select p.productname, r.comment, r.createdat
                                from products p
                                join reviews r on p.productid = r.productid

                            ";
    public const string Query8 = @"select category, avg(price) as avgprice
                                from products
                                group by category
                            ";
    public const string Query9 = @"select u.userid, u.firstname || ' ' || u.lastname as fullname,
                                u.email, u.phonenumber, u.address, u.dateofbirth, r.rating
                                from users u
                                join reviews r on u.userid = r.userid
                                where r.rating > 4
                            ";
    public const string Query10 = @"select u.userid, u.firstname || ' ' || u.lastname as fullname,
                                    u.email, u.phonenumber, u.address, u.dateofbirth
                                    from users u
                                    join supporttickets s on u.userid = s.userid
                                    where status = 'Closed'
                            ";
    public const string Query11 = @"select p.productid, p.productname, count(r.reviewid) as counts
                                    from products p
                                    join reviews r on p.productid = r.productid
                                    group by p.productid
                                    order by p.productid desc
                                    limit 5
                            ";
    public const string Query12 = @"select u.userid, u.firstname || ' ' || u.lastname as fullname,
                                    sum(o.totalamount) as summtotal
                                    from users u
                                    join orders o on o.userid = u.userid
                                    group by u.userid
                            ";
    public const string Query13 = @"select u.userid, u.firstname || ' ' || u.lastname as fullname,
                                        max(s.createdat) as maxcreat
                                        from users u 
                                        join supporttickets s on u.userid = s.userid
                                        group by u.userid
                                        order by max(s.createdat) desc
                                        limit 1
                                    ";
    public const string Query14 = @"select ticketid, userid, issuetype, description, status, createdat, resolvedat
                                        from supporttickets 
                                        where status = 'Open' or status = 'In Progress'
                                    ";
    public const string Query15 = @"select u.userid, u.firstname || ' ' || u.lastname as fullname,
                                    s.status
                                    from users u
                                    join supporttickets s on u.userid = s.userid
                                    ";
    public const string Query16 = @"select p.productid, p.productname, p.stockquantity 
                                    from products p
                                    where p.stockquantity > 100
                                    ";

}