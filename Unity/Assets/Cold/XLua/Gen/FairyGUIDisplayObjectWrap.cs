﻿#if USE_UNI_LUA
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
    public partial class FairyGUIDisplayObjectWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(FairyGUI.DisplayObject);
			Utils.BeginObjectRegister(type, L, translator, 0, 124, 64, 38);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetXY", _m_SetXY);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPosition", _m_SetPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetSize", _m_SetSize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EnsureSizeCorrect", _m_EnsureSizeCorrect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetScale", _m_SetScale);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EnterPaintingMode", _m_EnterPaintingMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LeavePaintingMode", _m_LeavePaintingMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetScreenShot", _m_GetScreenShot);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetBounds", _m_GetBounds);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GlobalToLocal", _m_GlobalToLocal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LocalToGlobal", _m_LocalToGlobal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WorldToLocal", _m_WorldToLocal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LocalToWorld", _m_LocalToWorld);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TransformPoint", _m_TransformPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TransformRect", _m_TransformRect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveFromParent", _m_RemoveFromParent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InvalidateBatchingState", _m_InvalidateBatchingState);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Update", _m_Update);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getparent", _g_get_parent);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getgameObject", _g_get_gameObject);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getcachedTransform", _g_get_cachedTransform);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getgraphics", _g_get_graphics);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getpaintingGraphics", _g_get_paintingGraphics);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonClick", _g_get_onClick);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonRightClick", _g_get_onRightClick);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonTouchBegin", _g_get_onTouchBegin);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonTouchMove", _g_get_onTouchMove);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonTouchEnd", _g_get_onTouchEnd);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonRollOver", _g_get_onRollOver);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonRollOut", _g_get_onRollOut);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonMouseWheel", _g_get_onMouseWheel);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonAddedToStage", _g_get_onAddedToStage);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonRemovedFromStage", _g_get_onRemovedFromStage);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonKeyDown", _g_get_onKeyDown);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonClickLink", _g_get_onClickLink);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonFocusIn", _g_get_onFocusIn);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonFocusOut", _g_get_onFocusOut);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getalpha", _g_get_alpha);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getgrayed", _g_get_grayed);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getvisible", _g_get_visible);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getx", _g_get_x);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "gety", _g_get_y);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getz", _g_get_z);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getxy", _g_get_xy);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getposition", _g_get_position);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getpixelPerfect", _g_get_pixelPerfect);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getwidth", _g_get_width);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getheight", _g_get_height);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getsize", _g_get_size);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getscaleX", _g_get_scaleX);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getscaleY", _g_get_scaleY);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getscale", _g_get_scale);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getrotation", _g_get_rotation);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getrotationX", _g_get_rotationX);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getrotationY", _g_get_rotationY);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getskew", _g_get_skew);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getperspective", _g_get_perspective);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getfocalLength", _g_get_focalLength);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getpivot", _g_get_pivot);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getlocation", _g_get_location);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getmaterial", _g_get_material);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getshader", _g_get_shader);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getrenderingOrder", _g_get_renderingOrder);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getlayer", _g_get_layer);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getfocusable", _g_get_focusable);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "gettabStop", _g_get_tabStop);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getfocused", _g_get_focused);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getcursor", _g_get_cursor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getisDisposed", _g_get_isDisposed);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "gettopmost", _g_get_topmost);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getstage", _g_get_stage);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getworldSpaceContainer", _g_get_worldSpaceContainer);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "gettouchable", _g_get_touchable);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "gettouchDisabled", _g_get_touchDisabled);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getpaintingMode", _g_get_paintingMode);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getcacheAsBitmap", _g_get_cacheAsBitmap);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getfilter", _g_get_filter);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getblendMode", _g_get_blendMode);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "gethome", _g_get_home);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getname", _g_get_name);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getgOwner", _g_get_gOwner);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getid", _g_get_id);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setalpha", _s_set_alpha);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setgrayed", _s_set_grayed);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setvisible", _s_set_visible);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setx", _s_set_x);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "sety", _s_set_y);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setz", _s_set_z);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setxy", _s_set_xy);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setposition", _s_set_position);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setpixelPerfect", _s_set_pixelPerfect);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setwidth", _s_set_width);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setheight", _s_set_height);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setsize", _s_set_size);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setscaleX", _s_set_scaleX);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setscaleY", _s_set_scaleY);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setscale", _s_set_scale);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setrotation", _s_set_rotation);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setrotationX", _s_set_rotationX);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setrotationY", _s_set_rotationY);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setskew", _s_set_skew);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setperspective", _s_set_perspective);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setfocalLength", _s_set_focalLength);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setpivot", _s_set_pivot);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setlocation", _s_set_location);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setmaterial", _s_set_material);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setshader", _s_set_shader);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setrenderingOrder", _s_set_renderingOrder);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setlayer", _s_set_layer);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setfocusable", _s_set_focusable);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "settabStop", _s_set_tabStop);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setcursor", _s_set_cursor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "settouchable", _s_set_touchable);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setcacheAsBitmap", _s_set_cacheAsBitmap);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setfilter", _s_set_filter);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setblendMode", _s_set_blendMode);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "sethome", _s_set_home);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setname", _s_set_name);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setgOwner", _s_set_gOwner);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setid", _s_set_id);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "addonPaint", _e_add_onPaint);
						
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "removeonPaint", _e_remove_onPaint);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "onPaint", _e_onPaint);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "parent", _g_get_parent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gameObject", _g_get_gameObject);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cachedTransform", _g_get_cachedTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "graphics", _g_get_graphics);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "paintingGraphics", _g_get_paintingGraphics);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onClick", _g_get_onClick);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onRightClick", _g_get_onRightClick);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onTouchBegin", _g_get_onTouchBegin);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onTouchMove", _g_get_onTouchMove);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onTouchEnd", _g_get_onTouchEnd);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onRollOver", _g_get_onRollOver);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onRollOut", _g_get_onRollOut);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onMouseWheel", _g_get_onMouseWheel);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onAddedToStage", _g_get_onAddedToStage);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onRemovedFromStage", _g_get_onRemovedFromStage);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onKeyDown", _g_get_onKeyDown);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onClickLink", _g_get_onClickLink);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onFocusIn", _g_get_onFocusIn);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onFocusOut", _g_get_onFocusOut);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "alpha", _g_get_alpha);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "grayed", _g_get_grayed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "visible", _g_get_visible);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "x", _g_get_x);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "y", _g_get_y);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "z", _g_get_z);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "xy", _g_get_xy);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "position", _g_get_position);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pixelPerfect", _g_get_pixelPerfect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "width", _g_get_width);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "height", _g_get_height);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "size", _g_get_size);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scaleX", _g_get_scaleX);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scaleY", _g_get_scaleY);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scale", _g_get_scale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rotation", _g_get_rotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rotationX", _g_get_rotationX);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rotationY", _g_get_rotationY);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "skew", _g_get_skew);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "perspective", _g_get_perspective);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "focalLength", _g_get_focalLength);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pivot", _g_get_pivot);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "location", _g_get_location);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "material", _g_get_material);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "shader", _g_get_shader);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "renderingOrder", _g_get_renderingOrder);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "layer", _g_get_layer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "focusable", _g_get_focusable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tabStop", _g_get_tabStop);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "focused", _g_get_focused);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cursor", _g_get_cursor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isDisposed", _g_get_isDisposed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "topmost", _g_get_topmost);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "stage", _g_get_stage);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "worldSpaceContainer", _g_get_worldSpaceContainer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "touchable", _g_get_touchable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "touchDisabled", _g_get_touchDisabled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "paintingMode", _g_get_paintingMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cacheAsBitmap", _g_get_cacheAsBitmap);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "filter", _g_get_filter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "blendMode", _g_get_blendMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "home", _g_get_home);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "name", _g_get_name);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gOwner", _g_get_gOwner);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "id", _g_get_id);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "alpha", _s_set_alpha);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "grayed", _s_set_grayed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "visible", _s_set_visible);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "x", _s_set_x);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "y", _s_set_y);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "z", _s_set_z);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "xy", _s_set_xy);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "position", _s_set_position);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pixelPerfect", _s_set_pixelPerfect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "width", _s_set_width);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "height", _s_set_height);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "size", _s_set_size);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scaleX", _s_set_scaleX);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scaleY", _s_set_scaleY);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scale", _s_set_scale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rotation", _s_set_rotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rotationX", _s_set_rotationX);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rotationY", _s_set_rotationY);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "skew", _s_set_skew);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "perspective", _s_set_perspective);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "focalLength", _s_set_focalLength);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pivot", _s_set_pivot);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "location", _s_set_location);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "material", _s_set_material);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "shader", _s_set_shader);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "renderingOrder", _s_set_renderingOrder);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "layer", _s_set_layer);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "focusable", _s_set_focusable);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "tabStop", _s_set_tabStop);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cursor", _s_set_cursor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "touchable", _s_set_touchable);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cacheAsBitmap", _s_set_cacheAsBitmap);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "filter", _s_set_filter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "blendMode", _s_set_blendMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "home", _s_set_home);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "name", _s_set_name);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gOwner", _s_set_gOwner);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "id", _s_set_id);
            
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
            
			
			
			
			
			
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					FairyGUI.DisplayObject gen_ret = new FairyGUI.DisplayObject();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.DisplayObject constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetXY(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _xv = (float)LuaAPI.lua_tonumber(L, 2);
                    float _yv = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    gen_to_be_invoked.SetXY( 
                        _xv, 
                        _yv );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPosition(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _xv = (float)LuaAPI.lua_tonumber(L, 2);
                    float _yv = (float)LuaAPI.lua_tonumber(L, 3);
                    float _zv = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    gen_to_be_invoked.SetPosition( 
                        _xv, 
                        _yv, 
                        _zv );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetSize(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _wv = (float)LuaAPI.lua_tonumber(L, 2);
                    float _hv = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    gen_to_be_invoked.SetSize( 
                        _wv, 
                        _hv );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EnsureSizeCorrect(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.EnsureSizeCorrect(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetScale(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _xv = (float)LuaAPI.lua_tonumber(L, 2);
                    float _yv = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    gen_to_be_invoked.SetScale( 
                        _xv, 
                        _yv );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EnterPaintingMode(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                    gen_to_be_invoked.EnterPaintingMode(  );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Nullable<FairyGUI.Margin>>(L, 3)) 
                {
                    int _requestorId = LuaAPI.xlua_tointeger(L, 2);
                    System.Nullable<FairyGUI.Margin> _extend;translator.Get(L, 3, out _extend);
                    
                    gen_to_be_invoked.EnterPaintingMode( 
                        _requestorId, 
                        _extend );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Nullable<FairyGUI.Margin>>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int _requestorId = LuaAPI.xlua_tointeger(L, 2);
                    System.Nullable<FairyGUI.Margin> _extend;translator.Get(L, 3, out _extend);
                    float _scale = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    gen_to_be_invoked.EnterPaintingMode( 
                        _requestorId, 
                        _extend, 
                        _scale );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.DisplayObject.EnterPaintingMode!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LeavePaintingMode(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _requestorId = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.LeavePaintingMode( 
                        _requestorId );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetScreenShot(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Nullable<FairyGUI.Margin> _extend;translator.Get(L, 2, out _extend);
                    float _scale = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.Texture2D gen_ret = gen_to_be_invoked.GetScreenShot( 
                        _extend, 
                        _scale );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBounds(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    FairyGUI.DisplayObject _targetSpace = (FairyGUI.DisplayObject)translator.GetObject(L, 2, typeof(FairyGUI.DisplayObject));
                    
                        UnityEngine.Rect gen_ret = gen_to_be_invoked.GetBounds( 
                        _targetSpace );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GlobalToLocal(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    
                        UnityEngine.Vector2 gen_ret = gen_to_be_invoked.GlobalToLocal( 
                        _point );
                        translator.PushUnityEngineVector2(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LocalToGlobal(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    
                        UnityEngine.Vector2 gen_ret = gen_to_be_invoked.LocalToGlobal( 
                        _point );
                        translator.PushUnityEngineVector2(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WorldToLocal(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _worldPoint;translator.Get(L, 2, out _worldPoint);
                    UnityEngine.Vector3 _direction;translator.Get(L, 3, out _direction);
                    
                        UnityEngine.Vector3 gen_ret = gen_to_be_invoked.WorldToLocal( 
                        _worldPoint, 
                        _direction );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LocalToWorld(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _localPoint;translator.Get(L, 2, out _localPoint);
                    
                        UnityEngine.Vector3 gen_ret = gen_to_be_invoked.LocalToWorld( 
                        _localPoint );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TransformPoint(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    FairyGUI.DisplayObject _targetSpace = (FairyGUI.DisplayObject)translator.GetObject(L, 3, typeof(FairyGUI.DisplayObject));
                    
                        UnityEngine.Vector2 gen_ret = gen_to_be_invoked.TransformPoint( 
                        _point, 
                        _targetSpace );
                        translator.PushUnityEngineVector2(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TransformRect(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Rect _rect;translator.Get(L, 2, out _rect);
                    FairyGUI.DisplayObject _targetSpace = (FairyGUI.DisplayObject)translator.GetObject(L, 3, typeof(FairyGUI.DisplayObject));
                    
                        UnityEngine.Rect gen_ret = gen_to_be_invoked.TransformRect( 
                        _rect, 
                        _targetSpace );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveFromParent(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.RemoveFromParent(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InvalidateBatchingState(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.InvalidateBatchingState(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Update(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    FairyGUI.UpdateContext _context = (FairyGUI.UpdateContext)translator.GetObject(L, 2, typeof(FairyGUI.UpdateContext));
                    
                    gen_to_be_invoked.Update( 
                        _context );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_parent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.parent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gameObject(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.gameObject);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cachedTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.cachedTransform);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_graphics(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.graphics);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_paintingGraphics(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.paintingGraphics);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onClick(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onClick);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onRightClick(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onRightClick);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onTouchBegin(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onTouchBegin);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onTouchMove(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onTouchMove);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onTouchEnd(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onTouchEnd);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onRollOver(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onRollOver);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onRollOut(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onRollOut);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onMouseWheel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onMouseWheel);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onAddedToStage(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onAddedToStage);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onRemovedFromStage(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onRemovedFromStage);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onKeyDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onKeyDown);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onClickLink(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onClickLink);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onFocusIn(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onFocusIn);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onFocusOut(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onFocusOut);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_alpha(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.alpha);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_grayed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.grayed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_visible(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.visible);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_x(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.x);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_y(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.y);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_z(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.z);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_xy(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.xy);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_position(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.position);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pixelPerfect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.pixelPerfect);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_width(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.width);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_height(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.height);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_size(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.size);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scaleX(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.scaleX);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scaleY(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.scaleY);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.scale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.rotation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rotationX(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.rotationX);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rotationY(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.rotationY);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_skew(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.skew);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_perspective(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.perspective);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_focalLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.focalLength);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pivot(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.pivot);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_location(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.location);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_material(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.material);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_shader(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.shader);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_renderingOrder(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.renderingOrder);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_layer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.layer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_focusable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.focusable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tabStop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.tabStop);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_focused(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.focused);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cursor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.cursor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isDisposed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isDisposed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_topmost(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.topmost);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_stage(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.stage);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_worldSpaceContainer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.worldSpaceContainer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_touchable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.touchable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_touchDisabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.touchDisabled);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_paintingMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.paintingMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cacheAsBitmap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.cacheAsBitmap);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_filter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.filter);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_blendMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.PushFairyGUIBlendMode(L, gen_to_be_invoked.blendMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_home(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.home);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_name(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.name);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gOwner(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.gOwner);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_id(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushuint(L, gen_to_be_invoked.id);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_alpha(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.alpha = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_grayed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.grayed = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_visible(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.visible = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_x(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.x = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_y(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.y = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_z(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.z = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_xy(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.xy = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_position(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.position = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pixelPerfect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.pixelPerfect = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_width(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.width = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_height(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.height = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_size(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.size = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_scaleX(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.scaleX = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_scaleY(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.scaleY = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_scale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.scale = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.rotation = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rotationX(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.rotationX = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rotationY(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.rotationY = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_skew(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.skew = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_perspective(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.perspective = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_focalLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.focalLength = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pivot(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.pivot = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_location(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.location = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_material(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.material = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_shader(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.shader = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_renderingOrder(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.renderingOrder = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_layer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.layer = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_focusable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.focusable = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tabStop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.tabStop = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cursor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.cursor = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_touchable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.touchable = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cacheAsBitmap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.cacheAsBitmap = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_filter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.filter = (FairyGUI.IFilter)translator.GetObject(L, 2, typeof(FairyGUI.IFilter));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_blendMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                FairyGUI.BlendMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.blendMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_home(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.home = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_name(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.name = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gOwner(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.gOwner = (FairyGUI.GObject)translator.GetObject(L, 2, typeof(FairyGUI.GObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_id(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.id = LuaAPI.xlua_touint(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_onPaint(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
                System.Action gen_delegate = translator.GetDelegate<System.Action>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.onPaint += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.onPaint -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.DisplayObject.onPaint!");
            return 0;
        }
        
		
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_add_onPaint(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
				System.Action gen_delegate = translator.GetDelegate<System.Action>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.Action!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.onPaint += gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.DisplayObject.onPaint!");
			return 0;
		}
		

		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int _e_remove_onPaint(RealStatePtr L)
		{
			try {
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = LuaAPI.lua_gettop(L);
			FairyGUI.DisplayObject gen_to_be_invoked = (FairyGUI.DisplayObject)translator.FastGetCSObj(L, 1);
				System.Action gen_delegate = translator.GetDelegate<System.Action>(L, 2);
				if (gen_delegate == null) {
					return LuaAPI.luaL_error(L, "#2 need System.Action!");
				}
				
				if (gen_param_count == 2)
				{
					gen_to_be_invoked.onPaint -= gen_delegate;
					return 0;
				}
			} catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.DisplayObject.onPaint!");
			return 0;
		}
		
		
		
		
		
		
		
    }
}
