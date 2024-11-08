using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.LinearStructures.No1_Array
{
    /// <summary>
    /// 정적 배열
    /// </summary>
    public class FixedArray<T> : AbstractArray<T>
    {
        #region Constructors
        public FixedArray(int capacity) : base(capacity) { }

        public FixedArray(int capacity, T newData) : base(capacity, newData) { }
        #endregion

        #region Overrides
        public override void Insert(T newData, int index)
        {
            if (lastIndex >= capacity - 1) return;

            index = index < 0 ? 0 :
                    index >= capacity ? capacity - 1 : index;

            for (int i = lastIndex; i >= index; i--)
            {
                array[i + 1] = array[i];
            }

            array[index] = newData;
            lastIndex++;
        }

        public override T Search(int index)
        {
            index = index < 0 ? 0 :
                    index >= capacity ? capacity - 1 : index;

            return array[index];
        }

        public override T Delete(int index)
        {
            if (lastIndex - 1 < 0) return default;

            index = index < 0 ? 0 :
                    index >= capacity ? capacity - 1 : index;
            T deletedData = array[index];

            for (int i = index; i < lastIndex; i++)
            {
                array[i] = array[i + 1];
            }

            lastIndex--;

            return deletedData;
        }
        #endregion
    }
}
