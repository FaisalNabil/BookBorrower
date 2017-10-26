using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBorrower.entity
{
    public class Types
    {
        int typeId;
        string bookType;

        public int TypeId
        {
            get
            {
                return typeId;
            }

            set
            {
                typeId = value;
            }
        }

        public string BookType
        {
            get
            {
                return bookType;
            }

            set
            {
                bookType = value;
            }
        }
    }
}
