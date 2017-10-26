using System;
using System.Collections.Generic;
using BookBorrower.entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBorrower.service
{
    public interface ITypesService
    {
        int Add(Types types);
        int Remove(int typesId);
        int Edit(Types types);
        List<Types> GetAll();
        Types GetById(int typesId);
        Types GetByName(string typesName);
    }
}
