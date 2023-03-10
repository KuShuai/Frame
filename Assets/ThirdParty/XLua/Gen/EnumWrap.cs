#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    
    public class UILayerWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UILayer), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UILayer), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UILayer), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Fixed", UILayer.Fixed);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Normal", UILayer.Normal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top", UILayer.Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Count", UILayer.Count);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__ToInt", __ToInt);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UILayer), L, translator);
        }

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __ToInt(RealStatePtr L)
		{
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            UILayer _enumValue;
            translator.Get(L, 1, out _enumValue);
            LuaAPI.xlua_pushinteger(L, (int)_enumValue);
            return 1;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUILayer(L, (UILayer)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Fixed"))
                {
                    translator.PushUILayer(L, UILayer.Fixed);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Normal"))
                {
                    translator.PushUILayer(L, UILayer.Normal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Top"))
                {
                    translator.PushUILayer(L, UILayer.Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Count"))
                {
                    translator.PushUILayer(L, UILayer.Count);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UILayer!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UILayer! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class EComponentWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(EComponent), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(EComponent), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(EComponent), L, null, 23, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Image", EComponent.Image);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Canvas", EComponent.Canvas);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RawImage", EComponent.RawImage);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Text", EComponent.Text);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Button", EComponent.Button);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Slider", EComponent.Slider);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Toggle", EComponent.Toggle);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ToggleGroup", EComponent.ToggleGroup);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScrollRect", EComponent.ScrollRect);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RectTransform", EComponent.RectTransform);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Transform", EComponent.Transform);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CanvasGroup", EComponent.CanvasGroup);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Animator", EComponent.Animator);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InputField", EComponent.InputField);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "GridLayoutGroup", EComponent.GridLayoutGroup);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PlayableDirector", EComponent.PlayableDirector);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EventTrigger", EComponent.EventTrigger);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SpriteRenderer", EComponent.SpriteRenderer);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TextMesh", EComponent.TextMesh);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ContentSizeFitter", EComponent.ContentSizeFitter);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CanvasScaler", EComponent.CanvasScaler);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CinemachineBrain", EComponent.CinemachineBrain);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__ToInt", __ToInt);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(EComponent), L, translator);
        }

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __ToInt(RealStatePtr L)
		{
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            EComponent _enumValue;
            translator.Get(L, 1, out _enumValue);
            LuaAPI.xlua_pushinteger(L, (int)_enumValue);
            return 1;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushEComponent(L, (EComponent)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Image"))
                {
                    translator.PushEComponent(L, EComponent.Image);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Canvas"))
                {
                    translator.PushEComponent(L, EComponent.Canvas);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RawImage"))
                {
                    translator.PushEComponent(L, EComponent.RawImage);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Text"))
                {
                    translator.PushEComponent(L, EComponent.Text);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Button"))
                {
                    translator.PushEComponent(L, EComponent.Button);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Slider"))
                {
                    translator.PushEComponent(L, EComponent.Slider);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Toggle"))
                {
                    translator.PushEComponent(L, EComponent.Toggle);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ToggleGroup"))
                {
                    translator.PushEComponent(L, EComponent.ToggleGroup);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScrollRect"))
                {
                    translator.PushEComponent(L, EComponent.ScrollRect);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RectTransform"))
                {
                    translator.PushEComponent(L, EComponent.RectTransform);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Transform"))
                {
                    translator.PushEComponent(L, EComponent.Transform);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CanvasGroup"))
                {
                    translator.PushEComponent(L, EComponent.CanvasGroup);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Animator"))
                {
                    translator.PushEComponent(L, EComponent.Animator);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InputField"))
                {
                    translator.PushEComponent(L, EComponent.InputField);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "GridLayoutGroup"))
                {
                    translator.PushEComponent(L, EComponent.GridLayoutGroup);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PlayableDirector"))
                {
                    translator.PushEComponent(L, EComponent.PlayableDirector);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EventTrigger"))
                {
                    translator.PushEComponent(L, EComponent.EventTrigger);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SpriteRenderer"))
                {
                    translator.PushEComponent(L, EComponent.SpriteRenderer);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TextMesh"))
                {
                    translator.PushEComponent(L, EComponent.TextMesh);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ContentSizeFitter"))
                {
                    translator.PushEComponent(L, EComponent.ContentSizeFitter);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CanvasScaler"))
                {
                    translator.PushEComponent(L, EComponent.CanvasScaler);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CinemachineBrain"))
                {
                    translator.PushEComponent(L, EComponent.CinemachineBrain);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for EComponent!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for EComponent! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class SystemReflectionBindingFlagsWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(System.Reflection.BindingFlags), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(System.Reflection.BindingFlags), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(System.Reflection.BindingFlags), L, null, 21, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Default", System.Reflection.BindingFlags.Default);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IgnoreCase", System.Reflection.BindingFlags.IgnoreCase);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DeclaredOnly", System.Reflection.BindingFlags.DeclaredOnly);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Instance", System.Reflection.BindingFlags.Instance);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Static", System.Reflection.BindingFlags.Static);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Public", System.Reflection.BindingFlags.Public);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NonPublic", System.Reflection.BindingFlags.NonPublic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FlattenHierarchy", System.Reflection.BindingFlags.FlattenHierarchy);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InvokeMethod", System.Reflection.BindingFlags.InvokeMethod);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CreateInstance", System.Reflection.BindingFlags.CreateInstance);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "GetField", System.Reflection.BindingFlags.GetField);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SetField", System.Reflection.BindingFlags.SetField);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "GetProperty", System.Reflection.BindingFlags.GetProperty);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SetProperty", System.Reflection.BindingFlags.SetProperty);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PutDispProperty", System.Reflection.BindingFlags.PutDispProperty);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PutRefDispProperty", System.Reflection.BindingFlags.PutRefDispProperty);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ExactBinding", System.Reflection.BindingFlags.ExactBinding);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SuppressChangeType", System.Reflection.BindingFlags.SuppressChangeType);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OptionalParamBinding", System.Reflection.BindingFlags.OptionalParamBinding);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IgnoreReturn", System.Reflection.BindingFlags.IgnoreReturn);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__ToInt", __ToInt);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(System.Reflection.BindingFlags), L, translator);
        }

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __ToInt(RealStatePtr L)
		{
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            System.Reflection.BindingFlags _enumValue;
            translator.Get(L, 1, out _enumValue);
            LuaAPI.xlua_pushinteger(L, (int)_enumValue);
            return 1;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushSystemReflectionBindingFlags(L, (System.Reflection.BindingFlags)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Default"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.Default);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IgnoreCase"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.IgnoreCase);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DeclaredOnly"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.DeclaredOnly);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Instance"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.Instance);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Static"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.Static);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Public"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.Public);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NonPublic"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.NonPublic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FlattenHierarchy"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.FlattenHierarchy);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InvokeMethod"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.InvokeMethod);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CreateInstance"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.CreateInstance);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "GetField"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.GetField);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SetField"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.SetField);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "GetProperty"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.GetProperty);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SetProperty"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.SetProperty);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PutDispProperty"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.PutDispProperty);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PutRefDispProperty"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.PutRefDispProperty);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ExactBinding"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.ExactBinding);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SuppressChangeType"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.SuppressChangeType);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OptionalParamBinding"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.OptionalParamBinding);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IgnoreReturn"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.IgnoreReturn);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for System.Reflection.BindingFlags!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for System.Reflection.BindingFlags! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineCameraClearFlagsWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.CameraClearFlags), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.CameraClearFlags), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.CameraClearFlags), L, null, 6, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Skybox", UnityEngine.CameraClearFlags.Skybox);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Color", UnityEngine.CameraClearFlags.Color);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SolidColor", UnityEngine.CameraClearFlags.SolidColor);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Depth", UnityEngine.CameraClearFlags.Depth);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Nothing", UnityEngine.CameraClearFlags.Nothing);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__ToInt", __ToInt);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.CameraClearFlags), L, translator);
        }

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __ToInt(RealStatePtr L)
		{
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            UnityEngine.CameraClearFlags _enumValue;
            translator.Get(L, 1, out _enumValue);
            LuaAPI.xlua_pushinteger(L, (int)_enumValue);
            return 1;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineCameraClearFlags(L, (UnityEngine.CameraClearFlags)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Skybox"))
                {
                    translator.PushUnityEngineCameraClearFlags(L, UnityEngine.CameraClearFlags.Skybox);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Color"))
                {
                    translator.PushUnityEngineCameraClearFlags(L, UnityEngine.CameraClearFlags.Color);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SolidColor"))
                {
                    translator.PushUnityEngineCameraClearFlags(L, UnityEngine.CameraClearFlags.SolidColor);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Depth"))
                {
                    translator.PushUnityEngineCameraClearFlags(L, UnityEngine.CameraClearFlags.Depth);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Nothing"))
                {
                    translator.PushUnityEngineCameraClearFlags(L, UnityEngine.CameraClearFlags.Nothing);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.CameraClearFlags!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.CameraClearFlags! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineKeyCodeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.KeyCode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.KeyCode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.KeyCode), L, null, 327, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.KeyCode.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Backspace", UnityEngine.KeyCode.Backspace);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Delete", UnityEngine.KeyCode.Delete);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Tab", UnityEngine.KeyCode.Tab);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Clear", UnityEngine.KeyCode.Clear);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Return", UnityEngine.KeyCode.Return);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Pause", UnityEngine.KeyCode.Pause);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Escape", UnityEngine.KeyCode.Escape);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Space", UnityEngine.KeyCode.Space);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Keypad0", UnityEngine.KeyCode.Keypad0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Keypad1", UnityEngine.KeyCode.Keypad1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Keypad2", UnityEngine.KeyCode.Keypad2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Keypad3", UnityEngine.KeyCode.Keypad3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Keypad4", UnityEngine.KeyCode.Keypad4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Keypad5", UnityEngine.KeyCode.Keypad5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Keypad6", UnityEngine.KeyCode.Keypad6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Keypad7", UnityEngine.KeyCode.Keypad7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Keypad8", UnityEngine.KeyCode.Keypad8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Keypad9", UnityEngine.KeyCode.Keypad9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "KeypadPeriod", UnityEngine.KeyCode.KeypadPeriod);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "KeypadDivide", UnityEngine.KeyCode.KeypadDivide);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "KeypadMultiply", UnityEngine.KeyCode.KeypadMultiply);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "KeypadMinus", UnityEngine.KeyCode.KeypadMinus);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "KeypadPlus", UnityEngine.KeyCode.KeypadPlus);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "KeypadEnter", UnityEngine.KeyCode.KeypadEnter);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "KeypadEquals", UnityEngine.KeyCode.KeypadEquals);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpArrow", UnityEngine.KeyCode.UpArrow);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DownArrow", UnityEngine.KeyCode.DownArrow);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightArrow", UnityEngine.KeyCode.RightArrow);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftArrow", UnityEngine.KeyCode.LeftArrow);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Insert", UnityEngine.KeyCode.Insert);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Home", UnityEngine.KeyCode.Home);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "End", UnityEngine.KeyCode.End);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PageUp", UnityEngine.KeyCode.PageUp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PageDown", UnityEngine.KeyCode.PageDown);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F1", UnityEngine.KeyCode.F1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F2", UnityEngine.KeyCode.F2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F3", UnityEngine.KeyCode.F3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F4", UnityEngine.KeyCode.F4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F5", UnityEngine.KeyCode.F5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F6", UnityEngine.KeyCode.F6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F7", UnityEngine.KeyCode.F7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F8", UnityEngine.KeyCode.F8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F9", UnityEngine.KeyCode.F9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F10", UnityEngine.KeyCode.F10);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F11", UnityEngine.KeyCode.F11);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F12", UnityEngine.KeyCode.F12);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F13", UnityEngine.KeyCode.F13);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F14", UnityEngine.KeyCode.F14);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F15", UnityEngine.KeyCode.F15);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha0", UnityEngine.KeyCode.Alpha0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha1", UnityEngine.KeyCode.Alpha1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha2", UnityEngine.KeyCode.Alpha2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha3", UnityEngine.KeyCode.Alpha3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha4", UnityEngine.KeyCode.Alpha4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha5", UnityEngine.KeyCode.Alpha5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha6", UnityEngine.KeyCode.Alpha6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha7", UnityEngine.KeyCode.Alpha7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha8", UnityEngine.KeyCode.Alpha8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha9", UnityEngine.KeyCode.Alpha9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Exclaim", UnityEngine.KeyCode.Exclaim);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DoubleQuote", UnityEngine.KeyCode.DoubleQuote);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Hash", UnityEngine.KeyCode.Hash);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Dollar", UnityEngine.KeyCode.Dollar);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Percent", UnityEngine.KeyCode.Percent);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ampersand", UnityEngine.KeyCode.Ampersand);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Quote", UnityEngine.KeyCode.Quote);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftParen", UnityEngine.KeyCode.LeftParen);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightParen", UnityEngine.KeyCode.RightParen);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Asterisk", UnityEngine.KeyCode.Asterisk);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Plus", UnityEngine.KeyCode.Plus);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Comma", UnityEngine.KeyCode.Comma);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Minus", UnityEngine.KeyCode.Minus);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Period", UnityEngine.KeyCode.Period);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Slash", UnityEngine.KeyCode.Slash);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Colon", UnityEngine.KeyCode.Colon);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Semicolon", UnityEngine.KeyCode.Semicolon);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Less", UnityEngine.KeyCode.Less);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Equals", UnityEngine.KeyCode.Equals);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Greater", UnityEngine.KeyCode.Greater);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Question", UnityEngine.KeyCode.Question);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "At", UnityEngine.KeyCode.At);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftBracket", UnityEngine.KeyCode.LeftBracket);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Backslash", UnityEngine.KeyCode.Backslash);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightBracket", UnityEngine.KeyCode.RightBracket);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Caret", UnityEngine.KeyCode.Caret);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Underscore", UnityEngine.KeyCode.Underscore);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BackQuote", UnityEngine.KeyCode.BackQuote);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "A", UnityEngine.KeyCode.A);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "B", UnityEngine.KeyCode.B);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "C", UnityEngine.KeyCode.C);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "D", UnityEngine.KeyCode.D);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "E", UnityEngine.KeyCode.E);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F", UnityEngine.KeyCode.F);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "G", UnityEngine.KeyCode.G);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "H", UnityEngine.KeyCode.H);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "I", UnityEngine.KeyCode.I);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "J", UnityEngine.KeyCode.J);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "K", UnityEngine.KeyCode.K);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "L", UnityEngine.KeyCode.L);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "M", UnityEngine.KeyCode.M);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "N", UnityEngine.KeyCode.N);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "O", UnityEngine.KeyCode.O);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "P", UnityEngine.KeyCode.P);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Q", UnityEngine.KeyCode.Q);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "R", UnityEngine.KeyCode.R);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "S", UnityEngine.KeyCode.S);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "T", UnityEngine.KeyCode.T);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "U", UnityEngine.KeyCode.U);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "V", UnityEngine.KeyCode.V);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "W", UnityEngine.KeyCode.W);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "X", UnityEngine.KeyCode.X);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Y", UnityEngine.KeyCode.Y);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Z", UnityEngine.KeyCode.Z);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftCurlyBracket", UnityEngine.KeyCode.LeftCurlyBracket);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Pipe", UnityEngine.KeyCode.Pipe);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightCurlyBracket", UnityEngine.KeyCode.RightCurlyBracket);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Tilde", UnityEngine.KeyCode.Tilde);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Numlock", UnityEngine.KeyCode.Numlock);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CapsLock", UnityEngine.KeyCode.CapsLock);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScrollLock", UnityEngine.KeyCode.ScrollLock);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightShift", UnityEngine.KeyCode.RightShift);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftShift", UnityEngine.KeyCode.LeftShift);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightControl", UnityEngine.KeyCode.RightControl);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftControl", UnityEngine.KeyCode.LeftControl);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightAlt", UnityEngine.KeyCode.RightAlt);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftAlt", UnityEngine.KeyCode.LeftAlt);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftCommand", UnityEngine.KeyCode.LeftCommand);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftApple", UnityEngine.KeyCode.LeftApple);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftWindows", UnityEngine.KeyCode.LeftWindows);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightCommand", UnityEngine.KeyCode.RightCommand);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightApple", UnityEngine.KeyCode.RightApple);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightWindows", UnityEngine.KeyCode.RightWindows);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AltGr", UnityEngine.KeyCode.AltGr);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Help", UnityEngine.KeyCode.Help);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Print", UnityEngine.KeyCode.Print);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SysReq", UnityEngine.KeyCode.SysReq);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Break", UnityEngine.KeyCode.Break);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Menu", UnityEngine.KeyCode.Menu);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mouse0", UnityEngine.KeyCode.Mouse0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mouse1", UnityEngine.KeyCode.Mouse1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mouse2", UnityEngine.KeyCode.Mouse2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mouse3", UnityEngine.KeyCode.Mouse3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mouse4", UnityEngine.KeyCode.Mouse4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mouse5", UnityEngine.KeyCode.Mouse5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mouse6", UnityEngine.KeyCode.Mouse6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton0", UnityEngine.KeyCode.JoystickButton0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton1", UnityEngine.KeyCode.JoystickButton1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton2", UnityEngine.KeyCode.JoystickButton2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton3", UnityEngine.KeyCode.JoystickButton3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton4", UnityEngine.KeyCode.JoystickButton4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton5", UnityEngine.KeyCode.JoystickButton5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton6", UnityEngine.KeyCode.JoystickButton6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton7", UnityEngine.KeyCode.JoystickButton7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton8", UnityEngine.KeyCode.JoystickButton8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton9", UnityEngine.KeyCode.JoystickButton9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton10", UnityEngine.KeyCode.JoystickButton10);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton11", UnityEngine.KeyCode.JoystickButton11);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton12", UnityEngine.KeyCode.JoystickButton12);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton13", UnityEngine.KeyCode.JoystickButton13);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton14", UnityEngine.KeyCode.JoystickButton14);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton15", UnityEngine.KeyCode.JoystickButton15);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton16", UnityEngine.KeyCode.JoystickButton16);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton17", UnityEngine.KeyCode.JoystickButton17);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton18", UnityEngine.KeyCode.JoystickButton18);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton19", UnityEngine.KeyCode.JoystickButton19);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button0", UnityEngine.KeyCode.Joystick1Button0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button1", UnityEngine.KeyCode.Joystick1Button1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button2", UnityEngine.KeyCode.Joystick1Button2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button3", UnityEngine.KeyCode.Joystick1Button3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button4", UnityEngine.KeyCode.Joystick1Button4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button5", UnityEngine.KeyCode.Joystick1Button5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button6", UnityEngine.KeyCode.Joystick1Button6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button7", UnityEngine.KeyCode.Joystick1Button7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button8", UnityEngine.KeyCode.Joystick1Button8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button9", UnityEngine.KeyCode.Joystick1Button9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button10", UnityEngine.KeyCode.Joystick1Button10);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button11", UnityEngine.KeyCode.Joystick1Button11);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button12", UnityEngine.KeyCode.Joystick1Button12);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button13", UnityEngine.KeyCode.Joystick1Button13);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button14", UnityEngine.KeyCode.Joystick1Button14);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button15", UnityEngine.KeyCode.Joystick1Button15);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button16", UnityEngine.KeyCode.Joystick1Button16);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button17", UnityEngine.KeyCode.Joystick1Button17);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button18", UnityEngine.KeyCode.Joystick1Button18);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button19", UnityEngine.KeyCode.Joystick1Button19);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button0", UnityEngine.KeyCode.Joystick2Button0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button1", UnityEngine.KeyCode.Joystick2Button1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button2", UnityEngine.KeyCode.Joystick2Button2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button3", UnityEngine.KeyCode.Joystick2Button3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button4", UnityEngine.KeyCode.Joystick2Button4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button5", UnityEngine.KeyCode.Joystick2Button5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button6", UnityEngine.KeyCode.Joystick2Button6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button7", UnityEngine.KeyCode.Joystick2Button7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button8", UnityEngine.KeyCode.Joystick2Button8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button9", UnityEngine.KeyCode.Joystick2Button9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button10", UnityEngine.KeyCode.Joystick2Button10);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button11", UnityEngine.KeyCode.Joystick2Button11);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button12", UnityEngine.KeyCode.Joystick2Button12);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button13", UnityEngine.KeyCode.Joystick2Button13);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button14", UnityEngine.KeyCode.Joystick2Button14);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button15", UnityEngine.KeyCode.Joystick2Button15);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button16", UnityEngine.KeyCode.Joystick2Button16);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button17", UnityEngine.KeyCode.Joystick2Button17);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button18", UnityEngine.KeyCode.Joystick2Button18);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button19", UnityEngine.KeyCode.Joystick2Button19);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button0", UnityEngine.KeyCode.Joystick3Button0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button1", UnityEngine.KeyCode.Joystick3Button1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button2", UnityEngine.KeyCode.Joystick3Button2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button3", UnityEngine.KeyCode.Joystick3Button3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button4", UnityEngine.KeyCode.Joystick3Button4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button5", UnityEngine.KeyCode.Joystick3Button5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button6", UnityEngine.KeyCode.Joystick3Button6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button7", UnityEngine.KeyCode.Joystick3Button7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button8", UnityEngine.KeyCode.Joystick3Button8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button9", UnityEngine.KeyCode.Joystick3Button9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button10", UnityEngine.KeyCode.Joystick3Button10);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button11", UnityEngine.KeyCode.Joystick3Button11);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button12", UnityEngine.KeyCode.Joystick3Button12);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button13", UnityEngine.KeyCode.Joystick3Button13);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button14", UnityEngine.KeyCode.Joystick3Button14);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button15", UnityEngine.KeyCode.Joystick3Button15);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button16", UnityEngine.KeyCode.Joystick3Button16);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button17", UnityEngine.KeyCode.Joystick3Button17);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button18", UnityEngine.KeyCode.Joystick3Button18);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button19", UnityEngine.KeyCode.Joystick3Button19);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button0", UnityEngine.KeyCode.Joystick4Button0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button1", UnityEngine.KeyCode.Joystick4Button1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button2", UnityEngine.KeyCode.Joystick4Button2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button3", UnityEngine.KeyCode.Joystick4Button3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button4", UnityEngine.KeyCode.Joystick4Button4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button5", UnityEngine.KeyCode.Joystick4Button5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button6", UnityEngine.KeyCode.Joystick4Button6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button7", UnityEngine.KeyCode.Joystick4Button7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button8", UnityEngine.KeyCode.Joystick4Button8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button9", UnityEngine.KeyCode.Joystick4Button9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button10", UnityEngine.KeyCode.Joystick4Button10);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button11", UnityEngine.KeyCode.Joystick4Button11);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button12", UnityEngine.KeyCode.Joystick4Button12);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button13", UnityEngine.KeyCode.Joystick4Button13);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button14", UnityEngine.KeyCode.Joystick4Button14);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button15", UnityEngine.KeyCode.Joystick4Button15);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button16", UnityEngine.KeyCode.Joystick4Button16);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button17", UnityEngine.KeyCode.Joystick4Button17);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button18", UnityEngine.KeyCode.Joystick4Button18);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button19", UnityEngine.KeyCode.Joystick4Button19);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button0", UnityEngine.KeyCode.Joystick5Button0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button1", UnityEngine.KeyCode.Joystick5Button1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button2", UnityEngine.KeyCode.Joystick5Button2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button3", UnityEngine.KeyCode.Joystick5Button3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button4", UnityEngine.KeyCode.Joystick5Button4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button5", UnityEngine.KeyCode.Joystick5Button5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button6", UnityEngine.KeyCode.Joystick5Button6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button7", UnityEngine.KeyCode.Joystick5Button7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button8", UnityEngine.KeyCode.Joystick5Button8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button9", UnityEngine.KeyCode.Joystick5Button9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button10", UnityEngine.KeyCode.Joystick5Button10);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button11", UnityEngine.KeyCode.Joystick5Button11);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button12", UnityEngine.KeyCode.Joystick5Button12);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button13", UnityEngine.KeyCode.Joystick5Button13);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button14", UnityEngine.KeyCode.Joystick5Button14);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button15", UnityEngine.KeyCode.Joystick5Button15);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button16", UnityEngine.KeyCode.Joystick5Button16);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button17", UnityEngine.KeyCode.Joystick5Button17);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button18", UnityEngine.KeyCode.Joystick5Button18);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button19", UnityEngine.KeyCode.Joystick5Button19);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button0", UnityEngine.KeyCode.Joystick6Button0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button1", UnityEngine.KeyCode.Joystick6Button1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button2", UnityEngine.KeyCode.Joystick6Button2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button3", UnityEngine.KeyCode.Joystick6Button3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button4", UnityEngine.KeyCode.Joystick6Button4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button5", UnityEngine.KeyCode.Joystick6Button5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button6", UnityEngine.KeyCode.Joystick6Button6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button7", UnityEngine.KeyCode.Joystick6Button7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button8", UnityEngine.KeyCode.Joystick6Button8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button9", UnityEngine.KeyCode.Joystick6Button9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button10", UnityEngine.KeyCode.Joystick6Button10);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button11", UnityEngine.KeyCode.Joystick6Button11);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button12", UnityEngine.KeyCode.Joystick6Button12);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button13", UnityEngine.KeyCode.Joystick6Button13);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button14", UnityEngine.KeyCode.Joystick6Button14);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button15", UnityEngine.KeyCode.Joystick6Button15);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button16", UnityEngine.KeyCode.Joystick6Button16);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button17", UnityEngine.KeyCode.Joystick6Button17);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button18", UnityEngine.KeyCode.Joystick6Button18);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button19", UnityEngine.KeyCode.Joystick6Button19);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button0", UnityEngine.KeyCode.Joystick7Button0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button1", UnityEngine.KeyCode.Joystick7Button1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button2", UnityEngine.KeyCode.Joystick7Button2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button3", UnityEngine.KeyCode.Joystick7Button3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button4", UnityEngine.KeyCode.Joystick7Button4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button5", UnityEngine.KeyCode.Joystick7Button5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button6", UnityEngine.KeyCode.Joystick7Button6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button7", UnityEngine.KeyCode.Joystick7Button7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button8", UnityEngine.KeyCode.Joystick7Button8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button9", UnityEngine.KeyCode.Joystick7Button9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button10", UnityEngine.KeyCode.Joystick7Button10);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button11", UnityEngine.KeyCode.Joystick7Button11);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button12", UnityEngine.KeyCode.Joystick7Button12);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button13", UnityEngine.KeyCode.Joystick7Button13);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button14", UnityEngine.KeyCode.Joystick7Button14);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button15", UnityEngine.KeyCode.Joystick7Button15);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button16", UnityEngine.KeyCode.Joystick7Button16);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button17", UnityEngine.KeyCode.Joystick7Button17);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button18", UnityEngine.KeyCode.Joystick7Button18);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button19", UnityEngine.KeyCode.Joystick7Button19);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button0", UnityEngine.KeyCode.Joystick8Button0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button1", UnityEngine.KeyCode.Joystick8Button1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button2", UnityEngine.KeyCode.Joystick8Button2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button3", UnityEngine.KeyCode.Joystick8Button3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button4", UnityEngine.KeyCode.Joystick8Button4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button5", UnityEngine.KeyCode.Joystick8Button5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button6", UnityEngine.KeyCode.Joystick8Button6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button7", UnityEngine.KeyCode.Joystick8Button7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button8", UnityEngine.KeyCode.Joystick8Button8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button9", UnityEngine.KeyCode.Joystick8Button9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button10", UnityEngine.KeyCode.Joystick8Button10);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button11", UnityEngine.KeyCode.Joystick8Button11);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button12", UnityEngine.KeyCode.Joystick8Button12);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button13", UnityEngine.KeyCode.Joystick8Button13);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button14", UnityEngine.KeyCode.Joystick8Button14);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button15", UnityEngine.KeyCode.Joystick8Button15);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button16", UnityEngine.KeyCode.Joystick8Button16);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button17", UnityEngine.KeyCode.Joystick8Button17);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button18", UnityEngine.KeyCode.Joystick8Button18);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button19", UnityEngine.KeyCode.Joystick8Button19);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__ToInt", __ToInt);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.KeyCode), L, translator);
        }

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __ToInt(RealStatePtr L)
		{
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            UnityEngine.KeyCode _enumValue;
            translator.Get(L, 1, out _enumValue);
            LuaAPI.xlua_pushinteger(L, (int)_enumValue);
            return 1;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineKeyCode(L, (UnityEngine.KeyCode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Backspace"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Backspace);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Delete"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Delete);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Tab"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Tab);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Clear"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Clear);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Return"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Return);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Pause"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Pause);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Escape"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Escape);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Space"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Space);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Keypad0"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Keypad0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Keypad1"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Keypad1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Keypad2"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Keypad2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Keypad3"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Keypad3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Keypad4"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Keypad4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Keypad5"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Keypad5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Keypad6"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Keypad6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Keypad7"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Keypad7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Keypad8"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Keypad8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Keypad9"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Keypad9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "KeypadPeriod"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.KeypadPeriod);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "KeypadDivide"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.KeypadDivide);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "KeypadMultiply"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.KeypadMultiply);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "KeypadMinus"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.KeypadMinus);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "KeypadPlus"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.KeypadPlus);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "KeypadEnter"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.KeypadEnter);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "KeypadEquals"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.KeypadEquals);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UpArrow"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.UpArrow);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DownArrow"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.DownArrow);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightArrow"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.RightArrow);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftArrow"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.LeftArrow);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Insert"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Insert);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Home"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Home);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "End"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.End);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PageUp"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.PageUp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PageDown"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.PageDown);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F1"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.F1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F2"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.F2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F3"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.F3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F4"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.F4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F5"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.F5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F6"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.F6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F7"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.F7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F8"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.F8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F9"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.F9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F10"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.F10);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F11"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.F11);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F12"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.F12);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F13"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.F13);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F14"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.F14);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F15"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.F15);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha0"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Alpha0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha1"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Alpha1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha2"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Alpha2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha3"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Alpha3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha4"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Alpha4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha5"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Alpha5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha6"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Alpha6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha7"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Alpha7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha8"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Alpha8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha9"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Alpha9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Exclaim"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Exclaim);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DoubleQuote"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.DoubleQuote);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Hash"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Hash);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Dollar"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Dollar);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Percent"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Percent);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Ampersand"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Ampersand);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Quote"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Quote);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftParen"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.LeftParen);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightParen"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.RightParen);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Asterisk"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Asterisk);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Plus"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Plus);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Comma"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Comma);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Minus"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Minus);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Period"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Period);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Slash"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Slash);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Colon"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Colon);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Semicolon"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Semicolon);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Less"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Less);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Equals"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Equals);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Greater"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Greater);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Question"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Question);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "At"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.At);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftBracket"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.LeftBracket);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Backslash"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Backslash);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightBracket"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.RightBracket);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Caret"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Caret);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Underscore"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Underscore);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BackQuote"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.BackQuote);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "A"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.A);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "B"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.B);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "C"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.C);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "D"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.D);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "E"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.E);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.F);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "G"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.G);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "H"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.H);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "I"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.I);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "J"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.J);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "K"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.K);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "L"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.L);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "M"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.M);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "N"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.N);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "O"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.O);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "P"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.P);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Q"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Q);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "R"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.R);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "S"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.S);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "T"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.T);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "U"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.U);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "V"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.V);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "W"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.W);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "X"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.X);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Y"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Y);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Z"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Z);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftCurlyBracket"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.LeftCurlyBracket);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Pipe"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Pipe);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightCurlyBracket"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.RightCurlyBracket);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Tilde"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Tilde);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Numlock"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Numlock);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CapsLock"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.CapsLock);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScrollLock"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.ScrollLock);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightShift"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.RightShift);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftShift"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.LeftShift);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightControl"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.RightControl);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftControl"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.LeftControl);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightAlt"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.RightAlt);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftAlt"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.LeftAlt);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftCommand"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.LeftCommand);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftApple"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.LeftApple);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftWindows"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.LeftWindows);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightCommand"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.RightCommand);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightApple"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.RightApple);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightWindows"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.RightWindows);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AltGr"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.AltGr);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Help"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Help);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Print"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Print);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SysReq"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.SysReq);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Break"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Break);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Menu"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Menu);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mouse0"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Mouse0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mouse1"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Mouse1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mouse2"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Mouse2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mouse3"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Mouse3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mouse4"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Mouse4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mouse5"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Mouse5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mouse6"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Mouse6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton0"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.JoystickButton0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton1"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.JoystickButton1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton2"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.JoystickButton2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton3"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.JoystickButton3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton4"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.JoystickButton4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton5"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.JoystickButton5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton6"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.JoystickButton6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton7"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.JoystickButton7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton8"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.JoystickButton8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton9"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.JoystickButton9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton10"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.JoystickButton10);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton11"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.JoystickButton11);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton12"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.JoystickButton12);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton13"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.JoystickButton13);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton14"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.JoystickButton14);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton15"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.JoystickButton15);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton16"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.JoystickButton16);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton17"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.JoystickButton17);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton18"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.JoystickButton18);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton19"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.JoystickButton19);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button0"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick1Button0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button1"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick1Button1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button2"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick1Button2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button3"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick1Button3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button4"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick1Button4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button5"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick1Button5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button6"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick1Button6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button7"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick1Button7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button8"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick1Button8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button9"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick1Button9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button10"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick1Button10);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button11"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick1Button11);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button12"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick1Button12);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button13"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick1Button13);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button14"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick1Button14);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button15"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick1Button15);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button16"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick1Button16);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button17"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick1Button17);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button18"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick1Button18);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button19"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick1Button19);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button0"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick2Button0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button1"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick2Button1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button2"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick2Button2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button3"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick2Button3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button4"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick2Button4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button5"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick2Button5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button6"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick2Button6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button7"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick2Button7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button8"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick2Button8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button9"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick2Button9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button10"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick2Button10);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button11"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick2Button11);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button12"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick2Button12);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button13"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick2Button13);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button14"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick2Button14);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button15"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick2Button15);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button16"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick2Button16);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button17"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick2Button17);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button18"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick2Button18);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button19"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick2Button19);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button0"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick3Button0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button1"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick3Button1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button2"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick3Button2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button3"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick3Button3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button4"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick3Button4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button5"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick3Button5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button6"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick3Button6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button7"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick3Button7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button8"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick3Button8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button9"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick3Button9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button10"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick3Button10);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button11"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick3Button11);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button12"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick3Button12);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button13"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick3Button13);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button14"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick3Button14);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button15"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick3Button15);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button16"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick3Button16);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button17"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick3Button17);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button18"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick3Button18);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button19"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick3Button19);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button0"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick4Button0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button1"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick4Button1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button2"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick4Button2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button3"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick4Button3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button4"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick4Button4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button5"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick4Button5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button6"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick4Button6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button7"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick4Button7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button8"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick4Button8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button9"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick4Button9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button10"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick4Button10);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button11"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick4Button11);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button12"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick4Button12);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button13"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick4Button13);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button14"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick4Button14);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button15"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick4Button15);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button16"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick4Button16);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button17"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick4Button17);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button18"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick4Button18);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button19"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick4Button19);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button0"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick5Button0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button1"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick5Button1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button2"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick5Button2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button3"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick5Button3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button4"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick5Button4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button5"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick5Button5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button6"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick5Button6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button7"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick5Button7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button8"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick5Button8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button9"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick5Button9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button10"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick5Button10);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button11"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick5Button11);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button12"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick5Button12);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button13"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick5Button13);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button14"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick5Button14);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button15"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick5Button15);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button16"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick5Button16);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button17"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick5Button17);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button18"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick5Button18);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button19"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick5Button19);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button0"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick6Button0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button1"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick6Button1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button2"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick6Button2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button3"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick6Button3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button4"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick6Button4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button5"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick6Button5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button6"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick6Button6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button7"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick6Button7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button8"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick6Button8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button9"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick6Button9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button10"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick6Button10);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button11"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick6Button11);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button12"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick6Button12);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button13"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick6Button13);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button14"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick6Button14);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button15"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick6Button15);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button16"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick6Button16);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button17"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick6Button17);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button18"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick6Button18);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button19"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick6Button19);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button0"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick7Button0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button1"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick7Button1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button2"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick7Button2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button3"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick7Button3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button4"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick7Button4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button5"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick7Button5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button6"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick7Button6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button7"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick7Button7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button8"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick7Button8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button9"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick7Button9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button10"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick7Button10);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button11"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick7Button11);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button12"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick7Button12);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button13"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick7Button13);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button14"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick7Button14);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button15"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick7Button15);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button16"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick7Button16);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button17"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick7Button17);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button18"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick7Button18);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button19"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick7Button19);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button0"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick8Button0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button1"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick8Button1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button2"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick8Button2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button3"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick8Button3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button4"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick8Button4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button5"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick8Button5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button6"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick8Button6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button7"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick8Button7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button8"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick8Button8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button9"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick8Button9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button10"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick8Button10);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button11"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick8Button11);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button12"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick8Button12);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button13"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick8Button13);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button14"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick8Button14);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button15"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick8Button15);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button16"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick8Button16);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button17"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick8Button17);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button18"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick8Button18);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button19"))
                {
                    translator.PushUnityEngineKeyCode(L, UnityEngine.KeyCode.Joystick8Button19);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.KeyCode!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.KeyCode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineTextAnchorWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.TextAnchor), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.TextAnchor), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.TextAnchor), L, null, 10, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpperLeft", UnityEngine.TextAnchor.UpperLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpperCenter", UnityEngine.TextAnchor.UpperCenter);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpperRight", UnityEngine.TextAnchor.UpperRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MiddleLeft", UnityEngine.TextAnchor.MiddleLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MiddleCenter", UnityEngine.TextAnchor.MiddleCenter);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MiddleRight", UnityEngine.TextAnchor.MiddleRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LowerLeft", UnityEngine.TextAnchor.LowerLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LowerCenter", UnityEngine.TextAnchor.LowerCenter);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LowerRight", UnityEngine.TextAnchor.LowerRight);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__ToInt", __ToInt);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.TextAnchor), L, translator);
        }

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __ToInt(RealStatePtr L)
		{
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            UnityEngine.TextAnchor _enumValue;
            translator.Get(L, 1, out _enumValue);
            LuaAPI.xlua_pushinteger(L, (int)_enumValue);
            return 1;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineTextAnchor(L, (UnityEngine.TextAnchor)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "UpperLeft"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.UpperLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UpperCenter"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.UpperCenter);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UpperRight"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.UpperRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MiddleLeft"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.MiddleLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MiddleCenter"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.MiddleCenter);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MiddleRight"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.MiddleRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LowerLeft"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.LowerLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LowerCenter"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.LowerCenter);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LowerRight"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.LowerRight);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.TextAnchor!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.TextAnchor! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUICanvasScalerScaleModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ConstantPixelSize", UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPixelSize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScaleWithScreenSize", UnityEngine.UI.CanvasScaler.ScaleMode.ScaleWithScreenSize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ConstantPhysicalSize", UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPhysicalSize);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__ToInt", __ToInt);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, translator);
        }

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __ToInt(RealStatePtr L)
		{
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            UnityEngine.UI.CanvasScaler.ScaleMode _enumValue;
            translator.Get(L, 1, out _enumValue);
            LuaAPI.xlua_pushinteger(L, (int)_enumValue);
            return 1;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUICanvasScalerScaleMode(L, (UnityEngine.UI.CanvasScaler.ScaleMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "ConstantPixelSize"))
                {
                    translator.PushUnityEngineUICanvasScalerScaleMode(L, UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPixelSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScaleWithScreenSize"))
                {
                    translator.PushUnityEngineUICanvasScalerScaleMode(L, UnityEngine.UI.CanvasScaler.ScaleMode.ScaleWithScreenSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ConstantPhysicalSize"))
                {
                    translator.PushUnityEngineUICanvasScalerScaleMode(L, UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPhysicalSize);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.CanvasScaler.ScaleMode!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.CanvasScaler.ScaleMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUICanvasScalerScreenMatchModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MatchWidthOrHeight", UnityEngine.UI.CanvasScaler.ScreenMatchMode.MatchWidthOrHeight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Expand", UnityEngine.UI.CanvasScaler.ScreenMatchMode.Expand);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Shrink", UnityEngine.UI.CanvasScaler.ScreenMatchMode.Shrink);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__ToInt", __ToInt);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, translator);
        }

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __ToInt(RealStatePtr L)
		{
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            UnityEngine.UI.CanvasScaler.ScreenMatchMode _enumValue;
            translator.Get(L, 1, out _enumValue);
            LuaAPI.xlua_pushinteger(L, (int)_enumValue);
            return 1;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUICanvasScalerScreenMatchMode(L, (UnityEngine.UI.CanvasScaler.ScreenMatchMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "MatchWidthOrHeight"))
                {
                    translator.PushUnityEngineUICanvasScalerScreenMatchMode(L, UnityEngine.UI.CanvasScaler.ScreenMatchMode.MatchWidthOrHeight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Expand"))
                {
                    translator.PushUnityEngineUICanvasScalerScreenMatchMode(L, UnityEngine.UI.CanvasScaler.ScreenMatchMode.Expand);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Shrink"))
                {
                    translator.PushUnityEngineUICanvasScalerScreenMatchMode(L, UnityEngine.UI.CanvasScaler.ScreenMatchMode.Shrink);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.CanvasScaler.ScreenMatchMode!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.CanvasScaler.ScreenMatchMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIGridLayoutGroupConstraintWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.GridLayoutGroup.Constraint), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.GridLayoutGroup.Constraint), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.GridLayoutGroup.Constraint), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Flexible", UnityEngine.UI.GridLayoutGroup.Constraint.Flexible);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FixedColumnCount", UnityEngine.UI.GridLayoutGroup.Constraint.FixedColumnCount);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FixedRowCount", UnityEngine.UI.GridLayoutGroup.Constraint.FixedRowCount);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__ToInt", __ToInt);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.GridLayoutGroup.Constraint), L, translator);
        }

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __ToInt(RealStatePtr L)
		{
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            UnityEngine.UI.GridLayoutGroup.Constraint _enumValue;
            translator.Get(L, 1, out _enumValue);
            LuaAPI.xlua_pushinteger(L, (int)_enumValue);
            return 1;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIGridLayoutGroupConstraint(L, (UnityEngine.UI.GridLayoutGroup.Constraint)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Flexible"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupConstraint(L, UnityEngine.UI.GridLayoutGroup.Constraint.Flexible);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FixedColumnCount"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupConstraint(L, UnityEngine.UI.GridLayoutGroup.Constraint.FixedColumnCount);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FixedRowCount"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupConstraint(L, UnityEngine.UI.GridLayoutGroup.Constraint.FixedRowCount);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.GridLayoutGroup.Constraint!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.GridLayoutGroup.Constraint! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineTouchScreenKeyboardTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.TouchScreenKeyboardType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.TouchScreenKeyboardType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.TouchScreenKeyboardType), L, null, 14, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Default", UnityEngine.TouchScreenKeyboardType.Default);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ASCIICapable", UnityEngine.TouchScreenKeyboardType.ASCIICapable);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NumbersAndPunctuation", UnityEngine.TouchScreenKeyboardType.NumbersAndPunctuation);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "URL", UnityEngine.TouchScreenKeyboardType.URL);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NumberPad", UnityEngine.TouchScreenKeyboardType.NumberPad);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PhonePad", UnityEngine.TouchScreenKeyboardType.PhonePad);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NamePhonePad", UnityEngine.TouchScreenKeyboardType.NamePhonePad);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EmailAddress", UnityEngine.TouchScreenKeyboardType.EmailAddress);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Social", UnityEngine.TouchScreenKeyboardType.Social);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Search", UnityEngine.TouchScreenKeyboardType.Search);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DecimalPad", UnityEngine.TouchScreenKeyboardType.DecimalPad);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OneTimeCode", UnityEngine.TouchScreenKeyboardType.OneTimeCode);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__ToInt", __ToInt);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.TouchScreenKeyboardType), L, translator);
        }

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __ToInt(RealStatePtr L)
		{
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            UnityEngine.TouchScreenKeyboardType _enumValue;
            translator.Get(L, 1, out _enumValue);
            LuaAPI.xlua_pushinteger(L, (int)_enumValue);
            return 1;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineTouchScreenKeyboardType(L, (UnityEngine.TouchScreenKeyboardType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Default"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.Default);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ASCIICapable"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.ASCIICapable);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NumbersAndPunctuation"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.NumbersAndPunctuation);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "URL"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.URL);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NumberPad"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.NumberPad);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PhonePad"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.PhonePad);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NamePhonePad"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.NamePhonePad);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EmailAddress"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.EmailAddress);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Social"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.Social);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Search"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.Search);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DecimalPad"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.DecimalPad);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OneTimeCode"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.OneTimeCode);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.TouchScreenKeyboardType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.TouchScreenKeyboardType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineVideoVideoRenderModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.Video.VideoRenderMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.Video.VideoRenderMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.Video.VideoRenderMode), L, null, 6, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CameraFarPlane", UnityEngine.Video.VideoRenderMode.CameraFarPlane);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CameraNearPlane", UnityEngine.Video.VideoRenderMode.CameraNearPlane);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RenderTexture", UnityEngine.Video.VideoRenderMode.RenderTexture);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MaterialOverride", UnityEngine.Video.VideoRenderMode.MaterialOverride);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "APIOnly", UnityEngine.Video.VideoRenderMode.APIOnly);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__ToInt", __ToInt);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.Video.VideoRenderMode), L, translator);
        }

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __ToInt(RealStatePtr L)
		{
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            UnityEngine.Video.VideoRenderMode _enumValue;
            translator.Get(L, 1, out _enumValue);
            LuaAPI.xlua_pushinteger(L, (int)_enumValue);
            return 1;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineVideoVideoRenderMode(L, (UnityEngine.Video.VideoRenderMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "CameraFarPlane"))
                {
                    translator.PushUnityEngineVideoVideoRenderMode(L, UnityEngine.Video.VideoRenderMode.CameraFarPlane);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CameraNearPlane"))
                {
                    translator.PushUnityEngineVideoVideoRenderMode(L, UnityEngine.Video.VideoRenderMode.CameraNearPlane);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RenderTexture"))
                {
                    translator.PushUnityEngineVideoVideoRenderMode(L, UnityEngine.Video.VideoRenderMode.RenderTexture);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MaterialOverride"))
                {
                    translator.PushUnityEngineVideoVideoRenderMode(L, UnityEngine.Video.VideoRenderMode.MaterialOverride);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "APIOnly"))
                {
                    translator.PushUnityEngineVideoVideoRenderMode(L, UnityEngine.Video.VideoRenderMode.APIOnly);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.Video.VideoRenderMode!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.Video.VideoRenderMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
}