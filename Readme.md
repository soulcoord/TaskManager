

# TaskManager 專案 

一個用 **ASP.NET Core MVC** 開發的任務管理系統範例，
目前功能包含 **任務清單顯示** 以及 **新增任務**，使用 **Entity Framework Core (InMemory)** 作為資料存取。

---

## 專案結構

```
TaskManager/
├── Controllers/
│   └── TasksController.cs
├── Data/
│   └── AppDbContext.cs
├── Models/
│   └── TaskItem.cs
├── Views/
│   └── Tasks/
│       ├── Index.cshtml
│       └── Create.cshtml
├── Program.cs
└── TaskManager.csproj
```

---

## 技術棧

* **ASP.NET Core MVC 9.0**
* **Entity Framework Core (InMemory)** — 方便本地快速測試
* **Razor View** — 畫面渲染
* **C# 9.0**

---

## 使用方法

1. 確認已安裝 [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)

2. Clone 專案並進入目錄

   ```bash
   git clone https://github.com/soulcoord/TaskManager.git
   cd TaskManager
   ```

3. 安裝套件

   ```bash
   dotnet restore
   ```

4. 執行專案

   ```bash
   dotnet run
   ```

5. 打開瀏覽器，進入：

   ```
   https://localhost:xxxx/Tasks/Index
   ```

   （xxxx 依執行時顯示的 port 而定）

---

## 功能

* 查看任務清單
* 新增任務（標題、描述、截止日、優先級、狀態）



