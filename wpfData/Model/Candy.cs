using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Candy : BaseEntity
    {
        private string candyName;

        private UserList userList;

        public UserList UserList
        {
            get { return userList; }
            set { userList = value; }
        }

        public string CandyName
        {
            get { return candyName; }
            set { candyName = value; }
        }

        
    }
    public class CandyList : List<Candy>
    {
        public CandyList() { } //בנאי ברירת מחדל
        public CandyList(IEnumerable<Candy> list) :
            base(list)
        { } //המרה של רשימת קורסים לאוסף של קורסים
        public CandyList(IEnumerable<BaseEntity> list) :
            base(list.Cast<Candy>().ToList())
        { } //המרה כלפי מטה מישות בסיס לרשימת קורסים

    }
}
