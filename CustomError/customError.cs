using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomError
{
    public class customError: Exception
    {
        private string _Message;
        private int _Number;
        public customError(int nbError)
        {
            _Number = nbError;
            switch (nbError)
            {
                case 10:
                    _Message = "Erreur 10";
                    break;
                case 20:
                    _Message = "Erruer 20";
                    break;
                default:
                    _Message = "NoMessage";
                    break;
            }
        }
        public int nbError
        {
            get { return _Number; }
        }
        public override string Message
        {
            get { return _Message; }
        }
    }
}
