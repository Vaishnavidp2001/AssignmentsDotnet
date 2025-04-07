using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTExhibition.Application.Interfaces
{
    public interface IUser
    {
        int UserID { get; set; }
        string Username { get; set; }
        string Email { get; set; }
    }
}
