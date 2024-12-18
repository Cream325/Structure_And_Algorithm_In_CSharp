﻿using Structure_And_Algorithm.Structure.Utils;

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

        #region Insert
        public override void Insert(T newData, int index)
        {
            CheckIndex(index);

            if (lastIndex + 1 == length)
            {
                Resize(array.Length * 2);
            }

            for (int i = lastIndex; i >= index; i--)
            {
                array[i + 1] = array[i];
            }

            array[index] = newData;
            lastIndex++;
        }
        #endregion

        #region Search
        public override T Search(int index)
        {
            CheckIndex(index);

            return array[index];
        }
        #endregion

        #region Delete
        public override T Delete(int index)
        {
            CheckIndex(index);

            if (lastIndex - 1 < length / 2)
            {
                Resize(length / 2);
            }

            T deletedData = array[index];

            for (int i = index; i < lastIndex; i++)
            {
                array[i] = array[i + 1];
            }

            lastIndex--;

            return deletedData;
        }
        #endregion

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
            length = newSize;
        }
        #endregion
    }
}
