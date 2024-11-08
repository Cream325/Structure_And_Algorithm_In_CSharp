using Structure_And_Algorithm.Structure.Utils;

namespace Structure_And_Algorithm.Structure.LinearStructures.No1_Array
{
    /// <summary>
    /// 동적 배열
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DynamicArray<T> : AbstractArray<T>
    {
        #region Construectors
        public DynamicArray(int capacity) : base(capacity) { }

        public DynamicArray(int capacity, T newData) : base(capacity, newData) { }
        #endregion

        #region Overrides

        public override void Insert(T newData, int index)
        {
            if (lastIndex + 1 >= capacity)
            {
                Resize(array.Length * 2);
            }

            index = index < 0 ? 0 :
                    index >= capacity ? capacity - 1 : index;

            for(int i = lastIndex; i >= index; i--)
                {
                array[i + 1] = array[i];
            }

            array[index] = newData;
            lastIndex++;
        }

        public override T Search(int index)
        {
            index = index < 0 ? 0 :
                    index >= capacity ? capacity-1 : index;

            return array[index];
        }

        public override T Delete(int index)
        {
            if (lastIndex - 1 < capacity / 2)
            {
                Resize(capacity / 2);
            }

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

        #region Private Functions
        /// <summary>
        /// 크기 재조정
        /// </summary>
        /// <param name="newSize"></param>
        private void Resize(int newSize)
        {
            T[] newArray = new T[newSize];
            for (int i = 0; i < lastIndex; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
            capacity = newSize;
        }
        #endregion
    }
}
