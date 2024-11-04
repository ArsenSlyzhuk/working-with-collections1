using System;
using System.Collections.Generic;

// Завдання 1: Керування списком завдань
public class Task
{
    public int TaskId { get; set; }
    public string Description { get; set; }
}

public class TaskManager
{
    private List<Task> tasks = new List<Task>();

    // Додавання нового завдання до списку
    public void AddTask(Task task)
    {
        tasks.Add(task);
        Console.WriteLine($"Завдання з ID {task.TaskId} додано.");
    }

    // Видалення завдання за ідентифікатором
    public void RemoveTask(int taskId)
    {
        Task taskToRemove = tasks.Find(t => t.TaskId == taskId);
        if (taskToRemove != null)
        {
            tasks.Remove(taskToRemove);
            Console.WriteLine($"Завдання з ID {taskId} видалено.");
        }
        else
        {
            Console.WriteLine($"Завдання з ID {taskId} не знайдено.");
        }
    }

    // Виведення усіх завдань у списку
    public void DisplayTasks()
    {
        Console.WriteLine("Список завдань:");
        foreach (var task in tasks)
        {
            Console.WriteLine($"ID: {task.TaskId}, Опис: {task.Description}");
        }
    }
}

// Завдання 2: Управління списком користувачів
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class UserManager
{
    private List<User> users = new List<User>();

    // Додавання нового користувача до списку
    public void AddUser(User user)
    {
        users.Add(user);
        Console.WriteLine($"Користувача {user.Name} додано.");
    }

    // Видалення користувача за ідентифікатором
    public void RemoveUser(int userId)
    {
        User userToRemove = users.Find(u => u.Id == userId);
        if (userToRemove != null)
        {
            users.Remove(userToRemove);
            Console.WriteLine($"Користувача з ID {userId} видалено.");
        }
        else
        {
            Console.WriteLine($"Користувача з ID {userId} не знайдено.");
        }
    }

    // Пошук користувача за ідентифікатором
    public User FindUser(int userId)
    {
        return users.Find(u => u.Id == userId);
    }

    // Виведення усіх користувачів у списку
    public void DisplayUsers()
    {
        Console.WriteLine("Список користувачів:");
        foreach (var user in users)
        {
            Console.WriteLine($"ID: {user.Id}, Ім'я: {user.Name}");
        }
    }
}

// Тестування
class Program
{
    static void Main()
    {
        // Тестування TaskManager
        Console.WriteLine("Тестування менеджера завдань:");
        TaskManager taskManager = new TaskManager();

        taskManager.AddTask(new Task { TaskId = 1, Description = "Скласти звіт" });
        taskManager.AddTask(new Task { TaskId = 2, Description = "Купити продукти" });
        taskManager.DisplayTasks();

        taskManager.RemoveTask(1);
        taskManager.DisplayTasks();

        // Тестування UserManager
        Console.WriteLine("\nТестування менеджера користувачів:");
        UserManager userManager = new UserManager();

        userManager.AddUser(new User { Id = 1, Name = "Іван" });
        userManager.AddUser(new User { Id = 2, Name = "Марія" });
        userManager.DisplayUsers();

        userManager.RemoveUser(1);
        userManager.DisplayUsers();

        // Пошук користувача
        User foundUser = userManager.FindUser(2);
        if (foundUser != null)
        {
            Console.WriteLine($"Знайдено користувача: ID {foundUser.Id}, Ім'я: {foundUser.Name}");
        }
        else
        {
            Console.WriteLine("Користувача не знайдено.");
        }
    }
}
