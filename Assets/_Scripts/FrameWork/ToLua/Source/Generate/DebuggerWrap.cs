using System;
using LuaInterface;

public class DebuggerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("Debugger");
		L.RegFunction("Log", Log);
		L.RegFunction("LogWarning", LogWarning);
		L.RegFunction("LogError", LogError);
		L.RegFunction("LogException", LogException);
		L.RegVar("useLog", get_useLog, set_useLog);
		L.RegVar("threadStack", get_threadStack, set_threadStack);
		L.RegVar("logger", get_logger, set_logger);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Log(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && ToLua.CheckTypes(L, 1, typeof(string)))
			{
				string arg0 = ToLua.ToString(L, 1);
				Debugger.Log(arg0);
				return 0;
			}
			else if (count == 1 && ToLua.CheckTypes(L, 1, typeof(object)))
			{
				object arg0 = ToLua.ToVarObject(L, 1);
				Debugger.Log(arg0);
				return 0;
			}
			else if (count == 2 && ToLua.CheckTypes(L, 1, typeof(string), typeof(object)))
			{
				string arg0 = ToLua.ToString(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				Debugger.Log(arg0, arg1);
				return 0;
			}
			else if (count == 3 && ToLua.CheckTypes(L, 1, typeof(string), typeof(object), typeof(object)))
			{
				string arg0 = ToLua.ToString(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				object arg2 = ToLua.ToVarObject(L, 3);
				Debugger.Log(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 4 && ToLua.CheckTypes(L, 1, typeof(string), typeof(object), typeof(object), typeof(object)))
			{
				string arg0 = ToLua.ToString(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				object arg2 = ToLua.ToVarObject(L, 3);
				object arg3 = ToLua.ToVarObject(L, 4);
				Debugger.Log(arg0, arg1, arg2, arg3);
				return 0;
			}
			else if (ToLua.CheckTypes(L, 1, typeof(string)) && ToLua.CheckParamsType(L, typeof(object), 2, count - 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				object[] arg1 = ToLua.ToParamsObject(L, 2, count - 1);
				Debugger.Log(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.tolua_error(L, "invalid arguments to method: Debugger.Log");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LogWarning(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && ToLua.CheckTypes(L, 1, typeof(string)))
			{
				string arg0 = ToLua.ToString(L, 1);
				Debugger.LogWarning(arg0);
				return 0;
			}
			else if (count == 1 && ToLua.CheckTypes(L, 1, typeof(object)))
			{
				object arg0 = ToLua.ToVarObject(L, 1);
				Debugger.LogWarning(arg0);
				return 0;
			}
			else if (count == 2 && ToLua.CheckTypes(L, 1, typeof(string), typeof(object)))
			{
				string arg0 = ToLua.ToString(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				Debugger.LogWarning(arg0, arg1);
				return 0;
			}
			else if (count == 3 && ToLua.CheckTypes(L, 1, typeof(string), typeof(object), typeof(object)))
			{
				string arg0 = ToLua.ToString(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				object arg2 = ToLua.ToVarObject(L, 3);
				Debugger.LogWarning(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 4 && ToLua.CheckTypes(L, 1, typeof(string), typeof(object), typeof(object), typeof(object)))
			{
				string arg0 = ToLua.ToString(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				object arg2 = ToLua.ToVarObject(L, 3);
				object arg3 = ToLua.ToVarObject(L, 4);
				Debugger.LogWarning(arg0, arg1, arg2, arg3);
				return 0;
			}
			else if (ToLua.CheckTypes(L, 1, typeof(string)) && ToLua.CheckParamsType(L, typeof(object), 2, count - 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				object[] arg1 = ToLua.ToParamsObject(L, 2, count - 1);
				Debugger.LogWarning(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.tolua_error(L, "invalid arguments to method: Debugger.LogWarning");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LogError(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && ToLua.CheckTypes(L, 1, typeof(string)))
			{
				string arg0 = ToLua.ToString(L, 1);
				Debugger.LogError(arg0);
				return 0;
			}
			else if (count == 1 && ToLua.CheckTypes(L, 1, typeof(object)))
			{
				object arg0 = ToLua.ToVarObject(L, 1);
				Debugger.LogError(arg0);
				return 0;
			}
			else if (count == 2 && ToLua.CheckTypes(L, 1, typeof(string), typeof(object)))
			{
				string arg0 = ToLua.ToString(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				Debugger.LogError(arg0, arg1);
				return 0;
			}
			else if (count == 3 && ToLua.CheckTypes(L, 1, typeof(string), typeof(object), typeof(object)))
			{
				string arg0 = ToLua.ToString(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				object arg2 = ToLua.ToVarObject(L, 3);
				Debugger.LogError(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 4 && ToLua.CheckTypes(L, 1, typeof(string), typeof(object), typeof(object), typeof(object)))
			{
				string arg0 = ToLua.ToString(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				object arg2 = ToLua.ToVarObject(L, 3);
				object arg3 = ToLua.ToVarObject(L, 4);
				Debugger.LogError(arg0, arg1, arg2, arg3);
				return 0;
			}
			else if (ToLua.CheckTypes(L, 1, typeof(string)) && ToLua.CheckParamsType(L, typeof(object), 2, count - 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				object[] arg1 = ToLua.ToParamsObject(L, 2, count - 1);
				Debugger.LogError(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.tolua_error(L, "invalid arguments to method: Debugger.LogError");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LogException(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && ToLua.CheckTypes(L, 1, typeof(System.Exception)))
			{
				System.Exception arg0 = (System.Exception)ToLua.ToObject(L, 1);
				Debugger.LogException(arg0);
				return 0;
			}
			else if (count == 2 && ToLua.CheckTypes(L, 1, typeof(string), typeof(System.Exception)))
			{
				string arg0 = ToLua.ToString(L, 1);
				System.Exception arg1 = (System.Exception)ToLua.ToObject(L, 2);
				Debugger.LogException(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.tolua_error(L, "invalid arguments to method: Debugger.LogException");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_useLog(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, Debugger.useLog);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_threadStack(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, Debugger.threadStack);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_logger(IntPtr L)
	{
		ToLua.PushObject(L, Debugger.logger);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_useLog(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			Debugger.useLog = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_threadStack(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			Debugger.threadStack = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_logger(IntPtr L)
	{
		try
		{
			ILogger arg0 = (ILogger)ToLua.CheckObject(L, 2, typeof(ILogger));
			Debugger.logger = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
