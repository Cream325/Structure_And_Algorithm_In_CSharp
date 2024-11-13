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
        private ErrorCode code = ErrorCode.Ok;
        private string? errorMessage = string.Empty;
        #endregion

        #region Propertied
        /// <summary>
        /// 에러 코드
        /// </summary>
        public ErrorCode Code { get => code; set => code = value; }

        /// <summary>
        /// 에러 메시지
        /// </summary>
        public string? ErrorMessage { get => errorMessage; set => errorMessage = value; }
        #endregion

        #region Constructors
        public RuntimeException() { }

        public RuntimeException(string? errorMessage) : base(errorMessage)
        {
            this.code = ErrorCode.Ok;
            this.errorMessage = errorMessage;
        }

        public RuntimeException(ErrorCode code, string? errorMessage) : base(errorMessage)
        {
            this.code = code;
            this.errorMessage = errorMessage;
        }

        public RuntimeException(ErrorCode code, string? errorMessage, Exception? innerException) : base(errorMessage, innerException) { }
        #endregion
    }
}
