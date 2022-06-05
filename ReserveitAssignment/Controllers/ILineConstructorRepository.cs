using System;
using System.Collections;
using System.Collections.Generic;

namespace ReserveitAssignment.Controllers
{
    public interface ILineConstructorRepository
    {
        public void LineConstructorRepositiry(int minLength, List<String> text);
        public ArrayList GetLines();
    }
}
