using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_CB
{
   public class validateMe
    {

      public bool idCheck(string check)
        {
           bool fff=true;
           int trash;
           fff = Int32.TryParse(check, out trash);
           if(check.Length != 5)
            {
                fff = false;
            }
            return fff;
       }//end of id check

        public bool stringCheck(string check)
        {
            bool fff = true;

            if (check.Length<= 1)
            {
                fff = false;
            }
            return fff;
            
        }//end of stringCheck


        public bool salCheck(decimal check)
        {
            bool fff = true;
          
            if (check < 0)
            {
                fff = false;

            }


            return fff;
        }//end of sal check

        public bool gpaCheck(decimal check)
        {
            bool fff = true;
           
            if(check > 4 || check < 0)
            {
                fff = false;
            }
            return fff;
        }//end of gpa check




        public bool hourlyCheck(decimal check)
        {
            bool fff = true;
            
            if (check > 20 || check < 0)
            {
                fff = false;
            }
            return fff;

        }




    }
}
