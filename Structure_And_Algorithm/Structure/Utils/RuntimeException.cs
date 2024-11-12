using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Utils
{
    /// <summary>
    /// 런타임 예외
    /// </summary>
    public class RuntimeException : Exception
    {
        #region Member Fields
        private int code = 0;
        private string? errorMessage = string.Empty;
        #endregion

        #region Propertied
        /// <summary>
        /// 에러 코드
        /// </summary>
        public int Code { get => code; set => code = value; }

        /// <summary>
        /// 에러 메시지
        /// </summary>
        public string? ErrorMessage { get => errorMessage; set => errorMessage = value; }
        #endregion

        #region Constructors
        public RuntimeException() { }

        public RuntimeException(string? message) : base(message) { }

        public RuntimeException(int code, string? message) : base(message) { }

        public RuntimeException(int code, string? message, Exception? innerException) : base(message, innerException) { }
        #endregion
    }
}
