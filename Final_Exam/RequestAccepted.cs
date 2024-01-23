using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam;

public class RequestAccepted
{
    public string Requester { get; set; } = null!;
    public string Accepter { get; set; } = null!;
    public DateTime AcceptedDate { get; set; }

    public RequestAccepted(string requester, string accepter, DateTime acceptedDate)
    {
        Requester = requester;
        Accepter = accepter;
        AcceptedDate = acceptedDate;
    }
}