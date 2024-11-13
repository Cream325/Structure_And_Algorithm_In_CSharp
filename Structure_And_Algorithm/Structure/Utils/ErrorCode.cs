using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Utils
{
    /// <summary>
    /// 에러 코드
    /// </summary>
    public enum ErrorCode
    {
        /// <summary>
        /// 정상
        /// </summary>
        Ok = 0,
        
        /// <summary>
        /// Head가 Null인 경우
        /// </summary>
        NullOfHeader = 1000,

        /// <summary>
        /// 인덱스 언더플로우(0미만인 경우)
        /// </summary>
        UnderflowedIndex = 1001,

        /// <summary>
        /// 인덱스 오버플로우(최대 길이 이상인 경우)
        /// </summary>
        OverflowedIndex = 1002,

        /// <summary>
        /// 스택 언더플로우
        /// </summary>
        EmptyOfStack = 2001,

        /// <summary>
        /// 스택 오버플로우
        /// </summary>
        FullOfStack = 2002,

        /// <summary>
        /// 큐 언더플로우
        /// </summary>
        EmptyOfQueue = 2003,

        /// <summary>
        /// 큐 오버플로우
        /// </summary>
        FullOfQueue = 2004
    }
}
