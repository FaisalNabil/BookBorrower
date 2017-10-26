using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookBorrower.entity;
using BookBorrower.data;

namespace BookBorrower.service
{
    public class TypesService : ITypesService
    {
        private static TypesDataAccess typesDataAccess = null;

        public TypesService()
        {
            if (TypesService.typesDataAccess == null)
            {
                TypesService.typesDataAccess = new TypesDataAccess();
            }
        }

        public int Add(Types types)
        {
            return TypesService.typesDataAccess.Add(types);
        }

        public int Edit(Types types)
        {
            return TypesService.typesDataAccess.Edit(types);
        }

        public List<Types> GetAll()
        {
            return TypesService.typesDataAccess.GetAll();
        }

        public Types GetById(int typesId)
        {
            return TypesService.typesDataAccess.GetById(typesId);
        }

        public Types GetByName(string typesName)
        {
            return TypesService.typesDataAccess.GetByName(typesName);
        }

        public int Remove(int typesId)
        {
            return TypesService.typesDataAccess.Remove(typesId);
        }
    }
}
