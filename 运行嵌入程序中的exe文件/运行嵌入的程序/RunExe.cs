using System;
using System.Reflection;

namespace 运行嵌入的程序
{
    internal class RunExe
    {
        public static string RunExeRes(Byte[] resFileName)
        {
            return RunExeRes(resFileName, null);
        }

        public static string RunExeRes(Byte[] resFileName, string[] args)
        {
            try
            {
                // 如果不用object[]将args包装，将会报“参数计算出错”的异常
                object[] objs = new object[] { args };
                Assembly asm = Assembly.Load(resFileName);
                MethodInfo info = asm.EntryPoint;
                ParameterInfo[] parameters = info.GetParameters();
                if (args != null)
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        info.Invoke(null, objs);
                    }
                    else
                    {
                        info.Invoke(null, null);
                    }
                }
                else
                {
                    info.Invoke(null, null);
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
