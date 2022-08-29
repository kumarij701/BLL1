using System;
using System.Data.SqlClient;
using DAL1;

namespace BLL1
{
    public class BLL
    {

        public static SqlDataReader cmd;
        public void Add1()
        {
           DAL1.DataAL dl1 =new DAL1.DataAL();

            try {
                SqlDataReader dr = dl1.RetrieveData();
                Console.WriteLine("------------User Story Table---------------");
                while (dr.Read())//loop rows
                {
                    for (int i = 0; i < dr.FieldCount; i++) //columns
                    {
                        Console.Write(dr[i] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
         }
        
    }
}
      /** static void Main()
        {
            DAL1.Class1 dal = new DAL1.Class1();
            dal.RetrieveData();


        }**/