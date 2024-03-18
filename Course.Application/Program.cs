using Course.Application;
using Course.Application.Controllers;
using Service;
using Service.Helpers.Enums;
using Service.Helpers.Extentions;

GroupController groupController = new();
StudentController studentController = new();
while (true)
{
    GetMenues();
Operation: string? operationStr = Console.ReadLine();

    int operation;

    bool isCorrectOperationFormat = int.TryParse(operationStr, out operation);
    if (isCorrectOperationFormat)
    {
        switch (operation)
        {
            case 1:
                groupController.Create();
                break;

            case 2:
                groupController.GetAll();
                break;

            //case 3:
            //    groupController.GetAll();
            //    break;
            case 5:
                studentController.Create();
                break;
            default:
                ConsoleColor.Red.WriteConsole("Operation is wrong, please choose again");
                goto Operation;
        }
    }
    else
    {
        ConsoleColor.Red.WriteConsole("Operation format is wrong, please add operation again");
        goto Operation;
    }
}

static void GetMenues()
{
    ConsoleColor.Cyan.WriteConsole("Choose one operation :  1-Group create, 2-Group delete, 3-Get all Group, 4-Edit Group,5-Student Create");
}
