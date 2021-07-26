
#### 介绍
本项目为[ET框架](https://github.com/egametang/ET) 通过接入[CSharp.lua](https://github.com/yanghuan/CSharp.lua) 集成Unity客户端[Xlua](https://github.com/Tencent/xLua)热更新功能

#### 项目说明
ET版本为ET6.0 matser ,Unity版本2020

日常开发使用C#，邻近版本发布时将ET框架客户端部分 整体转化为Xlua热更新脚本，达到客户端整体项目热更的目的。

提供C#代码一键转换为Xlua脚本功能：Tools->Gen Lua Scripts  (快捷键：shift + s)

网络消息通讯，Excel配置生成，Proto消息配置生成均已调通。

#### 使用说明

1.  编译服务端，并启动Server.App.exe
2.  运行unity，打开Init场景，启动Game

#### 注意
  
1.  使用者需对ET6.0,CSharp2Lua,Xlua等技术框架十分熟悉。
2.  本项目为ET框架热更新试验版本，仅用于提供C#转Lua热更思路与学习用途。
3.  若用于公司商用项目，一切后果自负。

#### 待完成项目
1.  清理接入热更功能时的冗余代码
2.  手写lua版红黑树，SortedDictionary需要
3.  lua版ETTask池

#### 项目参考

1. [ET-CSharp.lua](https://gitee.com/ZuoQingYue/ET-CSharp.lua)

2. [DCET](https://github.com/DukeChiang/DCET)
