using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Utils
{
    /// <summary>
    /// 로그 레벨
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// 동작
        /// </summary>
        Info,
        /// <summary>
        /// 경고
        /// </summary>
        Warn,
        /// <summary>
        /// 에러
        /// </summary>
        Error
    }

    /// <summary>
    /// 로그 작성용 클래스
    /// </summary>
    public sealed class Logger
    {
        #region Member Fields
        private static Logger? instance;

        /// <summary>
        /// 로그 경로
        /// </summary>
        private string logPath;
        #endregion

        #region Properties
        /// <summary>
        /// Instance
        /// </summary>
        public Logger Instance { get => instance; }
        #endregion

        #region Constructors
        private Logger() { }

        private Logger(string logPath)
        {
            this.logPath = logPath;
        }
        #endregion

        #region Public Functions
        /// <summary>
        /// 로거 생성
        /// </summary>
        /// <param name="logPath"></param>
        public static void CreateLogger(string logPath)
        {
            if(instance == null) instance = new(logPath);

            if(!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);

                string filePath = Path.Combine(logPath, $"{DateTime.Now.ToString("yyyyMMdd")}.log");
                File.Create(filePath);
            }
        }

        /// <summary>
        /// 로그 작성
        /// </summary>
        /// <param name="message"></param>
        /// <param name="level"></param>
        public static void WriteLog(string message, LogLevel level = LogLevel.Info)
        {
            DateTime today = DateTime.Now;
            string currentTime =today.ToString("HHmmss");
            string filePath = Path.Combine(instance.logPath, $"{today.ToString("yyyyMMdd")}.log");

            if (!File.Exists(filePath))
                File.Create(filePath);

            File.AppendAllTextAsync(filePath, $"{currentTime}, {level} - {message}\n");
        }
        #endregion
    }
}
