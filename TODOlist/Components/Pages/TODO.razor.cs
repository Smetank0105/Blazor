using TODOlist.Classes;

namespace TODOlist.Components.Pages
{
    public partial class TODO
    {
        List<TODOitem> todos = [];
        string task;
        void AddTask()
        {
            if (string.IsNullOrWhiteSpace(task)) return;
            for (int i = 0; i < todos.Count; i++)
                if (todos[i].Title == task) return;
            todos.Add(new TODOitem { Title = task});
            task = "";
        }
    }
}
