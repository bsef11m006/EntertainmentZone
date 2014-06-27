using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ead_Project.Models
{
    public class UserRepository:IUserRepository
    {
        public void Save(User u)
        {
            using (EntertainmentEntities1 db = new EntertainmentEntities1())
            {
                db.Users.Add(u);
                db.SaveChanges();
            }
        }
        public bool checkUser(string user)
        {
            using (EntertainmentEntities1 db= new EntertainmentEntities1())
            {
                List<User> u = new List<User>();
                u.Add(db.Users.Find(user));
                if (u[0] != null)
                    return true;
                return false;
            }
        }
        public string getLink(string i)
        {
            Random rnd = new Random();
            using(EntertainmentEntities1 db= new EntertainmentEntities1())
            {
                if (i.Equals("Action"))
                {
                    List<Action> ac = new List<Action>();
                    int j = rnd.Next(1, 11);
                    ac.Add(db.Actions.Find(j));
                    if (ac[0] != null)
                        return ac[0].Link;
                }
                if (i.Equals("Cell"))
                {
                    List<Cell_Phone> cell = new List<Cell_Phone>();
                    int j = rnd.Next(1, 10);
                    cell.Add(db.Cell_Phone.Find(j));
                    if (cell[0] != null)
                        return cell[0].Link;
                }
                if (i.Equals("Music"))
                {
                    List<Muzic> cell = new List<Muzic>();
                    int j = rnd.Next(1, 10);

                    cell.Add(db.Muzics.Find(j));
                    if (cell[0] != null)
                        return cell[0].Link;
                }
                if (i.Equals("Online Games"))
                {
                    List<Game> cell = new List<Game>();
                    int j = rnd.Next(1, 12);

                    cell.Add(db.Games.Find(j));
                    if (cell[0] != null)
                        return cell[0].Link;
                }
                if (i.Equals("Quotes"))
                {
                    List<Quote> cell = new List<Quote>();
                    int j = rnd.Next(1, 9);
                    cell.Add(db.Quotes.Find(j));
                    if (cell[0] != null)
                        return cell[0].Link;
                }
                if (i.Equals("Sports"))
                {
                    List<Sport> cell = new List<Sport>();
                    int j = rnd.Next(1, 9);

                    cell.Add(db.Sports.Find(j));
                    if (cell[0] != null)
                        return cell[0].Link;
                }
                if (i.Equals("Technology"))
                {
                    List<Technology> cell = new List<Technology>();
                    int j = rnd.Next(1, 11);
                    cell.Add(db.Technologies.Find(j));
                    if (cell[0] != null)
                        return cell[0].Link;
                }
                return null;
            }
 
        }
        public void SaveLink(string l)
        {
            using(EntertainmentEntities1 db= new EntertainmentEntities1())
            {
               
            }
        }
        public void SaveInterest(Interest i)
        {
            using (EntertainmentEntities1 db = new EntertainmentEntities1())
            {
                db.Interests.Add(i);
                db.SaveChanges();
            }
        }

    }
}