using Structure_And_Algorithm.Structure.Utils;

namespace Structure_And_Algorithm.Structure.LinearStructures.No1_Array
{
    public class ArrayDynamic<T> : AbstractArray<T>
    {
        private T[] data;

        public ArrayDynamic() { data = new T[0]; }


        public bool Insert(T newData, int index)
        {
            if(index < data.Length) {
                data[index] = newData;
                return false;
            }

            return true;
        }

        public void ReSize(int newlen)
        {
            T[] a = new T[newlen];

            for(int i = 0; i < data.Length; i++) {

                a[i] = data[i];
            }

            data = a;
        }

        public T? Search(int index)
        {
            if(index < data.Length) {
                return data[index];
            }

            return default;
        }

        public int Size()
        {
            return data.Length;
        }
    }

    /// <summary>
    /// 동적 배열
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class IVector<T> {
        #region Properties
        public int Capacity { get => arr.Size(); }

        #endregion

        private int lastIndex;

        public AbstractArray<T> arr;

        public IVector(AbstractArray<T> a) {
            arr = a;
        }
        
        #region Append
        /// <summary>
        /// 배열 - 단일 추가
        /// </summary>
        /// <param name="newData"></param>
        public void Append(T newData) {
            if(lastIndex+1 >= Capacity) {
                arr.ReSize(Capacity << 1);
            }

            arr.Insert(newData, lastIndex++);
        }

        /// <summary>
        /// 배열 - 전체 추가
        /// </summary>
        /// <param name="newDatas"></param>
        public void AppendAll(T[] newDatas) {
            for(int i = 0; i < newDatas.Length; i++)
                Append(newDatas[i]);
        }


        #endregion

        #region Delete
        /// <summary>
        /// 배열 - 단일 삭제
        /// </summary>
        /// <param name="index"></param>
        public T? Delete(int index) {
            T? deletedData = default;

            if (lastIndex-1 < Capacity/2)
                arr.ReSize(Capacity >> 1);

            index = index < 0 ? 0 :
                    index >= Capacity ? Capacity - 1 : index;

            // 인덱스가 LastIndex-1이상인 경우
            if (index > lastIndex)
                lastIndex--;
            else
            {
                // 일반적인 경우
                // array[index] = default;
                deletedData = arr.Search(index);
                lastIndex--;

                for (int i = index; i < lastIndex; i++)
                    arr.Insert(arr.Search(i + 1) ?? default, i);
            }

            return deletedData;
        }
        #endregion   
    }
    // charger
    public class AbstractVector<T, K> : IVector<T> where K : AbstractArray<T>, new() {
        public AbstractVector() : base(new K()) {}
    }

    public class ArrayVector<T> : AbstractVector<T, ArrayDynamic<T>> {} // version
}