using Structure_And_Algorithm.Structure.Utils;

namespace Structure_And_Algorithm.Structure.LinearStructures.No1_Array
{
    /// <summary>
    /// 동적 배열
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DynamicArray<T, K> where K : AbstractArray<T>, new() {

        #region Properties
        public int Capacity { get => arr.Size(); }

        #endregion

        private int lastIndex;

        public AbstractArray<T> arr;

        public DynamicArray() {
            arr = new K();
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
}