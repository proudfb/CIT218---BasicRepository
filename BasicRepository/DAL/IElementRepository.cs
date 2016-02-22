using BasicRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRepository.DAL
{
    public interface IElementRepository : IDisposable
    {
        IEnumerable<Element> SelectAll();
        IEnumerable<Element> SelectEachMember(AppEnum.Family family);
        Element SelectByAtomicNumber(int atomicNumber);
        void Insert(Element element);
        void Update(Element element);
        void Delete(int atomicNumber);
    }
}
