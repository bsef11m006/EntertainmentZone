using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ead_Project.Models
{
    public interface IUserRepository
    {
        void Save(User u);
        bool checkUser(string us);
        string getLink(string i);
        void SaveInterest(Interest i);
        void SaveLink(string l);
    }
}