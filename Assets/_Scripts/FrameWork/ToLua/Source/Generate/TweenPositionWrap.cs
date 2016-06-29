using System;
using LuaInterface;

public class TweenPositionWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(TweenPosition), typeof(UITweener));
		L.RegFunction("Begin", Begin);
		L.RegFunction("SetStartToCurrentValue", SetStartToCurrentValue);
		L.RegFunction("SetEndToCurrentValue", SetEndToCurrentValue);
		L.RegFunction("New", _CreateTweenPosition);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("from", get_from, set_from);
		L.RegVar("to", get_to, set_to);
		L.RegVar("worldSpace", get_worldSpace, set_worldSpace);
		L.RegVar("cachedTransform", get_cachedTransform, null);
		L.RegVar("value", get_value, set_value);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateTweenPosition(IntPtr L)
	{
		return LuaDLL.tolua_error(L, "TweenPosition class does not have a constructor function");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Begin(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3 && ToLua.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(float), typeof(UnityEngine.Vector3)))
			{
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
				UnityEngine.Vector3 arg2 = ToLua.ToVector3(L, 3);
				TweenPosition o = TweenPosition.Begin(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 4 && ToLua.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(float), typeof(UnityEngine.Vector3), typeof(bool)))
			{
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
				UnityEngine.Vector3 arg2 = ToLua.ToVector3(L, 3);
				bool arg3 = LuaDLL.lua_toboolean(L, 4);
				TweenPosition o = TweenPosition.Begin(arg0, arg1, arg2, arg3);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.tolua_error(L, "invalid arguments to method: TweenPosition.Begin");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetStartToCurrentValue(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TweenPosition obj = (TweenPosition)ToLua.CheckObject(L, 1, typeof(TweenPosition));
			obj.SetStartToCurrentValue();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetEndToCurrentValue(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TweenPosition obj = (TweenPosition)ToLua.CheckObject(L, 1, typeof(TweenPosition));
			obj.SetEndToCurrentValue();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_from(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TweenPosition obj = (TweenPosition)o;
			UnityEngine.Vector3 ret = obj.from;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index from on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_to(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TweenPosition obj = (TweenPosition)o;
			UnityEngine.Vector3 ret = obj.to;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index to on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_worldSpace(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TweenPosition obj = (TweenPosition)o;
			bool ret = obj.worldSpace;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index worldSpace on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cachedTransform(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TweenPosition obj = (TweenPosition)o;
			UnityEngine.Transform ret = obj.cachedTransform;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index cachedTransform on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_value(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TweenPosition obj = (TweenPosition)o;
			UnityEngine.Vector3 ret = obj.value;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index value on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_from(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TweenPosition obj = (TweenPosition)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.from = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index from on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_to(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TweenPosition obj = (TweenPosition)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.to = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index to on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_worldSpace(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TweenPosition obj = (TweenPosition)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.worldSpace = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index worldSpace on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_value(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TweenPosition obj = (TweenPosition)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.value = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index value on a nil value" : e.Message);
		}
	}
}
