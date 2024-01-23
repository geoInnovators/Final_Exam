

using Final_Exam;
using System.Xml.Serialization;

#region Who Has the Most Friends


var accepted = new List<RequestAccepted>
{
    new RequestAccepted("avto", "ani", new DateTime(2024, 10, 2)),
    new RequestAccepted("avto", "beqa", new DateTime(2024, 10, 2)),
    new RequestAccepted("ani", "giorgi", new DateTime(2024, 10, 2)),
    new RequestAccepted("anzori", "ani", new DateTime(2024, 10, 2))
};

/*
+--------------+-------------+-------------+
| requester    | accepter    | accept_date |
+--------------+-------------+-------------+
| avto         | ani         | 2023/06/ 03 |
| avto         | beqa        | 2023/06/ 08 |
| ani          | giorgi      | 2023/06/ 08 |
| anzori       | ani         | 2023/06/ 09 |
+--------------+-------------+-------------+
*/

static string PersonWithMaxFriends(List<RequestAccepted> ac)
{

    // TODO: Write your code here

    throw new NotImplementedException();
}
#endregion


#region Product Price at a Given Date


var changeLog = new List<PriceChangeLog>
{
    new PriceChangeLog(1, 20m, new DateTime(2024,08,14)),
    new PriceChangeLog(2, 50m, new DateTime(2024,08,14)),
    new PriceChangeLog(1, 30m, new DateTime(2024,08,15)),
    new PriceChangeLog(1, 35m, new DateTime(2024,08,16)),
    new PriceChangeLog(2, 65m, new DateTime(2024,08,17)),
    new PriceChangeLog(3, 20m, new DateTime(2024,08,18)),
};

/*
+------------+-----------+-------------+
| product_id | new_price | change_date |
+------------+-----------+-------------+
| 1          | 20        | 2024-08-14  |
| 2          | 50        | 2024-08-14  |
| 1          | 30        | 2024-08-15  |
| 1          | 35        | 2024-08-16  |
| 2          | 65        | 2024-08-17  |
| 3          | 20        | 2024-08-18  |
+------------+-----------+-------------+
 */
static List<decimal?> ProductPrices(int productsCount, decimal initialPrice, List<PriceChangeLog> changeLog, DateTime givenDate)
{
    // TODO: Write your code here
    throw new NotImplementedException();
}

#endregion


#region Ranks in Olympiad

var scores = new List<StudentScore>
{
    new StudentScore("ani", 100),
    new StudentScore("giorgi", 90),
    new StudentScore("avto", 100),
    new StudentScore("beqa", 75),
    new StudentScore("anzori", 90),
};

/*
+-------+-------+
| name  | score |
+-------+-------+
| ani   | 100   |
| giorgi| 90    |
| avto  | 100   |
| beqa  | 75    |
| anzori| 90    |
+-------+-------+

ani 1
avto 1
giorgi 2
anzori 2
beqa 3
*/


static List<Tuple<string, int>> GetRanks(List<StudentScore> scores)
{
    // TODO: Write your code here
    throw new NotImplementedException();
}



#endregion


