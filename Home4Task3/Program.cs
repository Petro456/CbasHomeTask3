using System;

namespace Home4Task3
{
    /// <summary>
    /// Ніби працює, але я не впевнений що так має бути.
    /// </summary>
    class DocumentWorker
    {
       int pro = 0;
       int exp =0;

        public  void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа в версии О");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа в версии О");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {        
            public override void EditDocument()
            {
                Console.WriteLine("Документ отредактирован");
            }
            public override void SaveDocument()
            {
                Console.WriteLine("Документ сохранен в старом формате, сохранение в других форматах есть в версии Эксперт");
            }
        public virtual void SaveDocument (string show)
        {
          show = "Документ сохранен в старом формате, сохранение в других форматах есть в версии Эксперт";
          Console.WriteLine(show);
        }
    }

    
    class ExpertDocumentWorker:ProDocumentWorker
    {
        public  override void SaveDocument ()

        {
            Console.WriteLine("Документ сохраненный в новом формате");
        }
        
    }

    internal class Program
    {
        /*Задание 4 

        Используя Visual Studio, создайте проект по шаблону Console Application, требуется cоздать класс DocumentWorker. 
        В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument(). В тело каждого из методов добавьте
        вывод на экран соответствующих строк: "Документ открыт", "Редактирование документа в версии О", "Сохранение документа в версии О".

        Создайте производный класс ProDocumentWorker. Переопределите соответствующие методы, при переопределении методов
        выводите следующие строки: "Документ отредактирован", "Документ сохранен в старом формате, сохранение в других форматах есть в версии Эксперт".

        Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker. 
        Переопределите подходящий способ. При вызове данного метода необходимо выводить на экран документ сохраненный в новом формате.

        В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp. 
        Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается экземпляр базового класса), 
        если пользователь ввел номера ключа доступа pro и exp, то должен создать экземпляр соответствующей версии класса, 
        приведенный к базовому - DocumentWorker.*/

        private const string proLicens = "010101";
        private const string expLicens = "101010";

        static void Main(string[] args)
        {
            Console.WriteLine("Ведiть код лiцензiї:");
            var license = Console.ReadLine();

            DocumentWorker documentWorker = new DocumentWorker();

            switch (license)
            {
                case proLicens:
                    {
                        documentWorker = new ProDocumentWorker();
                    }
                    break;
                case expLicens:
                    {
                        documentWorker = new ExpertDocumentWorker();
                    }
                     break;
                default:
                    {
                        documentWorker = new DocumentWorker(); 
                    }
                    break;
            }

            while (true)
            {
                Console.WriteLine("Виберiть команду: ");
                Console.WriteLine("1 - вiдкрити файл");
                Console.WriteLine("2 - редагувати файл");
                Console.WriteLine("3 - зберегти файл");
                Console.WriteLine("4 - повернутись назад");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            documentWorker.OpenDocument();
                        }
                       break;

                    case "2":
                        {
                            documentWorker.EditDocument();
                        }
                        break;
                    case "3":
                        {
                            documentWorker.SaveDocument();
                        }
                        break;
                    case "4": return;
         
                
                }
            }
            
        }

    }
}
