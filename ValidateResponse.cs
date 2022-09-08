using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNUltimate.UserLogin
{
    public class ValidateResponse
    {
        public bool Valid { get; private set; }
        public string Error { get; private set; }

        public ValidateResponse(bool valid, string error)
        {
            Valid = valid;
            Error = error;
        }

        public ValidateResponse()
        {
        }

    }
}
