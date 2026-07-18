# XKJ-HX-ZEBER 解决方案文件树

## 顶层结构

```
XKJ-HX-ZEBER/
├── src/                          # 源代码目录
│   ├── apps/                     # 应用程序（各设备项目）
│   ├── common/                   # 公共库（跨项目共享）
│   ├── framework/                # 框架源码（UI 主题等）
│   ├── demos/                    # 演示项目
│   └── tests/                    # 测试项目
│
├── libs/                         # 预编译 DLL（二进制依赖）
│   ├── common/                   # 公共三方库
│   └── framework/                # 框架预编译 DLL
│
├── build/                        # 构建相关
│   └── define/                   # 项目定义文件（.csproj）
│
├── scripts/                      # 构建脚本
│   └── build/                    # 文件复制任务等
│
├── assets/                       # 共享资源
│   ├── HSL.xml                   # HSL 通信配置
│   └── shared/                   # 共享 UI 资源
│       └── app/ui/
│
├── doc/                          # 文档目录
├── TestFail/                     # 测试失败用例
├── .gitignore
├── Directory.Build.props         # 全局构建属性（版本、路径变量）
├── Directory.Build.targets       # 全局构建目标
├── Directory.Packages.props      # 集中包版本管理
├── NuGet.config                  # NuGet 源配置
├── ProjManger.cs                 # 项目管理器
├── XKJ-ZEBER.slnx               # 解决方案文件（新格式）
├── XKJ-ZEBER.sln.DotSettings    # Rider/ReSharper 设置
└── README.md
```

---

## src/apps/ — 应用程序项目

每个子文件夹对应一个设备/项目：

```
apps/
├── App/                          # 主应用（ZC 应用壳）
├── ASM12/                        # ASM12 设备项目
├── ASM15-1/                      # ASM15-1 设备项目
├── ASM15-2/                      # ASM15-2 设备项目
├── ASM4/                         # ASM4 设备项目
├── MFG15/                        # MFG15 设备项目
├── SUB1/                         # SUB1 设备项目
└── apps.zip                      # 备份压缩包
```

---

## src/common/ — 公共库

```
common/
├── Common.Base/                  # 基础公共库（最小依赖）
│   ├── Assets/                   # 资源文件
│   ├── Attributes/               # 自定义特性
│   └── CommonLibLoader.cs        # 程序集加载器
│
├── Common.Core/                  # 核心公共库（业务逻辑）
│   ├── Assets/                   # 资源文件
│   ├── Devices/                  # 设备抽象/接口
│   ├── Ext/                      # 扩展方法
│   ├── Models/                   # 数据模型
│   ├── Services/                 # 业务服务
│   ├── UI/                       # UI 相关公共组件
│   ├── CommonAppConfig.cs        # 应用配置
│   ├── CommonAppCore.cs          # 应用核心逻辑
│   ├── CommonUiAppCore.cs        # UI 应用核心
│   └── Global.cs                 # 全局常量/静态类
│
└── Common.Shared/                # 共享层（被 App 和 Common 引用）
    ├── Assets/                   # 资源文件
    ├── Ext/                      # 扩展方法
    ├── Services/                 # 服务接口/实现
    ├── UI/                       # UI 共享组件
    ├── App.cs                    # 共享应用入口
    └── Global.cs                 # 全局定义
```

---

## src/framework/ — 框架源码（当前仅 UI Theme）

```
framework/
└── UI.Theme/                     # ZC UI 主题库
    ├── ControlLibs/              # 控件库
    ├── Controls/                 # 自定义控件
    ├── RES/                      # 主题资源
    ├── Styles/                   # 样式定义
    ├── Themes/                   # 主题切换
    ├── UiTheme.axaml             # 主题入口
    ├── UiTheme.axaml.cs
    ├── UiThemeResource.axaml     # 主题资源字典
    └── UiThemeResource.cs
```

---

## libs/ — 预编译二进制

