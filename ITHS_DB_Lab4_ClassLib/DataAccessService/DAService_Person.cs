using ITHS_DB_Lab4_DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITHS_DB_Lab4_ClassLib.DataAccessService
{
    public class DAService_Person
    {
        public Person GetOne(int personId)
        {
            using (var db = new ExersiceContext())
            {
                try
                {
                    return db.Person.First(p => p.Id == personId);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }
        public List<Person> GetAll()
        {
            using (var db = new ExersiceContext())
            {
                try
                {
                    return db.Person.ToList();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }
    }
}
