using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // var orderProcessor = new OrderProcessor(new ShippingCalculator());
            // var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f};
            // orderProcessor.Process(order);

            // var dbMigrator = new DbMigrator(new FileLogger("./test.txt"));
            // dbMigrator.Migrate();

            // Exercise
            var engine = new WorkflowEngine();
            
            var workflow = new Workflow();
            workflow.Add(new UploadVideo());
            var call = new CallWebService();
            workflow.Add(call);
            var email = new SendEmail();
            workflow.Add(email);
            workflow.Add(new Processing());
            
            engine.Run(workflow);
            Console.WriteLine();

            workflow.Remove(call);
            
            engine.Run(workflow);
            Console.WriteLine();
            
            workflow.Change(email, call);
            
            engine.Run(workflow);
        }
    }
}
