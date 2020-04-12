using System;

namespace Aki
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "akmal the best".ToLower();
            string passwordexpert = "aki".ToLower();
            Console.WriteLine("Введите пароль: ");
            string inpass = Console.ReadLine().ToLower();
            if (inpass == password)
            {
                ProAccess();
            }
            else if (inpass == passwordexpert)
            {
                ExAccess();
            }
            else
            {
                BaseAccess();
            }
        }
        static void BaseAccess()
        {
            bool vkl = true;
            DocumentWorker dw = new DocumentWorker();
            while (vkl)
            {
                Console.WriteLine("Вы в начале пути");
                Console.WriteLine("1 для открытия файла\n2 для редактирование файла\n3 для сохранения\n4 для выхода");
                int chs = int.Parse(Console.ReadLine());
                switch (chs)
                {
                    case 1:
                        {
                            dw.OpenDocument();
                        }
                        break;
                    case 2:
                        {
                            dw.EditDocument();
                        }
                        break;
                    case 3:
                        {
                            dw.SaveDocument();
                        }
                        break;
                    case 4:
                        {
                            vkl = false;
                        }
                        break;
                }
            }
        }
        static void ProAccess()
        {
            bool vkl = true;
            DocumentWorker aki = new ProDocumentWorker();
            while (vkl)
            {
                Console.WriteLine("Добро пожаловать в Про версию");
                Console.WriteLine("1 для открытия файла\n2 для редактирование файла\n3 для сохранения файла\n4 для выхода");
                int chs = int.Parse(Console.ReadLine());
                switch (chs)
                {
                    case 1:
                        {
                            aki.OpenDocument();
                        }
                        break;
                    case 2:
                        {
                            aki.EditDocument();
                        }
                        break;
                    case 3:
                        {
                            aki.SaveDocument();
                        }
                        break;
                    case 4:
                        {
                            vkl = false;
                        }
                        break;
                }
            }
        }
        static void ExAccess()
        {
            bool vkl = true;
            DocumentWorker edw = new ExpertDocumentWorker();
            while (vkl)
            {
                Console.WriteLine("Добро пожаловать в Экссперт версию");
                Console.WriteLine("1 для открытия файла\n2 для редактирование файла\n3 для сохранения файла\n4 для выхода");
                int chs = int.Parse(Console.ReadLine());
                switch (chs)
                {
                    case 1:
                        {
                            edw.OpenDocument();
                        }
                        break;
                    case 2:
                        {
                            edw.EditDocument();
                        }
                        break;
                    case 3:
                        {
                            edw.SaveDocument();
                        }
                        break;
                    case 4:
                        {
                            vkl = false;
                        }
                        break;
                }
            }
        }
    }
    class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Открытие документа");
    }
    public virtual void EditDocument()
    {
        Console.WriteLine("Вы можете редактировать файл в Про версии");
    }
    public virtual void SaveDocument()
    {
        Console.WriteLine("Вы можете сохранить файл в Про версии");
    }
}
class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ изменен");
    }
    public override void SaveDocument()
    {
        Console.WriteLine("Документ был сохнанен в предедыщем формате,сохранить документ можно в эксперт");
    }
}
class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом формате");
    }
}
}