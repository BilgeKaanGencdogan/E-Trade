using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Results.Bases
{
    public abstract class Result // base, parent, super
    {
        public bool IsSuccessful { get; } // readonly, can only be assigned by the constructor or on this line
        public string Message { get; set; }

        protected Result(bool isSuccessful, string message)
        {
            IsSuccessful = isSuccessful;
            Message = message;
        }
    }
}
