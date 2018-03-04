using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_CB
{
    public class buddy
    {
        public string type;
        public string id;
        public string fname;
        public string lname;
        private bool jeez;
        private string errorMsg="";
        

        validateMe validate = new validateMe();

 


        public buddy(string type, string id, string fname, string lname){
          
            this.Type = type;
            this.Id = id;
            this.Fname = fname;
            this.Lname = lname;
           

        }//end of empty construct

        public string Type
        {
            get { return type; }
            set { type = value; }
        }


        public string Id
        {
            get
            {

                    return id;
               
            }
            set
            {
                jeez = validate.idCheck(value);
                if (jeez == true)
                {
                    id = value;
                }
                else
                {
                    errorMsg += "\nThere was a problem with your ID input.";
                }

            }


        }

        public string Fname
        {
            get { return fname; }
            set
            {
                jeez = validate.stringCheck(value);
                if (jeez == true)
                {
                    fname = value;
                }
                else
                {
                    errorMsg += "\nThere was a problem with your First Name input.";
                }

            }
        }

        public string Lname
        {
            get { return lname; }
            set
            {
                jeez = validate.stringCheck(value);
                if (jeez == true)
                {
                    lname = value;
                }
                else
                {
                    errorMsg += "\nThere was a problem with your Lasr Name input.";
                }

            }
        }


        public virtual string displayMe()
        {
            return $"TYPE : {type}\nID # : {id}\nFIRST NAME : {fname}\nLAST NAME : {lname}";
            
        }


        public virtual string ErrorMsg() 
        {
            return errorMsg;
        }



    }
}
