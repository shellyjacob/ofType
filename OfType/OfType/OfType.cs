using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfType
{
    public class OfType : IOfType
    {
        public IEnumerable<T> GetOfType<T>(IEnumerable enumerable)
        {
            if (enumerable != null)
            {
                foreach (object item in enumerable)
                {
                    if (item is T)
                        yield return (T)item;
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(enumerable));
            }
        }

        public IEnumerable<TOutput> GetOfType<TSource, TOutput>(IEnumerable<TSource> enumerable)
        {
            return GetOfType<TOutput>(enumerable);
        }

        public IEnumerable<TBase> OfBase<TBase, TDerived>(IEnumerable<TDerived> derivedItems) where TDerived : TBase
        {
            throw new NotImplementedException();
        }
    }
}
