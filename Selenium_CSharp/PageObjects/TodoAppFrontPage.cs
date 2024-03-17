using OpenQA.Selenium;


namespace Selenium_CSharp{
     public class TodoAppFrontPage
    {
        public string Url =  "/examples/react/dist/";
        public By Identifier = By.CssSelector(".todoapp");
        public By PageHeader = By.CssSelector(".todoapp h1");
        public readonly By AddNewTodoInput = By.CssSelector(".new-todo");
        public By TodoList = By.CssSelector(".todo-list");
        public By TodoItems = By.CssSelector(".todo-list li");
        public By SelectItems = By.CssSelector(".toggle");
        public By TodoItemLabel = By.CssSelector(".todo-list li label");
        public By DeleteItem = By.CssSelector(".destroy");
        public By NumberOfItemsLeft = By.CssSelector(".todo-count strong");
        public By CompleteAll = By.CssSelector("#toggle-all");
        public By ClearAllCompleted = By.CssSelector(".clear-completed");
        public By FilterByCompletedItem = By.CssSelector("a[href='#/completed']");
    }
}