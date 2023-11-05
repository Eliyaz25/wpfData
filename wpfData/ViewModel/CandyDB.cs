using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public class CandyDB : BaseDB
    {
        protected override BaseEntity NewEntity()
        {
            return new Candy() as BaseEntity; //יצירת עצם חדש מסוג
        }

        //Reader-מילוי העצם בערכים מה
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Candy candy = (Candy)entity;
            candy.Id = (int)this.reader["ID"];
            candy.CandyName = (string)this.reader["CandyName"];
            return candy;
        }

        public CandyList SelectAll()
        {
            command.CommandText = "SELECT * FROM TblSnacks";
            CandyList candyList = new CandyList(base.ExecuteCommand());
            return candyList;
        }

        public Candy SelectById(int id)
        {
            command.CommandText = $"SELECT * FROM TblSnacks WHERE ID={id}";
            CandyList candyList = new CandyList(base.ExecuteCommand());
            if (candyList.Count == 0)
                return null;
            return candyList[0];
        }

        public CandyList SelectByUser(User user)
        {
            command.CommandText = "SELECT *  FROM (TblUserSnack INNER JOIN TblSnacks ON TblUserSnack.userSnack = tblSnacks.ID) " 
                + $" WHERE UserId={user.Id}";
            CandyList candyList = new CandyList(base.ExecuteCommand());
            return candyList;
        }
    }
}

