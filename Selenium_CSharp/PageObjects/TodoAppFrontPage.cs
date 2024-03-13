using OpenQA.Selenium;


namespace Selenium_CSharp{
     public class MainPage
    {
        // Page Elements
        private string Url =  "/examples/react/#/";
        private By Identifier = By.CssSelector(".learn-bar");
        private By PageHeader = By.CssSelector(".todoapp h1");
        private By AddNewTodoInput = By.CssSelector(".new-todo");
        private By TodoList = By.CssSelector(".todo-list");
        private By TodoItems = By.CssSelector(".todo-list li");
        private By SelectItems = By.CssSelector(".toggle");
        private By TodoItemLabel = By.CssSelector(".todo-list li label");
        private By DeleteItem = By.CssSelector(".destroy");
        private By NumberOfItemsLeft = By.CssSelector(".todo-count strong");
        private By CompleteAll = By.CssSelector("#toggle-all");
        private By ClearAllCompleted = By.CssSelector(".clear-completed");
        private By FilterByCompletedItem = By.CssSelector("a[href='#/completed']");

    }
}