using System;
using System.IO;
namespace Curso.Common
{
    public class Logging
    {
        #region --Attributes--

        private static volatile Logging _instance;
        private string _path = "C:/Users/Nicolas/Desktop/Curso_Final/Proyecto Final/Curso.Common/LogFile/Curso.log";
        private StreamWriter _wr;

        #endregion --Attributes--

        #region --Singleton--

        public static Logging Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (typeof(Logging))
                    {
                        if (_instance == null)
                            _instance = new Logging();
                    }
                }
                return _instance;
            }
        }

        #endregion --Singleton--

        #region --Constructors & Destructors--

        private Logging()
        {
            try
            {

            }
            catch
            {
                //Si no hay seteado un logger, continua y listo....!!!!
            }
        }

        #endregion --Constructors & Destructors--

        #region --Methods--

        public void LogError(string message)
        {
            _wr = new StreamWriter(_path, true);
            _wr.WriteLine(DateTime.Now + ", " + message);
            _wr.Close();
            
        }

        public void LogError(string message, System.Exception ex)
        {
            _wr = new StreamWriter(_path, true);
            _wr.WriteLine(DateTime.Now + ", " + message);
            _wr.Close();
            
        }

        public void LogError(System.Exception ex)
        {
            _wr = new StreamWriter(_path, true);
            _wr.Write(DateTime.Now + ", " + ex.ToString());
            _wr.Close();

        }

        #endregion
    }
}
