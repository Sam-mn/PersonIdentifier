using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonIdentifier
{
    abstract class UserError
    {
       public abstract string UEMessage();
    }

   internal class NumericInputError : UserError 
    { 
    
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field, This fierd an error.";
        }
          
    }

    internal class TextInputError : UserError 
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numaric only field, This fierd an error.";
        }
    }

    internal class FirstError : UserError
    {
        public override string UEMessage()
        {
            return "From first Error, This fierd an error.";
        }
    }

    internal class SecondError : UserError
    {
        public override string UEMessage()
        {
            return "From second Error, This fierd an error.";
        }
    }

    internal class ThirdError : UserError
    {
        public override string UEMessage()
        {
            return "From third Error, This fierd an error.";
        }
    }


}
