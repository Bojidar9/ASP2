using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SQLQuery
/// </summary>
public class SQLQuery
{
    /// <summary>
    /// Insert into news
    /// </summary>
    public const string NewsInsert = "Insert into news(Title, Author, Conten, CreateDate, Image) VALUES (@Title, @Author, @Conten, @CreateDate, @Image) ";

    public const string InsertActivetionCode = "INSERT INTO UserActivetions VALUES (@UserId, @ActivationCode)";

}