```
libs/
├── common/
│   ├── Accessibility.dll                         # Windows 无障碍 API
│   ├── HslCommunication.dll                      # HslCommunication 通信库
│   ├── HslCommunication.pdb
│   ├── Microsoft.Web.WebView2.Core.dll           # WebView2 核心
│   └── Microsoft.Web.WebView2.Core.pdb
│
└── framework/
    ├── ref/                                      # 引用程序集（空）
    ├── ZC.Framework.dll                          # ZC 框架核心
    ├── ZC.RoslynGen.dll                          # Roslyn 源码生成器
    ├── ZC.UI.dll                                 # ZC UI 库
    ├── ZC.UI.Theme.dll                           # ZC UI 主题预编译
    └── ZC.UI.Theme.pdb
```

---

## build/define/ — 项目定义文件

```
build/define/
├── DefApp.csproj               # 应用程序项目定义模板
├── DefBase.csproj              # 基础库项目定义模板
├── DefCore.csproj              # 核心库项目定义模板
├── DefHotAvaloniaApp.csproj    # Hot Avalonia 应用定义
├── DefUiApp.csproj             # UI 应用项目定义模板
└── DefWebApp.csproj            # Web 应用项目定义模板
```

---

## scripts/build/

```
scripts/build/
└── FileCopyTask.cs             # MSBuild 自定义任务：构建后文件复制
```

---

## 关键全局文件

| 文件 | 作用 |
|------|------|
| `Directory.Build.props` | 全局构建属性：版本号、框架路径变量、NuGet 打包设置 |
| `Directory.Build.targets` | 全局构建目标（扩展点） |
| `Directory.Packages.props` | 集中包版本管理（PackageReference） |
| `NuGet.config` | NuGet 源配置 |
| `ProjManger.cs` | 项目管理器（可能是构建脚本） |
| `XKJ-ZEBER.slnx` | 解决方案文件（.NET 新格式） |

---

## 全局路径变量（Directory.Build.props 定义）

| 变量 | 值 | 说明 |
|------|------|------|
| `FrameworkProjectPath` | `$(SolutionDir)src/framework/` | 框架源码路径 |
| `FrameworkAssemblyPath` | `$(SolutionDir)libs/framework/` | 框架预编译路径 |
| `CommonProjectPath` | `$(SolutionDir)src/common/` | 公共库源码路径 |
| `CommonAssemblyPath` | `$(SolutionDir)libs/common/` | 公共库预编译路径 |

---

## 框架源码应该放哪里？

### 现状

- `libs/framework/` 存放 **预编译 DLL**（ZC.Framework.dll、ZC.UI.dll 等）
- `src/framework/` 只有 **UI.Theme** 一个项目源码
- 其他框架组件（Framework、UI）没有源码，只有二进制

### 建议：框架源码放 `src/framework/`

```
src/framework/
├── Framework/                   # ← 新增：框架核心源码
│   ├── ZC.Framework.csproj
│   └── ...
├── UI/                          # ← 新增：UI 库源码
│   ├── ZC.UI.csproj
│   └── ...
└── UI.Theme/                    # 已有：UI 主题源码
    └── ...
```

**理由：**

1. **路径变量已就绪** — `Directory.Build.props` 已定义 `FrameworkProjectPath` 指向 `src/framework/`
2. **与 libs 对称** — `libs/framework/` 是预编译输出，`src/framework/` 是源码，职责清晰
3. **混合模式可行** — 当前项目支持 `FrameworkUsingMode=single-assembly`，可以部分用源码、部分用 DLL，按需替换
4. **不破坏现有结构** — 各 App 项目已通过路径变量引用，改源码只需改路径引用，不影响顶层

### 推荐的渐进迁移策略

| 阶段 | 操作 | 说明 |
|------|------|------|
| 1 | 在 `src/framework/` 下建 Framework/、UI/ 子目录 | 搭好目录结构 |
| 2 | 将 DLL 中需要修改的类反编译为源码 | 用 JetBrains 反编译 |
| 3 | 修改项目引用：从 `libs/framework/*.dll` 改为 `src/framework/*.csproj` | 逐步替换 |
| 4 | 保留 libs 中暂时没有源码的 DLL | 避免一次性迁移风险 |

**关键原则**：哪个框架组件需要改，就把哪个的源码放 `src/framework/`；不需要改的继续用 `libs/framework/` 的 DLL。
