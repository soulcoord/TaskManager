
# TaskManager ���� 

һ���� **ASP.NET Core MVC** �_�l���΄չ���ϵ�y������
Ŀǰ���ܰ��� **�΄�����@ʾ** �Լ� **�����΄�**��ʹ�� **Entity Framework Core (InMemory)** �����Y�ϴ�ȡ��

---

## ?? �����Y��

```
TaskManager/
������ Controllers/
��   ������ TasksController.cs   # �������̣�̎���΄���Ρ�����
������ Data/
��   ������ AppDbContext.cs      # �Y�ώ��B���c DbSet �O��
������ Models/
��   ������ TaskItem.cs          # �΄�ģ�� (Title, Description, Status, Priority...)
������ Views/
��   ������ Tasks/
��       ������ Index.cshtml     # �΄�������
��       ������ Create.cshtml    # �����΄����
������ Program.cs               # �����M���c���]�Է����c·��
������ TaskManager.csproj       # �����n
```

---

## ?? ���g��

* **ASP.NET Core MVC 9.0**
* **Entity Framework Core (InMemory)** �� ���㱾�ؿ��ٜyԇ
* **Razor View** �� ������Ⱦ
* **C# 9.0**

---

## ?? ʹ�÷���

1. �_�J�Ѱ��b [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)

2. Clone �����K�M��Ŀ�

   ```bash
   git clone <��Č����Wַ>
   cd TaskManager
   ```

3. ���b�׼�

   ```bash
   dotnet restore
   ```

4. ���Ќ���

   ```bash
   dotnet run
   ```

5. ���_�g�[�����M�룺

   ```
   https://localhost:xxxx/Tasks/Index
   ```

   ��xxxx �����Еr�@ʾ�� port ������

---

## ? ����

* �鿴�΄����
* �����΄գ����}����������ֹ�ա����ȼ�����B��

---

## ?? ���k���

* [ ] ��݋�΄�
* [ ] �h���΄�
* [ ] ����ʹ������C
* [ ] �Q�� SQL Server �� SQLite �����Y��
* [ ] ���� UI��Bootstrap / Tailwind��

