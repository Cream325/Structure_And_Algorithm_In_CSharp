namespace Structure_And_Algorithm.Structure.LinearStructures.No1_Array
{
    /// <summary>
    /// 동적 배열
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DynamicArray<T> : AbstractArray<T>
    {
        #region Member Fields
        private int lastIndex;
        private T[] array;
        #endregion

        #region Construectors
        public DynamicArray(int capacity) : base(capacity)
        {
            lastIndex = 0;
            array = new T[capacity];
        }

        public DynamicArray(int capacity, T newData) : this(capacity)
        {
            Append(newData);
        }
        #endregion

        #region Overrides

        #region Append
        public override void Append(T newData)
        {
            if(lastIndex+1 >= capacity)
                Resize(ResizeType.Extend);

            array[lastIndex++] = newData;
        }

        public override void AppendAll(T[] newDatas)
        {
            for(int i = 0; i < newDatas.Length; i++)
                Append(newDatas[i]);
        }
        #endregion

        public override void Insert(T newData, int index)
        {
            if (lastIndex+1 >= capacity)
                Resize(ResizeType.Extend);

            index = index < 0 ? 0 :
                    index >= capacity ? capacity - 1 : index;

            // 인덱스가 LastIndex-1이상인 경우 (Append와 같음)
            if (index >= lastIndex)
                array[lastIndex++] = newData;
            else
            {
                // 일반적인 경우
                for(int i = lastIndex; i >= index; i--)
                {
                    array[i+1] = array[i];
                }

                array[index] = newData;
                lastIndex++;
            }
        }

        public override T? Search(int index)
        {
            index = index < 0 ? 0 :
                    index >= capacity ? capacity-1 : index;

            T? searchedData = array[index] != null ? array[index] : default;
            return searchedData;
        }

        public override T? Delete(int index)
        {
            T? deletedData = default;

            if (lastIndex-1 < capacity/2)
                Resize(ResizeType.Reduce);

            index = index < 0 ? 0 :
                    index >= capacity ? capacity - 1 : index;

            // 인덱스가 LastIndex-1이상인 경우
            if (index > lastIndex)
                array[lastIndex--] = default;
            else
            {
                // 일반적인 경우
                array[index] = default;
                deletedData = array[index];
                lastIndex--;

                for (int i = index; i < lastIndex; i++)
                {
                    array[i] = array[i+1];
                    array[i+1] = default;
                }
            }

            return deletedData;
        }

        public override void Traversal()
        {
            int currentIndex = 0;

            while(currentIndex < capacity &&
                array[currentIndex] != null)
            {
                Console.Write($"{array[currentIndex++]} ");
            }
        }
        #endregion

        #region Private Functions
        /// <summary>
        /// 배열 크기 재조정 함수
        /// </summary>
        /// <param name="type"></param>
        private void Resize(ResizeType type)
        {
            if (array == null)
                return;

            int length = 0;
            switch (type)
            {
                case ResizeType.Extend:
                    capacity = array.Length * 2;
                    length = array.Length;
                    break;
                case ResizeType.Reduce:
                    capacity = array.Length / 2;
                    length = capacity;
                    break;
            }

            T[] newArray = new T[capacity];
            for (int i = 0; i < length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }
        #endregion
    }
}
