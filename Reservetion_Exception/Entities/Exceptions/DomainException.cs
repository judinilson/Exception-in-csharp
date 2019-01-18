using System;


namespace Reservetion_Exception.Entities.Exceptions
{
    class DomainException :ApplicationException
    {
        public DomainException(string message): base(message)
        {

        }
    }
}
