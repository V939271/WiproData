using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class VotingException : ApplicationException
    {

        //public VotingException(string error)
        //This is a constructor method — it runs when you create an object like:
        // throw new VotingException("You are not eligible");


        public VotingException(string error) : base(error) { }
        //: base(error)
        //Send this error message to the base class, which is ApplicationException
        //The base class (ApplicationException) already knows
        //how to store and handle error messages.

        //So you’re telling the parent class: “Hey,
        //store this message using your built-in system.
    }
}