using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfType
{
    public interface IOfType
    {
        IEnumerable<T> GetOfType<T>(IEnumerable enumerable);

        IEnumerable<TOutput> GetOfType<TSource, TOutput>(IEnumerable<TSource> enumerable);

        IEnumerable<TBase> OfBase<TBase, TDerived>(IEnumerable<TDerived> derivedItems) where TDerived : TBase;
    }
}
